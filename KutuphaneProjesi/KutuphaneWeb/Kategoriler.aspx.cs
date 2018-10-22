using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using KutuphaneData.Models;

namespace KutuphaneWeb
{
    public partial class Kategoriler : System.Web.UI.Page
    {
        private DbHelper _dbHelper = new DbHelper();
        public string KategoriId
        {
            get
            {
                if (ViewState["KategoriId"] != null)
                {
                    return ViewState["KategoriId"].ToString();
                }
                return "";
            }
            set { ViewState["KategoriId"] = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                veriGetir();
            }
        }

        private bool AlanlariKontorlEt()
        {
            if (TextBox_Kategori.Text.Trim() == "")
            {
                return false;
            }

            return true;
        }
        protected void ButtonKategori_Ekle_Click(object sender, EventArgs e)
        {
            //button text i ekle ekleme 
            //Güncelle ise güncelleme olacak
            if (ButtonKategori_Ekle.Text == "EKLE")
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
                    if (CheckBox_Kategori.Checked)
                    {
                        isDeleted = 1;
                    }

                    var insertSqlWithPar = "Insert Into Kategori(KategoriAdi,IsDeleted) values (@KategoriAdi,@IsDeleted)";
                    var pars = new Dictionary<string, object>();
                    pars.Add("@KategoriAdi", TextBox_Kategori.Text);
                    pars.Add("@IsDeleted", isDeleted);
                    _dbHelper.Execute(insertSqlWithPar, pars);
                    veriGetir();
                }
                else
                {
                    MessageBox.Show("Kategori ismini giriniz!");
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
                    if (CheckBox_Kategori.Checked)
                    {
                        isDeleted = 1;
                    }


                    var updateSql =
                   "UPDATE Kategori SET KategoriAdi=@KategoriAdi,IsDeleted=@IsDeleted WHERE KategoriID=@KategoriID";

                    var pars = new Dictionary<string, object>();
                    pars.Add("@KategoriAdi", TextBox_Kategori.Text);
                    pars.Add("@KategoriID", KategoriId);
                    pars.Add("@IsDeleted", isDeleted);
                    _dbHelper.Execute(updateSql, pars);
                    veriGetir();

                }
                else
                {
                    MessageBox.Show("Kategori ismini giriniz!");
                }
            }

        }
        private void veriGetir()
        {
            DataTable dt = _dbHelper.GetDataTable("Select * From Kategori ORDER BY KategoriAdi");
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        private bool KayitVarMi()//Aynı kayıtın tekrar eklenmesini engelledik
        {
            try
            {
                if (ButtonKategori_Ekle.Text == "EKLE")
                {
                    string varmi = "Select Count(*) From Kategori Where KategoriAdi=@KategoriAdi";

                    var pars = new Dictionary<string, object>();
                    pars.Add("@Kategoriadi", TextBox_Kategori.Text.Trim());

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
                    pars.Add("@KategoriAdi", TextBox_Kategori.Text.Trim());
                    pars.Add("@KategoriID", KategoriId);

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
            TextBox_Kategori.Text = "";
            CheckBox_Kategori.Checked = false;
            ButtonKategori_Ekle.Text = "EKLE";
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Duzenle")
            {

                KategoriId = e.CommandArgument.ToString();
                DataTable dt = _dbHelper.GetDataTable("Select * From Kategori Where KategoriID=" + KategoriId);

                TextBox_Kategori.Text = dt.Rows[0]["KategoriAdi"].ToString();


                var isDeleted = dt.Rows[0]["IsDeleted"].ToString();
                if (isDeleted == "1")
                {
                    CheckBox_Kategori.Checked = true;
                }
                else
                {
                    CheckBox_Kategori.Checked = false;

                }
                    ButtonKategori_Ekle.Text = "GÜNCELLE";


            }
        }
    }
}