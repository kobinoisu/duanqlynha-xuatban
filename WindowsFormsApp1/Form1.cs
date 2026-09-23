using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuanLyNhaXuatBan
{
    public partial class Form1 : Form
    {
        // ================= CẤU HÌNH KẾT NỐI =================
        // "."  = instance mặc định của SQL Server 2022 trên máy này.
        // Nếu cài bản Express  -> đổi thành: Data Source=.\SQLEXPRESS
        // Nếu dùng tài khoản sa -> đổi thành:
        // @"Data Source=.;Initial Catalog=QuanLyNhaXuatBan;User ID=sa;Password=MAT_KHAU_CUA_BAN;TrustServerCertificate=True;"
        private const string CHUOI_KET_NOI =
            @"Data Source=SINE;Initial Catalog=qlnxb;Persist Security Info=True;User ID=sine;Password=020220";

        // ---------- Mô hình dữ liệu ----------
        private class NhaXuatBan
        {
            public string MaNXB { get; set; }
            public string TenNXB { get; set; }
            public DateTime NgayThanhLap { get; set; }
            public string LoaiHinh { get; set; }
            public string DienThoai { get; set; }
            public string Email { get; set; }
            public string DiaChi { get; set; }
        }

        private List<NhaXuatBan> danhSach = new List<NhaXuatBan>();   // nạp từ CSDL
        private List<NhaXuatBan> ketQuaLoc = new List<NhaXuatBan>();  // dữ liệu sau lọc
        private int trangHienTai = 1;
        private string maDangSua = null;                              // null = đang thêm mới

        // Placeholder (cue banner) cho TextBox tìm kiếm
        private const int EM_SETCUEBANNER = 0x1501;
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, string lParam);

        public Form1()
        {
            InitializeComponent();
        }

        // ---------- Khởi động ----------
        private void Form1_Load(object sender, EventArgs e)
        {
            cboLoaiHinh.SelectedIndex = 0;
            cboTimLoaiHinh.SelectedIndex = 0;
            cboSoBanGhi.SelectedIndex = 0;

            SendMessage(txtTimMaNXB.Handle, EM_SETCUEBANNER, IntPtr.Zero, "Nhập mã nhà xuất bản");
            SendMessage(txtTimTenNXB.Handle, EM_SETCUEBANNER, IntPtr.Zero, "Nhập tên nhà xuất bản");
            SendMessage(txtTimDienThoai.Handle, EM_SETCUEBANNER, IntPtr.Zero, "Nhập số điện thoại");

            txtMaNXB.TextChanged += (s, ev) =>
                            lblBadgeMa.Text = "Mã: " + txtMaNXB.Text.Trim();

            ApDungBoLoc(); // nạp lưới lần đầu từ CSDL
        }

        // ==========================================================
        //               CÁC HÀM TRUY VẤN SQL SERVER
        // ==========================================================
        private List<NhaXuatBan> DocTatCaTuDb()
        {
            var ds = new List<NhaXuatBan>();
            const string sql = "SELECT MaNXB, TenNXB, NgayThanhLap, LoaiHinh, DienThoai, Email, DiaChi " +
                               "FROM NhaXuatBan ORDER BY MaNXB";
            using (var conn = new SqlConnection(CHUOI_KET_NOI))
            using (var cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        ds.Add(new NhaXuatBan
                        {
                            MaNXB = dr["MaNXB"].ToString(),
                            TenNXB = dr["TenNXB"].ToString(),
                            NgayThanhLap = dr["NgayThanhLap"] == DBNull.Value
                                            ? new DateTime(1900, 1, 1)
                                            : Convert.ToDateTime(dr["NgayThanhLap"]),
                            LoaiHinh = dr["LoaiHinh"].ToString(),
                            DienThoai = dr["DienThoai"].ToString(),
                            Email = dr["Email"].ToString(),
                            DiaChi = dr["DiaChi"].ToString()
                        });
                    }
                }
            }
            return ds;
        }

        private bool MaDaTonTai(string ma)
        {
            const string sql = "SELECT COUNT(*) FROM NhaXuatBan WHERE MaNXB = @ma";
            using (var conn = new SqlConnection(CHUOI_KET_NOI))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@ma", ma);
                conn.Open();
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        private string TaoMaMoi()
        {
            const string sql = "SELECT MAX(MaNXB) FROM NhaXuatBan WHERE MaNXB LIKE 'NXB[0-9]%'";
            using (var conn = new SqlConnection(CHUOI_KET_NOI))
            using (var cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                var kq = cmd.ExecuteScalar();
                int max = 0;
                if (kq != null && kq != DBNull.Value)
                    int.TryParse(kq.ToString().Replace("NXB", ""), out max);
                return "NXB" + (max + 1).ToString("D4");
            }
        }

        private static void GanThamSo(SqlCommand cmd, NhaXuatBan nxb)
        {
            cmd.Parameters.AddWithValue("@ma", nxb.MaNXB);
            cmd.Parameters.AddWithValue("@ten", nxb.TenNXB);
            cmd.Parameters.AddWithValue("@ngay", nxb.NgayThanhLap);
            cmd.Parameters.AddWithValue("@lh", nxb.LoaiHinh);
            cmd.Parameters.AddWithValue("@sdt", nxb.DienThoai);
            cmd.Parameters.AddWithValue("@email", nxb.Email);
            cmd.Parameters.AddWithValue("@dc", nxb.DiaChi);
        }

        private void ThemVaoDb(NhaXuatBan nxb)
        {
            const string sql = "INSERT INTO NhaXuatBan (MaNXB, TenNXB, NgayThanhLap, LoaiHinh, DienThoai, Email, DiaChi) " +
                               "VALUES (@ma, @ten, @ngay, @lh, @sdt, @email, @dc)";
            using (var conn = new SqlConnection(CHUOI_KET_NOI))
            using (var cmd = new SqlCommand(sql, conn))
            {
                GanThamSo(cmd, nxb);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void CapNhatVaoDb(NhaXuatBan nxb)
        {
            const string sql = "UPDATE NhaXuatBan SET TenNXB=@ten, NgayThanhLap=@ngay, LoaiHinh=@lh, " +
                               "DienThoai=@sdt, Email=@email, DiaChi=@dc WHERE MaNXB=@ma";
            using (var conn = new SqlConnection(CHUOI_KET_NOI))
            using (var cmd = new SqlCommand(sql, conn))
            {
                GanThamSo(cmd, nxb);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void XoaKhoiDb(string ma)
        {
            const string sql = "DELETE FROM NhaXuatBan WHERE MaNXB = @ma";
            using (var conn = new SqlConnection(CHUOI_KET_NOI))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@ma", ma);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // ---------- Lọc + phân trang ----------
        private int SoBanGhiMoiTrang() => int.Parse(cboSoBanGhi.Text);

        private static string KhongDau(string s)
        {
            if (string.IsNullOrEmpty(s)) return "";
            var normalized = s.Normalize(NormalizationForm.FormD);
            var sb = new StringBuilder();
            foreach (var ch in normalized)
            {
                var uni = CharUnicodeInfo.GetUnicodeCategory(ch);
                if (uni != System.Globalization.UnicodeCategory.NonSpacingMark)
                    sb.Append(ch);
            }
            return sb.ToString().Normalize(NormalizationForm.FormC).ToLower();
        }

        private void ApDungBoLoc()
        {
            // Mỗi lần lọc là mỗi lần đọc mới từ CSDL -> lưới luôn đúng dữ liệu mới nhất
            try
            {
                danhSach = DocTatCaTuDb();
            }
            catch (Exception ex)
            {
                danhSach = new List<NhaXuatBan>();
                ketQuaLoc = new List<NhaXuatBan>();
                dgvNXB.Rows.Clear();
                lblThongTinTrang.Text = "Hiển thị 0 - 0 trên 0 bản ghi";
                MessageBox.Show(
                    "Không thể kết nối SQL Server!\n\n" + ex.Message +
                    "\n\nVui lòng kiểm tra:\n" +
                    "1. Đã chạy script tạo CSDL QuanLyNhaXuatBan chưa?\n" +
                    "2. Chuỗi kết nối CHUOI_KET_NOI trong Form1.cs có đúng instance không?\n" +
                    "   (máy cài bản Express phải dùng: Data Source=.\\SQLEXPRESS)",
                    "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string ma = KhongDau(txtTimMaNXB.Text.Trim());
            string ten = KhongDau(txtTimTenNXB.Text.Trim());
            string sdt = txtTimDienThoai.Text.Trim();
            string loaiHinh = cboTimLoaiHinh.SelectedIndex <= 0 ? "" : cboTimLoaiHinh.Text;

            ketQuaLoc = danhSach.Where(t =>
                (ma == "" || KhongDau(t.MaNXB).Contains(ma)) &&
                (ten == "" || KhongDau(t.TenNXB).Contains(ten)) &&
                (loaiHinh == "" || t.LoaiHinh == loaiHinh) &&
                (sdt == "" || t.DienThoai.Contains(sdt))
            ).ToList();

            trangHienTai = 1;
            TaiDuLieuLenLuoi();
        }

        private void TaiDuLieuLenLuoi()
        {
            int pageSize = SoBanGhiMoiTrang();
            int tongSoTrang = Math.Max(1, (int)Math.Ceiling(ketQuaLoc.Count * 1.0 / pageSize));
            if (trangHienTai > tongSoTrang) trangHienTai = tongSoTrang;

            var banGhi = ketQuaLoc
                .Skip((trangHienTai - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            dgvNXB.Rows.Clear();
            int stt = (trangHienTai - 1) * pageSize + 1;
            foreach (var t in banGhi)
            {
                dgvNXB.Rows.Add(
                    stt++, t.MaNXB, t.TenNXB,
                    t.NgayThanhLap.ToString("dd/MM/yyyy"), t.LoaiHinh,
                    t.DienThoai, t.Email, t.DiaChi);
            }

            int tu = ketQuaLoc.Count == 0 ? 0 : (trangHienTai - 1) * pageSize + 1;
            int den = Math.Min(trangHienTai * pageSize, ketQuaLoc.Count);
            lblThongTinTrang.Text = $"Hiển thị {tu} - {den} trên {ketQuaLoc.Count} bản ghi";

            CapNhatNutTrang(tongSoTrang);
        }

        private void CapNhatNutTrang(int tongSoTrang)
        {
            int dau = ((trangHienTai - 1) / 3) * 3 + 1;
            Button[] cacNut = { btnPage1, btnPage2, btnPage3 };
            for (int i = 0; i < 3; i++)
            {
                int p = dau + i;
                if (p <= tongSoTrang)
                {
                    cacNut[i].Visible = true;
                    cacNut[i].Text = p.ToString();
                    bool active = (p == trangHienTai);
                    cacNut[i].BackColor = active ? Color.FromArgb(15, 76, 89) : Color.White;
                    cacNut[i].ForeColor = active ? Color.White : Color.FromArgb(15, 76, 89);
                }
                else cacNut[i].Visible = false;
            }
        }

        private void DenTrang(int trang)
        {
            trangHienTai = trang;
            TaiDuLieuLenLuoi();
        }

        // ---------- Sự kiện tìm kiếm / phân trang ----------
        private void btnTimKiem_Click(object sender, EventArgs e) => ApDungBoLoc();

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimMaNXB.Clear(); txtTimTenNXB.Clear(); txtTimDienThoai.Clear();
            cboTimLoaiHinh.SelectedIndex = 0;
            ApDungBoLoc();
        }

        private void cboSoBanGhi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ketQuaLoc != null) TaiDuLieuLenLuoi();
        }

        private void btnFirst_Click(object sender, EventArgs e) => DenTrang(1);
        private void btnPrevious_Click(object sender, EventArgs e) => DenTrang(Math.Max(1, trangHienTai - 1));
        private void btnNext_Click(object sender, EventArgs e) => DenTrang(trangHienTai + 1);
        private void btnLast_Click(object sender, EventArgs e) =>
            DenTrang(Math.Max(1, (int)Math.Ceiling(ketQuaLoc.Count * 1.0 / SoBanGhiMoiTrang())));

        private void btnPage_Click(object sender, EventArgs e)
        {
            if (int.TryParse(((Button)sender).Text, out int p)) DenTrang(p);
        }

        // ---------- Thêm / Sửa / Xoá (ghi trực tiếp vào SQL Server) ----------
        private bool KiemTraDuLieu()
        {
            if (txtTenNXB.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên nhà xuất bản!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNXB.Focus();
                return false;
            }
            if (!Regex.IsMatch(txtDienThoai.Text.Trim(), @"^\d{9,11}$"))
            {
                MessageBox.Show("Số điện thoại phải gồm 9-11 chữ số!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDienThoai.Focus();
                return false;
            }
            return true;
        }

        private void XoaTrangNhap()
        {
            txtMaNXB.Clear(); txtMaNXB.ReadOnly = false;
            txtTenNXB.Clear(); txtDienThoai.Clear(); txtEmail.Clear(); txtDiaChi.Clear();
            cboLoaiHinh.SelectedIndex = 0;
            dtpNgayThanhLap.Value = new DateTime(1990, 1, 1);
            maDangSua = null;
            btnLuu.Text = "💾  Lưu";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu()) return;

            try
            {
                string ma = txtMaNXB.Text.Trim() == "" ? TaoMaMoi() : txtMaNXB.Text.Trim();

                var nxb = new NhaXuatBan
                {
                    MaNXB = ma,
                    TenNXB = txtTenNXB.Text.Trim(),
                    NgayThanhLap = dtpNgayThanhLap.Value,
                    LoaiHinh = cboLoaiHinh.Text,
                    DienThoai = txtDienThoai.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    DiaChi = txtDiaChi.Text.Trim()
                };

                if (maDangSua == null)
                {
                    if (MaDaTonTai(ma))
                    {
                        MessageBox.Show($"Mã nhà xuất bản {ma} đã tồn tại!", "Cảnh báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaNXB.Focus();
                        return;
                    }
                    ThemVaoDb(nxb);
                    MessageBox.Show($"Đã thêm nhà xuất bản {ma} thành công!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    CapNhatVaoDb(nxb);
                    MessageBox.Show($"Đã cập nhật nhà xuất bản {ma} thành công!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                XoaTrangNhap();
                ApDungBoLoc(); // đọc lại từ CSDL để làm mới lưới
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL Server:\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNXB.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một bản ghi trong danh sách để sửa!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string ma = dgvNXB.SelectedRows[0].Cells["colMaNXB"].Value.ToString();
            var nxb = danhSach.First(t => t.MaNXB == ma);

            txtMaNXB.Text = nxb.MaNXB;
            txtMaNXB.ReadOnly = true;
            txtTenNXB.Text = nxb.TenNXB;
            dtpNgayThanhLap.Value = nxb.NgayThanhLap;
            cboLoaiHinh.SelectedItem = nxb.LoaiHinh;
            txtDienThoai.Text = nxb.DienThoai;
            txtEmail.Text = nxb.Email;
            txtDiaChi.Text = nxb.DiaChi;

            maDangSua = ma;
            btnLuu.Text = "💾  Lưu cập nhật";
            grpThongTin.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNXB.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một bản ghi trong danh sách để xoá!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string ma = dgvNXB.SelectedRows[0].Cells["colMaNXB"].Value.ToString();
            if (MessageBox.Show($"Bạn có chắc muốn xoá nhà xuất bản {ma}?", "Xác nhận xoá",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    XoaKhoiDb(ma);
                    if (maDangSua == ma) XoaTrangNhap();
                    ApDungBoLoc();
                    MessageBox.Show("Đã xoá bản ghi thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi SQL Server:\n" + ex.Message,
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ---------- Xuất file CSV (mở đúng tiếng Việt trong Excel) ----------
        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            using (var dlg = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                FileName = "danh-sach-nha-xuat-ban.csv"
            })
            {
                if (dlg.ShowDialog() != DialogResult.OK) return;

                var sb = new StringBuilder();
                sb.AppendLine("STT,Mã NXB,Tên nhà xuất bản,Ngày thành lập,Loại hình,Điện thoại,Email,Địa chỉ");
                int stt = 1;
                foreach (var t in ketQuaLoc)
                {
                    sb.AppendLine(string.Join(",",
                        stt++, TruongCsv(t.MaNXB), TruongCsv(t.TenNXB),
                        t.NgayThanhLap.ToString("dd/MM/yyyy"), t.LoaiHinh,
                        t.DienThoai, t.Email, TruongCsv(t.DiaChi)));
                }
                System.IO.File.WriteAllText(dlg.FileName, sb.ToString(), new UTF8Encoding(true));
                MessageBox.Show($"Đã xuất {ketQuaLoc.Count} bản ghi ra file!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private static string TruongCsv(string s) =>
            s.Contains(",") || s.Contains("\"") ? "\"" + s.Replace("\"", "\"\"") + "\"" : s;

        private void btnThoat_Click(object sender, EventArgs e) => this.Close();

        // ---------- Vẽ trang trí (huy hiệu quyển sách bo góc) ----------
        private void PnBadge_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            var rect = new Rectangle(0, 0, pnBadge.Width - 1, pnBadge.Height - 1);

            using (var path = BoTronGoc(rect, 14))
            using (var brush = new SolidBrush(Color.FromArgb(15, 76, 89)))
                g.FillPath(brush, path);

            // biểu tượng quyển sách cách điệu màu trắng
            float w = pnBadge.Width, h = pnBadge.Height;
            using (var trang = new SolidBrush(Color.White))
            {
                g.FillRectangle(trang, w * 0.24f, h * 0.30f, w * 0.52f, h * 0.10f);
                g.FillRectangle(trang, w * 0.24f, h * 0.46f, w * 0.52f, h * 0.10f);
                g.FillRectangle(trang, w * 0.24f, h * 0.62f, w * 0.34f, h * 0.10f);
            }
        }

        private static GraphicsPath BoTronGoc(Rectangle rect, int bankinh)
        {
            var path = new GraphicsPath();
            int d = bankinh * 2;
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
