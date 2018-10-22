namespace Umit_AKINCI_KutuphaneProjesi
{
    partial class FrmKitap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKitap));
            this.textBox_Kitap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_Kitap = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.comboBoxKategori = new System.Windows.Forms.ComboBox();
            this.comboBoxYazar = new System.Windows.Forms.ComboBox();
            this.buttonEkleGuncelleKitap = new System.Windows.Forms.Button();
            this.buttonTemizleKitap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Kitap
            // 
            this.textBox_Kitap.Location = new System.Drawing.Point(99, 6);
            this.textBox_Kitap.Name = "textBox_Kitap";
            this.textBox_Kitap.Size = new System.Drawing.Size(116, 20);
            this.textBox_Kitap.TabIndex = 1;
            this.textBox_Kitap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Kitap_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kitap Adı :";
            // 
            // checkBox_Kitap
            // 
            this.checkBox_Kitap.AutoSize = true;
            this.checkBox_Kitap.Location = new System.Drawing.Point(276, 92);
            this.checkBox_Kitap.Name = "checkBox_Kitap";
            this.checkBox_Kitap.Size = new System.Drawing.Size(91, 17);
            this.checkBox_Kitap.TabIndex = 6;
            this.checkBox_Kitap.Text = "Silinmiş mi?";
            this.checkBox_Kitap.UseVisualStyleBackColor = true;
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
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(637, 370);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kategori Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Yazar Adı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "ISBN :";
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(425, 33);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(116, 20);
            this.textBoxISBN.TabIndex = 4;
            // 
            // comboBoxKategori
            // 
            this.comboBoxKategori.FormattingEnabled = true;
            this.comboBoxKategori.Location = new System.Drawing.Point(99, 33);
            this.comboBoxKategori.Name = "comboBoxKategori";
            this.comboBoxKategori.Size = new System.Drawing.Size(140, 21);
            this.comboBoxKategori.TabIndex = 2;
            // 
            // comboBoxYazar
            // 
            this.comboBoxYazar.FormattingEnabled = true;
            this.comboBoxYazar.Location = new System.Drawing.Point(425, 1);
            this.comboBoxYazar.Name = "comboBoxYazar";
            this.comboBoxYazar.Size = new System.Drawing.Size(140, 21);
            this.comboBoxYazar.TabIndex = 3;
            // 
            // buttonEkleGuncelleKitap
            // 
            this.buttonEkleGuncelleKitap.Image = global::Umit_AKINCI_KutuphaneProjesi.Properties.Resources.math_add_icon1;
            this.buttonEkleGuncelleKitap.Location = new System.Drawing.Point(138, 60);
            this.buttonEkleGuncelleKitap.Name = "buttonEkleGuncelleKitap";
            this.buttonEkleGuncelleKitap.Size = new System.Drawing.Size(120, 49);
            this.buttonEkleGuncelleKitap.TabIndex = 5;
            this.buttonEkleGuncelleKitap.Text = "EKLE";
            this.buttonEkleGuncelleKitap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEkleGuncelleKitap.UseVisualStyleBackColor = true;
            this.buttonEkleGuncelleKitap.Click += new System.EventHandler(this.buttonEkleGuncelleKitap_Click);
            // 
            // buttonTemizleKitap
            // 
            this.buttonTemizleKitap.Image = global::Umit_AKINCI_KutuphaneProjesi.Properties.Resources.temizle1;
            this.buttonTemizleKitap.Location = new System.Drawing.Point(13, 60);
            this.buttonTemizleKitap.Name = "buttonTemizleKitap";
            this.buttonTemizleKitap.Size = new System.Drawing.Size(119, 49);
            this.buttonTemizleKitap.TabIndex = 7;
            this.buttonTemizleKitap.Text = "Temizle";
            this.buttonTemizleKitap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTemizleKitap.UseVisualStyleBackColor = true;
            this.buttonTemizleKitap.Click += new System.EventHandler(this.buttonTemizleKitap_Click);
            // 
            // FrmKitap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(666, 483);
            this.Controls.Add(this.comboBoxYazar);
            this.Controls.Add(this.comboBoxKategori);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonEkleGuncelleKitap);
            this.Controls.Add(this.checkBox_Kitap);
            this.Controls.Add(this.buttonTemizleKitap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Kitap);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmKitap";
            this.Text = "Kitap Tanımlama Ekranı";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Kitap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_Kitap;
        private System.Windows.Forms.Button buttonEkleGuncelleKitap;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.ComboBox comboBoxKategori;
        private System.Windows.Forms.ComboBox comboBoxYazar;
        private System.Windows.Forms.Button buttonTemizleKitap;
    }
}