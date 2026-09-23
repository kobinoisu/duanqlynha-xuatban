using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyNhaXuatBan
{
    partial class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.lblDecor = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblPhuDe = new System.Windows.Forms.Label();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.cboLoaiHinh = new System.Windows.Forms.ComboBox();
            this.lblLoaiHinh = new System.Windows.Forms.Label();
            this.dtpNgayThanhLap = new System.Windows.Forms.DateTimePicker();
            this.lblNgayThanhLap = new System.Windows.Forms.Label();
            this.txtTenNXB = new System.Windows.Forms.TextBox();
            this.lblTenNXB = new System.Windows.Forms.Label();
            this.txtMaNXB = new System.Windows.Forms.TextBox();
            this.lblMaNXB = new System.Windows.Forms.Label();
            this.lblBadgeMa = new System.Windows.Forms.Label();
            this.pnBadge = new System.Windows.Forms.Panel();
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.tlpTimKiem = new System.Windows.Forms.TableLayoutPanel();
            this.lblTimMaNXB = new System.Windows.Forms.Label();
            this.txtTimMaNXB = new System.Windows.Forms.TextBox();
            this.lblTimTenNXB = new System.Windows.Forms.Label();
            this.txtTimTenNXB = new System.Windows.Forms.TextBox();
            this.lblTimLoaiHinh = new System.Windows.Forms.Label();
            this.cboTimLoaiHinh = new System.Windows.Forms.ComboBox();
            this.lblTimDienThoai = new System.Windows.Forms.Label();
            this.txtTimDienThoai = new System.Windows.Forms.TextBox();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.lblThongTinTrang = new System.Windows.Forms.Label();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPage3 = new System.Windows.Forms.Button();
            this.btnPage2 = new System.Windows.Forms.Button();
            this.btnPage1 = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.lblTrenMoiTrang = new System.Windows.Forms.Label();
            this.cboSoBanGhi = new System.Windows.Forms.ComboBox();
            this.lblHienThi = new System.Windows.Forms.Label();
            this.dgvNXB = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayThanhLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiHinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnHeader.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            this.grpTimKiem.SuspendLayout();
            this.tlpTimKiem.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).BeginInit();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.pnHeader.Controls.Add(this.lblDecor);
            this.pnHeader.Controls.Add(this.lblTieuDe);
            this.pnHeader.Controls.Add(this.lblPhuDe);
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1335, 85);
            this.pnHeader.TabIndex = 0;
            // 
            // lblDecor
            // 
            this.lblDecor.AutoSize = true;
            this.lblDecor.Font = new System.Drawing.Font("Segoe UI", 28F);
            this.lblDecor.ForeColor = System.Drawing.Color.White;
            this.lblDecor.Location = new System.Drawing.Point(1249, 16);
            this.lblDecor.Name = "lblDecor";
            this.lblDecor.Size = new System.Drawing.Size(74, 51);
            this.lblDecor.TabIndex = 2;
            this.lblDecor.Text = "🏛️";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTieuDe.Location = new System.Drawing.Point(30, 16);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(467, 32);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "CẬP NHẬT THÔNG TIN NHÀ XUẤT BẢN";
            // 
            // lblPhuDe
            // 
            this.lblPhuDe.AutoSize = true;
            this.lblPhuDe.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPhuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(220)))), ((int)(((byte)(225)))));
            this.lblPhuDe.Location = new System.Drawing.Point(33, 54);
            this.lblPhuDe.Name = "lblPhuDe";
            this.lblPhuDe.Size = new System.Drawing.Size(302, 17);
            this.lblPhuDe.TabIndex = 1;
            this.lblPhuDe.Text = "Quản lý thông tin các nhà xuất bản trong hệ thống";
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.btnThoat);
            this.grpThongTin.Controls.Add(this.btnXuatFile);
            this.grpThongTin.Controls.Add(this.btnXoa);
            this.grpThongTin.Controls.Add(this.btnSua);
            this.grpThongTin.Controls.Add(this.btnLuu);
            this.grpThongTin.Controls.Add(this.txtDiaChi);
            this.grpThongTin.Controls.Add(this.lblDiaChi);
            this.grpThongTin.Controls.Add(this.txtEmail);
            this.grpThongTin.Controls.Add(this.lblEmail);
            this.grpThongTin.Controls.Add(this.txtDienThoai);
            this.grpThongTin.Controls.Add(this.lblDienThoai);
            this.grpThongTin.Controls.Add(this.cboLoaiHinh);
            this.grpThongTin.Controls.Add(this.lblLoaiHinh);
            this.grpThongTin.Controls.Add(this.dtpNgayThanhLap);
            this.grpThongTin.Controls.Add(this.lblNgayThanhLap);
            this.grpThongTin.Controls.Add(this.txtTenNXB);
            this.grpThongTin.Controls.Add(this.lblTenNXB);
            this.grpThongTin.Controls.Add(this.txtMaNXB);
            this.grpThongTin.Controls.Add(this.lblMaNXB);
            this.grpThongTin.Controls.Add(this.lblBadgeMa);
            this.grpThongTin.Controls.Add(this.pnBadge);
            this.grpThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.grpThongTin.Location = new System.Drawing.Point(15, 95);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(360, 700);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "📕  THÔNG TIN NHÀ XUẤT BẢN";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(20, 635);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(320, 42);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "🚪  Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.btnXuatFile.FlatAppearance.BorderSize = 0;
            this.btnXuatFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatFile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXuatFile.ForeColor = System.Drawing.Color.White;
            this.btnXuatFile.Location = new System.Drawing.Point(185, 585);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(155, 42);
            this.btnXuatFile.TabIndex = 8;
            this.btnXuatFile.Text = "📤  Xuất file";
            this.btnXuatFile.UseVisualStyleBackColor = false;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(20, 585);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(155, 42);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "🗑️  Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(185, 535);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(155, 42);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "✏️  Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(140)))), ((int)(((byte)(60)))));
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(20, 535);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(155, 42);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "💾  Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDiaChi.Location = new System.Drawing.Point(20, 450);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(320, 70);
            this.txtDiaChi.TabIndex = 4;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblDiaChi.Location = new System.Drawing.Point(20, 430);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(47, 17);
            this.lblDiaChi.TabIndex = 0;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtEmail.Location = new System.Drawing.Point(20, 395);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(320, 24);
            this.txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblEmail.Location = new System.Drawing.Point(20, 375);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 17);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDienThoai.Location = new System.Drawing.Point(20, 340);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(320, 24);
            this.txtDienThoai.TabIndex = 2;
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDienThoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblDienThoai.Location = new System.Drawing.Point(20, 320);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(67, 17);
            this.lblDienThoai.TabIndex = 0;
            this.lblDienThoai.Text = "Điện thoại";
            // 
            // cboLoaiHinh
            // 
            this.cboLoaiHinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiHinh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboLoaiHinh.Items.AddRange(new object[] {
            "Nhà nước",
            "Tư nhân"});
            this.cboLoaiHinh.Location = new System.Drawing.Point(20, 285);
            this.cboLoaiHinh.Name = "cboLoaiHinh";
            this.cboLoaiHinh.Size = new System.Drawing.Size(320, 25);
            this.cboLoaiHinh.TabIndex = 1;
            // 
            // lblLoaiHinh
            // 
            this.lblLoaiHinh.AutoSize = true;
            this.lblLoaiHinh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblLoaiHinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblLoaiHinh.Location = new System.Drawing.Point(20, 265);
            this.lblLoaiHinh.Name = "lblLoaiHinh";
            this.lblLoaiHinh.Size = new System.Drawing.Size(60, 17);
            this.lblLoaiHinh.TabIndex = 0;
            this.lblLoaiHinh.Text = "Loại hình";
            // 
            // dtpNgayThanhLap
            // 
            this.dtpNgayThanhLap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayThanhLap.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpNgayThanhLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayThanhLap.Location = new System.Drawing.Point(20, 230);
            this.dtpNgayThanhLap.Name = "dtpNgayThanhLap";
            this.dtpNgayThanhLap.Size = new System.Drawing.Size(320, 24);
            this.dtpNgayThanhLap.TabIndex = 2;
            // 
            // lblNgayThanhLap
            // 
            this.lblNgayThanhLap.AutoSize = true;
            this.lblNgayThanhLap.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNgayThanhLap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblNgayThanhLap.Location = new System.Drawing.Point(20, 210);
            this.lblNgayThanhLap.Name = "lblNgayThanhLap";
            this.lblNgayThanhLap.Size = new System.Drawing.Size(97, 17);
            this.lblNgayThanhLap.TabIndex = 0;
            this.lblNgayThanhLap.Text = "Ngày thành lập";
            // 
            // txtTenNXB
            // 
            this.txtTenNXB.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTenNXB.Location = new System.Drawing.Point(20, 175);
            this.txtTenNXB.Name = "txtTenNXB";
            this.txtTenNXB.Size = new System.Drawing.Size(320, 24);
            this.txtTenNXB.TabIndex = 1;
            // 
            // lblTenNXB
            // 
            this.lblTenNXB.AutoSize = true;
            this.lblTenNXB.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTenNXB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblTenNXB.Location = new System.Drawing.Point(20, 155);
            this.lblTenNXB.Name = "lblTenNXB";
            this.lblTenNXB.Size = new System.Drawing.Size(107, 17);
            this.lblTenNXB.TabIndex = 0;
            this.lblTenNXB.Text = "Tên nhà xuất bản";
            // 
            // txtMaNXB
            // 
            this.txtMaNXB.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtMaNXB.Location = new System.Drawing.Point(20, 120);
            this.txtMaNXB.Name = "txtMaNXB";
            this.txtMaNXB.Size = new System.Drawing.Size(320, 24);
            this.txtMaNXB.TabIndex = 0;
            // 
            // lblMaNXB
            // 
            this.lblMaNXB.AutoSize = true;
            this.lblMaNXB.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblMaNXB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblMaNXB.Location = new System.Drawing.Point(20, 100);
            this.lblMaNXB.Name = "lblMaNXB";
            this.lblMaNXB.Size = new System.Drawing.Size(106, 17);
            this.lblMaNXB.TabIndex = 0;
            this.lblMaNXB.Text = "Mã nhà xuất bản";
            // 
            // lblBadgeMa
            // 
            this.lblBadgeMa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBadgeMa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.lblBadgeMa.Location = new System.Drawing.Point(86, 42);
            this.lblBadgeMa.Name = "lblBadgeMa";
            this.lblBadgeMa.Size = new System.Drawing.Size(254, 32);
            this.lblBadgeMa.TabIndex = 0;
            this.lblBadgeMa.Text = "Mã: ";
            this.lblBadgeMa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnBadge
            // 
            this.pnBadge.Location = new System.Drawing.Point(20, 30);
            this.pnBadge.Name = "pnBadge";
            this.pnBadge.Size = new System.Drawing.Size(56, 56);
            this.pnBadge.TabIndex = 1;
            this.pnBadge.Paint += new System.Windows.Forms.PaintEventHandler(this.PnBadge_Paint);
            // 
            // grpTimKiem
            // 
            this.grpTimKiem.Controls.Add(this.btnLamMoi);
            this.grpTimKiem.Controls.Add(this.btnTimKiem);
            this.grpTimKiem.Controls.Add(this.tlpTimKiem);
            this.grpTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.grpTimKiem.Location = new System.Drawing.Point(390, 95);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Padding = new System.Windows.Forms.Padding(15, 25, 15, 10);
            this.grpTimKiem.Size = new System.Drawing.Size(933, 110);
            this.grpTimKiem.TabIndex = 2;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "🔍  TÌM KIẾM NHÀ XUẤT BẢN";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.White;
            this.btnLamMoi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.btnLamMoi.Location = new System.Drawing.Point(675, 61);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(145, 34);
            this.btnLamMoi.TabIndex = 2;
            this.btnLamMoi.Text = "🔄 Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(675, 21);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(145, 34);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "🔍 Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // tlpTimKiem
            // 
            this.tlpTimKiem.ColumnCount = 4;
            this.tlpTimKiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tlpTimKiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTimKiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tlpTimKiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTimKiem.Controls.Add(this.lblTimMaNXB, 0, 0);
            this.tlpTimKiem.Controls.Add(this.txtTimMaNXB, 1, 0);
            this.tlpTimKiem.Controls.Add(this.lblTimTenNXB, 0, 1);
            this.tlpTimKiem.Controls.Add(this.txtTimTenNXB, 1, 1);
            this.tlpTimKiem.Controls.Add(this.lblTimLoaiHinh, 2, 0);
            this.tlpTimKiem.Controls.Add(this.cboTimLoaiHinh, 3, 0);
            this.tlpTimKiem.Controls.Add(this.lblTimDienThoai, 2, 1);
            this.tlpTimKiem.Controls.Add(this.txtTimDienThoai, 3, 1);
            this.tlpTimKiem.Location = new System.Drawing.Point(105, 23);
            this.tlpTimKiem.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTimKiem.Name = "tlpTimKiem";
            this.tlpTimKiem.RowCount = 2;
            this.tlpTimKiem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTimKiem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTimKiem.Size = new System.Drawing.Size(560, 72);
            this.tlpTimKiem.TabIndex = 0;
            // 
            // lblTimMaNXB
            // 
            this.lblTimMaNXB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTimMaNXB.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTimMaNXB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblTimMaNXB.Location = new System.Drawing.Point(3, 0);
            this.lblTimMaNXB.Name = "lblTimMaNXB";
            this.lblTimMaNXB.Size = new System.Drawing.Size(89, 36);
            this.lblTimMaNXB.TabIndex = 0;
            this.lblTimMaNXB.Text = "Mã NXB:";
            this.lblTimMaNXB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTimMaNXB
            // 
            this.txtTimMaNXB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimMaNXB.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTimMaNXB.Location = new System.Drawing.Point(95, 3);
            this.txtTimMaNXB.Margin = new System.Windows.Forms.Padding(0, 3, 6, 3);
            this.txtTimMaNXB.Name = "txtTimMaNXB";
            this.txtTimMaNXB.Size = new System.Drawing.Size(179, 24);
            this.txtTimMaNXB.TabIndex = 1;
            // 
            // lblTimTenNXB
            // 
            this.lblTimTenNXB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTimTenNXB.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTimTenNXB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblTimTenNXB.Location = new System.Drawing.Point(3, 36);
            this.lblTimTenNXB.Name = "lblTimTenNXB";
            this.lblTimTenNXB.Size = new System.Drawing.Size(89, 36);
            this.lblTimTenNXB.TabIndex = 2;
            this.lblTimTenNXB.Text = "Tên NXB:";
            this.lblTimTenNXB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTimTenNXB
            // 
            this.txtTimTenNXB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimTenNXB.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTimTenNXB.Location = new System.Drawing.Point(95, 39);
            this.txtTimTenNXB.Margin = new System.Windows.Forms.Padding(0, 3, 6, 3);
            this.txtTimTenNXB.Name = "txtTimTenNXB";
            this.txtTimTenNXB.Size = new System.Drawing.Size(179, 24);
            this.txtTimTenNXB.TabIndex = 3;
            // 
            // lblTimLoaiHinh
            // 
            this.lblTimLoaiHinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTimLoaiHinh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTimLoaiHinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblTimLoaiHinh.Location = new System.Drawing.Point(283, 0);
            this.lblTimLoaiHinh.Name = "lblTimLoaiHinh";
            this.lblTimLoaiHinh.Size = new System.Drawing.Size(89, 36);
            this.lblTimLoaiHinh.TabIndex = 4;
            this.lblTimLoaiHinh.Text = "Loại hình:";
            this.lblTimLoaiHinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboTimLoaiHinh
            // 
            this.cboTimLoaiHinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboTimLoaiHinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimLoaiHinh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboTimLoaiHinh.Items.AddRange(new object[] {
            "-- Tất cả --",
            "Nhà nước",
            "Tư nhân"});
            this.cboTimLoaiHinh.Location = new System.Drawing.Point(375, 3);
            this.cboTimLoaiHinh.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.cboTimLoaiHinh.Name = "cboTimLoaiHinh";
            this.cboTimLoaiHinh.Size = new System.Drawing.Size(185, 25);
            this.cboTimLoaiHinh.TabIndex = 5;
            // 
            // lblTimDienThoai
            // 
            this.lblTimDienThoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTimDienThoai.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTimDienThoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblTimDienThoai.Location = new System.Drawing.Point(283, 36);
            this.lblTimDienThoai.Name = "lblTimDienThoai";
            this.lblTimDienThoai.Size = new System.Drawing.Size(89, 36);
            this.lblTimDienThoai.TabIndex = 6;
            this.lblTimDienThoai.Text = "Điện thoại:";
            this.lblTimDienThoai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTimDienThoai
            // 
            this.txtTimDienThoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimDienThoai.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTimDienThoai.Location = new System.Drawing.Point(375, 39);
            this.txtTimDienThoai.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.txtTimDienThoai.Name = "txtTimDienThoai";
            this.txtTimDienThoai.Size = new System.Drawing.Size(185, 24);
            this.txtTimDienThoai.TabIndex = 7;
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Controls.Add(this.lblThongTinTrang);
            this.grpDanhSach.Controls.Add(this.btnLast);
            this.grpDanhSach.Controls.Add(this.btnNext);
            this.grpDanhSach.Controls.Add(this.btnPage3);
            this.grpDanhSach.Controls.Add(this.btnPage2);
            this.grpDanhSach.Controls.Add(this.btnPage1);
            this.grpDanhSach.Controls.Add(this.btnPrevious);
            this.grpDanhSach.Controls.Add(this.btnFirst);
            this.grpDanhSach.Controls.Add(this.lblTrenMoiTrang);
            this.grpDanhSach.Controls.Add(this.cboSoBanGhi);
            this.grpDanhSach.Controls.Add(this.lblHienThi);
            this.grpDanhSach.Controls.Add(this.dgvNXB);
            this.grpDanhSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpDanhSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.grpDanhSach.Location = new System.Drawing.Point(390, 215);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(933, 580);
            this.grpDanhSach.TabIndex = 3;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "📋  DANH SÁCH NHÀ XUẤT BẢN";
            // 
            // lblThongTinTrang
            // 
            this.lblThongTinTrang.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblThongTinTrang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblThongTinTrang.Location = new System.Drawing.Point(216, 523);
            this.lblThongTinTrang.Name = "lblThongTinTrang";
            this.lblThongTinTrang.Size = new System.Drawing.Size(705, 22);
            this.lblThongTinTrang.TabIndex = 11;
            this.lblThongTinTrang.Text = "Hiển thị 1 - 5 trên 12 bản ghi";
            this.lblThongTinTrang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.White;
            this.btnLast.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.btnLast.Location = new System.Drawing.Point(824, 478);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(34, 30);
            this.btnLast.TabIndex = 10;
            this.btnLast.Text = "⏭";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.btnNext.Location = new System.Drawing.Point(786, 478);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(34, 30);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "▶";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPage3
            // 
            this.btnPage3.BackColor = System.Drawing.Color.White;
            this.btnPage3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.btnPage3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPage3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPage3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.btnPage3.Location = new System.Drawing.Point(748, 478);
            this.btnPage3.Name = "btnPage3";
            this.btnPage3.Size = new System.Drawing.Size(34, 30);
            this.btnPage3.TabIndex = 8;
            this.btnPage3.Text = "3";
            this.btnPage3.UseVisualStyleBackColor = false;
            this.btnPage3.Click += new System.EventHandler(this.btnPage_Click);
            // 
            // btnPage2
            // 
            this.btnPage2.BackColor = System.Drawing.Color.White;
            this.btnPage2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.btnPage2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPage2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.btnPage2.Location = new System.Drawing.Point(710, 478);
            this.btnPage2.Name = "btnPage2";
            this.btnPage2.Size = new System.Drawing.Size(34, 30);
            this.btnPage2.TabIndex = 7;
            this.btnPage2.Text = "2";
            this.btnPage2.UseVisualStyleBackColor = false;
            this.btnPage2.Click += new System.EventHandler(this.btnPage_Click);
            // 
            // btnPage1
            // 
            this.btnPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.btnPage1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.btnPage1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPage1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPage1.ForeColor = System.Drawing.Color.White;
            this.btnPage1.Location = new System.Drawing.Point(672, 478);
            this.btnPage1.Name = "btnPage1";
            this.btnPage1.Size = new System.Drawing.Size(34, 30);
            this.btnPage1.TabIndex = 6;
            this.btnPage1.Text = "1";
            this.btnPage1.UseVisualStyleBackColor = false;
            this.btnPage1.Click += new System.EventHandler(this.btnPage_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.White;
            this.btnPrevious.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrevious.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.btnPrevious.Location = new System.Drawing.Point(634, 478);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(34, 30);
            this.btnPrevious.TabIndex = 5;
            this.btnPrevious.Text = "◀";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.White;
            this.btnFirst.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFirst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.btnFirst.Location = new System.Drawing.Point(596, 478);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(34, 30);
            this.btnFirst.TabIndex = 4;
            this.btnFirst.Text = "⏮";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // lblTrenMoiTrang
            // 
            this.lblTrenMoiTrang.AutoSize = true;
            this.lblTrenMoiTrang.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTrenMoiTrang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblTrenMoiTrang.Location = new System.Drawing.Point(140, 478);
            this.lblTrenMoiTrang.Name = "lblTrenMoiTrang";
            this.lblTrenMoiTrang.Size = new System.Drawing.Size(140, 17);
            this.lblTrenMoiTrang.TabIndex = 3;
            this.lblTrenMoiTrang.Text = "bản ghi trên mỗi trang";
            // 
            // cboSoBanGhi
            // 
            this.cboSoBanGhi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSoBanGhi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboSoBanGhi.Items.AddRange(new object[] {
            "5",
            "10",
            "20",
            "50"});
            this.cboSoBanGhi.Location = new System.Drawing.Point(75, 474);
            this.cboSoBanGhi.Name = "cboSoBanGhi";
            this.cboSoBanGhi.Size = new System.Drawing.Size(55, 25);
            this.cboSoBanGhi.TabIndex = 2;
            this.cboSoBanGhi.SelectedIndexChanged += new System.EventHandler(this.cboSoBanGhi_SelectedIndexChanged);
            // 
            // lblHienThi
            // 
            this.lblHienThi.AutoSize = true;
            this.lblHienThi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblHienThi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblHienThi.Location = new System.Drawing.Point(20, 478);
            this.lblHienThi.Name = "lblHienThi";
            this.lblHienThi.Size = new System.Drawing.Size(52, 17);
            this.lblHienThi.TabIndex = 1;
            this.lblHienThi.Text = "Hiển thị";
            // 
            // dgvNXB
            // 
            this.dgvNXB.AllowUserToAddRows = false;
            this.dgvNXB.AllowUserToDeleteRows = false;
            this.dgvNXB.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.dgvNXB.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvNXB.BackgroundColor = System.Drawing.Color.White;
            this.dgvNXB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNXB.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNXB.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dgvNXB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvNXB.ColumnHeadersHeight = 40;
            this.dgvNXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvNXB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMaNXB,
            this.colTenNXB,
            this.colNgayThanhLap,
            this.colLoaiHinh,
            this.colDienThoai,
            this.colEmail,
            this.colDiaChi});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNXB.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvNXB.EnableHeadersVisualStyles = false;
            this.dgvNXB.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgvNXB.Location = new System.Drawing.Point(20, 30);
            this.dgvNXB.MultiSelect = false;
            this.dgvNXB.Name = "dgvNXB";
            this.dgvNXB.ReadOnly = true;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.dgvNXB.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvNXB.RowHeadersWidth = 25;
            this.dgvNXB.RowTemplate.Height = 32;
            this.dgvNXB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNXB.Size = new System.Drawing.Size(907, 430);
            this.dgvNXB.TabIndex = 0;
            // 
            // colSTT
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSTT.DefaultCellStyle = dataGridViewCellStyle10;
            this.colSTT.HeaderText = "STT";
            this.colSTT.MinimumWidth = 6;
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            this.colSTT.Width = 45;
            // 
            // colMaNXB
            // 
            this.colMaNXB.HeaderText = "Mã NXB";
            this.colMaNXB.MinimumWidth = 6;
            this.colMaNXB.Name = "colMaNXB";
            this.colMaNXB.ReadOnly = true;
            this.colMaNXB.Width = 75;
            // 
            // colTenNXB
            // 
            this.colTenNXB.HeaderText = "Tên nhà xuất bản";
            this.colTenNXB.MinimumWidth = 6;
            this.colTenNXB.Name = "colTenNXB";
            this.colTenNXB.ReadOnly = true;
            this.colTenNXB.Width = 140;
            // 
            // colNgayThanhLap
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colNgayThanhLap.DefaultCellStyle = dataGridViewCellStyle11;
            this.colNgayThanhLap.HeaderText = "Ngày thành lập";
            this.colNgayThanhLap.MinimumWidth = 6;
            this.colNgayThanhLap.Name = "colNgayThanhLap";
            this.colNgayThanhLap.ReadOnly = true;
            // 
            // colLoaiHinh
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colLoaiHinh.DefaultCellStyle = dataGridViewCellStyle12;
            this.colLoaiHinh.HeaderText = "Loại hình";
            this.colLoaiHinh.MinimumWidth = 6;
            this.colLoaiHinh.Name = "colLoaiHinh";
            this.colLoaiHinh.ReadOnly = true;
            this.colLoaiHinh.Width = 75;
            // 
            // colDienThoai
            // 
            this.colDienThoai.HeaderText = "Điện thoại";
            this.colDienThoai.MinimumWidth = 6;
            this.colDienThoai.Name = "colDienThoai";
            this.colDienThoai.ReadOnly = true;
            this.colDienThoai.Width = 95;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.MinimumWidth = 6;
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Width = 130;
            // 
            // colDiaChi
            // 
            this.colDiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDiaChi.HeaderText = "Địa chỉ";
            this.colDiaChi.MinimumWidth = 130;
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1335, 815);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.grpTimKiem);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.pnHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ NHÀ XUẤT BẢN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpTimKiem.ResumeLayout(false);
            this.tlpTimKiem.ResumeLayout(false);
            this.tlpTimKiem.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            this.grpDanhSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnHeader;
        private Label lblDecor;
        private Label lblTieuDe;
        private Label lblPhuDe;
        private GroupBox grpThongTin;
        private Panel pnBadge;
        private Label lblBadgeMa;
        private Label lblMaNXB; private TextBox txtMaNXB;
        private Label lblTenNXB; private TextBox txtTenNXB;
        private Label lblNgayThanhLap; private DateTimePicker dtpNgayThanhLap;
        private Label lblLoaiHinh; private ComboBox cboLoaiHinh;
        private Label lblDienThoai; private TextBox txtDienThoai;
        private Label lblEmail; private TextBox txtEmail;
        private Label lblDiaChi; private TextBox txtDiaChi;
        private Button btnLuu; private Button btnSua; private Button btnXoa;
        private Button btnXuatFile; private Button btnThoat;
        private GroupBox grpTimKiem;
        private TableLayoutPanel tlpTimKiem;
        private Label lblTimMaNXB; private TextBox txtTimMaNXB;
        private Label lblTimTenNXB; private TextBox txtTimTenNXB;
        private Label lblTimLoaiHinh; private ComboBox cboTimLoaiHinh;
        private Label lblTimDienThoai; private TextBox txtTimDienThoai;
        private Button btnTimKiem; private Button btnLamMoi;
        private GroupBox grpDanhSach;
        private DataGridView dgvNXB;
        private DataGridViewTextBoxColumn colSTT;
        private DataGridViewTextBoxColumn colMaNXB;
        private DataGridViewTextBoxColumn colTenNXB;
        private DataGridViewTextBoxColumn colNgayThanhLap;
        private DataGridViewTextBoxColumn colLoaiHinh;
        private DataGridViewTextBoxColumn colDienThoai;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colDiaChi;
        private Label lblHienThi; private ComboBox cboSoBanGhi; private Label lblTrenMoiTrang;
        private Button btnFirst; private Button btnPrevious;
        private Button btnPage1; private Button btnPage2; private Button btnPage3;
        private Button btnNext; private Button btnLast;
        private Label lblThongTinTrang;
    }
}
