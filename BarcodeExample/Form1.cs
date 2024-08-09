namespace BarcodeExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // jangan lupa install zen.barcode
        private void btn_barcode_Click(object sender, EventArgs e)
        {
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureBox1.Image = barcode.Draw(tx_barcode.Text, 50);
        }

        private void btn_qrcode_Click(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox1.Image = qrcode.Draw(tx_qrcode.Text, 50);
        }
    }
}
