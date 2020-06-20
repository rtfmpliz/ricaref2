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
//2. tambahkan libary crytal engine
using CrystalDecisions.CrystalReports.Engine;

//using Aplikasi_Penjualan.Kelas;

namespace Aplikasi_Penjualan.Laporan
{
    public partial class CetakBarang : Form
    {
        #region 3. membuat variable untuk akses query sql
        private DataSet ds;
        private SqlDataAdapter da;


        #endregion

        #region 4.import koneksi dari folder (kelas/koneksi.cs) menjadi objek konn

        Kelas.Koneksi konn = new Kelas.Koneksi();

        #endregion

        #region 5. membuat void CetakLaporanBarang
       
        void CetakLaporanBarang()
        {
            SqlConnection conn = konn.GetConn();
            {
                conn.Open();
                da = new SqlDataAdapter("SELECT * FROM tbl_barang ORDER BY KodeBarang ASC", conn);
                ds = new DataSet();
                da.Fill(ds, "tbl_barang");
                report_barang myreport = new report_barang();
                myreport.SetDataSource(ds);
                crystalReportViewer1.ReportSource = myreport;
                crystalReportViewer1.Refresh();
                conn.Close();

            }
        }

        #endregion

        public CetakBarang()
        {
            InitializeComponent();
            #region 6.  ppanggil procedure cetak 
            CetakLaporanBarang();
            #endregion
        }
    }
}
