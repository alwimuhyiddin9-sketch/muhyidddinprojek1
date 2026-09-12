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
    public partial class FormRole : Form

    {
        string idRoleTerpilih = "";
        public FormRole()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public void tampildata()
        {
            dgvRole.Rows.Clear();
            DB.crud("SELECT * FROM role");
            foreach (DataRow baris in DB.ds.Tables[0].Rows)
            {
                string id = "" + baris["id_role"];
                string nr = "" + baris["nama_role"];
                string de = "" + baris["Deskripsi"];
                dgvRole.Rows.Add(id, nr, de);

            }
        }
        public void bersih()
        {
            txtUsername.Text = "";
            txtdesk.Text = "";
        }
  



        private void dgvRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = e.RowIndex;
            int kolom = e.ColumnIndex;
            string idnya = dgvRole.Rows[baris].Cells[0].Value.ToString();
            if (kolom == 3)
            {


                DB.crud($"SELECT * FROM role WHERE id_role ='{idnya}'");
                foreach (DataRow bariss in DB.ds.Tables[0].Rows)
                {
                    string id = " " + bariss["id_role"];
                    string nr = "" + bariss["Nama"];
                    string de = "" + bariss["Deskripsi"];
                    label2.Text = id;
                    txtUsername.Text = nr;
                    txtdesk.Text = de;


                }
            }
        }

       

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void FormRole_Load(object sender, EventArgs e)
        {
            dgvRole.Rows.Clear();
            DB.crud($"SELECT * FROM role WHERE nama_role LIKE '%{txtCari.Text}%'");
            foreach (DataRow baris in DB.ds.Tables[0].Rows)
            {
                string id = "" + baris["id_role"];
                string nr = "" + baris["nama_role"];
                string de = "" + baris["Deskripsi"];
                dgvRole.Rows.Add(id, nr, de);

            }
        }

        private void btnSimpan_Click_1(object sender, EventArgs e)
        {
            string nr = txtUsername.Text;
            string de = txtdesk.Text;
            DB.crud($"INSERT INTO role VALUES(null,'{nr}','{de}')");
            bersih();
            tampildata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Memanggil kembali Form2 (Induk)
            if (this.Owner != null)
            {
                this.Owner.Show();
            }

            // Menutup form saat ini
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtShow_Click_1(object sender, EventArgs e)
        {
            tampildata();
        }

        private void txtCari_TextChanged_1(object sender, EventArgs e)
        {
            dgvRole.Rows.Clear();
            DB.crud($"SELECT * FROM role WHERE nama_role LIKE '%{txtCari.Text}%'");
            foreach (DataRow baris in DB.ds.Tables[0].Rows)
            {
                string id = "" + baris["id_role"];
                string nr = "" + baris["nama_role"];
                string de = "" + baris["Deskripsi"];
                dgvRole.Rows.Add(id, nr, de);


            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {

        }
    }
}
