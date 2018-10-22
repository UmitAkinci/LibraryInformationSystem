namespace Umit_AKINCI_KutuphaneProjesi
{
    partial class FrmAnaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaMenu));
            this.buttonOdunc = new System.Windows.Forms.Button();
            this.buttonOgrenci = new System.Windows.Forms.Button();
            this.buttonKitap = new System.Windows.Forms.Button();
            this.buttonBolum = new System.Windows.Forms.Button();
            this.buttonYazar = new System.Windows.Forms.Button();
            this.buttonKategori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOdunc
            // 
            this.buttonOdunc.Image = global::Umit_AKINCI_KutuphaneProjesi.Properties.Resources.Generate_tables_icon;
            this.buttonOdunc.Location = new System.Drawing.Point(523, 243);
            this.buttonOdunc.Name = "buttonOdunc";
            this.buttonOdunc.Size = new System.Drawing.Size(229, 163);
            this.buttonOdunc.TabIndex = 5;
            this.buttonOdunc.Text = "ÖDÜNÇ TABLOSU";
            this.buttonOdunc.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonOdunc.UseVisualStyleBackColor = true;
            this.buttonOdunc.Click += new System.EventHandler(this.buttonOdunc_Click);
            // 
            // buttonOgrenci
            // 
            this.buttonOgrenci.Image = global::Umit_AKINCI_KutuphaneProjesi.Properties.Resources._1470937396_elementary_school;
            this.buttonOgrenci.Location = new System.Drawing.Point(262, 243);
            this.buttonOgrenci.Name = "buttonOgrenci";
            this.buttonOgrenci.Size = new System.Drawing.Size(241, 163);
            this.buttonOgrenci.TabIndex = 4;
            this.buttonOgrenci.Text = "ÖĞRENCİ TANIMLAMA";
            this.buttonOgrenci.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonOgrenci.UseVisualStyleBackColor = true;
            this.buttonOgrenci.Click += new System.EventHandler(this.buttonOgrenci_Click_1);
            // 
            // buttonKitap
            // 
            this.buttonKitap.Image = global::Umit_AKINCI_KutuphaneProjesi.Properties.Resources._1470937315_Library;
            this.buttonKitap.Location = new System.Drawing.Point(14, 243);
            this.buttonKitap.Name = "buttonKitap";
            this.buttonKitap.Size = new System.Drawing.Size(235, 163);
            this.buttonKitap.TabIndex = 3;
            this.buttonKitap.Text = "KİTAP TANIMLAMA";
            this.buttonKitap.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonKitap.UseVisualStyleBackColor = true;
            this.buttonKitap.Click += new System.EventHandler(this.buttonKitap_Click_1);
            // 
            // buttonBolum
            // 
            this.buttonBolum.Image = global::Umit_AKINCI_KutuphaneProjesi.Properties.Resources._1470937218_app_type_university_512px_GREY;
            this.buttonBolum.Location = new System.Drawing.Point(523, 12);
            this.buttonBolum.Name = "buttonBolum";
            this.buttonBolum.Size = new System.Drawing.Size(229, 154);
            this.buttonBolum.TabIndex = 2;
            this.buttonBolum.Text = "BÖLÜM TANIMLAMA";
            this.buttonBolum.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonBolum.UseVisualStyleBackColor = true;
            this.buttonBolum.Click += new System.EventHandler(this.buttonBolum_Click);
            // 
            // buttonYazar
            // 
            this.buttonYazar.Image = global::Umit_AKINCI_KutuphaneProjesi.Properties.Resources._1470937126_Writer_Male_Light;
            this.buttonYazar.Location = new System.Drawing.Point(262, 12);
            this.buttonYazar.Name = "buttonYazar";
            this.buttonYazar.Size = new System.Drawing.Size(241, 154);
            this.buttonYazar.TabIndex = 1;
            this.buttonYazar.Text = "YAZAR TANIMLAMA";
            this.buttonYazar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonYazar.UseVisualStyleBackColor = true;
            this.buttonYazar.Click += new System.EventHandler(this.buttonYazar_Click);
            // 
            // buttonKategori
            // 
            this.buttonKategori.Image = global::Umit_AKINCI_KutuphaneProjesi.Properties.Resources._1470937019_x_office_address_book;
            this.buttonKategori.Location = new System.Drawing.Point(14, 12);
            this.buttonKategori.Name = "buttonKategori";
            this.buttonKategori.Size = new System.Drawing.Size(235, 154);
            this.buttonKategori.TabIndex = 0;
            this.buttonKategori.Text = "KATEGORİ TANIMLAMA";
            this.buttonKategori.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonKategori.UseVisualStyleBackColor = true;
            this.buttonKategori.Click += new System.EventHandler(this.buttonKategori_Click);
            // 
            // FrmAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(776, 485);
            this.Controls.Add(this.buttonOdunc);
            this.Controls.Add(this.buttonOgrenci);
            this.Controls.Add(this.buttonKitap);
            this.Controls.Add(this.buttonBolum);
            this.Controls.Add(this.buttonYazar);
            this.Controls.Add(this.buttonKategori);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAnaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane Ödünç Sistemi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonKategori;
        private System.Windows.Forms.Button buttonYazar;
        private System.Windows.Forms.Button buttonBolum;
        private System.Windows.Forms.Button buttonKitap;
        private System.Windows.Forms.Button buttonOgrenci;
        private System.Windows.Forms.Button buttonOdunc;
    }
}

