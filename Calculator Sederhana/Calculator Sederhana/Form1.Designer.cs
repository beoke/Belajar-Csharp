namespace Calculator_Sederhana
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_angka1 = new System.Windows.Forms.TextBox();
            this.tb_angka2 = new System.Windows.Forms.TextBox();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.btn_kali = new System.Windows.Forms.Button();
            this.btn_kurang = new System.Windows.Forms.Button();
            this.btn_bagi = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.lbl_hasil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "angka 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "angka 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "hasil";
            // 
            // tb_angka1
            // 
            this.tb_angka1.Location = new System.Drawing.Point(178, 65);
            this.tb_angka1.Name = "tb_angka1";
            this.tb_angka1.Size = new System.Drawing.Size(100, 22);
            this.tb_angka1.TabIndex = 3;
            // 
            // tb_angka2
            // 
            this.tb_angka2.Location = new System.Drawing.Point(178, 105);
            this.tb_angka2.Name = "tb_angka2";
            this.tb_angka2.Size = new System.Drawing.Size(100, 22);
            this.tb_angka2.TabIndex = 4;
            // 
            // btn_tambah
            // 
            this.btn_tambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tambah.Location = new System.Drawing.Point(100, 179);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(48, 40);
            this.btn_tambah.TabIndex = 6;
            this.btn_tambah.Text = "+";
            this.btn_tambah.UseVisualStyleBackColor = true;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // btn_kali
            // 
            this.btn_kali.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kali.Location = new System.Drawing.Point(102, 225);
            this.btn_kali.Name = "btn_kali";
            this.btn_kali.Size = new System.Drawing.Size(48, 39);
            this.btn_kali.TabIndex = 7;
            this.btn_kali.Text = "x";
            this.btn_kali.UseVisualStyleBackColor = true;
            this.btn_kali.Click += new System.EventHandler(this.btn_kali_Click);
            // 
            // btn_kurang
            // 
            this.btn_kurang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kurang.Location = new System.Drawing.Point(157, 179);
            this.btn_kurang.Name = "btn_kurang";
            this.btn_kurang.Size = new System.Drawing.Size(50, 40);
            this.btn_kurang.TabIndex = 8;
            this.btn_kurang.Text = "-";
            this.btn_kurang.UseVisualStyleBackColor = true;
            this.btn_kurang.Click += new System.EventHandler(this.btn_kurang_Click);
            // 
            // btn_bagi
            // 
            this.btn_bagi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bagi.Location = new System.Drawing.Point(156, 225);
            this.btn_bagi.Name = "btn_bagi";
            this.btn_bagi.Size = new System.Drawing.Size(50, 39);
            this.btn_bagi.TabIndex = 9;
            this.btn_bagi.Text = "/";
            this.btn_bagi.UseVisualStyleBackColor = true;
            this.btn_bagi.Click += new System.EventHandler(this.btn_bagi_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(213, 179);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(65, 85);
            this.btn_clear.TabIndex = 10;
            this.btn_clear.Text = "C";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // lbl_hasil
            // 
            this.lbl_hasil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_hasil.Location = new System.Drawing.Point(178, 143);
            this.lbl_hasil.Name = "lbl_hasil";
            this.lbl_hasil.Size = new System.Drawing.Size(100, 23);
            this.lbl_hasil.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 367);
            this.Controls.Add(this.lbl_hasil);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_bagi);
            this.Controls.Add(this.btn_kurang);
            this.Controls.Add(this.btn_kali);
            this.Controls.Add(this.btn_tambah);
            this.Controls.Add(this.tb_angka2);
            this.Controls.Add(this.tb_angka1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_angka1;
        private System.Windows.Forms.TextBox tb_angka2;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.Button btn_kali;
        private System.Windows.Forms.Button btn_kurang;
        private System.Windows.Forms.Button btn_bagi;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label lbl_hasil;
    }
}

