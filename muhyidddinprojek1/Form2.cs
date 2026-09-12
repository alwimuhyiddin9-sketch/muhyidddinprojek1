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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Tampilkanform(Form form)
        {
            panel1.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panel1.Controls.Add(form);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRole formRole = new FormRole();
            formRole.Owner = this; // Menjadikan Form2 saat ini sebagai "Induk"
            formRole.Show();
            this.Hide();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormUser formUser = new FormUser();
            formUser.Owner = this; // Menjadikan Form2 saat ini sebagai "Induk"
            formUser.Show();
            this.Hide();


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnabsensi_Click(object sender, EventArgs e)
        {
                FormAbsensi formAbsen = new FormAbsensi();
                formAbsen.Owner = this; // KUNCI: Menjadikan Form2 saat ini sebagai "Induk"
                formAbsen.Show();
                this.Hide();
            
        }
    }
}
