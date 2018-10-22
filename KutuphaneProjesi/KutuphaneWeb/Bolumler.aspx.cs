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
    public partial class FrmBolum : System.Web.UI.Page
    {
        private DbHelper _dbHelper = new DbHelper();

        public string BolumId
        {
            get
            {
                if (ViewState["YazarId"] != null)
                {
                    return ViewState["YazarId"].ToString();
                }
                return "";
            }
            set { ViewState["YazarId"] = value; }
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
            if (TextBox_Bolum.Text.Trim() == "")
            {
                return false;
            }

            return true;
        }

        protected void ButtonBolum_Ekle_Click(object sender, EventArgs e)
        {
            //button text i ekle ekleme 
            //Güncelle ise güncelleme olacak
            if (ButtonBolum_Ekle.Text == "EKLE")
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
                    if (CheckBox_Bolum.Checked)
                    {
                        isDeleted = 1;
                    }

                    var insertSqlWithPar = "Insert Into Bolum(BolumAdi,IsDeleted) values (@BolumAdi,@IsDeleted)";
                    var pars = new Dictionary<string, object>();
                    pars.Add("@BolumAdi", TextBox_Bolum.Text);
                    pars.Add("@IsDeleted", isDeleted);
                    _dbHelper.Execute(insertSqlWithPar, pars);
                    veriGetir();
                }
                else
                {
                    MessageBox.Show("Bölüm ismini giriniz!");
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
                    if (CheckBox_Bolum.Checked)
                    {
                        isDeleted = 1;
                    }


                    var updateSql =
                   "UPDATE Bolum SET BolumAdi=@BolumAdi,IsDeleted=@IsDeleted WHERE BolumID=@BolumID";

                    var pars = new Dictionary<string, object>();
                    pars.Add("@BolumAdi", TextBox_Bolum.Text);
                    pars.Add("@BolumID", BolumId);
                    pars.Add("@IsDeleted", isDeleted);
                    _dbHelper.Execute(updateSql, pars);
                    veriGetir();

                }
                else
                {
                    MessageBox.Show("Yazar ismini giriniz!");
                }
            }
        }
        private void veriGetir()
        {
            DataTable dt = _dbHelper.GetDataTable("Select * From Bolum ORDER BY BolumAdi");
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        private bool KayitVarMi()//Aynı kayıtın tekrar eklenmesini engelledik
        {
            try
            {
                if (ButtonBolum_Ekle.Text == "EKLE")
                {
                    string varmi = "Select Count(*) From Bolum Where BolumAdi=@BolumAdi";

                    var pars = new Dictionary<string, object>();
                    pars.Add("@BolumAdi", TextBox_Bolum.Text.Trim());

                    int sayi = _dbHelper.ExecuteScalar(varmi, pars);

                    if (sayi != 0)
                    {
                        return true;
                    }
                }
                else
                {
                    string varmi = "Select Count(*) From Bolum Where BolumAdi=@BolumAdi AND BolumID<>@BolumID";

                    var pars = new Dictionary<string, object>();
                    pars.Add("@BolumAdi", TextBox_Bolum.Text.Trim());
                    pars.Add("@BolumID", BolumId);

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

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Duzenle")
            {

                BolumId = e.CommandArgument.ToString();
                DataTable dt = _dbHelper.GetDataTable("Select * From Bolum Where BolumID=" + BolumId);

               TextBox_Bolum.Text = dt.Rows[0]["BolumAdi"].ToString();


                var isDeleted = dt.Rows[0]["IsDeleted"].ToString();
                if (isDeleted == "1")
                {
                    CheckBox_Bolum.Checked = true;
                }
                else
                {
                    CheckBox_Bolum.Checked = false;

                }
                ButtonBolum_Ekle.Text = "GÜNCELLE";


            }
        }

        protected void ButtonBolum_Temizle_Click(object sender, EventArgs e)
        {
            TextBox_Bolum.Text = "";
            CheckBox_Bolum.Checked = false;
        }
    }
}