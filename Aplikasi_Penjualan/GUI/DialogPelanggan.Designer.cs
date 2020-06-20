namespace Aplikasi_Penjualan.GUI
{
    partial class DialogPelanggan
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
            this.text_CariPelanggan = new System.Windows.Forms.TextBox();
            this.dataGridView_Pelanggan2 = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Pelanggan2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.text_CariPelanggan);
            this.groupBox3.Controls.Add(this.dataGridView_Pelanggan2);
            this.groupBox3.Location = new System.Drawing.Point(10, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(781, 444);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = ":: Data Pelanggan ::";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(248, 28);
            this.label9.TabIndex = 18;
            this.label9.Text = "Cari Pelanggan (ID / Nama)";
            // 
            // text_CariPelanggan
            // 
            this.text_CariPelanggan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_CariPelanggan.Location = new System.Drawing.Point(287, 40);
            this.text_CariPelanggan.Multiline = true;
            this.text_CariPelanggan.Name = "text_CariPelanggan";
            this.text_CariPelanggan.Size = new System.Drawing.Size(466, 28);
            this.text_CariPelanggan.TabIndex = 1;
            this.text_CariPelanggan.TextChanged += new System.EventHandler(this.text_CariPelanggan_TextChanged);
            // 
            // dataGridView_Pelanggan2
            // 
            this.dataGridView_Pelanggan2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Pelanggan2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_Pelanggan2.Location = new System.Drawing.Point(3, 90);
            this.dataGridView_Pelanggan2.Name = "dataGridView_Pelanggan2";
            this.dataGridView_Pelanggan2.RowHeadersVisible = false;
            this.dataGridView_Pelanggan2.RowHeadersWidth = 62;
            this.dataGridView_Pelanggan2.RowTemplate.Height = 28;
            this.dataGridView_Pelanggan2.Size = new System.Drawing.Size(775, 351);
            this.dataGridView_Pelanggan2.TabIndex = 0;
            this.dataGridView_Pelanggan2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Pelanggan2_CellDoubleClick);
            // 
            // DialogPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogPelanggan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: Cari Pelanggan ::";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Pelanggan2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox text_CariPelanggan;
        private System.Windows.Forms.DataGridView dataGridView_Pelanggan2;
    }
}