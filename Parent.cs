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
    public partial class Parent : Form
    {
        public Form1 ListSiswa;
        public Parent()
        {
            InitializeComponent();

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListSiswa = new Form1();
            ListSiswa.MdiParent = this;
            ListSiswa.Show();
        }

        private void dataMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
