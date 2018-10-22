using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using KutuphaneData.Models;


namespace Umit_AKINCI_KutuphaneProjesi
{
    //*********************ÖĞRENCİ TANIMLAMA*******************
    public partial class FrmOgrenci : Form
    {
        public string id;
        public string ogrenciNo;
        public string tcNo; 
        private Helper _helper;
        private DbHelper _dbHelper;
        OpenFileDialog fd = new OpenFileDialog();
        private void veriGetir()
        
        {
            DataTable dt = _dbHelper.GetDataTable("SELECT * FROM Vwogrencibolumu ORDER BY OgrenciAdi");
            dataGridView1.DataSource = dt;
            
        }

        private void resimKayit()
        {
           
            var exeFolder = Application.StartupPath;
            var imagePath = exeFolder + @"\Photos\" + textBox_tckimlikno.Text + ".jpeg";
                if (File.Exists(imagePath))//Dosyanın varlığını kontrol ettik.
                {
                    File.Delete(imagePath);//Dosya eğer varsa sil.Sonra güncelleme işlemlerini yap.
                    pictureBox1.Image = new Bitmap(fd.OpenFile());
                    //gelen resmi temp dosyasına yükle
                    File.Copy(fd.FileName, imagePath);
                    
                }
                else
                {
                    pictureBox1.Image = new Bitmap(fd.OpenFile());
                    //gelen resmi temp dosyasına yükle
                    File.Copy(fd.FileName, imagePath);
                }
           
        }

        public FrmOgrenci()
        {
            InitializeComponent();
            _helper = new Helper();
            _dbHelper = new DbHelper();
        }
        private void Form6_Load(object sender, EventArgs e)
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
            dataGridView1.Columns[0].Visible = false; //OgrenciID yi gizledik.
            dataGridView1.Columns[1].Visible = false; //BolumID yi gizledik.
            //dataGridView1.Columns[8].Visible = false;  //Isdeleted ı gizledik.

            //Bolum tablosundaki BolumAdi ni combobox a çektik.
            FillCmbBolum();
        }

        private bool AlanlariKontorlEt()
        {
            if (textBox_Ogrenci.Text.Trim() == "" && textBox_ogrencisoyadi.Text.Trim() == "")
            {
                return false;
            }

            return true;
        }

        private void FillCmbBolum()
        {
            comboBox1.Items.Clear();
            var seciniz = new ListItem
            {
                Id = -1,
                Name = "Seçiniz"
            };
            comboBox1.Items.Add(seciniz);

            var dtBolum = _dbHelper.GetDataTable("SELECT * FROM Bolum where IsDeleted=0 order by BolumAdi");
            foreach (DataRow dr in dtBolum.Rows)
            {

                var listItem = new ListItem
                {
                    Id = Convert.ToInt32(dr["BolumID"]),
                    Name = dr["BolumAdi"].ToString()
                };
                comboBox1.Items.Add(listItem);
            }

            comboBox1.SelectedIndex = 0;
        }

        private bool KayitVarMi() //Aynı kayıtın tekrar eklenmesini engelledik
        {

            try
            {
                if (buttonEkleGuncelleOgrenci.Text == "EKLE")
                {
                    string varmi = "Select Count(*) From Ogrenci Where OgrenciNo=@OgrenciNo";
                    var pars = new Dictionary<string, object>();
                    pars.Add("@OgrenciNo", textBox_ogrencino.Text);
                    pars.Add("@TCKimlikNo", textBox_tckimlikno.Text);
                    int sayi = _dbHelper.ExecuteScalar(varmi, pars);

                    if (sayi != 0)
                    {
                        return true;
                    }
                }
                else
                {
                    string varmi = "Select Count(*) From Ogrenci Where OgrenciNo=@OgrenciNo AND OgrenciID<>@OgrenciID";
                    var pars = new Dictionary<string, object>();
                    pars.Add("@OgrenciNo", textBox_ogrencino.Text);
                    pars.Add("@TCKimlikNo", textBox_tckimlikno.Text);
                    pars.Add("@OgrenciID", id);
                    
                    

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
        
        private void buttonEkleGuncelleOgrenci_Click(object sender, EventArgs e)
        {
           
            //gelen resmi temp dosyasına yükle 
            //button text i ekle ise ekleme 
            //Güncelle ise güncelleme olacak
            if (buttonEkleGuncelleOgrenci.Text == "EKLE")
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
                    if (checkBox_Ogrenci.Checked)
                    {
                        isDeleted = 1;
                    }

                    var bolum = comboBox1.SelectedItem as ListItem;
                    if (bolum == null)
                    {
                        MessageBox.Show("Bölüm seçilmemiştir!");
                        return;
                    }

                    if (bolum.Id < 0)
                    {
                        MessageBox.Show("Bölüm seçilmemiştir!");
                        return;
                    }
                    if (fd.FileName == "")
                    {
                        MessageBox.Show("Lütfen fotoğraf seçiniz!");
                        return;
                    }

                        var insertSqlWithPar =
                            "Insert Into Ogrenci(OgrenciAdi,OgrenciSoyadi,BolumID,OgrenciNo,TCKimlikNo,TelefonNo,IsDeleted,FotoAdi) values (@OgrenciAdi,@OgrenciSoyadi,@BolumID,@OgrenciNo,@TCKimlikNo,@TelefonNo,@IsDeleted,@FotoAdi)";
                        var pars = new Dictionary<string, object>();
                        pars.Add("@OgrenciAdi", textBox_Ogrenci.Text);
                        pars.Add("@OgrenciSoyadi", textBox_ogrencisoyadi.Text);
                        pars.Add("@BolumID", bolum.Id);
                        pars.Add("@OgrenciNo", textBox_ogrencino.Text);
                        pars.Add("@TCKimlikNo", textBox_tckimlikno.Text);
                        pars.Add("@TelefonNo", textBox_telefonno.Text);
                        pars.Add("@IsDeleted", isDeleted);
                        pars.Add("@FotoAdi", textBox_tckimlikno.Text + ".jpeg");
                        _dbHelper.Execute(insertSqlWithPar, pars);
                        resimKayit();
                        veriGetir();
                }
                else
                {
                    MessageBox.Show("Alanlar boş bırakılamaz!");
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
                    if (checkBox_Ogrenci.Checked)
                    {
                        isDeleted = 1;
                    }

                    var bolum = comboBox1.SelectedItem as ListItem;
                    if (bolum == null)
                    {
                        MessageBox.Show("Bölüm seçilmemiştir!");
                        return;
                    }

                    if (bolum.Id < 0)
                    {
                        MessageBox.Show("Bölüm seçilmemiştir!");
                        return;
                    }
                    var pars = new Dictionary<string, object>();
                    var updateSql =
                        "UPDATE Ogrenci SET OgrenciAdi=@OgrenciAdi,OgrenciSoyadi=@OgrenciSoyadi,BolumID=@BolumID,OgrenciNo=@OgrenciNo,TCKimlikNo=@TCKimlikNo,TelefonNo=@TelefonNo,IsDeleted=@IsDeleted,FotoAdi=@FotoAdi WHERE OgrenciID=@Ogrenciid";
                    pars.Add("@OgrenciAdi", textBox_Ogrenci.Text);
                    pars.Add("@OgrenciSoyadi", textBox_ogrencisoyadi.Text);
                    pars.Add("@BolumID", bolum.Id);
                    pars.Add("@OgrenciNo", textBox_ogrencino.Text);
                    pars.Add("@TCKimlikNo", textBox_tckimlikno.Text);
                    pars.Add("@TelefonNo", textBox_telefonno.Text);
                    pars.Add("@Ogrenciid", id);
                    pars.Add("@IsDeleted", isDeleted);
                    pars.Add("@FotoAdi", textBox_tckimlikno.Text + ".jpeg");
                    _dbHelper.Execute(updateSql, pars);
                    if (fd.FileName == "")
                    {
                        MessageBox.Show("Güncelleme gerçekleşti!");
                    }
                    else
                    {
                        resimKayit();
                    }
                    veriGetir();

                }
                else
                {
                    MessageBox.Show("Alanlar boş bırakılamaz!");
                }
            }
        }

        private void buttonTemizleOgrenci_Click(object sender, EventArgs e)
        {
            textBox_Ogrenci.Clear();
            textBox_ogrencisoyadi.Clear();
            textBox_ogrencino.Clear();
            textBox_tckimlikno.Clear();
            textBox_telefonno.Clear();
            fd.FileName= null;
            pictureBox1.Image = null;
            comboBox1.Text = "Seçiniz";
            checkBox_Ogrenci.Checked = false;
            buttonEkleGuncelleOgrenci.Text = "EKLE";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dataGridView1.Columns[""].Index && e.RowIndex >= 0)
            {
                ogrenciNo = dataGridView1.Rows[e.RowIndex].Cells["OgrenciNo"].Value.ToString();
                tcNo = dataGridView1.Rows[e.RowIndex].Cells["TCKimlikNo"].Value.ToString();
                id = dataGridView1.Rows[e.RowIndex].Cells["OgrenciID"].Value.ToString(); //ogrenciid
                var bolumId = dataGridView1.Rows[e.RowIndex].Cells["BolumID"].Value.ToString();
                _helper.SelectCmb(comboBox1, int.Parse(bolumId));
                //bu bölüm id ile comboboxda bolum adını seçmemiz lazım

                textBox_Ogrenci.Text = dataGridView1.Rows[e.RowIndex].Cells["OgrenciAdi"].Value.ToString();
                textBox_ogrencisoyadi.Text = dataGridView1.Rows[e.RowIndex].Cells["OgrenciSoyadi"].Value.ToString();
                textBox_ogrencino.Text = dataGridView1.Rows[e.RowIndex].Cells["OgrenciNo"].Value.ToString();
                textBox_tckimlikno.Text = dataGridView1.Rows[e.RowIndex].Cells["TCKimlikNo"].Value.ToString();
                textBox_telefonno.Text = dataGridView1.Rows[e.RowIndex].Cells["TelefonNo"].Value.ToString();
                buttonEkleGuncelleOgrenci.Text = "GÜNCELLE";
                var exeFolder = Application.StartupPath;
                var imagePath = exeFolder + @"\Photos\" + textBox_tckimlikno.Text + ".jpeg";
                pictureBox1.ImageLocation = imagePath;

                checkBox_Ogrenci.Checked = dataGridView1.Rows[e.RowIndex].Cells["IsDeleted"].Value.ToString() == "1"
                    ? true
                    : false;

            }
        }

        private void textBox_telefonno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);//Sadece sayı girilsin
        }

        private void textBox_tckimlikno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);//Sadece sayı girilsin
        }

        private void textBox_ogrencino_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);//Sadece sayı girilsin
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

        private void buttonResim_Click(object sender, EventArgs e)
        {
            //var exeFolder = Application.StartupPath;
            //var imagePath = exeFolder + @"\Photos\" + textBox_tckimlikno.Text + ".jpeg";
            //if (buttonEkleGuncelleOgrenci.Text == "GÜNCELLE")
            //{
            //    if (File.Exists(imagePath))//Dosyanın varlığını kontrol ettik.
            //    {
            //        File.Delete(imagePath);//Dosya eğer varsa sil.Sonra güncelleme işlemlerini yap.
            //        OpenFileDialog fd = new OpenFileDialog();
            //        fd.Title = "Resim Seç";
            //        if (fd.ShowDialog() == DialogResult.OK)
            //        {
            //            pictureBox1.Image = new Bitmap(fd.OpenFile());
            //            //gelen resmi temp dosyasına yükle
            //            File.Copy(fd.FileName, imagePath);
            //        }
            //    }
            //}
            //else if (buttonEkleGuncelleOgrenci.Text == "EKLE")
            //{
            //    OpenFileDialog fd = new OpenFileDialog();
            //    fd.Title = "Resim Seç";
            //    if (fd.ShowDialog() == DialogResult.OK)
            //    {
            //        pictureBox1.Image = new Bitmap(fd.OpenFile());
            //        //gelen resmi temp dosyasına yükle
            //        File.Copy(fd.FileName, imagePath);
            //    }
            //}
            try
            {
                fd.Title = "Resim Seç";
                fd.Filter = "|*.jpg";
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(fd.OpenFile());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Yanlış dosya türü seçildi!");
            }
                

        }

        private void textBox_Ogrenci_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)//Sadece harf girilsin
                 && !char.IsSeparator(e.KeyChar);
        }

        private void textBox_ogrencisoyadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)//Sadece harf girilsin
                 && !char.IsSeparator(e.KeyChar);
        }
    }
}