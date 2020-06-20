using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//1. tambahkan Libary Sql
using System.Data.SqlClient;

namespace Aplikasi_Penjualan.GUI
{
    public partial class DialogBarang : Form
    {
        #region 2.Tambahkan var sql

        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        // buat variable globa untuk pemanggilan 
        public string kodebarang, namabarang, harga = "";


        #endregion


        #region 3. import kelas koneksi 
        Kelas.Koneksi konn = new Kelas.Koneksi();

        #endregion


        #region 4. membuat procedure refresh_barang() 

        void refresh_barang()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {

                    conn.Open();
                    cmd = new SqlCommand("Select * From tbl_barang", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "tbl_barang");
                    dataGridView_Barang.DataSource = ds;
                    dataGridView_Barang.DataMember = "tbl_barang";
                    dataGridView_Barang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_Barang.AllowUserToAddRows = false;
                    dataGridView_Barang.Refresh();


                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                finally
                {
                    conn.Close();
                }

            }
        }

        #endregion


        #region 6. membuat procedure cari_barang()
        void cari_barang()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {

                    conn.Open();
                    cmd = new SqlCommand("Select * From tbl_barang where KodeBarang like '%" + text_CariBarang.Text + "%' or NamaBarang like '%" + text_CariBarang.Text + "%'", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "tbl_barang");
                    dataGridView_Barang.DataSource = ds;
                    dataGridView_Barang.DataMember = "tbl_barang";
                    dataGridView_Barang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_Barang.AllowUserToAddRows = false;
                    dataGridView_Barang.Refresh();


                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                finally
                {
                    conn.Close();
                }

            }
        }



        #endregion


        private void text_CariBarang_TextChanged(object sender, EventArgs e)
        {
            #region 7. panggil procedure cari_barang()
           
            cari_barang();
            #endregion
        }

        


        #region 9. buat fucntion ambil_kodebarang

        public string ambil_kodebarang
        {
            get
            {
                return kodebarang;
            }
        }

        #endregion

        #region 10. buat fucntion ambil_namabarang

        public string ambil_namabarang
        {
            get
            {
                return namabarang;
            }
        }
        #endregion

        #region 11. buat fucntion ambil_harga

        public string ambil_harga
        {
            get
            {
                return harga;
            }
        }

        #endregion


        private void dataGridView_Barang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            #region 8. buat fungsi ketika DataGrid doubleclick

            try
            {
                //mengisi var yang akan diparsing dari datagridview
                DataGridViewRow row = this.dataGridView_Barang.Rows[e.RowIndex];

                //var yang tadinya kosong akan terisi
                kodebarang = row.Cells["KodeBarang"].Value.ToString();
                namabarang = row.Cells["NamaBarang"].Value.ToString();
                harga = row.Cells["Harga"].Value.ToString();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            #endregion

        }

        public DialogBarang()
        {
            InitializeComponent();

            #region 5. panggil procedure refresh_barang()
            refresh_barang();
            #endregion

        }
    }
}
