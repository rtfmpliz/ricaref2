namespace Aplikasi_Penjualan.GUI
{
    partial class FormTransaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransaksi));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_Kwitansi = new System.Windows.Forms.DateTimePicker();
            this.btn_CariPelanggan = new System.Windows.Forms.Button();
            this.text_NamaPelanggan = new System.Windows.Forms.TextBox();
            this.text_IDPelanggan = new System.Windows.Forms.TextBox();
            this.text_NoKwitansi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.text_jumlah = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.text_hargabarang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.text_namabarang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_caribarang = new System.Windows.Forms.Button();
            this.text_kodebarang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox_transaksi = new System.Windows.Forms.GroupBox();
            this.dataGridView_transaksi = new System.Windows.Forms.DataGridView();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.btn_baru = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label_totalseluruh = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox_transaksi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_transaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker_Kwitansi);
            this.groupBox1.Controls.Add(this.btn_CariPelanggan);
            this.groupBox1.Controls.Add(this.text_NamaPelanggan);
            this.groupBox1.Controls.Add(this.text_IDPelanggan);
            this.groupBox1.Controls.Add(this.text_NoKwitansi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = ":: Sistem Order ::";
            // 
            // dateTimePicker_Kwitansi
            // 
            this.dateTimePicker_Kwitansi.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker_Kwitansi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Kwitansi.Location = new System.Drawing.Point(338, 91);
            this.dateTimePicker_Kwitansi.Name = "dateTimePicker_Kwitansi";
            this.dateTimePicker_Kwitansi.Size = new System.Drawing.Size(182, 26);
            this.dateTimePicker_Kwitansi.TabIndex = 0;
            // 
            // btn_CariPelanggan
            // 
            this.btn_CariPelanggan.BackColor = System.Drawing.SystemColors.Control;
            this.btn_CariPelanggan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CariPelanggan.Image = ((System.Drawing.Image)(resources.GetObject("btn_CariPelanggan.Image")));
            this.btn_CariPelanggan.Location = new System.Drawing.Point(214, 186);
            this.btn_CariPelanggan.Name = "btn_CariPelanggan";
            this.btn_CariPelanggan.Size = new System.Drawing.Size(85, 28);
            this.btn_CariPelanggan.TabIndex = 0;
            this.btn_CariPelanggan.UseVisualStyleBackColor = false;
            this.btn_CariPelanggan.Click += new System.EventHandler(this.btn_CariPelanggan_Click);
            // 
            // text_NamaPelanggan
            // 
            this.text_NamaPelanggan.Location = new System.Drawing.Point(310, 186);
            this.text_NamaPelanggan.Multiline = true;
            this.text_NamaPelanggan.Name = "text_NamaPelanggan";
            this.text_NamaPelanggan.Size = new System.Drawing.Size(210, 28);
            this.text_NamaPelanggan.TabIndex = 5;
            // 
            // text_IDPelanggan
            // 
            this.text_IDPelanggan.Location = new System.Drawing.Point(16, 186);
            this.text_IDPelanggan.Multiline = true;
            this.text_IDPelanggan.Name = "text_IDPelanggan";
            this.text_IDPelanggan.Size = new System.Drawing.Size(192, 28);
            this.text_IDPelanggan.TabIndex = 4;
            // 
            // text_NoKwitansi
            // 
            this.text_NoKwitansi.Location = new System.Drawing.Point(338, 40);
            this.text_NoKwitansi.Name = "text_NoKwitansi";
            this.text_NoKwitansi.Size = new System.Drawing.Size(182, 26);
            this.text_NoKwitansi.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nama Pelanggan";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "ID Pelanggan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tgl Kwitansi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "No Kwitansi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_min);
            this.groupBox2.Controls.Add(this.btn_plus);
            this.groupBox2.Controls.Add(this.text_jumlah);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.text_hargabarang);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.text_namabarang);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btn_caribarang);
            this.groupBox2.Controls.Add(this.text_kodebarang);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox2.Location = new System.Drawing.Point(12, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(543, 258);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = ":: Ambil Barang ::";
            // 
            // btn_min
            // 
            this.btn_min.BackColor = System.Drawing.SystemColors.Control;
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_min.Location = new System.Drawing.Point(457, 202);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(50, 33);
            this.btn_min.TabIndex = 16;
            this.btn_min.Text = "-";
            this.btn_min.UseVisualStyleBackColor = false;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.BackColor = System.Drawing.SystemColors.Control;
            this.btn_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_plus.Location = new System.Drawing.Point(401, 202);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(50, 33);
            this.btn_plus.TabIndex = 15;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = false;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // text_jumlah
            // 
            this.text_jumlah.Location = new System.Drawing.Point(150, 197);
            this.text_jumlah.Multiline = true;
            this.text_jumlah.Name = "text_jumlah";
            this.text_jumlah.Size = new System.Drawing.Size(228, 38);
            this.text_jumlah.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Jumlah";
            // 
            // text_hargabarang
            // 
            this.text_hargabarang.Location = new System.Drawing.Point(150, 140);
            this.text_hargabarang.Multiline = true;
            this.text_hargabarang.Name = "text_hargabarang";
            this.text_hargabarang.Size = new System.Drawing.Size(228, 38);
            this.text_hargabarang.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Harga Barang ";
            // 
            // text_namabarang
            // 
            this.text_namabarang.Location = new System.Drawing.Point(150, 91);
            this.text_namabarang.Multiline = true;
            this.text_namabarang.Name = "text_namabarang";
            this.text_namabarang.Size = new System.Drawing.Size(228, 38);
            this.text_namabarang.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nama Barang ";
            // 
            // btn_caribarang
            // 
            this.btn_caribarang.BackColor = System.Drawing.SystemColors.Control;
            this.btn_caribarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_caribarang.Image = ((System.Drawing.Image)(resources.GetObject("btn_caribarang.Image")));
            this.btn_caribarang.Location = new System.Drawing.Point(391, 40);
            this.btn_caribarang.Name = "btn_caribarang";
            this.btn_caribarang.Size = new System.Drawing.Size(60, 33);
            this.btn_caribarang.TabIndex = 6;
            this.btn_caribarang.UseVisualStyleBackColor = false;
            this.btn_caribarang.Click += new System.EventHandler(this.btn_caribarang_Click);
            // 
            // text_kodebarang
            // 
            this.text_kodebarang.Location = new System.Drawing.Point(150, 40);
            this.text_kodebarang.Multiline = true;
            this.text_kodebarang.Name = "text_kodebarang";
            this.text_kodebarang.Size = new System.Drawing.Size(228, 38);
            this.text_kodebarang.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Kode Barang ";
            // 
            // groupBox_transaksi
            // 
            this.groupBox_transaksi.Controls.Add(this.dataGridView_transaksi);
            this.groupBox_transaksi.Location = new System.Drawing.Point(573, 23);
            this.groupBox_transaksi.Name = "groupBox_transaksi";
            this.groupBox_transaksi.Size = new System.Drawing.Size(903, 548);
            this.groupBox_transaksi.TabIndex = 2;
            this.groupBox_transaksi.TabStop = false;
            this.groupBox_transaksi.Text = ":: Data Transaksi ::";
            // 
            // dataGridView_transaksi
            // 
            this.dataGridView_transaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_transaksi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_transaksi.Location = new System.Drawing.Point(3, 72);
            this.dataGridView_transaksi.Name = "dataGridView_transaksi";
            this.dataGridView_transaksi.RowHeadersVisible = false;
            this.dataGridView_transaksi.RowHeadersWidth = 62;
            this.dataGridView_transaksi.RowTemplate.Height = 28;
            this.dataGridView_transaksi.Size = new System.Drawing.Size(897, 473);
            this.dataGridView_transaksi.TabIndex = 0;
            this.dataGridView_transaksi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_transaksi_CellDoubleClick);
            // 
            // btn_simpan
            // 
            this.btn_simpan.BackColor = System.Drawing.SystemColors.Control;
            this.btn_simpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simpan.Image = ((System.Drawing.Image)(resources.GetObject("btn_simpan.Image")));
            this.btn_simpan.Location = new System.Drawing.Point(426, 606);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(129, 57);
            this.btn_simpan.TabIndex = 18;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_simpan.UseVisualStyleBackColor = false;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // btn_baru
            // 
            this.btn_baru.BackColor = System.Drawing.SystemColors.Control;
            this.btn_baru.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_baru.Image = ((System.Drawing.Image)(resources.GetObject("btn_baru.Image")));
            this.btn_baru.Location = new System.Drawing.Point(12, 598);
            this.btn_baru.Name = "btn_baru";
            this.btn_baru.Size = new System.Drawing.Size(149, 57);
            this.btn_baru.TabIndex = 17;
            this.btn_baru.Text = "Baru";
            this.btn_baru.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_baru.UseVisualStyleBackColor = false;
            this.btn_baru.Click += new System.EventHandler(this.btn_baru_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1021, 609);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 28);
            this.label9.TabIndex = 17;
            this.label9.Text = "Total Seluruh Rp.";
            // 
            // label_totalseluruh
            // 
            this.label_totalseluruh.AutoSize = true;
            this.label_totalseluruh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalseluruh.Location = new System.Drawing.Point(1182, 609);
            this.label_totalseluruh.Name = "label_totalseluruh";
            this.label_totalseluruh.Size = new System.Drawing.Size(23, 28);
            this.label_totalseluruh.TabIndex = 19;
            this.label_totalseluruh.Text = "0";
            // 
            // FormTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1555, 667);
            this.Controls.Add(this.label_totalseluruh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.btn_baru);
            this.Controls.Add(this.groupBox_transaksi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTransaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: Form Transaksi ::";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox_transaksi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_transaksi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox_transaksi;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Kwitansi;
        private System.Windows.Forms.Button btn_CariPelanggan;
        private System.Windows.Forms.TextBox text_NoKwitansi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.TextBox text_jumlah;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox text_hargabarang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text_namabarang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_caribarang;
        private System.Windows.Forms.TextBox text_kodebarang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.Button btn_baru;
        private System.Windows.Forms.DataGridView dataGridView_transaksi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_totalseluruh;
        public System.Windows.Forms.TextBox text_NamaPelanggan;
        public System.Windows.Forms.TextBox text_IDPelanggan;
    }
}