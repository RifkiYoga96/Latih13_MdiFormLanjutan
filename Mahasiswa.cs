using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latih13_MdiFormLanjutan
{
    public partial class Mahasiswa : Form
    {
        private DbDapper dbdapper;
        public List<string> list;
        public Mahasiswa()
        {
            InitializeComponent();
            dbdapper = new DbDapper();
            dataGridView1.DataSource = dbdapper.DataNilai("0");

            list = new List<string>()
            {
                "Semua","Diatas KKM","Dibawah KKM"
            };
            comboBox1.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            dbdapper = new DbDapper();
            dataGridView1.DataSource = dbdapper.DataNilai(input);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var select = comboBox1.SelectedIndex;
            dbdapper = new DbDapper();
            if (select == 1)
            {

            }
        }
    }
}
