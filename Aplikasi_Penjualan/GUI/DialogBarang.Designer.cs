namespace Aplikasi_Penjualan.GUI
{
    partial class DialogBarang
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.text_CariBarang = new System.Windows.Forms.TextBox();
            this.dataGridView_Barang = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Barang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.text_CariBarang);
            this.groupBox3.Controls.Add(this.dataGridView_Barang);
            this.groupBox3.Location = new System.Drawing.Point(12, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(781, 444);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = ":: Data Barang ::";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(245, 28);
            this.label9.TabIndex = 18;
            this.label9.Text = "Cari Barang (Kode / Nama)";
            // 
            // text_CariBarang
            // 
            this.text_CariBarang.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_CariBarang.Location = new System.Drawing.Point(266, 44);
            this.text_CariBarang.Name = "text_CariBarang";
            this.text_CariBarang.Size = new System.Drawing.Size(496, 26);
            this.text_CariBarang.TabIndex = 1;
            this.text_CariBarang.TextChanged += new System.EventHandler(this.text_CariBarang_TextChanged);
            // 
            // dataGridView_Barang
            // 
            this.dataGridView_Barang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Barang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_Barang.Location = new System.Drawing.Point(3, 90);
            this.dataGridView_Barang.Name = "dataGridView_Barang";
            this.dataGridView_Barang.RowHeadersVisible = false;
            this.dataGridView_Barang.RowHeadersWidth = 62;
            this.dataGridView_Barang.RowTemplate.Height = 28;
            this.dataGridView_Barang.Size = new System.Drawing.Size(775, 351);
            this.dataGridView_Barang.TabIndex = 0;
            this.dataGridView_Barang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Barang_CellDoubleClick);
            // 
            // DialogBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 481);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogBarang";
            this.Text = ":: Cari Barang ::";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Barang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView_Barang;
        private System.Windows.Forms.TextBox text_CariBarang;
        private System.Windows.Forms.Label label9;
    }
}