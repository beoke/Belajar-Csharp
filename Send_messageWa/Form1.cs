using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Send_messageWa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void sendWhatsApp(string number, string message)
        {
            try
            {
                if (number == "")
                {
                    MessageBox.Show("No number added");
                }
                if (number.Length <= 0)
                {
                    number = "+62" + number;
                }
                number = number.Replace(" ","");
                System.Diagnostics.Process.Start("http://api.whatsapp.com/send?phone=" +number + "&text=" +message);
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            sendWhatsApp(tx_message.Text, tx_message.Text);
            cleartextbox();
        }
        public void cleartextbox()
        {
            tx_message.Text = "";
            tx_number.Text = "";
           
        }
    }
}
