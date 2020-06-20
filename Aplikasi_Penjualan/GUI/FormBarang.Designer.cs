namespace Aplikasi_Penjualan.GUI
{
    partial class FormBarang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox_form = new System.Windows.Forms.GroupBox();
            this.cbo_Satuan = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Stok = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_HargaBarang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NamaBarang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_KodeBarang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_proses = new System.Windows.Forms.GroupBox();
            this.button_hapus = new System.Windows.Forms.Button();
            this.button_simpan = new System.Windows.Forms.Button();
            this.button_ubah = new System.Windows.Forms.Button();
            this.button_baru = new System.Windows.Forms.Button();
            this.groupBox_data = new System.Windows.Forms.GroupBox();
            this.dataGridView_Barang = new System.Windows.Forms.DataGridView();
            this.txt_CariBarang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox_form.SuspendLayout();
            this.groupBox_proses.SuspendLayout();
            this.groupBox_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Barang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_form
            // 
            this.groupBox_form.Controls.Add(this.cbo_Satuan);
            this.groupBox_form.Controls.Add(this.label5);
            this.groupBox_form.Controls.Add(this.txt_Stok);
            this.groupBox_form.Controls.Add(this.label4);
            this.groupBox_form.Controls.Add(this.txt_HargaBarang);
            this.groupBox_form.Controls.Add(this.label3);
            this.groupBox_form.Controls.Add(this.txt_NamaBarang);
            this.groupBox_form.Controls.Add(this.label2);
            this.groupBox_form.Controls.Add(this.txt_KodeBarang);
            this.groupBox_form.Controls.Add(this.label1);
            this.groupBox_form.Location = new System.Drawing.Point(12, 12);
            this.groupBox_form.Name = "groupBox_form";
            this.groupBox_form.Size = new System.Drawing.Size(479, 379);
            this.groupBox_form.TabIndex = 0;
            this.groupBox_form.TabStop = false;
            this.groupBox_form.Text = ":: Form Barang ::";
            // 
            // cbo_Satuan
            // 
            this.cbo_Satuan.FormattingEnabled = true;
            this.cbo_Satuan.Items.AddRange(new object[] {
            "Unit",
            "Pcs"});
            this.cbo_Satuan.Location = new System.Drawing.Point(179, 321);
            this.cbo_Satuan.Name = "cbo_Satuan";
            this.cbo_Satuan.Size = new System.Drawing.Size(281, 40);
            this.cbo_Satuan.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Satuan ";
            // 
            // txt_Stok
            // 
            this.txt_Stok.Location = new System.Drawing.Point(179, 259);
            this.txt_Stok.Name = "txt_Stok";
            this.txt_Stok.Size = new System.Drawing.Size(281, 39);
            this.txt_Stok.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Stok";
            // 
            // txt_HargaBarang
            // 
            this.txt_HargaBarang.Location = new System.Drawing.Point(179, 193);
            this.txt_HargaBarang.Name = "txt_HargaBarang";
            this.txt_HargaBarang.Size = new System.Drawing.Size(281, 39);
            this.txt_HargaBarang.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Harga Barang";
            // 
            // txt_NamaBarang
            // 
            this.txt_NamaBarang.Location = new System.Drawing.Point(179, 129);
            this.txt_NamaBarang.Name = "txt_NamaBarang";
            this.txt_NamaBarang.Size = new System.Drawing.Size(281, 39);
            this.txt_NamaBarang.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama Barang";
            // 
            // txt_KodeBarang
            // 
            this.txt_KodeBarang.Location = new System.Drawing.Point(179, 57);
            this.txt_KodeBarang.Name = "txt_KodeBarang";
            this.txt_KodeBarang.Size = new System.Drawing.Size(281, 39);
            this.txt_KodeBarang.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Barang ";
            // 
            // groupBox_proses
            // 
            this.groupBox_proses.Controls.Add(this.button_hapus);
            this.groupBox_proses.Controls.Add(this.button_simpan);
            this.groupBox_proses.Controls.Add(this.button_ubah);
            this.groupBox_proses.Controls.Add(this.button_baru);
            this.groupBox_proses.Location = new System.Drawing.Point(12, 397);
            this.groupBox_proses.Name = "groupBox_proses";
            this.groupBox_proses.Size = new System.Drawing.Size(479, 127);
            this.groupBox_proses.TabIndex = 1;
            this.groupBox_proses.TabStop = false;
            this.groupBox_proses.Text = ":: Proses ::";
            // 
            // button_hapus
            // 
            this.button_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_hapus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_hapus.Image = global::Aplikasi_Penjualan.Properties.Resources.b_drop;
            this.button_hapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_hapus.Location = new System.Drawing.Point(357, 38);
            this.button_hapus.Name = "button_hapus";
            this.button_hapus.Size = new System.Drawing.Size(111, 56);
            this.button_hapus.TabIndex = 12;
            this.button_hapus.Text = "&Hapus";
            this.button_hapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_hapus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_hapus.UseVisualStyleBackColor = true;
            this.button_hapus.Click += new System.EventHandler(this.button_hapus_Click);
            // 
            // button_simpan
            // 
            this.button_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_simpan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_simpan.Image = global::Aplikasi_Penjualan.Properties.Resources.b_save;
            this.button_simpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_simpan.Location = new System.Drawing.Point(123, 38);
            this.button_simpan.Name = "button_simpan";
            this.button_simpan.Size = new System.Drawing.Size(111, 56);
            this.button_simpan.TabIndex = 11;
            this.button_simpan.Text = "&Simpan";
            this.button_simpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_simpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_simpan.UseVisualStyleBackColor = true;
            this.button_simpan.Click += new System.EventHandler(this.button_simpan_Click);
            // 
            // button_ubah
            // 
            this.button_ubah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ubah.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ubah.Image = global::Aplikasi_Penjualan.Properties.Resources.edit_topic_pencil_1_;
            this.button_ubah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ubah.Location = new System.Drawing.Point(240, 38);
            this.button_ubah.Name = "button_ubah";
            this.button_ubah.Size = new System.Drawing.Size(111, 56);
            this.button_ubah.TabIndex = 10;
            this.button_ubah.Text = "Ubah";
            this.button_ubah.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_ubah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_ubah.UseVisualStyleBackColor = true;
            this.button_ubah.Click += new System.EventHandler(this.button_ubah_Click);
            // 
            // button_baru
            // 
            this.button_baru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_baru.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_baru.Image = global::Aplikasi_Penjualan.Properties.Resources.task_add_filled_20_black_2x_1_;
            this.button_baru.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_baru.Location = new System.Drawing.Point(6, 38);
            this.button_baru.Name = "button_baru";
            this.button_baru.Size = new System.Drawing.Size(111, 56);
            this.button_baru.TabIndex = 9;
            this.button_baru.Text = "&Baru";
            this.button_baru.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_baru.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_baru.UseVisualStyleBackColor = true;
            this.button_baru.Click += new System.EventHandler(this.button_baru_Click);
            // 
            // groupBox_data
            // 
            this.groupBox_data.Controls.Add(this.dataGridView_Barang);
            this.groupBox_data.Controls.Add(this.txt_CariBarang);
            this.groupBox_data.Controls.Add(this.label6);
            this.groupBox_data.Location = new System.Drawing.Point(509, 29);
            this.groupBox_data.Name = "groupBox_data";
            this.groupBox_data.Size = new System.Drawing.Size(610, 495);
            this.groupBox_data.TabIndex = 2;
            this.groupBox_data.TabStop = false;
            this.groupBox_data.Text = ":: Data Barang ::";
            // 
            // dataGridView_Barang
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dataGridView_Barang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Barang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Barang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_Barang.Location = new System.Drawing.Point(3, 88);
            this.dataGridView_Barang.Name = "dataGridView_Barang";
            this.dataGridView_Barang.RowHeadersWidth = 62;
            this.dataGridView_Barang.RowTemplate.Height = 28;
            this.dataGridView_Barang.Size = new System.Drawing.Size(604, 404);
            this.dataGridView_Barang.TabIndex = 11;
            this.dataGridView_Barang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Barang_CellClick);
            // 
            // txt_CariBarang
            // 
            this.txt_CariBarang.Location = new System.Drawing.Point(314, 43);
            this.txt_CariBarang.Name = "txt_CariBarang";
            this.txt_CariBarang.Size = new System.Drawing.Size(290, 39);
            this.txt_CariBarang.TabIndex = 10;
            this.txt_CariBarang.TextChanged += new System.EventHandler(this.txt_CariBarang_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(298, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cari Barang (Kode / Nama)";
            // 
            // FormBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1131, 536);
            this.Controls.Add(this.groupBox_data);
            this.Controls.Add(this.groupBox_proses);
            this.Controls.Add(this.groupBox_form);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: Form Barang  ::";
            this.groupBox_form.ResumeLayout(false);
            this.groupBox_form.PerformLayout();
            this.groupBox_proses.ResumeLayout(false);
            this.groupBox_data.ResumeLayout(false);
            this.groupBox_data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Barang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_form;
        private System.Windows.Forms.GroupBox groupBox_proses;
        private System.Windows.Forms.GroupBox groupBox_data;
        private System.Windows.Forms.TextBox txt_Stok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_HargaBarang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NamaBarang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_KodeBarang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_Satuan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView_Barang;
        private System.Windows.Forms.TextBox txt_CariBarang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_hapus;
        private System.Windows.Forms.Button button_simpan;
        private System.Windows.Forms.Button button_ubah;
        private System.Windows.Forms.Button button_baru;
    }
}