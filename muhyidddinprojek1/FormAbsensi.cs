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
    public partial class FormAbsensi : Form
    {
        public FormAbsensi()
        {
            InitializeComponent();
        }

        private void cbstatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormAbsensi_Load(object sender, EventArgs e)
        {
            // Mengambil data kelas dari database
            DB.crud("SELECT id_kelas, nama_kelas FROM kelas");

            // Memasukkan data ke ComboBox cbKelas
            cbkelas.DataSource = DB.ds.Tables[0];
            cbkelas.DisplayMember = "nama_kelas";
            cbkelas.ValueMember = "id_kelas";

            cbkelas.SelectedIndex = -1; // Biar awal dibuka kotaknya kosong
        }

        private void btntampil_Click(object sender, EventArgs e)
        {
           
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
           ;
        }

        private void btnkembali_Click(object sender, EventArgs e)
        {
            // Memanggil kembali Form2 (Induk)
            if (this.Owner != null)
            {
                this.Owner.Show();
            }

            // Menutup form saat ini
            this.Close();
        }

        private void dgvabsensi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnkembali_Click_1(object sender, EventArgs e)
        {
            // Memanggil kembali Form2 (Induk)
            if (this.Owner != null)
            {
                this.Owner.Show();
            }

            // Menutup form saat ini
            this.Close();
        }

        private void btnsimpan_Click_1(object sender, EventArgs e)
        {
            if (dgvabsensi.Rows.Count == 0)
            {
                MessageBox.Show("Tampilkan data siswa terlebih dahulu!");
                return;
            }

            // Ambil tanggal dari DateTimePicker
            string tanggalAbsen = dtpTanggal.Value.ToString("yyyy-MM-dd");

            // Looping setiap baris di tabel untuk disimpan ke database
            foreach (DataGridViewRow row in dgvabsensi.Rows)
            {
                if (row.Cells["nis"].Value == null) continue;

                string nis = row.Cells["nis"].Value.ToString();
                string status = row.Cells["status"].Value?.ToString() ?? "Hadir";
                string keterangan = ""; // Kosongkan jika tidak ada textbox keterangan

                // Eksekusi simpan ke tabel absensi
                string query = $"INSERT INTO absensi (nis, tanggal, status, keterangan) VALUES ('{nis}', '{tanggalAbsen}', '{status}', '{keterangan}')";
                DB.crud(query);
            }

            MessageBox.Show("Data absensi berhasil disimpan!");
        }

        private void btntampil_Click_1(object sender, EventArgs e)
        {
             if (cbkelas.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih kelas terlebih dahulu!");
                return;
            }

            dgvabsensi.Rows.Clear();
            dgvabsensi.Columns.Clear();

            // 1. Tambah kolom teks biasa untuk NIS dan Nama
            dgvabsensi.Columns.Add("nis", "NIS");
            dgvabsensi.Columns.Add("nama_siswa", "Nama Siswa");

            // 2. Wajib ada bagian ini supaya kolom status jadi ComboBox dropdown!
            DataGridViewComboBoxColumn colStatus = new DataGridViewComboBoxColumn();
            colStatus.Name = "status";
            colStatus.HeaderText = "Status Kehadiran";
            colStatus.Items.Add("Hadir");
            colStatus.Items.Add("Izin");
            colStatus.Items.Add("Sakit");
            colStatus.Items.Add("Alpha");
            dgvabsensi.Columns.Add(colStatus);

            // 3. Tarik data siswa dari database berdasarkan kelas yang dipilih
            string idKelasDipilih = cbkelas.SelectedValue.ToString();
            DB.crud($"SELECT nis, nama_siswa FROM siswa WHERE id_kelas = '{idKelasDipilih}'");

            // 4. Masukkan ke baris tabel
            foreach (DataRow baris in DB.ds.Tables[0].Rows)
            {
                string nis = baris["nis"].ToString();
                string nama = baris["nama_siswa"].ToString();

                // Baris ini ngisi data siswa sekaligus nge-set default dropdown jadi "Hadir"
                dgvabsensi.Rows.Add(nis, nama, "Hadir");
            }
        }
    }
}
