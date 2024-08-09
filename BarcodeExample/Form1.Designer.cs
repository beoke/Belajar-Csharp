namespace BarcodeExample
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_barcode = new Button();
            label1 = new Label();
            tx_barcode = new TextBox();
            tx_qrcode = new TextBox();
            label2 = new Label();
            btn_qrcode = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_barcode
            // 
            btn_barcode.Location = new Point(397, 261);
            btn_barcode.Name = "btn_barcode";
            btn_barcode.Size = new Size(94, 29);
            btn_barcode.TabIndex = 0;
            btn_barcode.Text = "Barcode";
            btn_barcode.UseVisualStyleBackColor = true;
            btn_barcode.Click += btn_barcode_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 261);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 1;
            label1.Text = "Barcode";
            // 
            // tx_barcode
            // 
            tx_barcode.Location = new Point(119, 262);
            tx_barcode.Name = "tx_barcode";
            tx_barcode.Size = new Size(258, 27);
            tx_barcode.TabIndex = 2;
            // 
            // tx_qrcode
            // 
            tx_qrcode.Location = new Point(119, 295);
            tx_qrcode.Name = "tx_qrcode";
            tx_qrcode.Size = new Size(258, 27);
            tx_qrcode.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 294);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 4;
            label2.Text = "Qr Code";
            // 
            // btn_qrcode
            // 
            btn_qrcode.Location = new Point(397, 294);
            btn_qrcode.Name = "btn_qrcode";
            btn_qrcode.Size = new Size(94, 29);
            btn_qrcode.TabIndex = 3;
            btn_qrcode.Text = "Qr Code";
            btn_qrcode.UseVisualStyleBackColor = true;
            btn_qrcode.Click += btn_qrcode_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(25, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(476, 219);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 350);
            Controls.Add(pictureBox1);
            Controls.Add(tx_qrcode);
            Controls.Add(label2);
            Controls.Add(btn_qrcode);
            Controls.Add(tx_barcode);
            Controls.Add(label1);
            Controls.Add(btn_barcode);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_barcode;
        private Label label1;
        private TextBox tx_barcode;
        private TextBox tx_qrcode;
        private Label label2;
        private Button btn_qrcode;
        private PictureBox pictureBox1;
    }
}
