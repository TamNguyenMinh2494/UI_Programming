namespace E02
{
    partial class Form3
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
            this.lbName = new System.Windows.Forms.Label();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.rdbTime = new System.Windows.Forms.RadioButton();
            this.rdbComic = new System.Windows.Forms.RadioButton();
            this.rdbUVN = new System.Windows.Forms.RadioButton();
            this.rdbThao = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(12, 92);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(117, 20);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Nhập Văn Bản:";
            // 
            // txtShow
            // 
            this.txtShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShow.Location = new System.Drawing.Point(74, 132);
            this.txtShow.Multiline = true;
            this.txtShow.Name = "txtShow";
            this.txtShow.Size = new System.Drawing.Size(575, 250);
            this.txtShow.TabIndex = 1;
            // 
            // rdbTime
            // 
            this.rdbTime.AutoSize = true;
            this.rdbTime.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTime.Location = new System.Drawing.Point(166, 25);
            this.rdbTime.Name = "rdbTime";
            this.rdbTime.Size = new System.Drawing.Size(204, 31);
            this.rdbTime.TabIndex = 2;
            this.rdbTime.TabStop = true;
            this.rdbTime.Text = "Time New Roman";
            this.rdbTime.UseVisualStyleBackColor = true;
            this.rdbTime.CheckedChanged += new System.EventHandler(this.rdbTime_CheckedChanged);
            // 
            // rdbComic
            // 
            this.rdbComic.AutoSize = true;
            this.rdbComic.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbComic.Location = new System.Drawing.Point(433, 25);
            this.rdbComic.Name = "rdbComic";
            this.rdbComic.Size = new System.Drawing.Size(203, 37);
            this.rdbComic.TabIndex = 3;
            this.rdbComic.TabStop = true;
            this.rdbComic.Text = "Comic Sans MS";
            this.rdbComic.UseVisualStyleBackColor = true;
            this.rdbComic.CheckedChanged += new System.EventHandler(this.rdbComic_CheckedChanged);
            // 
            // rdbUVN
            // 
            this.rdbUVN.AutoSize = true;
            this.rdbUVN.Font = new System.Drawing.Font("UVN Lac Long Quan", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbUVN.Location = new System.Drawing.Point(166, 68);
            this.rdbUVN.Name = "rdbUVN";
            this.rdbUVN.Size = new System.Drawing.Size(251, 36);
            this.rdbUVN.TabIndex = 4;
            this.rdbUVN.TabStop = true;
            this.rdbUVN.Text = "UVN Lac Long Quan";
            this.rdbUVN.UseVisualStyleBackColor = true;
            this.rdbUVN.CheckedChanged += new System.EventHandler(this.rdbUVN_CheckedChanged);
            // 
            // rdbThao
            // 
            this.rdbThao.AutoSize = true;
            this.rdbThao.Font = new System.Drawing.Font("PhuongThao 1.1", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbThao.Location = new System.Drawing.Point(433, 68);
            this.rdbThao.Name = "rdbThao";
            this.rdbThao.Size = new System.Drawing.Size(192, 37);
            this.rdbThao.TabIndex = 5;
            this.rdbThao.TabStop = true;
            this.rdbThao.Text = "PhuongThao 1.1";
            this.rdbThao.UseVisualStyleBackColor = true;
            this.rdbThao.CheckedChanged += new System.EventHandler(this.rdbThao_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(713, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.rdbThao);
            this.Controls.Add(this.rdbUVN);
            this.Controls.Add(this.rdbComic);
            this.Controls.Add(this.rdbTime);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.lbName);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtShow;
        private System.Windows.Forms.RadioButton rdbTime;
        private System.Windows.Forms.RadioButton rdbComic;
        private System.Windows.Forms.RadioButton rdbUVN;
        private System.Windows.Forms.RadioButton rdbThao;
        private System.Windows.Forms.Button btnExit;
    }
}