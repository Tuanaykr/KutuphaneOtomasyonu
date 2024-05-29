namespace KutuphaneOtomasyonu
{
    partial class FormUyeIslemleri
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
            this.kaydetBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.araBtn = new System.Windows.Forms.Button();
            this.uyeAraTxt = new System.Windows.Forms.TextBox();
            this.adresTxt = new System.Windows.Forms.TextBox();
            this.telefonTxt = new System.Windows.Forms.TextBox();
            this.sifreTxt = new System.Windows.Forms.TextBox();
            this.mailTxt = new System.Windows.Forms.TextBox();
            this.soyadTxt = new System.Windows.Forms.TextBox();
            this.adTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SilBtn = new System.Windows.Forms.Button();
            this.guncelleBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // kaydetBtn
            // 
            this.kaydetBtn.BackColor = System.Drawing.Color.Indigo;
            this.kaydetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kaydetBtn.FlatAppearance.BorderSize = 0;
            this.kaydetBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(27)))));
            this.kaydetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kaydetBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.kaydetBtn.ForeColor = System.Drawing.Color.White;
            this.kaydetBtn.Location = new System.Drawing.Point(11, 299);
            this.kaydetBtn.Margin = new System.Windows.Forms.Padding(4);
            this.kaydetBtn.Name = "kaydetBtn";
            this.kaydetBtn.Size = new System.Drawing.Size(145, 54);
            this.kaydetBtn.TabIndex = 69;
            this.kaydetBtn.Text = "Kaydet";
            this.kaydetBtn.UseVisualStyleBackColor = false;
            this.kaydetBtn.Click += new System.EventHandler(this.kaydetBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(338, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(620, 335);
            this.dataGridView1.TabIndex = 68;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // araBtn
            // 
            this.araBtn.BackColor = System.Drawing.Color.Indigo;
            this.araBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.araBtn.FlatAppearance.BorderSize = 0;
            this.araBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(27)))));
            this.araBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.araBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.araBtn.ForeColor = System.Drawing.Color.White;
            this.araBtn.Location = new System.Drawing.Point(814, 37);
            this.araBtn.Margin = new System.Windows.Forms.Padding(4);
            this.araBtn.Name = "araBtn";
            this.araBtn.Size = new System.Drawing.Size(145, 33);
            this.araBtn.TabIndex = 67;
            this.araBtn.Text = "Üye Ara";
            this.araBtn.UseVisualStyleBackColor = false;
            this.araBtn.Click += new System.EventHandler(this.araBtn_Click);
            // 
            // uyeAraTxt
            // 
            this.uyeAraTxt.Location = new System.Drawing.Point(338, 42);
            this.uyeAraTxt.Name = "uyeAraTxt";
            this.uyeAraTxt.Size = new System.Drawing.Size(456, 22);
            this.uyeAraTxt.TabIndex = 66;
            // 
            // adresTxt
            // 
            this.adresTxt.Location = new System.Drawing.Point(128, 226);
            this.adresTxt.Name = "adresTxt";
            this.adresTxt.Size = new System.Drawing.Size(181, 22);
            this.adresTxt.TabIndex = 65;
            // 
            // telefonTxt
            // 
            this.telefonTxt.Location = new System.Drawing.Point(128, 188);
            this.telefonTxt.MaxLength = 11;
            this.telefonTxt.Name = "telefonTxt";
            this.telefonTxt.Size = new System.Drawing.Size(181, 22);
            this.telefonTxt.TabIndex = 64;
            // 
            // sifreTxt
            // 
            this.sifreTxt.Location = new System.Drawing.Point(128, 152);
            this.sifreTxt.Name = "sifreTxt";
            this.sifreTxt.PasswordChar = '*';
            this.sifreTxt.Size = new System.Drawing.Size(181, 22);
            this.sifreTxt.TabIndex = 63;
            // 
            // mailTxt
            // 
            this.mailTxt.Location = new System.Drawing.Point(128, 116);
            this.mailTxt.Name = "mailTxt";
            this.mailTxt.Size = new System.Drawing.Size(181, 22);
            this.mailTxt.TabIndex = 62;
            // 
            // soyadTxt
            // 
            this.soyadTxt.Location = new System.Drawing.Point(128, 79);
            this.soyadTxt.Name = "soyadTxt";
            this.soyadTxt.Size = new System.Drawing.Size(181, 22);
            this.soyadTxt.TabIndex = 61;
            // 
            // adTxt
            // 
            this.adTxt.Location = new System.Drawing.Point(128, 42);
            this.adTxt.Name = "adTxt";
            this.adTxt.Size = new System.Drawing.Size(181, 22);
            this.adTxt.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label6.Location = new System.Drawing.Point(53, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 27);
            this.label6.TabIndex = 59;
            this.label6.Text = "Adres:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label5.Location = new System.Drawing.Point(38, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 27);
            this.label5.TabIndex = 58;
            this.label5.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label4.Location = new System.Drawing.Point(65, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 27);
            this.label4.TabIndex = 57;
            this.label4.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label3.Location = new System.Drawing.Point(47, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 27);
            this.label3.TabIndex = 56;
            this.label3.Text = "E-Mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label2.Location = new System.Drawing.Point(48, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 27);
            this.label2.TabIndex = 55;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label1.Location = new System.Drawing.Point(81, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 27);
            this.label1.TabIndex = 54;
            this.label1.Text = "Ad:";
            // 
            // SilBtn
            // 
            this.SilBtn.BackColor = System.Drawing.Color.Indigo;
            this.SilBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SilBtn.FlatAppearance.BorderSize = 0;
            this.SilBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(27)))));
            this.SilBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SilBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.SilBtn.ForeColor = System.Drawing.Color.White;
            this.SilBtn.Location = new System.Drawing.Point(86, 361);
            this.SilBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SilBtn.Name = "SilBtn";
            this.SilBtn.Size = new System.Drawing.Size(145, 54);
            this.SilBtn.TabIndex = 53;
            this.SilBtn.Text = "Sil";
            this.SilBtn.UseVisualStyleBackColor = false;
            this.SilBtn.Click += new System.EventHandler(this.SilBtn_Click);
            // 
            // guncelleBtn
            // 
            this.guncelleBtn.BackColor = System.Drawing.Color.Indigo;
            this.guncelleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guncelleBtn.FlatAppearance.BorderSize = 0;
            this.guncelleBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(27)))));
            this.guncelleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guncelleBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.guncelleBtn.ForeColor = System.Drawing.Color.White;
            this.guncelleBtn.Location = new System.Drawing.Point(164, 299);
            this.guncelleBtn.Margin = new System.Windows.Forms.Padding(4);
            this.guncelleBtn.Name = "guncelleBtn";
            this.guncelleBtn.Size = new System.Drawing.Size(145, 54);
            this.guncelleBtn.TabIndex = 70;
            this.guncelleBtn.Text = "Güncelle";
            this.guncelleBtn.UseVisualStyleBackColor = false;
            this.guncelleBtn.Click += new System.EventHandler(this.guncelleBtn_Click);
            // 
            // FormUyeIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(980, 469);
            this.Controls.Add(this.guncelleBtn);
            this.Controls.Add(this.kaydetBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.araBtn);
            this.Controls.Add(this.uyeAraTxt);
            this.Controls.Add(this.adresTxt);
            this.Controls.Add(this.telefonTxt);
            this.Controls.Add(this.sifreTxt);
            this.Controls.Add(this.mailTxt);
            this.Controls.Add(this.soyadTxt);
            this.Controls.Add(this.adTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SilBtn);
            this.Name = "FormUyeIslemleri";
            this.Text = "FormUyeIslemleri";
            this.Load += new System.EventHandler(this.FormUyeIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kaydetBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button araBtn;
        private System.Windows.Forms.TextBox uyeAraTxt;
        private System.Windows.Forms.TextBox adresTxt;
        private System.Windows.Forms.TextBox telefonTxt;
        private System.Windows.Forms.TextBox sifreTxt;
        private System.Windows.Forms.TextBox mailTxt;
        private System.Windows.Forms.TextBox soyadTxt;
        private System.Windows.Forms.TextBox adTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SilBtn;
        private System.Windows.Forms.Button guncelleBtn;
    }
}