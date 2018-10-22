namespace Umit_AKINCI_KutuphaneProjesi
{
    partial class FrmYazar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYazar));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Yazar = new System.Windows.Forms.TextBox();
            this.checkBox_Yazar = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonYazarEkleGuncelle = new System.Windows.Forms.Button();
            this.buttonYazarTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Yazar Adı :";
            // 
            // textBox_Yazar
            // 
            this.textBox_Yazar.Location = new System.Drawing.Point(78, 9);
            this.textBox_Yazar.Name = "textBox_Yazar";
            this.textBox_Yazar.Size = new System.Drawing.Size(116, 20);
            this.textBox_Yazar.TabIndex = 1;
            this.textBox_Yazar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Yazar_KeyPress);
            // 
            // checkBox_Yazar
            // 
            this.checkBox_Yazar.AutoSize = true;
            this.checkBox_Yazar.Location = new System.Drawing.Point(78, 35);
            this.checkBox_Yazar.Name = "checkBox_Yazar";
            this.checkBox_Yazar.Size = new System.Drawing.Size(91, 17);
            this.checkBox_Yazar.TabIndex = 3;
            this.checkBox_Yazar.Text = "Silinmiş mi?";
            this.checkBox_Yazar.UseVisualStyleBackColor = true;
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
            this.dataGridView1.Location = new System.Drawing.Point(1, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(575, 402);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // buttonYazarEkleGuncelle
            // 
            this.buttonYazarEkleGuncelle.Image = global::Umit_AKINCI_KutuphaneProjesi.Properties.Resources.math_add_icon;
            this.buttonYazarEkleGuncelle.Location = new System.Drawing.Point(325, 6);
            this.buttonYazarEkleGuncelle.Name = "buttonYazarEkleGuncelle";
            this.buttonYazarEkleGuncelle.Size = new System.Drawing.Size(119, 46);
            this.buttonYazarEkleGuncelle.TabIndex = 2;
            this.buttonYazarEkleGuncelle.Text = "EKLE";
            this.buttonYazarEkleGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonYazarEkleGuncelle.UseVisualStyleBackColor = true;
            this.buttonYazarEkleGuncelle.Click += new System.EventHandler(this.buttonYazarEkleGuncelle_Click);
            // 
            // buttonYazarTemizle
            // 
            this.buttonYazarTemizle.Image = global::Umit_AKINCI_KutuphaneProjesi.Properties.Resources.temizle;
            this.buttonYazarTemizle.Location = new System.Drawing.Point(200, 6);
            this.buttonYazarTemizle.Name = "buttonYazarTemizle";
            this.buttonYazarTemizle.Size = new System.Drawing.Size(119, 46);
            this.buttonYazarTemizle.TabIndex = 4;
            this.buttonYazarTemizle.Text = "Temizle";
            this.buttonYazarTemizle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonYazarTemizle.UseVisualStyleBackColor = true;
            this.buttonYazarTemizle.Click += new System.EventHandler(this.buttonYazarTemizle_Click);
            // 
            // FrmYazar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(579, 462);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonYazarEkleGuncelle);
            this.Controls.Add(this.buttonYazarTemizle);
            this.Controls.Add(this.checkBox_Yazar);
            this.Controls.Add(this.textBox_Yazar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmYazar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yazar Tanımlama Ekranı";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Yazar;
        private System.Windows.Forms.CheckBox checkBox_Yazar;
        private System.Windows.Forms.Button buttonYazarTemizle;
        private System.Windows.Forms.Button buttonYazarEkleGuncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}