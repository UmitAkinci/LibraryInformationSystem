using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KutuphaneData.Models;


namespace Umit_AKINCI_KutuphaneProjesi
{
    //************************Kitap Tanımlama*************************
    public partial class FrmKitap : Form
    {
        public string id;
        private Helper _helper;
        private DbHelper _dbHelper;
        public FrmKitap()
        {
            InitializeComponent();
            _helper = new Helper();
            _dbHelper = new DbHelper();
  
        }

        private void veriGetir()
        {
            DataTable dt = _dbHelper.GetDataTable("Select * From Vwkitaptanimlama ORDER BY KitapAdi");
            dataGridView1.DataSource = dt;
        }
        private bool AlanlariKontorlEt()
        {
            if (textBox_Kitap.Text.Trim() == "")
            {
                return false;
            }

            return true;
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            veriGetir();
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            Image image = Umit_AKINCI_KutuphaneProjesi.Properties.Resources.kalem;
            img.Image = image;
            dataGridView1.Columns.Add(img);
            img.HeaderText = "";
            img.Width = 65;
            img.ImageLayout = DataGridViewImageCellLayout.Stretch;
            /*DataGridViewButtonColumn buton = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(buton);
            buton.HeaderText = "Düzenle";
            buton.Text = "Düzenle";
            buton.Name = "Düzenle";
            buton.UseColumnTextForButtonValue = true;*/
            FillCmbYazar();
            FillCmbKategori();
            dataGridView1.Columns[0].Visible = false;//KitapID yi gizledik
            dataGridView1.Columns[1].Visible = false;//KategoriID yi gizledik
            dataGridView1.Columns[2].Visible = false;//YazarID yi gizledik
            //dataGridView1.Columns[7].Visible = false;//Isdeleted ı gizledik
            
        }
        //Kategori....................
        private void FillCmbKategori()
        {
            comboBoxKategori.Items.Clear();
            var seciniz = new ListItem
            {
                Id = -1,
                Name = "Seçiniz"
            };
            comboBoxKategori.Items.Add(seciniz);

            var dtKategori = _dbHelper.GetDataTable("SELECT * FROM Kategori where IsDeleted=0 order by KategoriAdi ");
            foreach (DataRow dr in dtKategori.Rows)
            {

                var listItem = new ListItem
                {
                    Id = Convert.ToInt32(dr["KategoriID"]),
                    Name = dr["KategoriAdi"].ToString()
                };
                comboBoxKategori.Items.Add(listItem);
            }

            comboBoxKategori.SelectedIndex = 0;
        }
        //Yazar........................
        private void FillCmbYazar()
        {
            comboBoxYazar.Items.Clear();
            var seciniz = new ListItem
            {
                Id = -1,
                Name = "Seçiniz"
            };
            comboBoxYazar.Items.Add(seciniz);

            var dtYazar = _dbHelper.GetDataTable("SELECT * FROM Yazar where IsDeleted=0 order by Adi_Soyadi");
            foreach (DataRow dr in dtYazar.Rows)
            {
                var listItem = new ListItem
                {
                    Id = Convert.ToInt32(dr["YazarID"]),
                    Name = dr["Adi_Soyadi"].ToString()
                };
                comboBoxYazar.Items.Add(listItem);
            }

            comboBoxYazar.SelectedIndex = 0;
        }
        private bool KayitVarMi()//Aynı kayıtın tekrar eklenmesini engelledik
        {
            try
            {
                if (buttonEkleGuncelleKitap.Text == "EKLE")
                {
                    string varmi = "Select Count(*) From Kitap Where KitapAdi=@KitapAdi";

                    var pars = new Dictionary<string, object>();
                    pars.Add("@KitapAdi", textBox_Kitap.Text.Trim());
                    int sayi = _dbHelper.ExecuteScalar(varmi, pars);

                    if (sayi != 0)
                    {
                        return true;
                    }
                }
                else
                {
                    string varmi = "Select Count(*) From Kitap Where KitapAdi=@KitapAdi AND KitapID<>@KitapID";

                    var pars = new Dictionary<string, object>();
                    pars.Add("@KitapAdi", textBox_Kitap.Text.Trim());
                    pars.Add("@KitapID", id);
                    int sayi = _dbHelper.ExecuteScalar(varmi, pars);

                    if (sayi != 0)
                    {
                        return true;
                    }
                }

                
            }
            catch (Exception)
            {

            }
            return false;
        }
        private void buttonEkleGuncelleKitap_Click(object sender, EventArgs e)
        {
            //button text i ekle ekleme 
            //Güncelle ise güncelleme olacak
            if (buttonEkleGuncelleKitap.Text == "EKLE")
            {
                if (KayitVarMi())
                {
                    MessageBox.Show("Böyle bir kayıt zaten mevcut!");
                    return;
                }
                //Ekleme yapılacak
                bool kontrol = AlanlariKontorlEt();
                if (kontrol)
                {
                    //Ekleme işlemi yapılabilir

                    var isDeleted = 0;
                    if (checkBox_Kitap.Checked)
                    {
                        isDeleted = 1;
                    }
                    var kategori = comboBoxKategori.SelectedItem as ListItem;
                    if (kategori == null)
                    {
                        MessageBox.Show("Kategori seçilmemiştir!");
                        return;
                    }

                    if (kategori.Id < 0)
                    {
                        MessageBox.Show("Kategori seçilmemiştir!");
                        return;
                    }
                    
                    
                    var yazar = comboBoxYazar.SelectedItem as ListItem;
                    if (yazar == null)
                    {
                        MessageBox.Show("Yazar seçilmemiştir!");
                        return;
                    }

                    if (yazar.Id < 0)
                    {
                        MessageBox.Show("Yazar seçilmemiştir!");
                        return;
                    }

                    var insertSqlWithPar = "Insert Into Kitap(KitapAdi,KategoriID,YazarID,ISBN,IsDeleted) values (@KitapAdi,@KategoriID,@YazarID,@ISBN,@IsDeleted)";

                    var pars = new Dictionary<string, object>();
                    pars.Add("@KitapAdi", textBox_Kitap.Text);
                    pars.Add("@KategoriID", kategori.Id);
                   pars.Add("@YazarID", yazar.Id);
                    pars.Add("@ISBN", textBoxISBN.Text);
                    pars.Add("@IsDeleted", isDeleted);
                    
                    _dbHelper.Execute(insertSqlWithPar, pars);
                    veriGetir();
                }
                else
                {
                    MessageBox.Show("Yazar boş bırakılamaz!");
                }

            }
            else
            {
                //Güncelleme yapılacak
                //Ekleme yapılacak
                bool kontrol = AlanlariKontorlEt();
                if (kontrol)
                {
                    if (KayitVarMi())
                    {
                        MessageBox.Show("Böyle bir kayıt zaten mevcut!");
                        return;
                    }
                    var isDeleted = 0;
                    if (checkBox_Kitap.Checked)
                    {
                        isDeleted = 1;
                    }
                    var kategori = comboBoxKategori.SelectedItem as ListItem;
                    if (kategori== null)
                    {
                        MessageBox.Show("Kategori seçilmemiştir!");
                        return;
                    }

                    if (kategori.Id < 0)
                    {
                        MessageBox.Show("Kategori seçilmemiştir!");
                        return;
                    }
                    var yazar = comboBoxYazar.SelectedItem as ListItem;
                    if (yazar == null)
                    {
                        MessageBox.Show("Yazar seçilmemiştir!");
                        return;
                    }

                    if (yazar.Id < 0)
                    {
                        MessageBox.Show("Yazar seçilmemiştir!");
                        return;
                    }

                    var updateSql =
                        "UPDATE Kitap SET KitapAdi=@KitapAdi,KategoriID=@KategoriID,YazarID=@YazarID,ISBN=@ISBN,IsDeleted=@IsDeleted WHERE KitapID=@Kitapid";

                    var pars = new Dictionary<string, object>();
                    pars.Add("@KitapAdi", textBox_Kitap.Text);
                    pars.Add("@KategoriID", kategori.Id);
                    pars.Add("@YazarID", yazar.Id);
                    pars.Add("@ISBN", textBoxISBN.Text);
                    pars.Add("@Kitapid", id);
                    pars.Add("@IsDeleted", isDeleted);
                    _dbHelper.Execute(updateSql, pars);
                    veriGetir();

                }
                else
                {
                    MessageBox.Show("Kitap boş bırakılamaz!");
                }
            }
        }
        private void buttonTemizleKitap_Click(object sender, EventArgs e)
        {
            textBox_Kitap.Clear();
            textBoxISBN.Clear();
            comboBoxKategori.Text = "Seçiniz";
            comboBoxYazar.Text = "Seçiniz";
            checkBox_Kitap.Checked = false;
            buttonEkleGuncelleKitap.Text = "EKLE";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dataGridView1.Columns[""].Index && e.RowIndex >= 0)
            {
                
                    id = dataGridView1.Rows[e.RowIndex].Cells["KitapID"].Value.ToString();
                    var kategoriId = dataGridView1.Rows[e.RowIndex].Cells["KategoriID"].Value.ToString();
                    _helper.SelectCmb(comboBoxKategori, int.Parse(kategoriId));
                    var yazarId = dataGridView1.Rows[e.RowIndex].Cells["YazarID"].Value.ToString();
                    _helper.SelectCmb(comboBoxYazar, int.Parse(yazarId));
                    textBox_Kitap.Text = dataGridView1.Rows[e.RowIndex].Cells["KitapAdi"].Value.ToString();
                    textBoxISBN.Text = dataGridView1.Rows[e.RowIndex].Cells["ISBN"].Value.ToString();
                    buttonEkleGuncelleKitap.Text = "GÜNCELLE";
                    checkBox_Kitap.Checked = dataGridView1.Rows[e.RowIndex].Cells["IsDeleted"].Value.ToString() == "1" ? true : false;
               
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //IsDeleted 'Evet','Hayır' ataması yaptık
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "IsDeleted")
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

        private void textBox_Kitap_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)//Sadece harf girilsin
                 && !char.IsSeparator(e.KeyChar);
        }
    }
}
