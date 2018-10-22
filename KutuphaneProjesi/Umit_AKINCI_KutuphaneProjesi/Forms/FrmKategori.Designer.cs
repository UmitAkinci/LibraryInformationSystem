namespace Umit_AKINCI_KutuphaneProjesi
{
    partial class FrmKategori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKategori));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Kategori = new System.Windows.Forms.TextBox();
            this.checkBoxKategori = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonEkleGuncelleKategori = new System.Windows.Forms.Button();
            this.buttonTemizleKategori = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Adı :";
            // 
            // textBox_Kategori
            // 
            this.textBox_Kategori.Location = new System.Drawing.Point(92, 12);
            this.textBox_Kategori.Name = "textBox_Kategori";
            this.textBox_Kategori.Size = new System.Drawing.Size(116, 20);
            this.textBox_Kategori.TabIndex = 2;
            this.textBox_Kategori.TextChanged += new System.EventHandler(this.textBox_Kategori_TextChanged);
            this.textBox_Kategori.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Kategori_KeyPress);
            // 
            // checkBoxKategori
            // 
            this.checkBoxKategori.AutoSize = true;
            this.checkBoxKategori.Location = new System.Drawing.Point(92, 38);
            this.checkBoxKategori.Name = "checkBoxKategori";
            this.checkBoxKategori.Size = new System.Drawing.Size(91, 17);
            this.checkBoxKategori.TabIndex = 4;
            this.checkBoxKategori.Text = "Silinmiş mi?";
            this.checkBoxKategori.UseVisualStyleBackColor = true;
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
            this.dataGridView1.Location = new System.Drawing.Point(5, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(584, 382);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // buttonEkleGuncelleKategori
            // 
            this.buttonEkleGuncelleKategori.Image = global::Umit_AKINCI_KutuphaneProjesi.Properties.Resources.math_add_icon;
            this.buttonEkleGuncelleKategori.Location = new System.Drawing.Point(347, 12);
            this.buttonEkleGuncelleKategori.Name = "buttonEkleGuncelleKategori";
            this.buttonEkleGuncelleKategori.Size = new System.Drawing.Size(119, 50);
            this.buttonEkleGuncelleKategori.TabIndex = 3;
            this.buttonEkleGuncelleKategori.Text = "EKLE";
            this.buttonEkleGuncelleKategori.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEkleGuncelleKategori.UseVisualStyleBackColor = true;
            this.buttonEkleGuncelleKategori.Click += new System.EventHandler(this.buttonEkleGuncelleKategori_Click);
            // 
            // buttonTemizleKategori
            // 
            this.buttonTemizleKategori.Image = global::Umit_AKINCI_KutuphaneProjesi.Properties.Resources.temizle;
            this.buttonTemizleKategori.Location = new System.Drawing.Point(223, 12);
            this.buttonTemizleKategori.Name = "buttonTemizleKategori";
            this.buttonTemizleKategori.Size = new System.Drawing.Size(118, 50);
            this.buttonTemizleKategori.TabIndex = 1;
            this.buttonTemizleKategori.Text = "Temizle";
            this.buttonTemizleKategori.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTemizleKategori.UseVisualStyleBackColor = true;
            this.buttonTemizleKategori.Click += new System.EventHandler(this.buttonTemizleKategori_Click);
            // 
            // FrmKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(591, 454);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkBoxKategori);
            this.Controls.Add(this.buttonEkleGuncelleKategori);
            this.Controls.Add(this.textBox_Kategori);
            this.Controls.Add(this.buttonTemizleKategori);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmKategori";
            this.Text = "Kategori Tanımlama Ekranı";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTemizleKategori;
        private System.Windows.Forms.TextBox textBox_Kategori;
        private System.Windows.Forms.Button buttonEkleGuncelleKategori;
        private System.Windows.Forms.CheckBox checkBoxKategori;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}