using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace muhyidddinprojek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DB.crud($"Select * from user where Username='{textBox1.Text}' and Password= '{textBox2.Text}'");
            int cekbaris = DB.ds.Tables[0].Rows.Count;
            if (cekbaris == 1)
            {
                Form2 pindah = new Form2();
                pindah.Visible = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show("salah");
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
    }

