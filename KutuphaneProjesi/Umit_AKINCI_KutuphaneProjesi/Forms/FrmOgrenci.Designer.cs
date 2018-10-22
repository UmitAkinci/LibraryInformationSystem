namespace Umit_AKINCI_KutuphaneProjesi
{
    partial class FrmOgrenci
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrenci));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Ogrenci = new System.Windows.Forms.TextBox();
            this.checkBox_Ogrenci = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ogrencisoyadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_ogrencino = new System.Windows.Forms.TextBox();
            this.textBox_tckimlikno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_telefonno = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonResim = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonEkleGuncelleOgrenci = new System.Windows.Forms.Button();
            this.buttonTemizleOgrenci = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Adı :";
            // 
            // textBox_Ogrenci
            // 
            this.textBox_Ogrenci.Location = new System.Drawing.Point(117, 6);
            this.textBox_Ogrenci.MaxLength = 40;
            this.textBox_Ogrenci.Name = "textBox_Ogrenci";
            this.textBox_Ogrenci.Size = new System.Drawing.Size(116, 20);
            this.textBox_Ogrenci.TabIndex = 1;
            this.textBox_Ogrenci.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Ogrenci_KeyPress);
            // 
            // checkBox_Ogrenci
            // 
            this.checkBox_Ogrenci.AutoSize = true;
            this.checkBox_Ogrenci.Location = new System.Drawing.Point(268, 113);
            this.checkBox_Ogrenci.Name = "checkBox_Ogrenci";
            this.checkBox_Ogrenci.Size = new System.Drawing.Size(92, 17);
            this.checkBox_Ogrenci.TabIndex = 10;
            this.checkBox_Ogrenci.Text = "Silinmiş Mi?";
            this.checkBox_Ogrenci.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(656, 318);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Öğrenci Soyadi :";
            // 
            // textBox_ogrencisoyadi
            // 
            this.textBox_ogrencisoyadi.Location = new System.Drawing.Point(117, 34);
            this.textBox_ogrencisoyadi.MaxLength = 40;
            this.textBox_ogrencisoyadi.Name = "textBox_ogrencisoyadi";
            this.textBox_ogrencisoyadi.Size = new System.Drawing.Size(116, 20);
            this.textBox_ogrencisoyadi.TabIndex = 2;
            this.textBox_ogrencisoyadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ogrencisoyadi_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Öğrenci Numarası :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "T.C Kimlik Numarası :";
            // 
            // textBox_ogrencino
            // 
            this.textBox_ogrencino.Location = new System.Drawing.Point(117, 64);
            this.textBox_ogrencino.MaxLength = 11;
            this.textBox_ogrencino.Name = "textBox_ogrencino";
            this.textBox_ogrencino.Size = new System.Drawing.Size(116, 20);
            this.textBox_ogrencino.TabIndex = 3;
            this.textBox_ogrencino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ogrencino_KeyPress);
            // 
            // textBox_tckimlikno
            // 
            this.textBox_tckimlikno.Location = new System.Drawing.Point(400, 37);
            this.textBox_tckimlikno.MaxLength = 11;
            this.textBox_tckimlikno.Name = "textBox_tckimlikno";
            this.textBox_tckimlikno.Size = new System.Drawing.Size(116, 20);
            this.textBox_tckimlikno.TabIndex = 5;
            this.textBox_tckimlikno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_tckimlikno_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Telefon Numarası :";
            // 
            // textBox_telefonno
            // 
            this.textBox_telefonno.Location = new System.Drawing.Point(400, 67);
            this.textBox_telefonno.MaxLength = 11;
            this.textBox_telefonno.Name = "textBox_telefonno";
            this.textBox_telefonno.Size = new System.Drawing.Size(116, 20);
            this.textBox_telefonno.TabIndex = 6;
            this.textBox_telefonno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_telefonno_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(400, 1);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(344, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Bölüm :";
            // 
            // buttonResim
            // 
            this.buttonResim.Location = new System.Drawing.Point(545, 107);
            this.buttonResim.Name = "buttonResim";
            this.buttonResim.Size = new System.Drawing.Size(109, 23);
            this.buttonResim.TabIndex = 7;
            this.buttonResim.Text = "Resim Seç";
            this.buttonResim.UseVisualStyleBackColor = true;
            this.buttonResim.Click += new System.EventHandler(this.buttonResim_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleName = "";
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.ErrorImage = global::Umit_AKINCI_KutuphaneProjesi.Properties.Resources.untitled;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(546, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "";
            // 
            // buttonEkleGuncelleOgrenci
            // 
            this.buttonEkleGuncelleOgrenci.Image = global::Umit_AKINCI_KutuphaneProjesi.Properties.Resources.math_add_icon;
            this.buttonEkleGuncelleOgrenci.Location = new System.Drawing.Point(135, 90);
            this.buttonEkleGuncelleOgrenci.Name = "buttonEkleGuncelleOgrenci";
            this.buttonEkleGuncelleOgrenci.Size = new System.Drawing.Size(127, 48);
            this.buttonEkleGuncelleOgrenci.TabIndex = 8;
            this.buttonEkleGuncelleOgrenci.Text = "EKLE";
            this.buttonEkleGuncelleOgrenci.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEkleGuncelleOgrenci.UseVisualStyleBackColor = true;
            this.buttonEkleGuncelleOgrenci.Click += new System.EventHandler(this.buttonEkleGuncelleOgrenci_Click);
            // 
            // buttonTemizleOgrenci
            // 
            this.buttonTemizleOgrenci.Image = global::Umit_AKINCI_KutuphaneProjesi.Properties.Resources.temizle;
            this.buttonTemizleOgrenci.Location = new System.Drawing.Point(12, 91);
            this.buttonTemizleOgrenci.Name = "buttonTemizleOgrenci";
            this.buttonTemizleOgrenci.Size = new System.Drawing.Size(117, 47);
            this.buttonTemizleOgrenci.TabIndex = 9;
            this.buttonTemizleOgrenci.Text = "Temizle";
            this.buttonTemizleOgrenci.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTemizleOgrenci.UseVisualStyleBackColor = true;
            this.buttonTemizleOgrenci.Click += new System.EventHandler(this.buttonTemizleOgrenci_Click);
            // 
            // FrmOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(666, 464);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonResim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox_telefonno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_tckimlikno);
            this.Controls.Add(this.textBox_ogrencino);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_ogrencisoyadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonEkleGuncelleOgrenci);
            this.Controls.Add(this.buttonTemizleOgrenci);
            this.Controls.Add(this.checkBox_Ogrenci);
            this.Controls.Add(this.textBox_Ogrenci);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOgrenci";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Öğrenci Tanımlama Ekranı";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Ogrenci;
        private System.Windows.Forms.CheckBox checkBox_Ogrenci;
        private System.Windows.Forms.Button buttonTemizleOgrenci;
        private System.Windows.Forms.Button buttonEkleGuncelleOgrenci;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ogrencisoyadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_ogrencino;
        private System.Windows.Forms.TextBox textBox_tckimlikno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_telefonno;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonResim;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}