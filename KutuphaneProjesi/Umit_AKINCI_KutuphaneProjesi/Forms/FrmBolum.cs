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
    //***********************************BÖLÜM TANIMLAMA****************************************
    public partial class FrmBolum : Form
    {
        public string id;
        private DbHelper _dbHelper;
        public FrmBolum()
        {
            InitializeComponent();
            _dbHelper=new DbHelper();
        }
      
        private void veriGetir()
        {
            DataTable dt = _dbHelper.GetDataTable("Select * From Bolum ORDER BY BolumAdi");
            dataGridView1.DataSource = dt;
        }
        private bool AlanlariKontorlEt()
        {
            if (txtBolumAdi.Text.Trim() == "")
            {
                return false;
            }

            return true;
        }
        private void Form2_Load(object sender, EventArgs e)
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
            dataGridView1.Columns[0].Visible = false;//BolumID yi gizledik
            //dataGridView1.Columns[2].Visible = false;//Isdeleted ı gizledik
	
           
        }

        private bool KayitVarMi()//Aynı kayıtın tekrar eklenmesini engelledik
        {
            try
            {
                if (buttonEkleGuncelleBolum.Text == "EKLE")
                {
                    string varmi = "Select Count(*) From Bolum Where BolumAdi=@BolumAdi";

                    var pars = new Dictionary<string, object>();
                    pars.Add("@BolumAdi", txtBolumAdi.Text.Trim());

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
                    pars.Add("@BolumAdi", txtBolumAdi.Text.Trim());
                    pars.Add("@BolumID", id);
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
        private void buttonEkleGuncelleBolum_Click(object sender, EventArgs e)
        {
            //button text i ekle ekleme 
            //Güncelle ise güncelleme olacak

            if (buttonEkleGuncelleBolum.Text == "EKLE")
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
                    if (checkBoxBolum.Checked)
                    {
                        isDeleted = 1;
                    }

                    var insertSqlWithPar = "Insert Into Bolum (BolumAdi,IsDeleted) values (@Ad,@IsDeleted)";
                    var pars = new Dictionary<string, object>();
                    pars.Add("@Ad", txtBolumAdi.Text);
                    pars.Add("@IsDeleted", isDeleted);
                    _dbHelper.Execute(insertSqlWithPar, pars);
                    veriGetir();
                }
                else
                {
                    MessageBox.Show("Bölüm boş bırakılamaz!");
                }

           }
            else if (buttonEkleGuncelleBolum.Text=="GÜNCELLE")
           {
                //Güncelleme yapılacak
                //Ekleme yapılacak
               if (KayitVarMi())
               {
                   MessageBox.Show("Böyle bir kayıt zaten mevcut!");
                   return;
               }
                
                bool kontrol = AlanlariKontorlEt();
                if (kontrol)
                {
                   
                    var isDeleted = 0;
                    if (checkBoxBolum.Checked)
                    {
                        isDeleted = 1;
                    }

                    var updateSql =
                       "UPDATE Bolum SET BolumAdi=@Ad,IsDeleted=@IsDeleted WHERE BolumID=@id";;

                    var pars = new Dictionary<string, object>();
                    pars.Add("@Ad", txtBolumAdi.Text);
                    pars.Add("@id", id);
                    pars.Add("@IsDeleted", isDeleted);
                    _dbHelper.Execute(updateSql, pars);
                    veriGetir();

                }
                else
                {
                    MessageBox.Show("Bölüm boş bırakılamaz");
                }
            }
        }

        private void buttonBolumTemizle_Click(object sender, EventArgs e)
        {
            txtBolumAdi.Clear();
            checkBoxBolum.Checked = false;
            buttonEkleGuncelleBolum.Text = "EKLE";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns[""].Index && e.RowIndex >= 0)
            {
                id = dataGridView1.Rows[e.RowIndex].Cells["BolumID"].Value.ToString();
                txtBolumAdi.Text = dataGridView1.Rows[e.RowIndex].Cells["BolumAdi"].Value.ToString();
                buttonEkleGuncelleBolum.Text = "GÜNCELLE";
                checkBoxBolum.Checked = dataGridView1.Rows[e.RowIndex].Cells["IsDeleted"].Value.ToString() == "1" ? true : false;
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //IsDeleted 'Evet','Hayır' ataması yaptık
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "Isdeleted")
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

        private void txtBolumAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)//Sadece harf girilsin
                 && !char.IsSeparator(e.KeyChar);
        }
    }
}
