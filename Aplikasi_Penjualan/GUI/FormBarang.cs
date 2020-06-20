using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Aplikasi_Penjualan.GUI
{
    public partial class FormBarang : Form
    {

        #region 1. membuat procedure bersih 

        void Bersih()
        {
            txt_KodeBarang.Text = "";
            txt_NamaBarang.Text = "";
            txt_HargaBarang.Text = "0";
            txt_Stok.Text = "0";
            cbo_Satuan.Text = "::Pilih Satuan::";


        }
        #endregion

        #region 2. membuat procedure atur tombol
        void atur_tombol(Boolean status)
        {
            button_ubah.Enabled = status;
            button_hapus.Enabled = status;
        }
        #endregion

        #region 4. tambahkan variable untuk perintah sql

        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        #endregion


        #region 5. import kelas koneksi dari package(kelas/koneksi.cs) dan jadikan objek dangan nama konn

        Kelas.Koneksi konn = new Kelas.Koneksi();



        #endregion


        #region 6. membuat procedure RefreshBarang


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


        #region 8. membuat procedure CariBarang
       
        void cari_barang()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {

                    conn.Open();
                    cmd = new SqlCommand("Select * From tbl_barang where KodeBarang like '%" + txt_CariBarang.Text + "%' or NamaBarang like '%" + txt_CariBarang.Text + "%'", conn);
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

        #region 14. membuat procedure Auto Number
        void AutoNumber ()
        {
            long hitung;
            string urut;
            SqlDataReader rd;
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("select KodeBarang from tbl_barang where KodeBarang in (select max(KodeBarang) from tbl_barang)order by KodeBarang desc ",conn);

            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["KodeBarang"].ToString().Length - 3, 3)) + 1;
                string joinstr = "000" + hitung;
                urut = "B" + joinstr.Substring(joinstr.Length - 3, 3);
            }

            else
            {
                urut = "B001";

            }

            rd.Close();
            txt_KodeBarang.Enabled = false;
            txt_KodeBarang.Text = urut;
            conn.Close();

        }

        #endregion



        public FormBarang()
        {
            InitializeComponent();
            #region 3. memanggil procedure bersih dan atur tombol

            Bersih();
            atur_tombol(false);

            #endregion

            #region 7. panggil refresh barang
            refresh_barang();

            #endregion

          

        }



        private void txt_CariBarang_TextChanged(object sender, EventArgs e)
        {
            #region 9. panggil prcedure cari_barang()
            cari_barang();
            #endregion
        }

        private void button_simpan_Click(object sender, EventArgs e)
        {
            #region 10. membuat SimpanBarang

                if (txt_KodeBarang.Text == "" || txt_NamaBarang.Text == "" || txt_HargaBarang.Text == "" || txt_Stok.Text == "" || cbo_Satuan.Text == "")
                {
                    MessageBox.Show("Data Kurang Lengkap", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    //persiapkan koneksi ke Sql 

                    SqlConnection conn = konn.GetConn();

                    try
                    {
                        cmd = new SqlCommand("insert into tbl_barang values('" + txt_KodeBarang.Text + "', '" + txt_NamaBarang.Text + "', '" + txt_HargaBarang.Text + "', '" + txt_Stok.Text + "', '" + cbo_Satuan.Text + "' )", conn);

                        //membuka koneksi
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        //tampilkan pesan 
                        MessageBox.Show("Data berhasil disimpan", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        refresh_barang();
                        Bersih();
                        atur_tombol(false);
                        AutoNumber();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }

            
            #endregion

        }

     

        private void button_ubah_Click(object sender, EventArgs e)
        {
            #region 11. membuat method ubah data
            if (txt_KodeBarang.Text == "" || txt_NamaBarang.Text == "" || txt_HargaBarang.Text == "" || txt_Stok.Text == "" || cbo_Satuan.Text == "")
            {
                MessageBox.Show("Data Kurang Lengkap", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                //persiapkan koneksi ke Sql 

                SqlConnection conn = konn.GetConn();

                try
                {
                    cmd = new SqlCommand("update tbl_barang set NamaBarang = '"+txt_NamaBarang.Text+"', Harga = '"+txt_HargaBarang.Text+"', Stok = '"+txt_Stok.Text+"', Satuan = '"+cbo_Satuan.Text+"' where KodeBarang = '"+txt_KodeBarang.Text+"' ", conn);

                    //membuka koneksi
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    //tampilkan pesan 
                    MessageBox.Show("Data berhasil diubah", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    refresh_barang();
                    Bersih();
                    atur_tombol(false);
                    AutoNumber();
                    button_simpan.Enabled = true;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }


            #endregion
        }

        private void button_hapus_Click(object sender, EventArgs e)
        {
            #region 12. membuat hapus data

            //if (MessageBox.Show("Yakin ingin hapus data = " +txt_NamaBarang.Text+ "?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question )==DialogResult.Yes);

            {
                SqlConnection conn = konn.GetConn();
                cmd = new SqlCommand("delete from tbl_barang where KodeBarang = '" + txt_KodeBarang.Text + "' ", conn);

                //membuka koneksi
                conn.Open();
                cmd.ExecuteNonQuery();
                //tampilkan pesan 
                MessageBox.Show("Data berhasil diHapus", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                refresh_barang();
                Bersih();
                atur_tombol(false);
                AutoNumber();
                button_simpan.Enabled = true;
            }

            #endregion

        }

        private void dataGridView_Barang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            #region 13. tampilkan dataGridView_Barang ke TextBox
            button_simpan.Enabled = false;
            atur_tombol(true);

            try
            {
                //isi textbox dan combobox yang diparsing dari datagrdiview
                DataGridViewRow row = dataGridView_Barang.Rows[e.RowIndex];
                txt_KodeBarang.Text = row.Cells["KodeBarang"].Value.ToString();
                txt_NamaBarang.Text = row.Cells["NamaBarang"].Value.ToString();
                txt_HargaBarang.Text = row.Cells["Harga"].Value.ToString();
                txt_Stok.Text = row.Cells["Stok"].Value.ToString();
                cbo_Satuan.Text = row.Cells["Satuan"].Value.ToString();


            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());

            }
            #endregion

        }

        private void button_baru_Click(object sender, EventArgs e)
        {

            #region 15. membuat data baru 

            Bersih();
            atur_tombol(false);
            button_simpan.Enabled = true;
            AutoNumber();
            #endregion


        }
    }
}
