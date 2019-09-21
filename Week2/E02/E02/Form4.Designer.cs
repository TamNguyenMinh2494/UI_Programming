namespace E02
{
    partial class Form4
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
            this.lbHead = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.cbSV = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbCafeSuaDa = new System.Windows.Forms.RadioButton();
            this.rdbCafeDa = new System.Windows.Forms.RadioButton();
            this.rdbCafeSua = new System.Windows.Forms.RadioButton();
            this.rdbCafeKem = new System.Windows.Forms.RadioButton();
            this.rdbCafeDen = new System.Windows.Forms.RadioButton();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongKhach = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbHead
            // 
            this.lbHead.AutoSize = true;
            this.lbHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHead.Location = new System.Drawing.Point(0, 0);
            this.lbHead.Name = "lbHead";
            this.lbHead.Size = new System.Drawing.Size(444, 55);
            this.lbHead.TabIndex = 0;
            this.lbHead.Text = "CAFE GIẢNG VIÊN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Khách Hàng:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(167, 78);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 2;
            // 
            // cbSV
            // 
            this.cbSV.AutoSize = true;
            this.cbSV.Location = new System.Drawing.Point(364, 77);
            this.cbSV.Name = "cbSV";
            this.cbSV.Size = new System.Drawing.Size(77, 17);
            this.cbSV.TabIndex = 3;
            this.cbSV.Text = "Sinh Viên?";
            this.cbSV.UseVisualStyleBackColor = true;
            this.cbSV.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbCafeSuaDa);
            this.groupBox1.Controls.Add(this.rdbCafeDa);
            this.groupBox1.Controls.Add(this.rdbCafeSua);
            this.groupBox1.Controls.Add(this.rdbCafeKem);
            this.groupBox1.Controls.Add(this.rdbCafeDen);
            this.groupBox1.Location = new System.Drawing.Point(24, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(736, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Loại Cafe";
            // 
            // rdbCafeSuaDa
            // 
            this.rdbCafeSuaDa.AutoSize = true;
            this.rdbCafeSuaDa.Location = new System.Drawing.Point(632, 33);
            this.rdbCafeSuaDa.Name = "rdbCafeSuaDa";
            this.rdbCafeSuaDa.Size = new System.Drawing.Size(86, 17);
            this.rdbCafeSuaDa.TabIndex = 4;
            this.rdbCafeSuaDa.TabStop = true;
            this.rdbCafeSuaDa.Text = "Cafe Sữa Đá";
            this.rdbCafeSuaDa.UseVisualStyleBackColor = true;
            this.rdbCafeSuaDa.CheckedChanged += new System.EventHandler(this.rdbCafeSuaDa_CheckedChanged);
            // 
            // rdbCafeDa
            // 
            this.rdbCafeDa.AutoSize = true;
            this.rdbCafeDa.Location = new System.Drawing.Point(418, 33);
            this.rdbCafeDa.Name = "rdbCafeDa";
            this.rdbCafeDa.Size = new System.Drawing.Size(64, 17);
            this.rdbCafeDa.TabIndex = 3;
            this.rdbCafeDa.TabStop = true;
            this.rdbCafeDa.Text = "Cafe Đá";
            this.rdbCafeDa.UseVisualStyleBackColor = true;
            this.rdbCafeDa.CheckedChanged += new System.EventHandler(this.rdbCafeDa_CheckedChanged);
            // 
            // rdbCafeSua
            // 
            this.rdbCafeSua.AutoSize = true;
            this.rdbCafeSua.Location = new System.Drawing.Point(209, 33);
            this.rdbCafeSua.Name = "rdbCafeSua";
            this.rdbCafeSua.Size = new System.Drawing.Size(69, 17);
            this.rdbCafeSua.TabIndex = 2;
            this.rdbCafeSua.TabStop = true;
            this.rdbCafeSua.Text = "Cafe Sữa";
            this.rdbCafeSua.UseVisualStyleBackColor = true;
            this.rdbCafeSua.CheckedChanged += new System.EventHandler(this.rdbCafeSua_CheckedChanged);
            // 
            // rdbCafeKem
            // 
            this.rdbCafeKem.AutoSize = true;
            this.rdbCafeKem.Location = new System.Drawing.Point(320, 77);
            this.rdbCafeKem.Name = "rdbCafeKem";
            this.rdbCafeKem.Size = new System.Drawing.Size(71, 17);
            this.rdbCafeKem.TabIndex = 1;
            this.rdbCafeKem.TabStop = true;
            this.rdbCafeKem.Text = "Cafe Kem";
            this.rdbCafeKem.UseVisualStyleBackColor = true;
            this.rdbCafeKem.CheckedChanged += new System.EventHandler(this.rdbCafeKem_CheckedChanged);
            // 
            // rdbCafeDen
            // 
            this.rdbCafeDen.AutoSize = true;
            this.rdbCafeDen.Location = new System.Drawing.Point(44, 33);
            this.rdbCafeDen.Name = "rdbCafeDen";
            this.rdbCafeDen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdbCafeDen.Size = new System.Drawing.Size(69, 17);
            this.rdbCafeDen.TabIndex = 0;
            this.rdbCafeDen.TabStop = true;
            this.rdbCafeDen.Text = "Cafe đen";
            this.rdbCafeDen.UseVisualStyleBackColor = true;
            this.rdbCafeDen.CheckedChanged += new System.EventHandler(this.rdbCafeDen_CheckedChanged);
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(49, 285);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(75, 23);
            this.btnTinhTien.TabIndex = 5;
            this.btnTinhTien.Text = "Tính Tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Location = new System.Drawing.Point(227, 285);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(75, 23);
            this.btnNhapLai.TabIndex = 6;
            this.btnNhapLai.Text = "Nhập Lại";
            this.btnNhapLai.UseVisualStyleBackColor = true;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(442, 285);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(75, 23);
            this.btnThanhToan.TabIndex = 7;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(656, 285);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tổng khách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tổng tiền";
            // 
            // txtTongKhach
            // 
            this.txtTongKhach.Location = new System.Drawing.Point(172, 357);
            this.txtTongKhach.Name = "txtTongKhach";
            this.txtTongKhach.Size = new System.Drawing.Size(100, 20);
            this.txtTongKhach.TabIndex = 11;
            this.txtTongKhach.TextChanged += new System.EventHandler(this.txtTongKhach_TextChanged);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(172, 390);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(100, 20);
            this.txtTongTien.TabIndex = 12;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtTongKhach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnNhapLai);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbSV);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbHead);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.CheckBox cbSV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbCafeSuaDa;
        private System.Windows.Forms.RadioButton rdbCafeDa;
        private System.Windows.Forms.RadioButton rdbCafeSua;
        private System.Windows.Forms.RadioButton rdbCafeKem;
        private System.Windows.Forms.RadioButton rdbCafeDen;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTongKhach;
        private System.Windows.Forms.TextBox txtTongTien;
    }
}