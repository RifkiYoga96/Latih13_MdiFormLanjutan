namespace Latih13_MdiFormLanjutan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            tabPage2 = new TabPage();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            txtKota = new TextBox();
            radioPerempuan = new RadioButton();
            radioLaki = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            txtAlamat = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtTempat = new TextBox();
            label6 = new Label();
            panel1 = new Panel();
            txtNIS = new TextBox();
            label3 = new Label();
            txtSiswaName = new TextBox();
            label2 = new Label();
            txtSiswaID = new TextBox();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(767, 503);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(button3);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(759, 465);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "List Data";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(743, 405);
            dataGridView1.TabIndex = 4;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.Location = new Point(639, 417);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 1;
            button3.Text = "New";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(panel1);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(759, 465);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Input Data";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(524, 418);
            button2.Name = "button2";
            button2.Size = new Size(112, 39);
            button2.TabIndex = 9;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(642, 418);
            button1.Name = "button1";
            button1.Size = new Size(112, 39);
            button1.TabIndex = 8;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(txtKota);
            panel2.Controls.Add(radioPerempuan);
            panel2.Controls.Add(radioLaki);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(txtAlamat);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtTempat);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(383, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(371, 406);
            panel2.TabIndex = 7;
            // 
            // txtKota
            // 
            txtKota.Anchor = AnchorStyles.None;
            txtKota.Location = new Point(27, 327);
            txtKota.Name = "txtKota";
            txtKota.Size = new Size(305, 31);
            txtKota.TabIndex = 7;
            // 
            // radioPerempuan
            // 
            radioPerempuan.Anchor = AnchorStyles.None;
            radioPerempuan.AutoSize = true;
            radioPerempuan.Location = new Point(165, 162);
            radioPerempuan.Name = "radioPerempuan";
            radioPerempuan.Size = new Size(126, 29);
            radioPerempuan.TabIndex = 9;
            radioPerempuan.TabStop = true;
            radioPerempuan.Text = "Perempuan";
            radioPerempuan.UseVisualStyleBackColor = true;
            radioPerempuan.CheckedChanged += radioPerempuan_CheckedChanged;
            // 
            // radioLaki
            // 
            radioLaki.Anchor = AnchorStyles.None;
            radioLaki.AutoSize = true;
            radioLaki.Location = new Point(27, 162);
            radioLaki.Name = "radioLaki";
            radioLaki.Size = new Size(114, 29);
            radioLaki.TabIndex = 8;
            radioLaki.TabStop = true;
            radioLaki.Text = "Laki - Laki";
            radioLaki.UseVisualStyleBackColor = true;
            radioLaki.CheckedChanged += radioLaki_CheckedChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.Location = new Point(27, 86);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(305, 31);
            dateTimePicker1.TabIndex = 7;
            // 
            // txtAlamat
            // 
            txtAlamat.Anchor = AnchorStyles.None;
            txtAlamat.Location = new Point(27, 252);
            txtAlamat.Multiline = true;
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(305, 69);
            txtAlamat.TabIndex = 6;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(27, 224);
            label4.Name = "label4";
            label4.Size = new Size(121, 25);
            label4.TabIndex = 5;
            label4.Text = "Alamat - Kota";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(27, 134);
            label5.Name = "label5";
            label5.Size = new Size(69, 25);
            label5.TabIndex = 3;
            label5.Text = "Gender";
            // 
            // txtTempat
            // 
            txtTempat.Anchor = AnchorStyles.None;
            txtTempat.Location = new Point(27, 47);
            txtTempat.Name = "txtTempat";
            txtTempat.Size = new Size(305, 31);
            txtTempat.TabIndex = 2;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(27, 19);
            label6.Name = "label6";
            label6.Size = new Size(190, 25);
            label6.TabIndex = 1;
            label6.Text = "Tempat - Tanggal Lahir";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(txtNIS);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtSiswaName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtSiswaID);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(371, 406);
            panel1.TabIndex = 0;
            // 
            // txtNIS
            // 
            txtNIS.Anchor = AnchorStyles.None;
            txtNIS.Location = new Point(27, 179);
            txtNIS.Name = "txtNIS";
            txtNIS.Size = new Size(305, 31);
            txtNIS.TabIndex = 6;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(27, 151);
            label3.Name = "label3";
            label3.Size = new Size(211, 25);
            label3.TabIndex = 5;
            label3.Text = "Nomor Induk Siswa (NIS)";
            // 
            // txtSiswaName
            // 
            txtSiswaName.Anchor = AnchorStyles.None;
            txtSiswaName.Location = new Point(27, 114);
            txtSiswaName.Name = "txtSiswaName";
            txtSiswaName.Size = new Size(305, 31);
            txtSiswaName.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(27, 86);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 3;
            label2.Text = "Siswa Name";
            // 
            // txtSiswaID
            // 
            txtSiswaID.Anchor = AnchorStyles.None;
            txtSiswaID.Location = new Point(27, 47);
            txtSiswaID.Name = "txtSiswaID";
            txtSiswaID.Size = new Size(305, 31);
            txtSiswaID.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(27, 19);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 1;
            label1.Text = "Siswa ID";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 503);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel2;
        private DateTimePicker dateTimePicker1;
        private TextBox txtAlamat;
        private Label label4;
        private Label label5;
        private TextBox txtTempat;
        private Label label6;
        private Panel panel1;
        private TextBox txtNIS;
        private Label label3;
        private TextBox txtSiswaName;
        private Label label2;
        private TextBox txtSiswaID;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox txtKota;
        private RadioButton radioPerempuan;
        private RadioButton radioLaki;
        private DataGridView dataGridView1;
    }
}
