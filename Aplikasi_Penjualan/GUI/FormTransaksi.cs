using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//3. membuat libary sql
using System.Data.SqlClient;


namespace Aplikasi_Penjualan.GUI
{
    public partial class FormTransaksi : Form
    {
        #region 4. tambahkan variable untuk perintah sql 
        private SqlCommand cmd;
        private SqlDataReader rd;
        private DataSet ds;
        private SqlDataAdapter da;

        #endregion

        #region 5. import kelas koneksi dari folder (kelas/koneksi.cs) menjadi objek konn
        
        Kelas.Koneksi konn = new Kelas.Koneksi();


        #endregion


        #region 6. membuat procedure bersih
        public void bersih()
        {
            text_NoKwitansi.Text = "";
            dateTimePicker_Kwitansi.Value = DateTime.Now;
            text_IDPelanggan.Text = "";
            text_NamaPelanggan.Text = "";
            text_kodebarang.Text = "";
            text_namabarang.Text = "";
            text_hargabarang.Text = "0";
            text_jumlah.Text = "0";
            

            text_IDPelanggan.Enabled = false;
            text_NamaPelanggan.Enabled = false;
            text_kodebarang.Enabled = false;
            text_namabarang.Enabled = false;
            text_hargabarang.Enabled = false;
            btn_min.Enabled = false;
            btn_simpan.Enabled = false;
            btn_CariPelanggan.Enabled = false;
            btn_caribarang.Enabled = false;

        }


        #endregion

        #region 7. membuat procedure awal
     
        public void Awal()
        {
            //panggil procedure bersih didalam procedure awal
            bersih();

            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    //buka sql server, buat view penjualan
                    cmd = new SqlCommand("SELECT * FROM vw_penjualan ORDER BY NoKwitansi DESC", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "vw_penjualan");

                    dataGridView_transaksi.DataSource = ds;
                    dataGridView_transaksi.DataMember = "vw_penjualan";
                    dataGridView_transaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_transaksi.Refresh();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
                groupBox_transaksi.Enabled = false;
            }

        }

        #endregion


        #region 8.membuat procedure auto_number

        private void Auto_Number()
        {
            long hitung;
            string urut, joinstr;
            SqlConnection conn = konn.GetConn();

            conn.Open();
            cmd = new SqlCommand("SELECT NoKwitansi FROM tbl_penjualan WHERE NoKwitansi IN (SELECT MAX(NoKwitansi)FROM  tbl_penjualan) ORDER BY NoKwitansi DESC ", conn);

            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {

                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["NoKwitansi"].ToString().Length - 12, 4)) + 1;
                
                joinstr = "0000" + hitung;

                urut = "TRX-" + joinstr.Substring(joinstr.Length - 4, 4) + "/" + DateTime.Now.ToString("MM/yyyy");
            }

            else
            {
                urut = "TRX-0001/" + DateTime.Now.ToString("MM/yyyy");
            }

            rd.Close();
            text_NoKwitansi.Text = urut;
            text_NoKwitansi.Enabled = false;
            conn.Close();
        }

        #endregion

        #region 11.membuat procedure simpan_MasterPenjualan

        private void Simpan_MasterPenjualan()
        {
            //mempersiapkan sql koneksi
            SqlConnection conn = konn.GetConn();

            //mempersiapkan sql command yang akan dieksekusi

            cmd = new SqlCommand("INSERT INTO tbl_penjualan VALUES ('" + text_NoKwitansi.Text + "', '" + dateTimePicker_Kwitansi.Text + "', '" + text_IDPelanggan.Text + "')", conn);
            //membuka koneksi database
            conn.Open();

            //menjalankan perintah query
            cmd.ExecuteNonQuery();

        }

        #endregion

        #region 12. membuat procedure simpan_DetailPenjualan
        private void simpan_DetailPenjualan()
        {
            //mempersiapkan sql connection
            SqlConnection conn = konn.GetConn();
            {
                //mempersiapkan sqlcommand yang akan dieksekusi
                cmd = new SqlCommand("INSERT INTO tbl_detailpenjualan VALUES('" + text_NoKwitansi.Text + "', '" + text_kodebarang.Text + "', '" + text_jumlah.Text + "')", conn);
                //membuat koneksi ke database
                conn.Open();
                //menjalankan perintah query
                cmd.ExecuteNonQuery();



            }
        
        
        }

        #endregion

        #region 13. membuat procedure refresh_penjualan

        private void refresh_penjualan()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    //buka microsoft sqlserver, membuat view detail
                    cmd = new SqlCommand("SELECT * FROM vw_detail WHERE NoKwitansi = '" + text_NoKwitansi.Text + "' ", conn);

                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "vw_detail");

                    dataGridView_transaksi.DataSource = ds;
                    dataGridView_transaksi.DataMember = "vw_detail";
                    dataGridView_transaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_transaksi.AllowUserToAddRows = false;
                    dataGridView_transaksi.Refresh();

                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.ToString());
                }

                finally
                {
                    conn.Close();
                }
            }
        }

        #endregion

        #region 14 membuat procedure RefreshTransaksi
        private void RefreshTransaksi()
        {
            //memanggil procedure refresh_penjualan dan bersihkan beberapa komponen transaksi barang 
            refresh_penjualan();
            text_kodebarang.Clear();
            text_namabarang.Clear();
            text_hargabarang.Text = "0";
            text_jumlah.Text = "0";
            text_jumlah.Focus();



        }

        #endregion


        #region 18. membuat procedure refresh totalseluruh

        private void totalseluruh()
        {
            SqlConnection conn = konn.GetConn();
            {
                conn.Open();
               SqlCommand cmd = new SqlCommand("SELECT SUM(Harga*Jumlah) AS TotalBayar FROM vw_detail WHERE NoKwitansi = '" + text_NoKwitansi.Text + "' ", conn);

                cmd.Connection = conn;
                int result = ((int)cmd.ExecuteScalar());
                //var result = (int)cmd.ExecuteScalar();
                string TotalSeluruh = result.ToString();
                label_totalseluruh.Text = result.ToString();
                conn.Close();
            }
        }

        #endregion
        public FormTransaksi()
        {
            InitializeComponent();
            #region 9. memanggil prosedure awal, auto_number dan bersih ketika saat pertama kali dijalankan
            Awal();
            Auto_Number();

            bersih();
            #endregion
        }

        private void btn_CariPelanggan_Click(object sender, EventArgs e)
        {
            #region 1. panggil form dialogpelanggan
            

            DialogPelanggan plgn = new DialogPelanggan();
            plgn.ShowDialog();

            //pemanggilan 2 function DialogPelanggan
            text_IDPelanggan.Text = plgn.Ambil_ID_Pelanggan;
            text_NamaPelanggan.Text = plgn.Ambil_Nama_Pelanggan;

            #endregion
        }

        private void btn_caribarang_Click(object sender, EventArgs e)
        {
            #region 2. panggil form DialogBarang
            DialogBarang brng = new DialogBarang();
            brng.ShowDialog();

            //panggil 3 function dari form DialogBarang
            text_kodebarang.Text = brng.ambil_kodebarang;
            text_namabarang.Text = brng.ambil_namabarang;
            text_hargabarang.Text = brng.ambil_harga;

            #endregion


        }

        private void btn_baru_Click(object sender, EventArgs e)
        {
            #region 10. memanggil procedure awal dan auto_number ketika dijalankan 

            Awal();
            Auto_Number();
            dateTimePicker_Kwitansi.Focus();
            btn_CariPelanggan.Enabled = true;
            btn_caribarang.Enabled = true;

            #endregion
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            #region 15. Simpan data penjualan perbarang(buat trigger dahulu di sql server untuk automatis stok)

            SqlDataReader reader = null;
            SqlConnection conn = konn.GetConn();

            {
                //buat pesan jika ada data yang kosong 
                if (text_NoKwitansi.Text == "" || text_IDPelanggan.Text == "" || text_kodebarang.Text == "" || text_jumlah.Text == "")
                {
                    MessageBox.Show("Data Belum Lengkap", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
                else
                {
                    conn.Open();
                    cmd = new SqlCommand("SELECT * FROM  tbl_penjualan WHERE NoKwitansi = '" + text_NoKwitansi.Text + "'", conn);
                    cmd.ExecuteNonQuery();
                    reader = cmd.ExecuteReader();
                    if (reader.Read()) //jika data penjualan sudah ada 
                    {
                        //memanggil proc detail penjualan 
                        simpan_DetailPenjualan();
                        //19.memanggil procedure totalseluruh()
                        totalseluruh();


                    }
                    else //jika data penjualan belum ada
                    {
                        // memangggil procedure simpan_MasterPenjualan dan simpan_DetailPenjualan
                        Simpan_MasterPenjualan();
                        simpan_DetailPenjualan();

                        //20. memanggil procedure totalseluruh()
                        totalseluruh();

                    }

                    btn_CariPelanggan.Enabled = false;
                    btn_simpan.Enabled = true;
                    groupBox_transaksi.Enabled = true; //aktifkan group box transaksi
                    //memanggil procedure refresh
                    RefreshTransaksi();

                }
            }

            #endregion
        }

        private void dataGridView_transaksi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            #region 16. membuat procedure tampilkan data penjualan barang 
            btn_plus.Enabled = false;
            btn_min.Enabled = true;
            DataGridViewRow row = this.dataGridView_transaksi.Rows[e.RowIndex];
            text_kodebarang.Text = row.Cells["KodeBarang"].Value.ToString();
            text_namabarang.Text = row.Cells["NamaBarang"].Value.ToString();
            text_hargabarang.Text = row.Cells["Harga"].Value.ToString();
            text_jumlah.Text = row.Cells["Jumlah"].Value.ToString();

            

            #endregion
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            #region 17. hapus data penjualan perbarang
            //mempersiapkan koneksi database
            SqlConnection conn = konn.GetConn();

            {
                //query menghapus data berdasarkan NomorKwitansi
                cmd = new SqlCommand("DELETE FROM tbl_detailpenjualan WHERE NoKwitansi = '" + text_NoKwitansi.Text + "' AND KodeBarang =  '" + text_kodebarang.Text + "'", conn);

                //cmd = new SqlCommand("DELETE FROM tbl_penjualan WHERE NoKwitansi = '" + text_NoKwitansi.Text + "' AND KodeBarang =  '" + text_kodebarang.Text + "'", conn);

                //buka koneksi database
                conn.Open();

                //eksekusi Query 
                cmd.ExecuteNonQuery();

                //21. memanggil procedure totalseluruh 
                //totalseluruh();

                //memanggil procedure RefreshTransaksi
                RefreshTransaksi();
                btn_plus.Enabled = true;
                //btn_min.Enabled = false;
                btn_min.Enabled = true;


            }

            #endregion
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            #region 19. transaksi selesai 
            MessageBox.Show("Transaksi Selesai");

            //kembalikan ke procedure baru 
            Awal();
            label_totalseluruh.Text = "0";
            btn_CariPelanggan.Enabled = true;

            //panggil procedure AutoNumber
            Auto_Number();

            #endregion

            #region 20. panggil form laporan CetakTransaksi

            Laporan.CetakTransaksi a = new Laporan.CetakTransaksi(text_NoKwitansi.Text);
            a.Show();
            #endregion
        }
    }
}
