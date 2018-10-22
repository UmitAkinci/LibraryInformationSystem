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
    //***************************YAZAR TANIMLAMA**************************
    public partial class FrmYazar : Form
    {
        public string id;

        private DbHelper _dbHelper;
        public FrmYazar()
        {
            InitializeComponent();
            _dbHelper=new DbHelper();
        }
       
        private void veriGetir()
        {
            DataTable dt = _dbHelper.GetDataTable("Select * From Yazar ORDER BY Adi_Soyadi");
            dataGridView1.DataSource = dt;
        }
        private bool AlanlariKontorlEt()
        {
            if (textBox_Yazar.Text.Trim() == "")
            {
                return false;
            }

            return true;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            veriGetir();
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            Image image = Umit_AKINCI_KutuphaneProjesi.Properties.Resources.kalem;
            img.Image = image;
            dataGridView1.Columns.Add(img);
            img.HeaderText = "";
            img.Width = 65;
            img.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.Columns[0].Visible = false;//YazarID yi gizledik
            //dataGridView1.Columns[2].Visible = false;//Isdeleted ı gizledik
        }
        private bool KayitVarMi()//Aynı kayıtın tekrar eklenmesini engelledik
        {
            try
            {
                if (buttonYazarEkleGuncelle.Text == "EKLE")
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
                    pars.Add("@YazarID",id);

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
        private void buttonYazarEkleGuncelle_Click(object sender, EventArgs e)
        {
                //button text i ekle ekleme 
                //Güncelle ise güncelleme olacak
                if (buttonYazarEkleGuncelle.Text == "EKLE")
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
                        pars.Add("@Yazarid", id);
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
        private void buttonYazarTemizle_Click(object sender, EventArgs e)
        {
            textBox_Yazar.Clear();
            checkBox_Yazar.Checked = false;
            buttonYazarEkleGuncelle.Text = "EKLE";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns[""].Index && e.RowIndex >= 0)
            {
                id = dataGridView1.Rows[e.RowIndex].Cells["YazarID"].Value.ToString();
                textBox_Yazar.Text = dataGridView1.Rows[e.RowIndex].Cells["Adi_Soyadi"].Value.ToString();
                buttonYazarEkleGuncelle.Text = "GÜNCELLE";
                checkBox_Yazar.Checked = dataGridView1.Rows[e.RowIndex].Cells["IsDeleted"].Value.ToString() == "1" ? true : false;
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

        private void textBox_Yazar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)//Sadece harf girilsin
                 && !char.IsSeparator(e.KeyChar);
        }
    }
}
