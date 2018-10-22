namespace Umit_AKINCI_KutuphaneProjesi
{
    partial class FrmBolum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBolum));
            this.txtBolumAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxBolum = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonEkleGuncelleBolum = new System.Windows.Forms.Button();
            this.buttonBolumTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBolumAdi
            // 
            this.txtBolumAdi.Location = new System.Drawing.Point(80, 6);
            this.txtBolumAdi.Name = "txtBolumAdi";
            this.txtBolumAdi.Size = new System.Drawing.Size(116, 20);
            this.txtBolumAdi.TabIndex = 0;
            this.txtBolumAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBolumAdi_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bölüm Adı :";
            // 
            // checkBoxBolum
            // 
            this.checkBoxBolum.AutoSize = true;
            this.checkBoxBolum.Location = new System.Drawing.Point(80, 32);
            this.checkBoxBolum.Name = "checkBoxBolum";
            this.checkBoxBolum.Size = new System.Drawing.Size(92, 17);
            this.checkBoxBolum.TabIndex = 2;
            this.checkBoxBolum.Text = "Silinmiş Mi?";
            this.checkBoxBolum.UseVisualStyleBackColor = true;
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
            this.dataGridView1.Location = new System.Drawing.Point(2, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(572, 367);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // buttonEkleGuncelleBolum
            // 
            this.buttonEkleGuncelleBolum.Image = global::Umit_AKINCI_KutuphaneProjesi.Properties.Resources.math_add_icon;
            this.buttonEkleGuncelleBolum.Location = new System.Drawing.Point(323, 6);
            this.buttonEkleGuncelleBolum.Name = "buttonEkleGuncelleBolum";
            this.buttonEkleGuncelleBolum.Size = new System.Drawing.Size(123, 43);
            this.buttonEkleGuncelleBolum.TabIndex = 4;
            this.buttonEkleGuncelleBolum.Text = "EKLE";
            this.buttonEkleGuncelleBolum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEkleGuncelleBolum.UseVisualStyleBackColor = true;
            this.buttonEkleGuncelleBolum.Click += new System.EventHandler(this.buttonEkleGuncelleBolum_Click);
            // 
            // buttonBolumTemizle
            // 
            this.buttonBolumTemizle.Image = global::Umit_AKINCI_KutuphaneProjesi.Properties.Resources.temizle;
            this.buttonBolumTemizle.Location = new System.Drawing.Point(202, 6);
            this.buttonBolumTemizle.Name = "buttonBolumTemizle";
            this.buttonBolumTemizle.Size = new System.Drawing.Size(115, 43);
            this.buttonBolumTemizle.TabIndex = 3;
            this.buttonBolumTemizle.Text = "Temizle";
            this.buttonBolumTemizle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBolumTemizle.UseVisualStyleBackColor = true;
            this.buttonBolumTemizle.Click += new System.EventHandler(this.buttonBolumTemizle_Click);
            // 
            // FrmBolum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(576, 423);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonEkleGuncelleBolum);
            this.Controls.Add(this.buttonBolumTemizle);
            this.Controls.Add(this.checkBoxBolum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBolumAdi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBolum";
            this.Text = "Bölüm Tanımlama Ekranı";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBolumAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxBolum;
        private System.Windows.Forms.Button buttonBolumTemizle;
        private System.Windows.Forms.Button buttonEkleGuncelleBolum;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}