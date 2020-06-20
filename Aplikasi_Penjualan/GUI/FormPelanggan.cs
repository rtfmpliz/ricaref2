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
    public partial class FormPelanggan : Form
    {

        #region 1. membuat procedure bersih 

        void Bersih()
        {
            txt_IdPelanggan.Enabled = false;
            txt_NamaPelanggan.Text = "";
            txt_Alamat.Text = "";
            txt_NoTelepon.Text = "0";
            


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

        #region 6. membuat procedure RefreshPelanggan


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
                    dataGridView_Pelanggan.DataSource = ds;
                    dataGridView_Pelanggan.DataMember = "tbl_pelanggan";
                    dataGridView_Pelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_Pelanggan.AllowUserToAddRows = false;
                    dataGridView_Pelanggan.Refresh();


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

        #region 8. membuat procedure CariPelanggan
        void cari_Pelanggan()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {

                    conn.Open();
                    cmd = new SqlCommand("Select * From tbl_pelanggan where IDPelanggan like '%" + txt_CariPelanggan.Text + "%' or NamaPelanggan like '%" + txt_CariPelanggan.Text + "%'", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "tbl_pelanggan");
                    dataGridView_Pelanggan.DataSource = ds;
                    dataGridView_Pelanggan.DataMember = "tbl_pelanggan";
                    dataGridView_Pelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_Pelanggan.AllowUserToAddRows = false;
                    dataGridView_Pelanggan.Refresh();


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
        void AutoNumber()
        {
            long hitung;
            string urut;
            SqlDataReader rd;
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("select IDPelanggan from tbl_pelanggan where IDPelanggan in (select max(IDPelanggan) from tbl_pelanggan)order by IDPelanggan desc ", conn);

            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["IDPelanggan"].ToString().Length - 3, 3)) + 1;
                string joinstr = "000" + hitung;
                urut = "P" + joinstr.Substring(joinstr.Length - 3, 3);
            }

            else
            {
                urut = "P001";

            }

            rd.Close();
            txt_IdPelanggan.Enabled = false;
            txt_IdPelanggan.Text = urut;
            conn.Close();

        }

        #endregion

        public FormPelanggan()
        {
            InitializeComponent();

            #region 3. memanggil procedure bersih dan atur tombol

            Bersih();
            atur_tombol(false);

            #endregion

            #region 7. panggil refresh barang
            refresh_pelanggan();

            #endregion
        }

        private void txt_CariPelanggan_TextChanged(object sender, EventArgs e)
        {
            #region 9. panggil procedure CariPelanggan 
            cari_Pelanggan();
            #endregion
        }

        private void button_simpan_Click(object sender, EventArgs e)
        {
            #region 10. membuat method SimpanPelanggan
            
            if (txt_IdPelanggan.Text == "" || txt_NamaPelanggan.Text == "" || txt_Alamat.Text == "" || txt_NoTelepon.Text == "" )
            {
              
                MessageBox.Show("Data Kurang Lengkap", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                //persiapkan koneksi ke Sql 

                SqlConnection conn = konn.GetConn();

                try
                {
                    cmd = new SqlCommand("insert into tbl_pelanggan values('" + txt_IdPelanggan.Text + "', '" + txt_NamaPelanggan.Text + "', '" +txt_Alamat.Text + "', '" + txt_NoTelepon.Text + "' )", conn);

                    //membuka koneksi
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    //tampilkan pesan 
                    MessageBox.Show("Data berhasil disimpan", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    refresh_pelanggan();
                    Bersih();
                    AutoNumber();
                    atur_tombol(false);
                    
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


            #endregion
        }

        private void button_ubah_Click(object sender, EventArgs e)
        {
            #region 11. membuat method ubah data
            if (txt_IdPelanggan.Text == "" || txt_NamaPelanggan.Text == "" || txt_Alamat.Text == "" || txt_NoTelepon.Text == "" )
            {
                MessageBox.Show("Data Kurang Lengkap", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                //persiapkan koneksi ke Sql 

                SqlConnection conn = konn.GetConn();

                try
                {
                    cmd = new SqlCommand("update tbl_pelanggan set NamaPelanggan = '"+txt_NamaPelanggan.Text+"', Alamat = '"+txt_Alamat.Text+"', NoTelepon = '"+txt_NoTelepon.Text+"' where IDPelanggan = '"+txt_IdPelanggan.Text+"' ", conn);

                    //membuka koneksi
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    //tampilkan pesan 
                    MessageBox.Show("Data berhasil diubah", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    refresh_pelanggan();
                    Bersih();
                    AutoNumber();
                    atur_tombol(false);
                   
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
                cmd = new SqlCommand("delete from tbl_pelanggan where IDPelanggan = '" + txt_IdPelanggan.Text + "' ", conn);

                //membuka koneksi
                conn.Open();
                cmd.ExecuteNonQuery();
                //tampilkan pesan 
                MessageBox.Show("Data berhasil diHapus", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                refresh_pelanggan();
                Bersih();
                atur_tombol(false);
                AutoNumber();
                button_simpan.Enabled = true;
            }

            #endregion
        }

        private void dataGridView_Pelanggan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            #region 13. tampilkan dataGridView_Pelanggan ke TextBox
            button_simpan.Enabled = false;
            atur_tombol(true);

            try
            {
                //isi textbox dan combobox yang diparsing dari datagrdiview
                DataGridViewRow row = dataGridView_Pelanggan.Rows[e.RowIndex];
                txt_IdPelanggan.Text = row.Cells["IDPelanggan"].Value.ToString();
                txt_NamaPelanggan.Text = row.Cells["NamaPelanggan"].Value.ToString();
                txt_Alamat.Text = row.Cells["Alamat"].Value.ToString();
                txt_NoTelepon.Text = row.Cells["NoTelepon"].Value.ToString();
                


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

