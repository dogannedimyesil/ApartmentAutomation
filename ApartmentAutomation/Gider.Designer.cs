namespace ApartmentAutomation
{
    partial class Giderler
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_Elekt = new System.Windows.Forms.CheckBox();
            this.cb_Su = new System.Windows.Forms.CheckBox();
            this.cb_Asans = new System.Windows.Forms.CheckBox();
            this.cb_Temizlik = new System.Windows.Forms.CheckBox();
            this.lbl_Tutar = new System.Windows.Forms.Label();
            this.lbl_Tarih = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_GiderEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_GiderEkle);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lbl_Tarih);
            this.groupBox1.Controls.Add(this.lbl_Tutar);
            this.groupBox1.Controls.Add(this.cb_Temizlik);
            this.groupBox1.Controls.Add(this.cb_Asans);
            this.groupBox1.Controls.Add(this.cb_Su);
            this.groupBox1.Controls.Add(this.cb_Elekt);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Gider Ekle";
            // 
            // cb_Elekt
            // 
            this.cb_Elekt.AutoSize = true;
            this.cb_Elekt.Location = new System.Drawing.Point(7, 20);
            this.cb_Elekt.Name = "cb_Elekt";
            this.cb_Elekt.Size = new System.Drawing.Size(61, 17);
            this.cb_Elekt.TabIndex = 0;
            this.cb_Elekt.Text = "Elektrik";
            this.cb_Elekt.UseVisualStyleBackColor = true;
            // 
            // cb_Su
            // 
            this.cb_Su.AutoSize = true;
            this.cb_Su.Location = new System.Drawing.Point(7, 43);
            this.cb_Su.Name = "cb_Su";
            this.cb_Su.Size = new System.Drawing.Size(39, 17);
            this.cb_Su.TabIndex = 1;
            this.cb_Su.Text = "Su";
            this.cb_Su.UseVisualStyleBackColor = true;
            // 
            // cb_Asans
            // 
            this.cb_Asans.AutoSize = true;
            this.cb_Asans.Location = new System.Drawing.Point(7, 66);
            this.cb_Asans.Name = "cb_Asans";
            this.cb_Asans.Size = new System.Drawing.Size(64, 17);
            this.cb_Asans.TabIndex = 2;
            this.cb_Asans.Text = "Asansör";
            this.cb_Asans.UseVisualStyleBackColor = true;
            // 
            // cb_Temizlik
            // 
            this.cb_Temizlik.AutoSize = true;
            this.cb_Temizlik.Location = new System.Drawing.Point(7, 89);
            this.cb_Temizlik.Name = "cb_Temizlik";
            this.cb_Temizlik.Size = new System.Drawing.Size(64, 17);
            this.cb_Temizlik.TabIndex = 3;
            this.cb_Temizlik.Text = "Temizlik";
            this.cb_Temizlik.UseVisualStyleBackColor = true;
            // 
            // lbl_Tutar
            // 
            this.lbl_Tutar.AutoSize = true;
            this.lbl_Tutar.Location = new System.Drawing.Point(187, 20);
            this.lbl_Tutar.Name = "lbl_Tutar";
            this.lbl_Tutar.Size = new System.Drawing.Size(35, 13);
            this.lbl_Tutar.TabIndex = 4;
            this.lbl_Tutar.Text = "Tutar:";
            // 
            // lbl_Tarih
            // 
            this.lbl_Tarih.AutoSize = true;
            this.lbl_Tarih.Location = new System.Drawing.Point(187, 47);
            this.lbl_Tarih.Name = "lbl_Tarih";
            this.lbl_Tarih.Size = new System.Drawing.Size(34, 13);
            this.lbl_Tarih.TabIndex = 5;
            this.lbl_Tarih.Text = "Tarih:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(228, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(228, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(141, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // btn_GiderEkle
            // 
            this.btn_GiderEkle.Location = new System.Drawing.Point(294, 69);
            this.btn_GiderEkle.Name = "btn_GiderEkle";
            this.btn_GiderEkle.Size = new System.Drawing.Size(75, 23);
            this.btn_GiderEkle.TabIndex = 8;
            this.btn_GiderEkle.Text = "Ekle";
            this.btn_GiderEkle.UseVisualStyleBackColor = true;
            this.btn_GiderEkle.Click += new System.EventHandler(this.btn_GiderEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(406, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // Giderler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 301);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Giderler";
            this.Text = "Giderler";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb_Temizlik;
        private System.Windows.Forms.CheckBox cb_Asans;
        private System.Windows.Forms.CheckBox cb_Su;
        private System.Windows.Forms.CheckBox cb_Elekt;
        private System.Windows.Forms.Button btn_GiderEkle;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_Tarih;
        private System.Windows.Forms.Label lbl_Tutar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}