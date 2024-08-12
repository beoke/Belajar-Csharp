using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using AForge.Video;
using AForge.Video.DirectShow;


namespace BarcodeScanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FilterInfoCollection fic;
        VideoCaptureDevice vcd;

        private void Form1_Load(object sender, EventArgs e)
        {
            fic = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in fic)
            {
                comboBox1.Items.Add(device.Name);
            }
            comboBox1 .SelectedIndex = 0;
        }
        private void btn_start_Click(object sender, EventArgs e)
        {
            vcd = new VideoCaptureDevice(fic[comboBox1.SelectedIndex].MonikerString);
            vcd.NewFrame += VideoCaptureDevice_NewFrame;
            vcd.Start();
            btn_start.Enabled = false;
            btn_stop.Enabled = true;
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            if(result!= null)
            {
                tx_barcode.Invoke(new MethodInvoker(delegate ()
                {
                    tx_barcode.Text = result.ToString();

                })); 
            }
            pictureBox1.Image = bitmap;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (vcd != null)
            {
                if(vcd.IsRunning)
                {
                    vcd.Stop();
                    Application.Exit();
                }
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            if (vcd != null)
            {
                if (vcd.IsRunning)
                {
                    vcd.Stop();
                    pictureBox1.Image=null;
                    btn_start.Enabled=true;
                    btn_stop.Enabled = false;
                    tx_barcode.Text = string.Empty;

                }
            }
        }
    }
}
