namespace XIIRPL2_29_Ticketing.MasterForm
{
    partial class FrmKodePromo
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
            txtKode_promo = new TextBox();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            BtnDelete = new DataGridViewButtonColumn();
            BtnEdit = new DataGridViewButtonColumn();
            txtBerlaku_sampai = new DateTimePicker();
            txtPersentase_diskon = new DomainUpDown();
            txtDeskripsi = new TextBox();
            label6 = new Label();
            txtMaksimum_diskon = new DomainUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(1090, 549);
            button2.Name = "button2";
            button2.Size = new Size(85, 27);
            button2.TabIndex = 46;
            button2.Text = "Simpan";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(983, 549);
            button1.Name = "button1";
            button1.Size = new Size(85, 27);
            button1.TabIndex = 45;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtKode_promo
            // 
            txtKode_promo.Location = new Point(374, 384);
            txtKode_promo.Name = "txtKode_promo";
            txtKode_promo.Size = new Size(203, 23);
            txtKode_promo.TabIndex = 41;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(736, 381);
            label8.Name = "label8";
            label8.Size = new Size(81, 23);
            label8.TabIndex = 40;
            label8.Text = "Deskripsi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(193, 466);
            label5.Name = "label5";
            label5.Size = new Size(151, 23);
            label5.TabIndex = 39;
            label5.Text = "Persentase Diskon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(193, 419);
            label4.Name = "label4";
            label4.Size = new Size(128, 23);
            label4.TabIndex = 38;
            label4.Text = "Berlaku Sampai";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(193, 381);
            label3.Name = "label3";
            label3.Size = new Size(105, 23);
            label3.TabIndex = 37;
            label3.Text = "Kode Promo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(188, 74);
            label2.Name = "label2";
            label2.Size = new Size(423, 23);
            label2.TabIndex = 36;
            label2.Text = "Semua kode promo yang terdaftar akan muncul di sini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(188, 31);
            label1.Name = "label1";
            label1.Size = new Size(243, 32);
            label1.TabIndex = 35;
            label1.Text = "Master Kode Promo";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnDelete, BtnEdit });
            dataGridView1.Location = new Point(188, 118);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1117, 244);
            dataGridView1.TabIndex = 34;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BtnDelete
            // 
            BtnDelete.HeaderText = "Delete";
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Resizable = DataGridViewTriState.True;
            BtnDelete.SortMode = DataGridViewColumnSortMode.Automatic;
            BtnDelete.Text = "Delete";
            BtnDelete.UseColumnTextForButtonValue = true;
            // 
            // BtnEdit
            // 
            BtnEdit.HeaderText = "Edit";
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Text = "Edit";
            BtnEdit.UseColumnTextForButtonValue = true;
            // 
            // txtBerlaku_sampai
            // 
            txtBerlaku_sampai.Location = new Point(374, 419);
            txtBerlaku_sampai.Name = "txtBerlaku_sampai";
            txtBerlaku_sampai.Size = new Size(203, 23);
            txtBerlaku_sampai.TabIndex = 47;
            txtBerlaku_sampai.ValueChanged += txtBerlaku_sampai_ValueChanged;
            // 
            // txtPersentase_diskon
            // 
            txtPersentase_diskon.Location = new Point(374, 466);
            txtPersentase_diskon.Name = "txtPersentase_diskon";
            txtPersentase_diskon.Size = new Size(203, 23);
            txtPersentase_diskon.TabIndex = 48;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(833, 384);
            txtDeskripsi.Multiline = true;
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(213, 105);
            txtDeskripsi.TabIndex = 49;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(193, 513);
            label6.Name = "label6";
            label6.Size = new Size(152, 23);
            label6.TabIndex = 50;
            label6.Text = "Maksimum Diskon";
            // 
            // txtMaksimum_diskon
            // 
            txtMaksimum_diskon.Location = new Point(374, 513);
            txtMaksimum_diskon.Name = "txtMaksimum_diskon";
            txtMaksimum_diskon.Size = new Size(203, 23);
            txtMaksimum_diskon.TabIndex = 51;
            // 
            // FrmKodePromo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1492, 607);
            Controls.Add(txtMaksimum_diskon);
            Controls.Add(label6);
            Controls.Add(txtDeskripsi);
            Controls.Add(txtPersentase_diskon);
            Controls.Add(txtBerlaku_sampai);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtKode_promo);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FrmKodePromo";
            Text = "FrmKodePromo";
            Load += FrmKodePromo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox txtKode_promo;
        private Label label8;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private DateTimePicker txtBerlaku_sampai;
        private DomainUpDown txtPersentase_diskon;
        private DataGridViewButtonColumn BtnDelete;
        private DataGridViewButtonColumn BtnEdit;
        private TextBox txtDeskripsi;
        private Label label6;
        private DomainUpDown txtMaksimum_diskon;
    }
}