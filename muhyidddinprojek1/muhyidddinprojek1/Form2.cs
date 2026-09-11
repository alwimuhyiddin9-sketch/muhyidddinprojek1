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

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FormRole Hal2 = new FormRole() { TopLevel = false, TopMost = true };
            DB.form21(Hal2, panel1);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            panel1.Controls.Clear();
            FormUser Hal2 = new FormUser() { TopLevel = false, TopMost = true };
            DB.form21(Hal2, panel1);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
