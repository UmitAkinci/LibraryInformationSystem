using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using KutuphaneData.Models;
using ListItem = System.Web.UI.WebControls.ListItem;

namespace KutuphaneWeb
{
    public partial class Ogrenciler : System.Web.UI.Page
    {
        private DbHelper _dbHelper = new DbHelper();
        public string ogrenciNo;
        public string tcNo; 
        public string OgrenciId
        {
            get
            {
                if (ViewState["OgrenciId"] != null)
                {
                    return ViewState["OgrenciId"].ToString();
                }
                return "";
            }
            set { ViewState["OgrenciId"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                veriGetir();
            }
            FillCmbBolum();
        }
        private bool AlanlariKontorlEt()
        {
            if (textBox_ogrenci.Text.Trim() == "")
            {
                return false;
            }

            return true;
        }

        protected void ButtonOgrenci_EKLE_Click(object sender, EventArgs e)
        {
             //button text i ekle ekleme 
            //Güncelle ise güncelleme olacak
            if (ButtonOgrenci_EKLE.Text == "EKLE")
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
                    if (CheckBox_Ogrenci.Checked)
                    {
                        isDeleted = 1;
                    }
                   var bolum = DropDownList_Bolum.SelectedItem as ListItem;
                    if (bolum == null)
                    {
                        MessageBox.Show("Bölüm seçilmemiştir!");
                        return;
                    }

                    if (Convert.ToInt32(bolum.Value) < 0)
                    {
                        MessageBox.Show("Bölüm seçilmemiştir!");
                        return;
                    }

                    var insertSqlWithPar =
                            "Insert Into Ogrenci(OgrenciAdi,OgrenciSoyadi,BolumID,OgrenciNo,TCKimlikNo,TelefonNo,IsDeleted,FotoAdi) values (@OgrenciAdi,@OgrenciSoyadi,@BolumID,@OgrenciNo,@TCKimlikNo,@TelefonNo,@IsDeleted,@FotoAdi)";
                        var pars = new Dictionary<string, object>();
                        pars.Add("@OgrenciAdi", textBox_ogrenci.Text);
                        pars.Add("@OgrenciSoyadi", textBox_ogrencisoyadi.Text);
                        pars.Add("@BolumID", bolum.Value);
                        pars.Add("@OgrenciNo", textBox_ogrencino.Text);
                        pars.Add("@TCKimlikNo", textBox_tckimlikno.Text);
                        pars.Add("@TelefonNo", textBox_telefonno.Text);
                        pars.Add("@IsDeleted", isDeleted);
                        pars.Add("@FotoAdi", textBox_tckimlikno.Text + ".jpeg");
                    _dbHelper.Execute(insertSqlWithPar, pars);
                    veriGetir();
                }
                else
                {
                    MessageBox.Show("Alanlar boş bırakalamaz!");
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
                    if (CheckBox_Ogrenci.Checked)
                    {
                        isDeleted = 1;
                    }
                    var bolum = DropDownList_Bolum.SelectedItem as ListItem;
                    if (bolum == null)
                    {
                        MessageBox.Show("Bölüm seçilmemiştir!");
                        return;
                    }

                    if (Convert.ToInt32(bolum.Value) < 0)
                    {
                        MessageBox.Show("Bölüm seçilmemiştir!");
                        return;
                    }

                    var pars = new Dictionary<string, object>();
                    var updateSql =
                        "UPDATE Ogrenci SET OgrenciAdi=@OgrenciAdi,OgrenciSoyadi=@OgrenciSoyadi,BolumID=@BolumID,OgrenciNo=@OgrenciNo,TCKimlikNo=@TCKimlikNo,TelefonNo=@TelefonNo,IsDeleted=@IsDeleted,FotoAdi=@FotoAdi WHERE OgrenciID=@Ogrenciid";
                    pars.Add("@OgrenciAdi", textBox_ogrenci.Text);
                    pars.Add("@OgrenciSoyadi", textBox_ogrencisoyadi.Text);
                    pars.Add("@BolumID", bolum.Value);
                    pars.Add("@OgrenciNo", textBox_ogrencino.Text);
                    pars.Add("@TCKimlikNo", textBox_tckimlikno.Text);
                    pars.Add("@TelefonNo", textBox_telefonno.Text);
                    pars.Add("@Ogrenciid", OgrenciId);
                    pars.Add("@IsDeleted", isDeleted);
                    pars.Add("@FotoAdi", textBox_tckimlikno.Text + ".jpeg");
                    _dbHelper.Execute(updateSql, pars);
                    veriGetir();

                }
                else
                {
                    MessageBox.Show("Alanlar boş bırakılamaz!");
                }
            }
        }
        private void FillCmbBolum()
        {
            DropDownList_Bolum.Items.Clear();
            var seciniz = new ListItem
            {
                Value = "-1",
                Text = "Seçiniz"
            };
            DropDownList_Bolum.Items.Add(seciniz);

            var dtBolum = _dbHelper.GetDataTable("SELECT * FROM Bolum where IsDeleted=0 order by BolumAdi");
            foreach (DataRow dr in dtBolum.Rows)
            {

                var listItem = new ListItem
                {
                    Value = (dr["BolumID"]).ToString(),
                    Text = dr["BolumAdi"].ToString()
                };
                DropDownList_Bolum.Items.Add(listItem);
            }

            DropDownList_Bolum.SelectedIndex = 0;
        }
        private bool KayitVarMi()//Aynı kayıtın tekrar eklenmesini engelledik
        {
            try
            {
                if (ButtonOgrenci_EKLE.Text == "EKLE")
                {
                    string varmi = "Select Count(*) From Ogrenci Where OgrenciAdi=@OgrenciAdi";

                    var pars = new Dictionary<string, object>();
                    pars.Add("@OgrenciAdi", textBox_ogrenci.Text.Trim());
                    pars.Add("@TCKimlikNo", textBox_tckimlikno.Text);

                    int sayi = _dbHelper.ExecuteScalar(varmi, pars);

                    if (sayi != 0)
                    {
                        return true;
                    }
                }
                else
                {
                    string varmi = "Select Count(*) From Ogrenci Where OgrenciAdi=@OgrenciAdi AND OgrenciID<>@OgrenciID";

                    var pars = new Dictionary<string, object>();
                    pars.Add("@OgrenciAdi", textBox_ogrenci.Text.Trim());
                    pars.Add("@OgrenciID", OgrenciId);

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
        private void veriGetir()
        {
            DataTable dt = _dbHelper.GetDataTable("Select * From Vwogrencibolumu ORDER BY OgrenciAdi");
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Duzenle")
            {

                OgrenciId = e.CommandArgument.ToString();
                DataTable dt = _dbHelper.GetDataTable("Select * From Ogrenci Where OgrenciID=" + OgrenciId);

                OgrenciId = dt.Rows[0]["OgrenciID"].ToString();
                tcNo = dt.Rows[0]["TCKimlikNo"].ToString();
                var bolumId = dt.Rows[0]["BolumID"].ToString();
                //_helper.Select(DropDownList_Bolum, int.Parse(bolumId));
                textBox_ogrenci.Text = dt.Rows[0]["OgrenciAdi"].ToString();
                textBox_ogrencisoyadi.Text = dt.Rows[0]["OgrenciSoyadi"].ToString();
                textBox_ogrencino.Text = dt.Rows[0]["OgrenciNo"].ToString();
                textBox_tckimlikno.Text = dt.Rows[0]["TCKimlikNo"].ToString();
                textBox_telefonno.Text = dt.Rows[0]["TelefonNo"].ToString();
                DropDownList_Bolum.SelectedItem.Value = dt.Rows[0]["BolumID"].ToString();


                var isDeleted = dt.Rows[0]["IsDeleted"].ToString();
                if (isDeleted == "1")
                {
                    CheckBox_Ogrenci.Checked = true;
                }
                else
                {
                    CheckBox_Ogrenci.Checked = false;

                }
                ButtonOgrenci_EKLE.Text = "GÜNCELLE";


            }
        }

        protected void ButtonOgrenci_Temizle_Click(object sender, EventArgs e)
        {
            textBox_telefonno.Text = "";
            textBox_ogrenci.Text = "";
            textBox_tckimlikno.Text = "";
            textBox_ogrencisoyadi.Text = "";
            textBox_ogrencino.Text = "";
            CheckBox_Ogrenci.Checked = false;
            ButtonOgrenci_EKLE.Text = "EKLE";
            FileUpload1= null;
            Image1.ImageUrl = null;
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button_Resim_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                FileUpload1.SaveAs(MapPath("PhotosWeb/"+FileUpload1.FileName));
                Image1.ImageUrl = "PhotosWeb/" + FileUpload1.FileName;
            }
        }
    }
}