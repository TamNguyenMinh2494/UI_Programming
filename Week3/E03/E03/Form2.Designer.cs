namespace E03
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdVietNam = new System.Windows.Forms.RadioButton();
            this.rdUSA = new System.Windows.Forms.RadioButton();
            this.rdItalian = new System.Windows.Forms.RadioButton();
            this.rdPhiliipine = new System.Windows.Forms.RadioButton();
            this.pbFlags = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlags)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(242, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "COUNTRY FLAGS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdPhiliipine);
            this.groupBox1.Controls.Add(this.rdItalian);
            this.groupBox1.Controls.Add(this.rdUSA);
            this.groupBox1.Controls.Add(this.rdVietNam);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(56, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 261);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Country";
            // 
            // rdVietNam
            // 
            this.rdVietNam.AutoSize = true;
            this.rdVietNam.Location = new System.Drawing.Point(110, 26);
            this.rdVietNam.Name = "rdVietNam";
            this.rdVietNam.Size = new System.Drawing.Size(87, 23);
            this.rdVietNam.TabIndex = 0;
            this.rdVietNam.TabStop = true;
            this.rdVietNam.Text = "VietNam";
            this.rdVietNam.UseVisualStyleBackColor = true;
            this.rdVietNam.CheckedChanged += new System.EventHandler(this.rdVietNam_CheckedChanged);
            // 
            // rdUSA
            // 
            this.rdUSA.AutoSize = true;
            this.rdUSA.Location = new System.Drawing.Point(110, 84);
            this.rdUSA.Name = "rdUSA";
            this.rdUSA.Size = new System.Drawing.Size(59, 23);
            this.rdUSA.TabIndex = 1;
            this.rdUSA.TabStop = true;
            this.rdUSA.Text = "USA";
            this.rdUSA.UseVisualStyleBackColor = true;
            this.rdUSA.CheckedChanged += new System.EventHandler(this.rdUSA_CheckedChanged);
            // 
            // rdItalian
            // 
            this.rdItalian.AutoSize = true;
            this.rdItalian.Location = new System.Drawing.Point(110, 139);
            this.rdItalian.Name = "rdItalian";
            this.rdItalian.Size = new System.Drawing.Size(69, 23);
            this.rdItalian.TabIndex = 2;
            this.rdItalian.TabStop = true;
            this.rdItalian.Text = "Italian";
            this.rdItalian.UseVisualStyleBackColor = true;
            this.rdItalian.CheckedChanged += new System.EventHandler(this.rdItalian_CheckedChanged);
            // 
            // rdPhiliipine
            // 
            this.rdPhiliipine.AutoSize = true;
            this.rdPhiliipine.Location = new System.Drawing.Point(110, 201);
            this.rdPhiliipine.Name = "rdPhiliipine";
            this.rdPhiliipine.Size = new System.Drawing.Size(97, 23);
            this.rdPhiliipine.TabIndex = 3;
            this.rdPhiliipine.TabStop = true;
            this.rdPhiliipine.Text = "Philippine";
            this.rdPhiliipine.UseVisualStyleBackColor = true;
            this.rdPhiliipine.CheckedChanged += new System.EventHandler(this.rdPhiliipine_CheckedChanged);
            // 
            // pbFlags
            // 
            this.pbFlags.Location = new System.Drawing.Point(435, 112);
            this.pbFlags.Name = "pbFlags";
            this.pbFlags.Size = new System.Drawing.Size(304, 261);
            this.pbFlags.TabIndex = 2;
            this.pbFlags.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbFlags);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlags)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdPhiliipine;
        private System.Windows.Forms.RadioButton rdItalian;
        private System.Windows.Forms.RadioButton rdUSA;
        private System.Windows.Forms.RadioButton rdVietNam;
        private System.Windows.Forms.PictureBox pbFlags;
    }
}