﻿namespace XIIRPL2_29_Ticketing.MasterForm
{
    partial class FrmDetailPenumpang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetailPenumpang));
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label8 = new Label();
            label12 = new Label();
            label13 = new Label();
            pictureBox4 = new PictureBox();
            label14 = new Label();
            label15 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            label16 = new Label();
            button3 = new Button();
            label1 = new Label();
            label17 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(17, 28);
            button1.Name = "button1";
            button1.Size = new Size(25, 30);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(62, 72);
            label2.Name = "label2";
            label2.Size = new Size(227, 17);
            label2.TabIndex = 4;
            label2.Text = "Mohon di isi data semua penumpang";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(17, 125);
            label3.Name = "label3";
            label3.Size = new Size(126, 23);
            label3.TabIndex = 5;
            label3.Text = "Penumpang #1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(17, 165);
            label4.Name = "label4";
            label4.Size = new Size(39, 21);
            label4.TabIndex = 6;
            label4.Text = "Title";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(159, 167);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(120, 23);
            comboBox1.TabIndex = 7;
            comboBox1.Text = "- Pilih Title -";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(17, 212);
            label5.Name = "label5";
            label5.Size = new Size(115, 21);
            label5.TabIndex = 8;
            label5.Text = "Nama Lengkap";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(159, 221);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(520, 23);
            textBox1.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonShadow;
            label6.Location = new Point(159, 247);
            label6.Name = "label6";
            label6.Size = new Size(334, 17);
            label6.TabIndex = 10;
            label6.Text = "Isi sesuai KTP/PASPOR/SIM(tanpa tanda baca dan gelar)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(28, 27);
            label7.Name = "label7";
            label7.Size = new Size(114, 23);
            label7.TabIndex = 6;
            label7.Text = "Penerbangan";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(130, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 17);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HighlightText;
            panel1.Controls.Add(label17);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(735, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(412, 604);
            panel1.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(156, 70);
            label9.Name = "label9";
            label9.Size = new Size(164, 20);
            label9.TabIndex = 9;
            label9.Text = "Soekarno - Hatta (CGK)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(28, 107);
            label10.Name = "label10";
            label10.Size = new Size(119, 20);
            label10.TabIndex = 10;
            label10.Text = "Pelita Air Service";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(28, 166);
            label11.Name = "label11";
            label11.Size = new Size(166, 23);
            label11.TabIndex = 11;
            label11.Text = "Detail Penerbangan";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(32, 214);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 21);
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(32, 259);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(21, 21);
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(28, 70);
            label8.Name = "label8";
            label8.Size = new Size(96, 20);
            label8.TabIndex = 7;
            label8.Text = "Juanda (SUB)";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(59, 215);
            label12.Name = "label12";
            label12.Size = new Size(154, 20);
            label12.TabIndex = 15;
            label12.Text = "Monday, 22 May 2023";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(59, 260);
            label13.Name = "label13";
            label13.Size = new Size(90, 20);
            label13.TabIndex = 16;
            label13.Text = "19:50 : 21:25";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(33, 305);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(21, 21);
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(60, 305);
            label14.Name = "label14";
            label14.Size = new Size(99, 20);
            label14.TabIndex = 18;
            label14.Text = "1 Penumpang";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(28, 354);
            label15.Name = "label15";
            label15.Size = new Size(106, 23);
            label15.TabIndex = 19;
            label15.Text = "Kode Promo";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(28, 396);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(271, 23);
            textBox2.TabIndex = 20;
            // 
            // button2
            // 
            button2.Location = new Point(317, 390);
            button2.Name = "button2";
            button2.Size = new Size(69, 33);
            button2.TabIndex = 21;
            button2.Text = "Pakai";
            button2.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(28, 512);
            label16.Name = "label16";
            label16.Size = new Size(150, 23);
            label16.TabIndex = 22;
            label16.Text = "Total Pembayaran";
            // 
            // button3
            // 
            button3.Location = new Point(28, 558);
            button3.Name = "button3";
            button3.Size = new Size(358, 33);
            button3.TabIndex = 23;
            button3.Text = "Konfirmasi Pembayaran";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(59, 25);
            label1.Name = "label1";
            label1.Size = new Size(220, 33);
            label1.TabIndex = 3;
            label1.Text = "Detail Penumpang";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = SystemColors.Highlight;
            label17.Location = new Point(255, 512);
            label17.Name = "label17";
            label17.Size = new Size(131, 29);
            label17.TabIndex = 24;
            label17.Text = "IDR 685.000";
            label17.Click += label17_Click;
            // 
            // FrmDetailPenumpang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 601);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "FrmDetailPenumpang";
            Text = "FrmDetailPenumpang";
            Load += FrmDetailPenumpang_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private Label label5;
        private TextBox textBox1;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label11;
        private Label label10;
        private Label label9;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox textBox2;
        private Label label15;
        private Label label14;
        private PictureBox pictureBox4;
        private Label label13;
        private Label label12;
        private Label label8;
        private Label label16;
        private Button button2;
        private Label label17;
        private Button button3;
        private Label label1;
    }
}