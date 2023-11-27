namespace XIIRPL2_29_Ticketing.MasterForm
{
    partial class FrmJadwalPenerbangan
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
            button2 = new Button();
            button1 = new Button();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            domainUpDown1 = new DomainUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(1057, 552);
            button2.Name = "button2";
            button2.Size = new Size(85, 27);
            button2.TabIndex = 33;
            button2.Text = "Simpan";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(956, 552);
            button1.Name = "button1";
            button1.Size = new Size(85, 27);
            button1.TabIndex = 32;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(377, 480);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(232, 23);
            comboBox1.TabIndex = 29;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(377, 442);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(232, 23);
            textBox3.TabIndex = 28;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(377, 404);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(232, 23);
            textBox2.TabIndex = 27;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(377, 369);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 23);
            textBox1.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(697, 404);
            label8.Name = "label8";
            label8.Size = new Size(180, 23);
            label8.TabIndex = 25;
            label8.Text = "Waktu Keberangkatan";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(697, 369);
            label7.Name = "label7";
            label7.Size = new Size(68, 23);
            label7.TabIndex = 24;
            label7.Text = "Tanggal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(210, 480);
            label6.Name = "label6";
            label6.Size = new Size(84, 23);
            label6.TabIndex = 23;
            label6.Text = "Maskapai";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(210, 442);
            label5.Name = "label5";
            label5.Size = new Size(29, 23);
            label5.TabIndex = 22;
            label5.Text = "Ke";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(210, 404);
            label4.Name = "label4";
            label4.Size = new Size(42, 23);
            label4.TabIndex = 21;
            label4.Text = "Dari";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(210, 369);
            label3.Name = "label3";
            label3.Size = new Size(155, 23);
            label3.TabIndex = 20;
            label3.Text = "Kode Penerbangan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(189, 58);
            label2.Name = "label2";
            label2.Size = new Size(377, 23);
            label2.TabIndex = 19;
            label2.Text = "Semua  jadwal penerbangan akan muncul di sini";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(189, 16);
            label1.Name = "label1";
            label1.Size = new Size(336, 32);
            label1.TabIndex = 18;
            label1.Text = "Master Jadwal Penerbangan";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(210, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1117, 244);
            dataGridView1.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(910, 369);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(232, 23);
            dateTimePicker1.TabIndex = 34;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(910, 407);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(232, 23);
            textBox4.TabIndex = 35;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(910, 445);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(232, 23);
            textBox5.TabIndex = 36;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(697, 442);
            label9.Name = "label9";
            label9.Size = new Size(166, 23);
            label9.TabIndex = 37;
            label9.Text = "Durasi Penerbangan";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(697, 480);
            label10.Name = "label10";
            label10.Size = new Size(126, 23);
            label10.TabIndex = 38;
            label10.Text = "Harga Per Tiket";
            // 
            // domainUpDown1
            // 
            domainUpDown1.Location = new Point(910, 481);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(232, 23);
            domainUpDown1.TabIndex = 39;
            // 
            // FrmJadwalPenerbangan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1495, 611);
            Controls.Add(domainUpDown1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FrmJadwalPenerbangan";
            Text = "FrmJadwalPenerbangan";
            Load += FrmJadwalPenerbangan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label9;
        private Label label10;
        private DomainUpDown domainUpDown1;
    }
}