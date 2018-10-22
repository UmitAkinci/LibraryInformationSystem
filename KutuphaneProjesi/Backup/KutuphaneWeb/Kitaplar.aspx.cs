using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using KutuphaneData.Models;
using ListItem = System.Web.UI.WebControls.ListItem;

namespace KutuphaneWeb
{
    public partial class Kitaplar : System.Web.UI.Page
    {
        private DbHelper _dbHelper = new DbHelper();
        public string KitapId
        {
            get
            {
                if (ViewState["KitapId"] != null)
                {
                    return ViewState["KitapId"].ToString();
                }
                return "";
            }
            set { ViewState["KitapId"] = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                veriGetir();
            }
            //GridView1.Columns[0].Visible = false;
            //GridView1.Columns[1].Visible = false;
            //GridView1.Columns[2].Visible = false;
            FillCmbKategori();
            FillCmbYazar();
        }
        private bool AlanlariKontorlEt()
        {
            if (TextBox_Kitap.Text.Trim() == "")
            {
                return false;
            }

            return true;
        }
        private void FillCmbKategori()
        {
            DropDownList_Kategori.Items.Clear();
            var seciniz = new ListItem
            {
                Value = "-1",
                Text = "Seçiniz"
            };
            DropDownList_Kategori.Items.Add(seciniz);

            var dtKategori = _dbHelper.GetDataTable("SELECT * FROM Kategori where IsDeleted=0 order by KategoriAdi ");
            foreach (DataRow dr in dtKategori.Rows)
            {

                var listItem = new ListItem
                {
                    Value = dr["KategoriID"].ToString(),
                    Text = dr["KategoriAdi"].ToString()
                };
                DropDownList_Kategori.Items.Add(listItem);
            }

            DropDownList_Kategori.SelectedIndex = 0;
        }
        private void FillCmbYazar()
        {
            DropDownList_Yazar.Items.Clear();
            var seciniz = new ListItem
            {
                Value = "-1",
                Text = "Seçiniz"
            };
            DropDownList_Yazar.Items.Add(seciniz);

            var dtYazar = _dbHelper.GetDataTable("SELECT * FROM Yazar where IsDeleted=0 order by Adi_Soyadi");
            foreach (DataRow dr in dtYazar.Rows)
            {

                var listItem = new ListItem
                {
                    Value = dr["YazarID"].ToString(),
                    Text = dr["Adi_Soyadi"].ToString()
                };
                DropDownList_Yazar.Items.Add(listItem);
            }

            DropDownList_Yazar.SelectedIndex = 0;
        }

        protected void ButtonKitaplar_EKLE_Click(object sender, EventArgs e)
        {
            //button text i ekle ekleme 
            //Güncelle ise güncelleme olacak
            if (ButtonKitaplar_EKLE.Text == "EKLE")
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
                    if (CheckBox_Kitap.Checked)
                    {
                        isDeleted = 1;
                    }
                    var kategori = DropDownList_Kategori.SelectedItem as ListItem;
                    if (kategori == null)
                    {
                        MessageBox.Show("Kategori seçilmemiştir!");
                        return;
                    }

                    if (Convert.ToInt32(kategori.Value)<0)
                    {
                        MessageBox.Show("Kategori seçilmemiştir!");
                        return;
                    }


                    var yazar = DropDownList_Yazar.SelectedItem as ListItem;
                    if (yazar == null)
                    {
                        MessageBox.Show("Yazar seçilmemiştir!");
                        return;
                    }

                    if (Convert.ToInt32(yazar.Value)< 0)
                    {
                        MessageBox.Show("Yazar seçilmemiştir!");
                        return;
                    }

                    var insertSqlWithPar = "Insert Into Kitap(KitapAdi,KategoriID,YazarID,ISBN,IsDeleted) values (@KitapAdi,@KategoriID,@YazarID,@ISBN,@IsDeleted)";

                    var pars = new Dictionary<string, object>();
                    pars.Add("@KitapAdi", TextBox_Kitap.Text);
                    pars.Add("@KategoriID", kategori.Value);
                    pars.Add("@YazarID", yazar.Value);
                    pars.Add("@ISBN", TextBoxISBN.Text);
                    pars.Add("@IsDeleted", isDeleted);
                    _dbHelper.Execute(insertSqlWithPar, pars);
                    veriGetir();
                }
                else
                {
                    MessageBox.Show("Kitap ismini giriniz!");
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
                    if (CheckBox_Kitap.Checked)
                    {
                        isDeleted = 1;
                    }
                    var kategori = DropDownList_Kategori.SelectedItem as ListItem;
                    if (kategori == null)
                    {
                        MessageBox.Show("Kategori seçilmemiştir!");
                        return;
                    }

                    if (Convert.ToInt32(kategori.Value) < 0)
                    {
                        MessageBox.Show("Kategori seçilmemiştir!");
                        return;
                    }
                    var yazar = DropDownList_Yazar.SelectedItem as ListItem;
                    if (yazar == null)
                    {
                        MessageBox.Show("Yazar seçilmemiştir!");
                        return;
                    }

                    if (Convert.ToInt32(yazar.Value) < 0)
                    {
                        MessageBox.Show("Yazar seçilmemiştir!");
                        return;
                    }


                    var updateSql =
                        "UPDATE Kitap SET KitapAdi=@KitapAdi,KategoriID=@KategoriID,YazarID=@YazarID,ISBN=@ISBN,IsDeleted=@IsDeleted WHERE KitapID=@Kitapid";

                    var pars = new Dictionary<string, object>();
                    pars.Add("@KitapAdi", TextBox_Kitap.Text);
                    pars.Add("@KategoriID", kategori.Value);
                    pars.Add("@YazarID", yazar.Value);
                    pars.Add("@ISBN", TextBoxISBN.Text);
                    pars.Add("@Kitapid", KitapId);
                    pars.Add("@IsDeleted", isDeleted);
                    _dbHelper.Execute(updateSql, pars);
                    veriGetir();

                }
                else
                {
                    MessageBox.Show("Kitap ismini giriniz!");
                }
            }
        }
        private void veriGetir()
        {
            DataTable dt = _dbHelper.GetDataTable("Select * From Vwkitaptanimlama ORDER BY KitapAdi");
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        private bool KayitVarMi()//Aynı kayıtın tekrar eklenmesini engelledik
        {
            try
            {
                if (ButtonKitaplar_EKLE.Text == "EKLE")
                {
                    string varmi = "Select Count(*) From Kitap Where KitapAdi=@KitapAdi";

                    var pars = new Dictionary<string, object>();
                    pars.Add("@KitapAdi", TextBox_Kitap.Text.Trim());

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
                    pars.Add("@KitapAdi", TextBox_Kitap.Text.Trim());
                    pars.Add("@KitapID", KitapId);

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

        protected void ButtonKategori_Temizle_Click(object sender, EventArgs e)
        {
            TextBox_Kitap.Text = "";
            TextBoxISBN.Text = "";
            CheckBox_Kitap.Checked = false;
            ButtonKitaplar_EKLE.Text = "EKLE";
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Duzenle")
            {

                KitapId = e.CommandArgument.ToString();
                DataTable dt = _dbHelper.GetDataTable("Select * From Kitap Where KitapID=" + KitapId);

                TextBox_Kitap.Text = dt.Rows[0]["KitapAdi"].ToString();
                TextBoxISBN.Text = dt.Rows[0]["ISBN"].ToString();


                var isDeleted = dt.Rows[0]["IsDeleted"].ToString();
                if (isDeleted == "1")
                {
                    CheckBox_Kitap.Checked = true;
                }
                else
                {
                    CheckBox_Kitap.Checked = false;

                }
                ButtonKitaplar_EKLE.Text = "GÜNCELLE";


            }
        }
    }
}