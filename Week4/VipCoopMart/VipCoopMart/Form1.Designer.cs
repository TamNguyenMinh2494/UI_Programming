namespace VipCoopMart
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.nudNgay = new System.Windows.Forms.NumericUpDown();
            this.nudThang = new System.Windows.Forms.NumericUpDown();
            this.nudNam = new System.Windows.Forms.NumericUpDown();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.dmNgheNghiep = new System.Windows.Forms.DomainUpDown();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnNhapMoi = new System.Windows.Forms.Button();
            this.btnTongKet = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNam)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(103, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(623, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "COOP MARK - ĐĂNG KÝ KHÁCH HÀNG VIP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "MS Khách hàng:";
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Location = new System.Drawing.Point(216, 137);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(312, 20);
            this.txtKhachHang.TabIndex = 1;
            this.txtKhachHang.TextChanged += new System.EventHandler(this.txtKhachHang_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ và Tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(279, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tháng: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(513, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Năm:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Địa chỉ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(61, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Nghề nghiệp: ";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(216, 191);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(312, 20);
            this.txtHoTen.TabIndex = 3;
            this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            // 
            // nudNgay
            // 
            this.nudNgay.Location = new System.Drawing.Point(165, 248);
            this.nudNgay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudNgay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNgay.Name = "nudNgay";
            this.nudNgay.Size = new System.Drawing.Size(63, 20);
            this.nudNgay.TabIndex = 5;
            this.nudNgay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudThang
            // 
            this.nudThang.Location = new System.Drawing.Point(400, 248);
            this.nudThang.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudThang.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudThang.Name = "nudThang";
            this.nudThang.Size = new System.Drawing.Size(72, 20);
            this.nudThang.TabIndex = 7;
            this.nudThang.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudNam
            // 
            this.nudNam.Location = new System.Drawing.Point(616, 248);
            this.nudNam.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.nudNam.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudNam.Name = "nudNam";
            this.nudNam.Size = new System.Drawing.Size(79, 20);
            this.nudNam.TabIndex = 9;
            this.nudNam.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(216, 303);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(312, 20);
            this.txtDiaChi.TabIndex = 11;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.txtDiaChi_TextChanged);
            // 
            // dmNgheNghiep
            // 
            this.dmNgheNghiep.Items.Add("Bác Sĩ");
            this.dmNgheNghiep.Items.Add("Công Nhân");
            this.dmNgheNghiep.Items.Add("Giáo Viên");
            this.dmNgheNghiep.Items.Add("Hướng dẫn viên du lịch");
            this.dmNgheNghiep.Items.Add("Nhân Viên VIP");
            this.dmNgheNghiep.Items.Add("Thông dịch viên");
            this.dmNgheNghiep.Items.Add("Nhân viên IT");
            this.dmNgheNghiep.Location = new System.Drawing.Point(216, 357);
            this.dmNgheNghiep.Name = "dmNgheNghiep";
            this.dmNgheNghiep.Size = new System.Drawing.Size(140, 20);
            this.dmNgheNghiep.TabIndex = 13;
            this.dmNgheNghiep.Text = "Công Nhân";
            // 
            // btnDangKy
            // 
            this.btnDangKy.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.Location = new System.Drawing.Point(64, 407);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(100, 31);
            this.btnDangKy.TabIndex = 14;
            this.btnDangKy.Text = "Đăng Ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnNhapMoi
            // 
            this.btnNhapMoi.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapMoi.Location = new System.Drawing.Point(216, 408);
            this.btnNhapMoi.Name = "btnNhapMoi";
            this.btnNhapMoi.Size = new System.Drawing.Size(99, 31);
            this.btnNhapMoi.TabIndex = 15;
            this.btnNhapMoi.Text = "Nhập Mới";
            this.btnNhapMoi.UseVisualStyleBackColor = true;
            this.btnNhapMoi.Click += new System.EventHandler(this.btnNhapMoi_Click);
            // 
            // btnTongKet
            // 
            this.btnTongKet.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTongKet.Location = new System.Drawing.Point(373, 408);
            this.btnTongKet.Name = "btnTongKet";
            this.btnTongKet.Size = new System.Drawing.Size(99, 30);
            this.btnTongKet.TabIndex = 16;
            this.btnTongKet.Text = "Tổng Kết";
            this.btnTongKet.UseVisualStyleBackColor = true;
            this.btnTongKet.Click += new System.EventHandler(this.btnTongKet_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(517, 407);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(99, 30);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTongKet);
            this.Controls.Add(this.btnNhapMoi);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.dmNgheNghiep);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.nudNam);
            this.Controls.Add(this.nudThang);
            this.Controls.Add(this.nudNgay);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKhachHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.NumericUpDown nudNgay;
        private System.Windows.Forms.NumericUpDown nudThang;
        private System.Windows.Forms.NumericUpDown nudNam;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.DomainUpDown dmNgheNghiep;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnNhapMoi;
        private System.Windows.Forms.Button btnTongKet;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Timer timer1;
    }
}

