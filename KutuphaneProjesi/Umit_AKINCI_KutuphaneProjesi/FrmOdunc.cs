using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Umit_AKINCI_KutuphaneProjesi.Models;

namespace Umit_AKINCI_KutuphaneProjesi
{
    public partial class FrmOdunc : Form
    {
        private Helper _helper;
        private DbHelper _dbHelper;
        public FrmOdunc()
        {
            InitializeComponent();
            _helper=new Helper();
            _dbHelper = new DbHelper();
        }
        private SqlConnection baglanti = new SqlConnection("Data Source=arge_dev2008;Initial Catalog=stajyer;User Id=stajyer;Password=stajyer;");
        private void veriGetir()
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
            veriGetir();
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            Image image = Umit_AKINCI_KutuphaneProjesi.Properties.Resources.kalem;
            img.Image = image;
            dataGridViewOdunc.Columns.Add(img);
            img.HeaderText = "Düzenle";
            img.Width = 65;
            img.ImageLayout = DataGridViewImageCellLayout.Stretch;
            FillCmbKitap();
            dataGridViewOdunc.Columns[0].Visible = false;//OduncID yi gizledik
            dataGridViewOdunc.Columns[1].Visible = false;//KitapID yi gizledik
            dataGridViewOdunc.Columns[2].Visible = false;//OgrenciID yi gizledik
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

            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Ogrenci order by OgrenciAdi,OgrenciSoyadi";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                var listItem = new ListItem
                {
                    Id = Convert.ToInt32(dr["OgrenciID"]),
                    Name = dr["OgrenciAdi"].ToString() + " " + dr["OgrenciSoyadi"].ToString()
                };
                cmbAdiSoyadi.Items.Add(listItem);
            }
            baglanti.Close();

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

            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Kitap order by KitapAdi";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                var listItem = new ListItem
                {
                    Id = Convert.ToInt32(dr["KitapID"]),
                    Name = dr["KitapAdi"].ToString()
                };
                cmbKitap.Items.Add(listItem);
            }
            baglanti.Close();

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

                    //Ekleme işlemi yapılabilir
                    string kayit = "Insert Into Odunc (KitapID,OgrenciID,VerilmeTarihi,IadeTarihi) values (@KitapID,@OgrenciID,@VerilmeTarihi,@IadeTarihi)";
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                    komut.Parameters.AddWithValue("@KitapID", kitap.Id);
                    komut.Parameters.AddWithValue("@OgrenciID",adisoyadi.Id);
                    komut.Parameters.AddWithValue("@VerilmeTarihi", dateTimePicker_verilme.Value);
                    komut.Parameters.AddWithValue("@IadeTarihi", dateTimePicker_iade.Value);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    veriGetir();
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

                    baglanti.Open();
                    SqlCommand komutupdate = new SqlCommand(
                        "UPDATE Odunc SET VerilmeTarihi=@VerilmeTarihi,IadeTarihi=@IadeTarihi,OgrenciID=@OgrenciID,KitapID=@KitapID WHERE OduncID=@OduncID",baglanti);

                    komutupdate.Parameters.AddWithValue("@VerilmeTarihi", dateTimePicker_verilme.Value);
                    komutupdate.Parameters.AddWithValue("@IadeTarihi", dateTimePicker_iade.Value);
                    komutupdate.Parameters.AddWithValue("@OgrenciID", adisoyadi.Id);
                    komutupdate.Parameters.AddWithValue("@KitapID", kitap.Id);
                    komutupdate.Parameters.AddWithValue("@OduncID", id);

                    komutupdate.ExecuteNonQuery();
                    baglanti.Close();
                    veriGetir();

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
        }

        private void dataGridViewOdunc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                id = dataGridViewOdunc.Rows[e.RowIndex].Cells["OduncID"].Value.ToString();
            var kitapId = dataGridViewOdunc.Rows[e.RowIndex].Cells["KitapID"].Value.ToString();
            _helper.SelectCmb(cmbKitap, int.Parse(kitapId));
            var adisoyadiId= dataGridViewOdunc.Rows[e.RowIndex].Cells["OgrenciID"].Value.ToString();
            _helper.SelectCmb(cmbAdiSoyadi,int.Parse(adisoyadiId));
            dateTimePicker_verilme.Value = (DateTime) dataGridViewOdunc.Rows[e.RowIndex].Cells["VerilmeTarihi"].Value;
            dateTimePicker_iade.Value = (DateTime) dataGridViewOdunc.Rows[e.RowIndex].Cells["IadeTarihi"].Value;
            buttonOduncEkle.Text = "GÜNCELLE";
            }

            
        }

        private void dateTimePicker_verilme_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker_iade.MinDate = dateTimePicker_verilme.Value;//Verilme tarihi hangi tarih seçilmişse iade tarihini o tarihten başlatır
        }
    }
}
