using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Latih13_MdiFormLanjutan
{
    public partial class Form1 : Form
    {
        public string gender;
        public Form1()
        {
            InitializeComponent();
            DaftarSiswa();
        }
        public void DaftarSiswa()
        {
            DbContextt db = new DbContextt();
            var ListSiswa = db.siswa.ToList();
            dataGridView1.DataSource = ListSiswa;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            NewSiswa();
        }

        public void NewSiswa()
        {
            var New = new SiswaModel();
            using var db = new DbContextt();
            db.siswa.Add(New);
            db.SaveChanges();

            ShowInput(New);
        }

        public void ShowInput(SiswaModel siswa)
        {
            txtSiswaID.Text = siswa.SiswaId.ToString();
            txtSiswaName.Text = siswa.SiswaName;
            txtNIS.Text = siswa.Nis;
            txtTempat.Text = siswa.TempatLahir;
            dateTimePicker1.Value = siswa.TglLahir;
            txtAlamat.Text = siswa.Alamat;
            txtKota.Text = siswa.Kota;

            tabControl1.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveData();
            ListData();
        }

        public void ListData()
        {
            using var db = new DbContextt();
            dataGridView1.DataSource = db.siswa.ToList();
            tabControl1.SelectedIndex = 0;
        }

        public void SaveData()
        {
            using var db = new DbContextt();
            var row = db.siswa.Find(int.Parse(txtSiswaID.Text));

            if (row == null) return;
            row.SiswaId = int.Parse(txtSiswaID.Text);
            row.SiswaName = txtSiswaName.Text;
            row.Nis = txtNIS.Text;
            row.TempatLahir = txtTempat.Text;
            row.TglLahir = dateTimePicker1.Value;
            row.Gender = gender;
            row.Alamat = txtAlamat.Text;
            row.Kota = txtKota.Text;

            db.SaveChanges();
        }

        private void radioLaki_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Laki - Laki";
        }

        private void radioPerempuan_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Perempuan";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using var db = new DbContextt();
            var row = db.siswa.Find(int.Parse(txtSiswaID.Text));

            if (row == null) return;
            db.siswa.Remove(row);
            db.SaveChanges();
            dataGridView1.Refresh();
            tabControl1.SelectedIndex = 0;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            var a = dataGridView1.CurrentRow.Cells["SiswaID"].Value;
            using var db = new DbContextt();
            var row = db.siswa.Find(a);

            if (row == null) return;
            ShowInput(row);
        }
    }
}
