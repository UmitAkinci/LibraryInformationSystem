using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using KutuphaneData.Models;

namespace KutuphaneWeb
{
    public partial class Yazarlar : System.Web.UI.Page
    {
        private DbHelper _dbHelper = new DbHelper();

        public string YazarId
        {
            get
            {
                if (ViewState["YazarId"]!=null)
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
            if (textBox_Yazar.Text.Trim() == "")
            {
                return false;
            }

            return true;
        }

        protected void btnEkleGuncelle_Click(object sender, EventArgs e)
        {
            //button text i ekle ekleme 
            //Güncelle ise güncelleme olacak
            if (btnEkleGuncelle.Text == "EKLE")
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
                    if (checkBox_Yazar.Checked)
                    {
                        isDeleted = 1;
                    }

                    var insertSqlWithPar = "Insert Into Yazar(Adi_Soyadi,IsDeleted) values (@Adi_Soyadi,@IsDeleted)";
                    var pars = new Dictionary<string, object>();
                    pars.Add("@Adi_Soyadi", textBox_Yazar.Text);
                    pars.Add("@IsDeleted", isDeleted);
                    _dbHelper.Execute(insertSqlWithPar, pars);
                    veriGetir();
                }
                else
                {
                    MessageBox.Show("Yazar ismini giriniz!");
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
                    if (checkBox_Yazar.Checked)
                    {
                        isDeleted = 1;
                    }


                    var updateSql =
                   "UPDATE Yazar SET Adi_Soyadi=@Adi_Soyadi,IsDeleted=@IsDeleted WHERE YazarID=@Yazarid";

                    var pars = new Dictionary<string, object>();
                    pars.Add("@Adi_Soyadi", textBox_Yazar.Text);
                    pars.Add("@Yazarid", YazarId);
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
            DataTable dt = _dbHelper.GetDataTable("Select * From Yazar ORDER BY Adi_Soyadi");
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        private bool KayitVarMi()//Aynı kayıtın tekrar eklenmesini engelledik
        {
            try
            {
                if (btnEkleGuncelle.Text == "EKLE")
                {
                    string varmi = "Select Count(*) From Yazar Where Adi_Soyadi=@Adi_Soyadi";

                    var pars = new Dictionary<string, object>();
                    pars.Add("@Adi_Soyadi", textBox_Yazar.Text.Trim());

                    int sayi = _dbHelper.ExecuteScalar(varmi, pars);

                    if (sayi != 0)
                    {
                        return true;
                    }
                }
                else
                {
                    string varmi = "Select Count(*) From Yazar Where Adi_Soyadi=@Adi_Soyadi AND YazarID<>@YazarID";

                    var pars = new Dictionary<string, object>();
                    pars.Add("@Adi_Soyadi", textBox_Yazar.Text.Trim());
                    pars.Add("@YazarID", YazarId);

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
            if (e.CommandName=="Duzenle")
            {
            
                YazarId = e.CommandArgument.ToString();
                DataTable dt = _dbHelper.GetDataTable("Select * From Yazar Where YazarID=" + YazarId);

                textBox_Yazar.Text = dt.Rows[0]["Adi_Soyadi"].ToString();


                var isDeleted = dt.Rows[0]["IsDeleted"].ToString();
                if (isDeleted == "1")
                {
                    checkBox_Yazar.Checked = true;
                }
                else
                {
                    checkBox_Yazar.Checked = false;

                }
                btnEkleGuncelle.Text = "GÜNCELLE";
              

            }
        }

        protected void Button_Temizle_Click(object sender, EventArgs e)
        {
            textBox_Yazar.Text = "";
            checkBox_Yazar.Checked = false;
            btnEkleGuncelle.Text = "EKLE";
        }
    }
}