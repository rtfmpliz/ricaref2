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

//2. tambahkan libary crystal engine
using CrystalDecisions.CrystalReports.Engine;


namespace Aplikasi_Penjualan.Laporan
{
    public partial class CetakPelanggan : Form
    {
        #region 3. membuat variable untuk akses query sql

        private DataSet ds;
        private SqlDataAdapter da;

        #endregion

        #region 4. import koneksi dari folder (kelas/koneksi.cs) menjadi objek konn
        Kelas.Koneksi konn = new Kelas.Koneksi();

        #endregion

        #region 5. membuat void CetakLaporanPelanggan
        
        void CetakLaporanPelanggan()
        {
            SqlConnection conn = konn.GetConn();
            {
                conn.Open();
                da = new SqlDataAdapter("SELECT * FROM tbl_pelanggan ORDER BY IDPelanggan ASC ", conn);
                ds = new DataSet();
                da.Fill(ds, "tbl_pelanggan");
                report_pelanggan myreport_plgn = new report_pelanggan();
                myreport_plgn.SetDataSource(ds);
                crystalReportViewer1.ReportSource = myreport_plgn;
                crystalReportViewer1.Refresh();
                conn.Close();
            }
                

        }


        #endregion



        public CetakPelanggan()
        {
            InitializeComponent();

            #region 6. panggil procedure  CetakLaporanPelanggan()

            CetakLaporanPelanggan();
           #endregion
        }
    }
}
