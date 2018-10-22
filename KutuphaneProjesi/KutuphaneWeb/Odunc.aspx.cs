using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Windows.Forms;
using KutuphaneData.Models;
using ListItem = System.Web.UI.WebControls.ListItem;

namespace KutuphaneWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private DbHelper _dbHelper = new DbHelper();
        private void veriGetir()
        {
            DataTable dt = _dbHelper.GetDataTable("Select * From Vwodunctanimlama ORDER BY OgrenciAdi");
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        public string OduncId
        {
            get
            {
                if (ViewState["OduncId"] != null)
                {
                    return ViewState["OduncId"].ToString();
                }
                return "";
            }
            set { ViewState["OduncId"] = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                veriGetir();
            }
            FillCmbKitap();
            FillCmbOgrenci();
        }
        private bool AlanlariKontorlEt()
        {
            if (DropDownList_adsoyad.Text.Trim() == "")
            {
                return false;
            }

            return true;
        }
       
        protected void ButtonOdunc_EKLE_Click(object sender, EventArgs e)
        {
            //dateTimePicker_iade.MinDate = dateTimePicker_verilme.Value;//Verilme tarihi hangi tarih seçilmişse iade tarihi o tarihten başlıcak
            //button text i ekle ekleme 
            //Güncelle ise güncelleme olacak
            if (ButtonOdunc_EKLE.Text == "EKLE")
            {
                //Ekleme yapılacak
                bool kontrol = AlanlariKontorlEt();
                if (kontrol)
                {
                    var iadeEdildiMi = 0;
                    if (CheckBox_Odunc.Checked)
                    {
                        iadeEdildiMi = 1;
                    }

                    var kitap = DropDownList_Verilenkitap.SelectedItem as ListItem;
                    if (kitap == null)
                    {
                        MessageBox.Show("Kitap seçilmemiştir!");
                        return;
                    }

                    if (Convert.ToInt32(kitap.Value) < 0)
                    {
                        MessageBox.Show("Kitap seçilmemiştir!");
                        return;
                    }
                    var adisoyadi = DropDownList_adsoyad.SelectedItem as ListItem;
                    if (adisoyadi == null)
                    {
                        MessageBox.Show("Öğrenci seçilmemiştir!");
                        return;
                    }

                    if (Convert.ToInt32(adisoyadi.Value) < 0)
                    {
                        MessageBox.Show("Öğrenci seçilmemiştir!");
                        return;
                    }

                    var insertSqlWithPar = "Insert Into Odunc (KitapID,OgrenciID,VerilmeTarihi,IadeEdecegiTarih,IadeEdildiMi) values (@KitapID,@OgrenciID,@VerilmeTarihi,@IadeEdecegiTarih,@IadeEdildiMi)";

                    var pars = new Dictionary<string, object>();
                    pars.Add("@KitapID", kitap.Value);
                    pars.Add("@OgrenciID", adisoyadi.Value);
                    pars.Add("@VerilmeTarihi", txtVerilmeTarihi.Text);
                    pars.Add("@IadeEdecegiTarih", txtIadeTarihi.Text);
                    pars.Add("@IadeEdildiMi", iadeEdildiMi);

                    _dbHelper.Execute(insertSqlWithPar, pars);
                    veriGetir();
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
                    if (CheckBox_Odunc.Checked)
                    {
                        iadeEdildiMi = 1;
                    }

                    var kitap = DropDownList_Verilenkitap.SelectedItem as ListItem;
                    if (kitap == null)
                    {
                        MessageBox.Show("Kitap seçilmemiştir!");
                        return;
                    }

                    if (Convert.ToInt32(kitap.Value) < 0)
                    {
                        MessageBox.Show("Kitap seçilmemiştir!");
                        return;
                    }
                    var adisoyadi =DropDownList_adsoyad.SelectedItem as ListItem;
                    if (adisoyadi == null)
                    {
                        MessageBox.Show("Öğrenci seçilmemiştir!");
                        return;
                    }

                    if (Convert.ToInt32(adisoyadi.Value) < 0)
                    {
                        MessageBox.Show("Öğrenci seçilmemiştir!");
                        return;
                    }


                    var updateSql =
                        "UPDATE Odunc SET VerilmeTarihi=@VerilmeTarihi,IadeEdecegiTarih=@IadeEdecegiTarih,OgrenciID=@OgrenciID,KitapID=@KitapID,IadeEdildiMi=@IadeEdildiMi WHERE OduncID=@OduncID";

                    var pars = new Dictionary<string, object>();
                    pars.Add("@KitapID", kitap.Value);
                    pars.Add("@OgrenciID", adisoyadi.Value);
                    //pars.Add("@VerilmeTarihi", dateTimePicker_verilme.Value);
                   // pars.Add("@IadeEdecegiTarih", dateTimePicker_iade.Value);
                    pars.Add("@IadeEdildiMi", iadeEdildiMi);
                    pars.Add("@OduncID", OduncId);
                    _dbHelper.Execute(updateSql, pars);

                    veriGetir();

                }
                else
                {
                    MessageBox.Show("Lütfen Seçim Yapınız!");
                }
            }
        }

        protected void ButtonOdunc_Temizle_Click(object sender, EventArgs e)
        {
            DropDownList_adsoyad.Text = "Seçiniz";
            DropDownList_Verilenkitap.Text = "Seçiniz";
            ButtonOdunc_EKLE.Text = "EKLE";
            CheckBox_Odunc.Checked = false;
            CheckBox_Odunc.Visible = false;
        }
        private void FillCmbOgrenci()
        {
            DropDownList_adsoyad.Items.Clear();
            var seciniz = new ListItem
            {
                Value = "-1",
                Text = "Seçiniz"
            };
            DropDownList_adsoyad.Items.Add(seciniz);

            var dtOgrenciler = _dbHelper.GetDataTable("Select * from ogrenci where IsDeleted=0  order by OgrenciAdi,OgrenciSoyadi");
            foreach (DataRow dr in dtOgrenciler.Rows)
            {

                var listItem = new ListItem
                {
                    Value = (dr["OgrenciID"]).ToString(),
                    Text = dr["OgrenciAdi"].ToString() + " " + dr["OgrenciSoyadi"].ToString()
                };
                DropDownList_adsoyad.Items.Add(listItem);
            }

            DropDownList_adsoyad.SelectedIndex = 0;
        }
        private void FillCmbKitap()
        {
            DropDownList_Verilenkitap.Items.Clear();
            var seciniz = new ListItem
            {
                Value = "-1",
                Text = "Seçiniz"
            };
            DropDownList_Verilenkitap.Items.Add(seciniz);

            DataTable dtKitaplar = _dbHelper.GetDataTable("SELECT * FROM Kitap where IsDeleted=0 order by KitapAdi");
            foreach (DataRow dr in dtKitaplar.Rows)
            {
                var listItem = new ListItem
                {
                    Value = dr["KitapID"].ToString(),
                    Text = dr["KitapAdi"].ToString()
                };
                DropDownList_Verilenkitap.Items.Add(listItem);
            }


            DropDownList_Verilenkitap.SelectedIndex = 0;
        }

        protected void GridView1_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Duzenle")
            {

                OduncId = e.CommandArgument.ToString();
                DataTable dt = _dbHelper.GetDataTable("Select * From Odunc Where OduncID=" + OduncId);
                DropDownList_adsoyad.Text = dt.Rows[0]["OgrenciAdi"].ToString();
                DropDownList_Verilenkitap.Text = dt.Rows[0]["KitapAdi"].ToString();
                txtIadeTarihi.Text = dt.Rows[0]["IadeEdecegiTarih"].ToString();
                txtVerilmeTarihi.Text = dt.Rows[0]["VerilmeTarihi"].ToString();

                var isDeleted = dt.Rows[0]["IsDeleted"].ToString();
                if (isDeleted == "1")
                {
                    CheckBox_Odunc.Checked = true;
                }
                else
                {
                    CheckBox_Odunc.Checked = false;

                }
                ButtonOdunc_EKLE.Text = "GÜNCELLE";


            }
        }
    }
}