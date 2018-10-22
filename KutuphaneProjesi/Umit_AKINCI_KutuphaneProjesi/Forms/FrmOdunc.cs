using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using KutuphaneData.Models;


namespace Umit_AKINCI_KutuphaneProjesi
{
    public partial class FrmOdunc : Form
    {
        private Helper _helper;
        private DbHelper _dbHelper;
        public FrmOdunc()
        {
            InitializeComponent();
            _helper = new Helper();
            _dbHelper = new DbHelper();
        }

        private void VeriGetir()
        {
            DataTable dt = _dbHelper.GetDataTable("Select * From VwOdunctanimlama ORDER BY OgrenciAdi");
            dataGridViewOdunc.DataSource = dt;
        }
        private bool AlanlariKontorlEt()
        {
            if (cmbAdiSoyadi.Text.Trim() == "")
            {
                return false;
            }

            return true;
        }
        public string id;
        private void FrmOdunc_Load(object sender, EventArgs e)
        {
            VeriGetir();
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            Image image = Umit_AKINCI_KutuphaneProjesi.Properties.Resources.kalem;
            img.Image = image;
            dataGridViewOdunc.Columns.Add(img);
            img.HeaderText = "";
            img.Width = 65;
            img.ImageLayout = DataGridViewImageCellLayout.Stretch;
            FillCmbKitap();
            dataGridViewOdunc.Columns[0].Visible = false;//OduncID yi gizledik
            dataGridViewOdunc.Columns[1].Visible = false;//KitapID yi gizledik
            dataGridViewOdunc.Columns[2].Visible = false;//OgrenciID yi gizledik
            checkBox_iade.Visible = false;
            FillCmbOgrenci();
        }
        private void FillCmbOgrenci()
        {
            cmbAdiSoyadi.Items.Clear();
            var seciniz = new ListItem
            {
                Id = -1,
                Name = "Seçiniz"
            };
            cmbAdiSoyadi.Items.Add(seciniz);

            var dtOgrenciler = _dbHelper.GetDataTable("Select * from ogrenci where IsDeleted=0  order by OgrenciAdi,OgrenciSoyadi");
            foreach (DataRow dr in dtOgrenciler.Rows)
            {

                var listItem = new ListItem
                {
                    Id = Convert.ToInt32(dr["OgrenciID"]),
                    Name = dr["OgrenciAdi"].ToString() + " " + dr["OgrenciSoyadi"].ToString()
                };
                cmbAdiSoyadi.Items.Add(listItem);
            }

            cmbAdiSoyadi.SelectedIndex = 0;
        }
        private void FillCmbKitap()
        {
            cmbKitap.Items.Clear();
            var seciniz = new ListItem
            {
                Id = -1,
                Name = "Seçiniz"
            };
            cmbKitap.Items.Add(seciniz);

            DataTable dtKitaplar = _dbHelper.GetDataTable("SELECT * FROM Kitap where IsDeleted=0 order by KitapAdi");
            foreach (DataRow dr in dtKitaplar.Rows)
            {
                var listItem = new ListItem
                {
                    Id = Convert.ToInt32(dr["KitapID"]),
                    Name = dr["KitapAdi"].ToString()
                };
                cmbKitap.Items.Add(listItem);
            }


            cmbKitap.SelectedIndex = 0;
        }
        private void buttonOduncEkle_Click(object sender, EventArgs e)
        {
            dateTimePicker_iade.MinDate = dateTimePicker_verilme.Value;//Verilme tarihi hangi tarih seçilmişse iade tarihi o tarihten başlıcak
            //button text i ekle ekleme 
            //Güncelle ise güncelleme olacak
            if (buttonOduncEkle.Text == "EKLE")
            {
                //Ekleme yapılacak
                bool kontrol = AlanlariKontorlEt();
                if (kontrol)
                {
                    var iadeEdildiMi = 0;
                    if (checkBox_iade.Checked)
                    {
                        iadeEdildiMi = 1;
                    }

                    var kitap = cmbKitap.SelectedItem as ListItem;
                    if (kitap == null)
                    {
                        MessageBox.Show("Kitap seçilmemiştir!");
                        return;
                    }

                    if (kitap.Id < 0)
                    {
                        MessageBox.Show("Kitap seçilmemiştir!");
                        return;
                    }
                    var adisoyadi = cmbAdiSoyadi.SelectedItem as ListItem;
                    if (adisoyadi == null)
                    {
                        MessageBox.Show("Öğrenci seçilmemiştir!");
                        return;
                    }

                    if (adisoyadi.Id < 0)
                    {
                        MessageBox.Show("Öğrenci seçilmemiştir!");
                        return;
                    }

                    var insertSqlWithPar = "Insert Into Odunc (KitapID,OgrenciID,VerilmeTarihi,IadeEdecegiTarih,IadeEdildiMi) values (@KitapID,@OgrenciID,@VerilmeTarihi,@IadeEdecegiTarih,@IadeEdildiMi)";

                    var pars = new Dictionary<string, object>();
                    pars.Add("@KitapID", kitap.Id);
                    pars.Add("@OgrenciID", adisoyadi.Id);
                    pars.Add("@VerilmeTarihi", dateTimePicker_verilme.Value);
                    pars.Add("@IadeEdecegiTarih", dateTimePicker_iade.Value);
                    pars.Add("@IadeEdildiMi",iadeEdildiMi);

                    _dbHelper.Execute(insertSqlWithPar, pars);
                    VeriGetir();
                    //Ekleme işlemi yapılabilir

                }
                else
                {
                    MessageBox.Show("Lütfen seçim yapınız!");
                }

            }
            else
            {
                //Güncelleme yapılacak
                //Ekleme yapılacak
                bool kontrol = AlanlariKontorlEt();
                if (kontrol)
                {
                    var iadeEdildiMi = 0;
                    if (checkBox_iade.Checked)
                    {
                        iadeEdildiMi = 1;
                    }

                    var kitap = cmbKitap.SelectedItem as ListItem;
                    if (kitap == null)
                    {
                        MessageBox.Show("Kitap seçilmemiştir!");
                        return;
                    }

                    if (kitap.Id < 0)
                    {
                        MessageBox.Show("Kitap seçilmemiştir!");
                        return;
                    }
                    var adisoyadi = cmbAdiSoyadi.SelectedItem as ListItem;
                    if (adisoyadi == null)
                    {
                        MessageBox.Show("Öğrenci seçilmemiştir!");
                        return;
                    }

                    if (adisoyadi.Id < 0)
                    {
                        MessageBox.Show("Öğrenci seçilmemiştir!");
                        return;
                    }


                    var updateSql =
                        "UPDATE Odunc SET VerilmeTarihi=@VerilmeTarihi,IadeEdecegiTarih=@IadeEdecegiTarih,OgrenciID=@OgrenciID,KitapID=@KitapID,IadeEdildiMi=@IadeEdildiMi WHERE OduncID=@OduncID";

                    var pars = new Dictionary<string, object>();
                    pars.Add("@KitapID", kitap.Id);
                    pars.Add("@OgrenciID", adisoyadi.Id);
                    pars.Add("@VerilmeTarihi", dateTimePicker_verilme.Value);
                    pars.Add("@IadeEdecegiTarih", dateTimePicker_iade.Value);
                    pars.Add("@IadeEdildiMi", iadeEdildiMi);
                    pars.Add("@OduncID", id);
                    _dbHelper.Execute(updateSql, pars);

                    VeriGetir();

                }
                else
                {
                    MessageBox.Show("Lütfen Seçim Yapınız!");
                }
            }
        }

        private void buttonOduncTemizle_Click(object sender, EventArgs e)
        {
            cmbAdiSoyadi.Text = "Seçiniz";
            cmbKitap.Text = "Seçiniz";
            buttonOduncEkle.Text = "EKLE";
            checkBox_iade.Checked = false;
            checkBox_iade.Visible = false;
        }

        private void dataGridViewOdunc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewOdunc.Columns[""].Index && e.RowIndex >= 0)
            {
                id = dataGridViewOdunc.Rows[e.RowIndex].Cells["OduncID"].Value.ToString();
                var kitapId = dataGridViewOdunc.Rows[e.RowIndex].Cells["KitapID"].Value.ToString();
                _helper.SelectCmb(cmbKitap, int.Parse(kitapId));
                var adisoyadiId = dataGridViewOdunc.Rows[e.RowIndex].Cells["OgrenciID"].Value.ToString();
                _helper.SelectCmb(cmbAdiSoyadi, int.Parse(adisoyadiId));
                dateTimePicker_verilme.Value = (DateTime)dataGridViewOdunc.Rows[e.RowIndex].Cells["VerilmeTarihi"].Value;
                dateTimePicker_iade.Value = (DateTime)dataGridViewOdunc.Rows[e.RowIndex].Cells["IadeTarihi"].Value;
                buttonOduncEkle.Text = "GÜNCELLE";
                checkBox_iade.Visible = true;
                checkBox_iade.Checked = dataGridViewOdunc.Rows[e.RowIndex].Cells["IadeEdildiMi"].Value.ToString() == "1"
                    ? true
                    : false;
            }


        }

        private void dateTimePicker_verilme_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker_iade.MinDate = dateTimePicker_verilme.Value;//Verilme tarihi hangi tarih seçilmişse iade tarihini o tarihten başlatır
        }

        private void dataGridViewOdunc_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridViewOdunc.Columns[e.ColumnIndex].Name == "IadeEdildiMi")
            {
                if (e.Value != null)
                {

                    int intValue = (int)e.Value;
                    switch (intValue)
                    {
                        case 1:
                            e.Value = "Evet";
                            break;
                        case 0:
                            e.Value = "Hayır";
                            break;

                    }
                }
            }
        }
    }
}
