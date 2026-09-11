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
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }
        public void tampildata()
        {
            dgvUser.Rows.Clear();
            DB.crud("SELECT * FROM user");
            foreach (DataRow baris in DB.ds.Tables[0].Rows)
            {
                string id = "" + baris["IDU"];
                string un = "" + baris["Username"];
                string pw = "" + baris["Password"];
                string ir = "" + baris["id_role"];
                dgvUser.Rows.Add(id, un, pw, ir);

            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormUser_Load(object sender, EventArgs e)
        {

            DB.crud("SELECT id_role, nama_role FROM role");

            cbRole.DataSource = DB.ds.Tables[0];
            cbRole.DisplayMember = "nama_role";
            cbRole.ValueMember = "id_role";

        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {

            string username = txtUser.Text;
            string password = txtpassword.Text;
            string id_role = cbRole.SelectedValue.ToString();

            DB.crud($"INSERT INTO user (Username, Password, id_role) VALUES ('{username}', '{password}', '{id_role}')");

            MessageBox.Show("Data user berhasil disimpan");

            txtUser.Clear();
            txtpassword.Clear();

            cbRole.SelectedIndex = -1;

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            tampildata();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvUser.Rows.Clear();
            DB.crud($"SELECT * FROM user WHERE Username LIKE '%{txtCari.Text}%'");
            foreach (DataRow baris in DB.ds.Tables[0].Rows)
            {
                string id = "" + baris["IDU"];
                string un = "" + baris["Username"];
                string pw = "" + baris["Password"];
                string ir = "" + baris["id_role"];
                dgvUser.Rows.Add(id, un, pw, ir);
            }
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = e.RowIndex;
            int kolom = e.ColumnIndex;
            string idnya = dgvUser.Rows[baris].Cells[0].Value.ToString();
            if (kolom == 4)
            {


                DB.crud($"SELECT * FROM user WHERE IDU ='{idnya}'");
                foreach (DataRow bariss in DB.ds.Tables[0].Rows)
                {
                    string id = "" + bariss["IDU"];
                    string un = "" + bariss["Username"];
                    string pw = "" + bariss["Password"];
                    string ir = "" + bariss["id_role"];
                    Text = id;
                    txtUser.Text = un;
                    txtpassword.Text = pw;
                    cbRole.Text = ir;
                    



                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
