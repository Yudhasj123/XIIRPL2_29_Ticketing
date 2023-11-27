namespace XIIRPL2_29_Ticketing.MasterForm
{
    partial class FrmMasterBandara
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
            dataGridView1 = new DataGridView();
            btnDelete = new DataGridViewButtonColumn();
            btnEdit = new DataGridViewButtonColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtNama = new TextBox();
            txtKodeIATA = new TextBox();
            txtKota = new TextBox();
            txtNegara = new ComboBox();
            txtJmlTerminal = new DomainUpDown();
            button1 = new Button();
            button2 = new Button();
            txtAlamat = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { btnDelete, btnEdit });
            dataGridView1.Location = new Point(12, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1117, 244);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnDelete
            // 
            btnDelete.HeaderText = "Delete";
            btnDelete.Name = "btnDelete";
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;
            // 
            // btnEdit
            // 
            btnEdit.HeaderText = "Edit";
            btnEdit.Name = "btnEdit";
            btnEdit.Text = "Edit";
            btnEdit.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(194, 32);
            label1.TabIndex = 1;
            label1.Text = "Master Bandara";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(394, 23);
            label2.TabIndex = 2;
            label2.Text = "Semua bandara yang terdaftar akan muncul di sini";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(17, 359);
            label3.Name = "label3";
            label3.Size = new Size(55, 23);
            label3.TabIndex = 3;
            label3.Text = "Nama";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(17, 397);
            label4.Name = "label4";
            label4.Size = new Size(88, 23);
            label4.TabIndex = 4;
            label4.Text = "Kode IATA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(17, 444);
            label5.Name = "label5";
            label5.Size = new Size(45, 23);
            label5.TabIndex = 5;
            label5.Text = "Kota";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(17, 494);
            label6.Name = "label6";
            label6.Size = new Size(65, 23);
            label6.TabIndex = 6;
            label6.Text = "Negara";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(575, 359);
            label7.Name = "label7";
            label7.Size = new Size(133, 23);
            label7.TabIndex = 7;
            label7.Text = "Jumlah Terminal";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(575, 397);
            label8.Name = "label8";
            label8.Size = new Size(64, 23);
            label8.TabIndex = 8;
            label8.Text = "Alamat";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(131, 359);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(203, 23);
            txtNama.TabIndex = 9;
            txtNama.TextChanged += txtNama_TextChanged;
            // 
            // txtKodeIATA
            // 
            txtKodeIATA.Location = new Point(131, 397);
            txtKodeIATA.Name = "txtKodeIATA";
            txtKodeIATA.Size = new Size(203, 23);
            txtKodeIATA.TabIndex = 10;
            // 
            // txtKota
            // 
            txtKota.Location = new Point(131, 444);
            txtKota.Name = "txtKota";
            txtKota.Size = new Size(203, 23);
            txtKota.TabIndex = 11;
            // 
            // txtNegara
            // 
            txtNegara.FormattingEnabled = true;
            txtNegara.Location = new Point(131, 488);
            txtNegara.Name = "txtNegara";
            txtNegara.Size = new Size(203, 23);
            txtNegara.TabIndex = 12;
            // 
            // txtJmlTerminal
            // 
            txtJmlTerminal.Location = new Point(732, 359);
            txtJmlTerminal.Name = "txtJmlTerminal";
            txtJmlTerminal.Size = new Size(263, 23);
            txtJmlTerminal.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(799, 560);
            button1.Name = "button1";
            button1.Size = new Size(85, 27);
            button1.TabIndex = 15;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(910, 560);
            button2.Name = "button2";
            button2.Size = new Size(85, 27);
            button2.TabIndex = 16;
            button2.Text = "Simpan";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(732, 405);
            txtAlamat.Multiline = true;
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(263, 106);
            txtAlamat.TabIndex = 17;
            // 
            // FrmMasterBandara
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 608);
            Controls.Add(txtAlamat);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtJmlTerminal);
            Controls.Add(txtNegara);
            Controls.Add(txtKota);
            Controls.Add(txtKodeIATA);
            Controls.Add(txtNama);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FrmMasterBandara";
            Text = "FrmMasterBandara";
            Load += FrmMasterBandara_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtNama;
        private TextBox txtKodeIATA;
        private TextBox txtKota;
        private ComboBox txtNegara;
        private DomainUpDown txtJmlTerminal;
        private Button button1;
        private Button button2;
        private TextBox txtAlamat;
        private DataGridViewButtonColumn btnDelete;
        private DataGridViewButtonColumn btnEdit;
    }
}