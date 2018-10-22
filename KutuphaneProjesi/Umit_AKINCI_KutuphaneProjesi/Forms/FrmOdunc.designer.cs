namespace Umit_AKINCI_KutuphaneProjesi
{
    partial class FrmOdunc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOdunc));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbKitap = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_verilme = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker_iade = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewOdunc = new System.Windows.Forms.DataGridView();
            this.cmbAdiSoyadi = new System.Windows.Forms.ComboBox();
            this.buttonOduncEkle = new System.Windows.Forms.Button();
            this.buttonOduncTemizle = new System.Windows.Forms.Button();
            this.checkBox_iade = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOdunc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Adı Soyadı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Verilen Kitap :";
            // 
            // cmbKitap
            // 
            this.cmbKitap.FormattingEnabled = true;
            this.cmbKitap.Location = new System.Drawing.Point(97, 43);
            this.cmbKitap.Name = "cmbKitap";
            this.cmbKitap.Size = new System.Drawing.Size(140, 21);
            this.cmbKitap.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Verilme Tarihi :";
            // 
            // dateTimePicker_verilme
            // 
            this.dateTimePicker_verilme.CausesValidation = false;
            this.dateTimePicker_verilme.Location = new System.Drawing.Point(441, 6);
            this.dateTimePicker_verilme.Name = "dateTimePicker_verilme";
            this.dateTimePicker_verilme.Size = new System.Drawing.Size(233, 20);
            this.dateTimePicker_verilme.TabIndex = 3;
            this.dateTimePicker_verilme.Value = new System.DateTime(2016, 8, 12, 0, 0, 0, 0);
            this.dateTimePicker_verilme.ValueChanged += new System.EventHandler(this.dateTimePicker_verilme_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "İade Tarihi :";
            // 
            // dateTimePicker_iade
            // 
            this.dateTimePicker_iade.Location = new System.Drawing.Point(441, 44);
            this.dateTimePicker_iade.Name = "dateTimePicker_iade";
            this.dateTimePicker_iade.Size = new System.Drawing.Size(233, 20);
            this.dateTimePicker_iade.TabIndex = 4;
            this.dateTimePicker_iade.Value = new System.DateTime(2016, 8, 12, 0, 0, 0, 0);
            // 
            // dataGridViewOdunc
            // 
            this.dataGridViewOdunc.AllowUserToAddRows = false;
            this.dataGridViewOdunc.AllowUserToDeleteRows = false;
            this.dataGridViewOdunc.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewOdunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOdunc.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewOdunc.Location = new System.Drawing.Point(5, 118);
            this.dataGridViewOdunc.Name = "dataGridViewOdunc";
            this.dataGridViewOdunc.ReadOnly = true;
            this.dataGridViewOdunc.Size = new System.Drawing.Size(717, 372);
            this.dataGridViewOdunc.TabIndex = 12;
            this.dataGridViewOdunc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOdunc_CellContentClick);
            this.dataGridViewOdunc.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewOdunc_CellFormatting);
            // 
            // cmbAdiSoyadi
            // 
            this.cmbAdiSoyadi.FormattingEnabled = true;
            this.cmbAdiSoyadi.Location = new System.Drawing.Point(97, 9);
            this.cmbAdiSoyadi.Name = "cmbAdiSoyadi";
            this.cmbAdiSoyadi.Size = new System.Drawing.Size(140, 21);
            this.cmbAdiSoyadi.TabIndex = 1;
            // 
            // buttonOduncEkle
            // 
            this.buttonOduncEkle.Image = global::Umit_AKINCI_KutuphaneProjesi.Properties.Resources.math_add_icon;
            this.buttonOduncEkle.Location = new System.Drawing.Point(133, 70);
            this.buttonOduncEkle.Name = "buttonOduncEkle";
            this.buttonOduncEkle.Size = new System.Drawing.Size(128, 42);
            this.buttonOduncEkle.TabIndex = 5;
            this.buttonOduncEkle.Text = "EKLE";
            this.buttonOduncEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOduncEkle.UseVisualStyleBackColor = true;
            this.buttonOduncEkle.Click += new System.EventHandler(this.buttonOduncEkle_Click);
            // 
            // buttonOduncTemizle
            // 
            this.buttonOduncTemizle.Image = global::Umit_AKINCI_KutuphaneProjesi.Properties.Resources.temizle;
            this.buttonOduncTemizle.Location = new System.Drawing.Point(17, 70);
            this.buttonOduncTemizle.Name = "buttonOduncTemizle";
            this.buttonOduncTemizle.Size = new System.Drawing.Size(110, 42);
            this.buttonOduncTemizle.TabIndex = 6;
            this.buttonOduncTemizle.Text = "Temizle";
            this.buttonOduncTemizle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOduncTemizle.UseVisualStyleBackColor = true;
            this.buttonOduncTemizle.Click += new System.EventHandler(this.buttonOduncTemizle_Click);
            // 
            // checkBox_iade
            // 
            this.checkBox_iade.AutoSize = true;
            this.checkBox_iade.Location = new System.Drawing.Point(279, 84);
            this.checkBox_iade.Name = "checkBox_iade";
            this.checkBox_iade.Size = new System.Drawing.Size(112, 17);
            this.checkBox_iade.TabIndex = 7;
            this.checkBox_iade.Text = "İade edildi mi ?";
            this.checkBox_iade.UseVisualStyleBackColor = true;
            // 
            // FrmOdunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(722, 502);
            this.Controls.Add(this.checkBox_iade);
            this.Controls.Add(this.cmbAdiSoyadi);
            this.Controls.Add(this.buttonOduncEkle);
            this.Controls.Add(this.buttonOduncTemizle);
            this.Controls.Add(this.dataGridViewOdunc);
            this.Controls.Add(this.dateTimePicker_iade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker_verilme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbKitap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOdunc";
            this.Text = "Ödünç Bilgileri Ekranı";
            this.Load += new System.EventHandler(this.FrmOdunc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOdunc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbKitap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_verilme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker_iade;
        private System.Windows.Forms.DataGridView dataGridViewOdunc;
        private System.Windows.Forms.Button buttonOduncTemizle;
        private System.Windows.Forms.Button buttonOduncEkle;
        private System.Windows.Forms.ComboBox cmbAdiSoyadi;
        private System.Windows.Forms.CheckBox checkBox_iade;
    }
}