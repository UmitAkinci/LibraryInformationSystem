using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Umit_AKINCI_KutuphaneProjesi
{
    public partial class FrmAnaMenu : Form
    {
        public FrmAnaMenu()
        {
            InitializeComponent();
        }

        private void buttonBolum_Click(object sender, EventArgs e)
        {
            FrmBolum goster = new FrmBolum();
            goster.ShowDialog();
        }

        private void buttonKategori_Click(object sender, EventArgs e)
        {
            FrmKategori kategorigoster=new FrmKategori();
            kategorigoster.ShowDialog();
        }

        private void buttonYazar_Click(object sender, EventArgs e)
        {
            FrmYazar yazargoster=new FrmYazar();
            yazargoster.ShowDialog();
        }

        private void buttonKitap_Click(object sender, EventArgs e)
        {
            FrmKitap kitapgoster=new FrmKitap();
            kitapgoster.ShowDialog();
        }

        private void buttonOgrenci_Click(object sender, EventArgs e)
        {
          
        }

        private void buttonOgrenci_Click_1(object sender, EventArgs e)
        {
            FrmOgrenci ogrencigoster = new FrmOgrenci();
            ogrencigoster.ShowDialog();
        }

        private void buttonKitap_Click_1(object sender, EventArgs e)
        {
            FrmKitap kitapgoster = new FrmKitap();
            kitapgoster.ShowDialog();
        }

        private void buttonOdunc_Click(object sender, EventArgs e)
        {
            FrmOdunc oduncgoster=new FrmOdunc();
            oduncgoster.ShowDialog();
        }
    }
}
