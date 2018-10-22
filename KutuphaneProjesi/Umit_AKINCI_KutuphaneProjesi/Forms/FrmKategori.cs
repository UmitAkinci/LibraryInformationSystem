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
    //***********************KATEGORİ TANIMLAMA******************************
    public partial class FrmKategori : Form
    {

        public string id;
        private DbHelper _dbHelper;

        public FrmKategori()
        {
            InitializeComponent();
            _dbHelper = new DbHelper();
        }

        //private SqlConnection baglanti =
        //    new SqlConnection("Data Source=arge_dev2008;Initial Catalog=stajyer;User Id=stajyer;Password=stajyer;");

        private void veriGetir()
        {
            DataTable dt = _dbHelper.GetDataTable("Select * From Kategori ORDER BY KategoriAdi");
            dataGridView1.DataSource = dt;
        }

        private bool KayitVarMi() //Aynı kayıtın tekrar eklenmesini engelledik
        {
            try
            {
                if (buttonEkleGuncelleKategori.Text == "EKLE")
                {
                    string varmi = "Select Count(*) From Kategori Where KategoriAdi=@KategoriAdi";

                    var pars = new Dictionary<string, object>();
                    pars.Add("@KategoriAdi", textBox_Kategori.Text.Trim());

                    int sayi = _dbHelper.ExecuteScalar(varmi, pars);
                    if (sayi != 0)
                    {
                        return true;
                    }
                }
                else
                {
                    string varmi = "Select Count(*) From Kategori Where KategoriAdi=@KategoriAdi AND KategoriID<>@KategoriID";

                    var pars = new Dictionary<string, object>();
                    pars.Add("@KategoriAdi", textBox_Kategori.Text.Trim());
                    pars.Add("@KategoriID", id);

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

        private void buttonEkleGuncelleKategori_Click(object sender, EventArgs e)
        {
            //button text i ekle ekleme 
            //Güncelle ise güncelleme olacak
            if (buttonEkleGuncelleKategori.Text == "EKLE")
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
                    if (checkBoxKategori.Checked)
                    {
                        isDeleted = 1;
                    }

                    var insertSqlWithPar = "Insert Into Kategori(KategoriAdi,IsDeleted) values (@KategoriAdi,@IsDeleted)";
                    var pars = new Dictionary<string, object>();
                    pars.Add("@KategoriAdi", textBox_Kategori.Text);
                    pars.Add("@IsDeleted", isDeleted);
                    _dbHelper.Execute(insertSqlWithPar, pars);
                    veriGetir();
                }
                else
                {
                    MessageBox.Show("Kategori boş bırakılamaz!");
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
                    if (checkBoxKategori.Checked)
                    {
                        isDeleted = 1;
                    }

                    var updateSql =
                        "UPDATE Kategori SET KategoriAdi=@KategoriAdi,IsDeleted=@IsDeleted WHERE KategoriID=@Kategoriid";

                    var pars = new Dictionary<string, object>();
                    pars.Add("@KategoriAdi", textBox_Kategori.Text);
                    pars.Add("@Kategoriid", id);
                    pars.Add("@IsDeleted", isDeleted);
                    _dbHelper.Execute(updateSql, pars);
                    veriGetir();

                }
                else
                {
                    MessageBox.Show("Kategori boş bırakılamaz!");
                }
            }
        }

        private bool AlanlariKontorlEt()
        {
            if (textBox_Kategori.Text.Trim() == "")
            {
                return false;
            }

            return true;
        }

        private void Form3_Load(object sender, EventArgs e)
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
            dataGridView1.Columns[0].Visible = false; //KategoriID yi gizledik
            dataGridView1.Columns[2].Visible = true; //Isdeleted ı gizledik

        }

        private void buttonTemizleKategori_Click(object sender, EventArgs e)
        {
            textBox_Kategori.Clear();
            checkBoxKategori.Checked = false;
            buttonEkleGuncelleKategori.Text = "EKLE";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns[""].Index && e.RowIndex >=0)
            {
                id = dataGridView1.Rows[e.RowIndex].Cells["KategoriID"].Value.ToString();
                textBox_Kategori.Text = dataGridView1.Rows[e.RowIndex].Cells["KategoriAdi"].Value.ToString();
                checkBoxKategori.Checked = dataGridView1.Rows[e.RowIndex].Cells["IsDeleted"].Value.ToString() == "1" ? true : false;
                buttonEkleGuncelleKategori.Text = "GÜNCELLE";
            }
        }

        private void textBox_Kategori_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //IsDeleted 'Evet','Hayır' ataması yaptık
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "IsDeleted")
            {
                if (e.Value != null)
                {

                    int intValue = (int) e.Value;
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

        private void textBox_Kategori_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)//Sadece harf girilsin
                 && !char.IsSeparator(e.KeyChar);
        }
    }
}