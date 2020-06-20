using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Penjualan.GUI
{
    public partial class Menu_Utama : Form
    {
        //private int childFormNumber = 0;

        //1. buat form menjadi objek 
        FormBarang brg;
        FormPelanggan plgn;
        FormTransaksi trx;

        //2. buat procedure close brg
        void brg_FormClosed(object sender, EventArgs e)
        {
            brg = null;
        }

        void plgn_FormClosed(object sender, EventArgs e)
        {
            plgn = null;
        }

        void trx_FormClosed(object sender, EventArgs e)
        {
            trx = null;
        }

        public Menu_Utama()
        {
            InitializeComponent();
        }

        private void submenu_barang_Click(object sender, EventArgs e)
        {
            if (brg == null)
            {
                brg = new FormBarang();
                brg.MdiParent = this;
                //panggil void form close
                brg.FormClosed += new FormClosedEventHandler(brg_FormClosed);
                brg.Show();
            }
            else
            {
                brg.Activate();
            }

        }

        private void submenu_pelanggan_Click(object sender, EventArgs e)
        {
            if (plgn == null)
            {
                plgn = new FormPelanggan();
                plgn.MdiParent = this;
                //panggil void form close
                plgn.FormClosed += new FormClosedEventHandler(plgn_FormClosed);
                plgn.Show();
            }
            else
            {
                plgn.Activate();
            }
        }

        private void submenu_penjualan_Click(object sender, EventArgs e)
        {
            if (trx == null)
            {
                trx = new FormTransaksi();
                trx.MdiParent = this;
                //panggil void form close 

                trx.FormClosed += new FormClosedEventHandler(trx_FormClosed);
                trx.Show();

            }

            else
            {
                trx.Activate();
            }
        }

        private void submenu_laporanbrg_Click(object sender, EventArgs e)
        {
            Laporan.CetakBarang ctkbarang = new Laporan.CetakBarang();
            ctkbarang.Show();
        }

        private void submenu_laporanplgn_Click(object sender, EventArgs e)
        {
            Laporan.CetakPelanggan ctkpelanggan = new Laporan.CetakPelanggan();
            ctkpelanggan.Show();
        }

       
    } 
}
