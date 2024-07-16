namespace Latih13_MdiFormLanjutan
{
    partial class Mahasiswa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            button3 = new Button();
            button2 = new Button();
            panel2 = new Panel();
            label8 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label6 = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            panel1 = new Panel();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
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
            tabControl1.Size = new Size(822, 511);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(814, 473);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Table Nilai";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(694, 429);
            button1.Name = "button1";
            button1.Size = new Size(112, 36);
            button1.TabIndex = 4;
            button1.Text = "New";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(79, 7);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(306, 31);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 10);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 2;
            label1.Text = "Filter";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(798, 379);
            dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(panel1);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(814, 473);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "CRUD Nilai";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(576, 433);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 9;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(694, 433);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 8;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(label8);
            panel2.Controls.Add(radioButton2);
            panel2.Controls.Add(radioButton1);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(410, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(396, 421);
            panel2.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 136);
            label8.Name = "label8";
            label8.Size = new Size(69, 25);
            label8.TabIndex = 10;
            label8.Text = "Gender";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(187, 167);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(126, 29);
            radioButton2.TabIndex = 9;
            radioButton2.TabStop = true;
            radioButton2.Text = "Perempuan";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(51, 167);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(114, 29);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Text = "Laki - Laki";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(24, 94);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(346, 31);
            dateTimePicker1.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(24, 354);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(346, 31);
            textBox5.TabIndex = 6;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(24, 279);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(346, 69);
            textBox6.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 251);
            label6.Name = "label6";
            label6.Size = new Size(108, 25);
            label6.TabIndex = 3;
            label6.Text = "Nama Siswa";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(24, 54);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(346, 31);
            textBox7.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 26);
            label7.Name = "label7";
            label7.Size = new Size(190, 25);
            label7.TabIndex = 1;
            label7.Text = "Tempat - Tanggal Lahir";
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(8, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(396, 421);
            panel1.TabIndex = 0;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(24, 190);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(346, 31);
            textBox4.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 162);
            label4.Name = "label4";
            label4.Size = new Size(211, 25);
            label4.TabIndex = 5;
            label4.Text = "Nomor Induk Siswa (NIS)";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(24, 122);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(346, 31);
            textBox3.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 94);
            label3.Name = "label3";
            label3.Size = new Size(108, 25);
            label3.TabIndex = 3;
            label3.Text = "Nama Siswa";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(24, 54);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(346, 31);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 26);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 1;
            label2.Text = "Siswa ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(413, 10);
            label5.Name = "label5";
            label5.Size = new Size(89, 25);
            label5.TabIndex = 5;
            label5.Text = "Filter Nilai";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(508, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(240, 33);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Mahasiswa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 511);
            Controls.Add(tabControl1);
            Name = "Mahasiswa";
            Text = "Mahasiswa";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
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
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private TabPage tabPage2;
        private Panel panel1;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private Panel panel2;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBox7;
        private Label label7;
        private Label label8;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private DateTimePicker dateTimePicker1;
        private Button button3;
        private Button button2;
        private ComboBox comboBox1;
        private Label label5;
    }
}