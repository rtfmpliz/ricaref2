namespace Aplikasi_Penjualan.GUI
{
    partial class FormPelanggan
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
            this.groupBox_data = new System.Windows.Forms.GroupBox();
            this.dataGridView_Pelanggan = new System.Windows.Forms.DataGridView();
            this.txt_CariPelanggan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox_proses = new System.Windows.Forms.GroupBox();
            this.button_hapus = new System.Windows.Forms.Button();
            this.button_simpan = new System.Windows.Forms.Button();
            this.button_ubah = new System.Windows.Forms.Button();
            this.button_baru = new System.Windows.Forms.Button();
            this.groupBox_form = new System.Windows.Forms.GroupBox();
            this.txt_NoTelepon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Alamat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NamaPelanggan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_IdPelanggan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Pelanggan)).BeginInit();
            this.groupBox_proses.SuspendLayout();
            this.groupBox_form.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_data
            // 
            this.groupBox_data.Controls.Add(this.dataGridView_Pelanggan);
            this.groupBox_data.Controls.Add(this.txt_CariPelanggan);
            this.groupBox_data.Controls.Add(this.label6);
            this.groupBox_data.Location = new System.Drawing.Point(534, 40);
            this.groupBox_data.Name = "groupBox_data";
            this.groupBox_data.Size = new System.Drawing.Size(610, 508);
            this.groupBox_data.TabIndex = 5;
            this.groupBox_data.TabStop = false;
            this.groupBox_data.Text = ":: Data Pelanggan ::";
            // 
            // dataGridView_Pelanggan
            // 
            this.dataGridView_Pelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Pelanggan.Location = new System.Drawing.Point(3, 88);
            this.dataGridView_Pelanggan.Name = "dataGridView_Pelanggan";
            this.dataGridView_Pelanggan.RowHeadersVisible = false;
            this.dataGridView_Pelanggan.RowHeadersWidth = 62;
            this.dataGridView_Pelanggan.RowTemplate.Height = 28;
            this.dataGridView_Pelanggan.Size = new System.Drawing.Size(604, 389);
            this.dataGridView_Pelanggan.TabIndex = 11;
            this.dataGridView_Pelanggan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Pelanggan_CellClick);
            // 
            // txt_CariPelanggan
            // 
            this.txt_CariPelanggan.Location = new System.Drawing.Point(314, 43);
            this.txt_CariPelanggan.Name = "txt_CariPelanggan";
            this.txt_CariPelanggan.Size = new System.Drawing.Size(290, 39);
            this.txt_CariPelanggan.TabIndex = 10;
            this.txt_CariPelanggan.TextChanged += new System.EventHandler(this.txt_CariPelanggan_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(304, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cari Pelanggan (ID / Nama)";
            // 
            // groupBox_proses
            // 
            this.groupBox_proses.Controls.Add(this.button_hapus);
            this.groupBox_proses.Controls.Add(this.button_simpan);
            this.groupBox_proses.Controls.Add(this.button_ubah);
            this.groupBox_proses.Controls.Add(this.button_baru);
            this.groupBox_proses.Location = new System.Drawing.Point(12, 418);
            this.groupBox_proses.Name = "groupBox_proses";
            this.groupBox_proses.Size = new System.Drawing.Size(504, 99);
            this.groupBox_proses.TabIndex = 4;
            this.groupBox_proses.TabStop = false;
            this.groupBox_proses.Text = ":: Proses ::";
            // 
            // button_hapus
            // 
            this.button_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_hapus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_hapus.Image = global::Aplikasi_Penjualan.Properties.Resources.b_drop;
            this.button_hapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_hapus.Location = new System.Drawing.Point(362, 38);
            this.button_hapus.Name = "button_hapus";
            this.button_hapus.Size = new System.Drawing.Size(111, 44);
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
            this.button_simpan.Location = new System.Drawing.Point(128, 38);
            this.button_simpan.Name = "button_simpan";
            this.button_simpan.Size = new System.Drawing.Size(111, 44);
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
            this.button_ubah.Location = new System.Drawing.Point(245, 38);
            this.button_ubah.Name = "button_ubah";
            this.button_ubah.Size = new System.Drawing.Size(111, 44);
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
            this.button_baru.Location = new System.Drawing.Point(11, 38);
            this.button_baru.Name = "button_baru";
            this.button_baru.Size = new System.Drawing.Size(111, 44);
            this.button_baru.TabIndex = 9;
            this.button_baru.Text = "&Baru";
            this.button_baru.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_baru.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_baru.UseVisualStyleBackColor = true;
            this.button_baru.Click += new System.EventHandler(this.button_baru_Click);
            // 
            // groupBox_form
            // 
            this.groupBox_form.Controls.Add(this.txt_NoTelepon);
            this.groupBox_form.Controls.Add(this.label4);
            this.groupBox_form.Controls.Add(this.txt_Alamat);
            this.groupBox_form.Controls.Add(this.label3);
            this.groupBox_form.Controls.Add(this.txt_NamaPelanggan);
            this.groupBox_form.Controls.Add(this.label2);
            this.groupBox_form.Controls.Add(this.txt_IdPelanggan);
            this.groupBox_form.Controls.Add(this.label1);
            this.groupBox_form.Location = new System.Drawing.Point(12, 30);
            this.groupBox_form.Name = "groupBox_form";
            this.groupBox_form.Size = new System.Drawing.Size(504, 370);
            this.groupBox_form.TabIndex = 3;
            this.groupBox_form.TabStop = false;
            this.groupBox_form.Text = ":: Form Pelanggan ::";
            // 
            // txt_NoTelepon
            // 
            this.txt_NoTelepon.Location = new System.Drawing.Point(211, 315);
            this.txt_NoTelepon.Name = "txt_NoTelepon";
            this.txt_NoTelepon.Size = new System.Drawing.Size(281, 39);
            this.txt_NoTelepon.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "No Telepon ";
            // 
            // txt_Alamat
            // 
            this.txt_Alamat.Location = new System.Drawing.Point(211, 158);
            this.txt_Alamat.Multiline = true;
            this.txt_Alamat.Name = "txt_Alamat";
            this.txt_Alamat.Size = new System.Drawing.Size(281, 143);
            this.txt_Alamat.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Alamat";
            // 
            // txt_NamaPelanggan
            // 
            this.txt_NamaPelanggan.Location = new System.Drawing.Point(211, 107);
            this.txt_NamaPelanggan.Name = "txt_NamaPelanggan";
            this.txt_NamaPelanggan.Size = new System.Drawing.Size(281, 39);
            this.txt_NamaPelanggan.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama Pelanggan";
            // 
            // txt_IdPelanggan
            // 
            this.txt_IdPelanggan.Location = new System.Drawing.Point(211, 60);
            this.txt_IdPelanggan.Name = "txt_IdPelanggan";
            this.txt_IdPelanggan.Size = new System.Drawing.Size(175, 39);
            this.txt_IdPelanggan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Pelanggan";
            // 
            // FormPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 522);
            this.Controls.Add(this.groupBox_data);
            this.Controls.Add(this.groupBox_proses);
            this.Controls.Add(this.groupBox_form);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPelanggan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: Form Pelanggan ::";
            this.groupBox_data.ResumeLayout(false);
            this.groupBox_data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Pelanggan)).EndInit();
            this.groupBox_proses.ResumeLayout(false);
            this.groupBox_form.ResumeLayout(false);
            this.groupBox_form.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_data;
        private System.Windows.Forms.DataGridView dataGridView_Pelanggan;
        private System.Windows.Forms.TextBox txt_CariPelanggan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox_proses;
        private System.Windows.Forms.Button button_hapus;
        private System.Windows.Forms.Button button_simpan;
        private System.Windows.Forms.Button button_ubah;
        private System.Windows.Forms.Button button_baru;
        private System.Windows.Forms.GroupBox groupBox_form;
        private System.Windows.Forms.TextBox txt_NoTelepon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Alamat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NamaPelanggan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_IdPelanggan;
        private System.Windows.Forms.Label label1;
    }
}