    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//1. tambahkan libary SQL
using System.Data.SqlClient;



namespace Aplikasi_Penjualan.GUI
{
    public partial class DialogPelanggan : Form
    {

        #region 2. tembahkan variabel Sql
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        // buat variable global untuk pemanggilan value idpelanggan dan namapelanggan
        public string idpelanggan, namapelanggan = "";


        #endregion


        #region 3.Import kelas koneksi dari Folder(kelas\koneksi.cs) menjadi objek --> konn
        Kelas.Koneksi konn = new Kelas.Koneksi();

        #endregion

        #region 4. membuat refresh Pelanggan

        void refresh_pelanggan()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {

                    conn.Open();
                    cmd = new SqlCommand("Select * From tbl_pelanggan", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "tbl_pelanggan");
                    dataGridView_Pelanggan2.DataSource = ds;
                    dataGridView_Pelanggan2.DataMember = "tbl_pelanggan";
                    dataGridView_Pelanggan2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_Pelanggan2.AllowUserToAddRows = false;
                    dataGridView_Pelanggan2.Refresh();


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


        #region 6. membuat procedure CariPelanggan
        void cari_Pelanggan()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {

                    conn.Open();
                    cmd = new SqlCommand("Select * From tbl_pelanggan where IDPelanggan like '%" + text_CariPelanggan.Text + "%' or NamaPelanggan like '%" + text_CariPelanggan.Text + "%'", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "tbl_pelanggan");
                    dataGridView_Pelanggan2.DataSource = ds;
                    dataGridView_Pelanggan2.DataMember = "tbl_pelanggan";
                    dataGridView_Pelanggan2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_Pelanggan2.AllowUserToAddRows = false;
                    dataGridView_Pelanggan2.Refresh();


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


        private void text_CariPelanggan_TextChanged(object sender, EventArgs e)
        {
            #region 7. panggil procedure cari pelanggan
            cari_Pelanggan();
            #endregion
        }

        private void dataGridView_Pelanggan2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            #region 8. buat fungsi ketika DataGrid doubleclick

            try
            {
                //mengisi var yang akan diparsing dari datagridview
                DataGridViewRow row = this.dataGridView_Pelanggan2.Rows[e.RowIndex];
                    
                //var yang tadinya kosong akan terisi
                idpelanggan = row.Cells["IDPelanggan"].Value.ToString();
                namapelanggan = row.Cells["NamaPelanggan"].Value.ToString();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            #endregion
        }

        #region 9. buat fungtion ambil_id_pelanggan

        public string Ambil_ID_Pelanggan
        {
            get
            {
                return idpelanggan;
            }

        }

        #endregion

        #region 10. buat fungtion Ambil_Nama_Pelanggan
        
        public string Ambil_Nama_Pelanggan
        {
            get
            {
                return namapelanggan;
            }

        }

        #endregion



        private void dataGridView_Pelanggan2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public DialogPelanggan()
        {
            InitializeComponent();

            #region 5. panggil procedure refresh_pelanggan()
            
            refresh_pelanggan();
            #endregion
        }
    }
}
