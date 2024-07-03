using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Sederhana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //clear code
            tb_angka1.Clear();
            tb_angka2.Clear();
            lbl_hasil.Text = "";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            //clear code
            tb_angka1.Clear();
            tb_angka2.Clear();
            lbl_hasil.Text = "";
        }
        private void btn_tambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_angka1.Text) || string.IsNullOrEmpty(tb_angka2.Text))
            {
                MessageBox.Show("angka harus di isikan terlebih dahulu!","Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int a, b, c;
                a = int.Parse(this.tb_angka1.Text);
                b = int.Parse(this.tb_angka2.Text);
                c = a + b;
                this.lbl_hasil.Text = c.ToString();
            }
        }


        private void btn_kurang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_angka1.Text) || string.IsNullOrEmpty(tb_angka2.Text))
            {
                MessageBox.Show("angka harus di isikan terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int a, b, c;
                a = int.Parse(this.tb_angka1.Text);
                b = int.Parse(this.tb_angka2.Text);
                c = a - b;
                this.lbl_hasil.Text = c.ToString();
            }
        }

        private void btn_kali_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_angka1.Text) || string.IsNullOrEmpty(tb_angka2.Text))
            {
                MessageBox.Show("angka harus di isikan terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int a, b, c;
                a = int.Parse(this.tb_angka1.Text);
                b = int.Parse(this.tb_angka2.Text);
                c = a * b;
                this.lbl_hasil.Text = c.ToString();
            }
        }

        private void btn_bagi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_angka1.Text) || string.IsNullOrEmpty(tb_angka2.Text))
            {
                MessageBox.Show("angka harus di isikan terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int a, b, c;
                a = int.Parse(this.tb_angka1.Text);
                b = int.Parse(this.tb_angka2.Text);
                c = a / b;
                this.lbl_hasil.Text = c.ToString();
            }
        }
    }
}
