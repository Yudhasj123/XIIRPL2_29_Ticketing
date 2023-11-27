namespace XIIRPL2_29_Ticketing.MasterForm
{
    partial class FrmMasterMaskapai
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
            txtPerusahaan = new TextBox();
            txtNama = new TextBox();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            txtJumlah_kru = new NumericUpDown();
            txtDeskripsi = new TextBox();
            BtnEdit = new DataGridViewButtonColumn();
            BtnDelete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtJumlah_kru).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(1092, 533);
            button2.Name = "button2";
            button2.Size = new Size(85, 27);
            button2.TabIndex = 33;
            button2.Text = "Simpan";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(988, 533);
            button1.Name = "button1";
            button1.Size = new Size(85, 27);
            button1.TabIndex = 32;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtPerusahaan
            // 
            txtPerusahaan.Location = new Point(309, 403);
            txtPerusahaan.Name = "txtPerusahaan";
            txtPerusahaan.Size = new Size(203, 23);
            txtPerusahaan.TabIndex = 27;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(309, 365);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(203, 23);
            txtNama.TabIndex = 26;
            txtNama.TextChanged += textBox1_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(751, 365);
            label8.Name = "label8";
            label8.Size = new Size(81, 23);
            label8.TabIndex = 25;
            label8.Text = "Deskripsi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(195, 450);
            label5.Name = "label5";
            label5.Size = new Size(95, 23);
            label5.TabIndex = 22;
            label5.Text = "Jumlah Kru";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(195, 403);
            label4.Name = "label4";
            label4.Size = new Size(101, 23);
            label4.TabIndex = 21;
            label4.Text = "Perusahaan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(195, 365);
            label3.Name = "label3";
            label3.Size = new Size(55, 23);
            label3.TabIndex = 20;
            label3.Text = "Nama";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(190, 58);
            label2.Name = "label2";
            label2.Size = new Size(403, 23);
            label2.TabIndex = 19;
            label2.Text = "Semua maskapai yang terdaftar akan muncul di sini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(190, 15);
            label1.Name = "label1";
            label1.Size = new Size(208, 32);
            label1.TabIndex = 18;
            label1.Text = "Master Maskapai";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnEdit, BtnDelete });
            dataGridView1.Location = new Point(190, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1117, 244);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellClick += dataGridView1_CellClick_1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtJumlah_kru
            // 
            txtJumlah_kru.Location = new Point(309, 454);
            txtJumlah_kru.Name = "txtJumlah_kru";
            txtJumlah_kru.Size = new Size(203, 23);
            txtJumlah_kru.TabIndex = 34;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(853, 374);
            txtDeskripsi.Multiline = true;
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(324, 124);
            txtDeskripsi.TabIndex = 35;
            // 
            // BtnEdit
            // 
            BtnEdit.HeaderText = "Edit";
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Text = "Edit";
            BtnEdit.UseColumnTextForButtonValue = true;
            // 
            // BtnDelete
            // 
            BtnDelete.HeaderText = "Delete";
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Text = "Delete";
            BtnDelete.UseColumnTextForButtonValue = true;
            // 
            // FrmMasterMaskapai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1507, 625);
            Controls.Add(txtDeskripsi);
            Controls.Add(txtJumlah_kru);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtPerusahaan);
            Controls.Add(txtNama);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FrmMasterMaskapai";
            Text = "FrmMaskapai";
            Load += FrmMasterMaskapai_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtJumlah_kru).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox txtPerusahaan;
        private TextBox txtNama;
        private Label label8;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private NumericUpDown txtJumlah_kru;
        private TextBox txtDeskripsi;
        private DataGridViewButtonColumn BtnEdit;
        private DataGridViewButtonColumn BtnDelete;
    }
}