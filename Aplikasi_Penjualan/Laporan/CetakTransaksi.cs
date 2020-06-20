using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//2. tambahkan libary sql
using System.Data.SqlClient;
//3. tambahkan libary crystal engine 
using CrystalDecisions.CrystalReports.Engine;



namespace Aplikasi_Penjualan.Laporan
{
    public partial class CetakTransaksi : Form
    {
        #region 4. membuat variable untuk akses query sql

        private DataSet ds;
        private SqlDataAdapter da;

        #endregion

        #region 5. buat variable untuk jadi parameter nokwitansi apa yang akan dicetak
        public string text_kwitansi;

        #endregion

        #region 6. import koneksi dari folder (kelas/koneksi.cs) menjadi objek konn
        Kelas.Koneksi konn = new Kelas.Koneksi();

        #endregion

        

        #region 8. membuat void CetakLaporanPelanggan

        void CetakLaporanTranskasi()
        {
            SqlConnection conn = konn.GetConn();
            {
                conn.Open();
                da = new SqlDataAdapter("SELECT * FROM vw_CetakTransaksi WHERE NoKwitansi = '"+text_kwitansi+"' ", conn);

                //da = new SqlDataAdapter("SELECT * FROM vw_CetakTransaksi  ", conn);

                ds = new DataSet();
                da.Fill(ds, "vw_CetakTransaksi");
                report_transaksi myreport_trns = new report_transaksi();
                myreport_trns.SetDataSource(ds);
                crystalReportViewer1.ReportSource = myreport_trns;
                crystalReportViewer1.Refresh();
                conn.Close();
            }


        }


        #endregion


        //1. rubah dahulu laporan transaksi menjadi function dengan parameter sehingga nanti laporan transaksi akan meneriman nokwitansi dari formtransaksi   
        public CetakTransaksi( string noKwitansi)
        {
            InitializeComponent();

            #region 7. isi variable text_kwitansi sesuai dengan nokwitansi yang akan didapat dari formtransaksi
            
            text_kwitansi = noKwitansi;


            #endregion

        }

        private void CetakTransaksi_Load(object sender, EventArgs e)
        {
            #region 9. panggil pada saat laporantransaksi terload 
            CetakLaporanTranskasi();
            #endregion
        }
    }
}
