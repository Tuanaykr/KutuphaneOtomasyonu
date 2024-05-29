namespace KutuphaneOtomasyonu
{
    partial class FormKitapIslemleri
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kategoriComboBox = new System.Windows.Forms.ComboBox();
            this.araBtn = new System.Windows.Forms.Button();
            this.kitapAraTxt = new System.Windows.Forms.TextBox();
            this.KaydetBtn = new System.Windows.Forms.Button();
            this.aciklamaTxt = new System.Windows.Forms.TextBox();
            this.sayfaSayisiTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.yayinEviTxt = new System.Windows.Forms.TextBox();
            this.baskiYiliTxt = new System.Windows.Forms.TextBox();
            this.yazarTxt = new System.Windows.Forms.TextBox();
            this.adTxt = new System.Windows.Forms.TextBox();
            this.ISBNTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guncelleBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(358, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(621, 382);
            this.dataGridView1.TabIndex = 58;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // kategoriComboBox
            // 
            this.kategoriComboBox.FormattingEnabled = true;
            this.kategoriComboBox.Location = new System.Drawing.Point(139, 122);
            this.kategoriComboBox.Name = "kategoriComboBox";
            this.kategoriComboBox.Size = new System.Drawing.Size(181, 24);
            this.kategoriComboBox.TabIndex = 57;
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
            this.araBtn.Location = new System.Drawing.Point(834, 15);
            this.araBtn.Margin = new System.Windows.Forms.Padding(4);
            this.araBtn.Name = "araBtn";
            this.araBtn.Size = new System.Drawing.Size(145, 33);
            this.araBtn.TabIndex = 56;
            this.araBtn.Text = "Kitap Ara";
            this.araBtn.UseVisualStyleBackColor = false;
            this.araBtn.Click += new System.EventHandler(this.araBtn_Click);
            // 
            // kitapAraTxt
            // 
            this.kitapAraTxt.Location = new System.Drawing.Point(358, 20);
            this.kitapAraTxt.Name = "kitapAraTxt";
            this.kitapAraTxt.Size = new System.Drawing.Size(456, 22);
            this.kitapAraTxt.TabIndex = 55;
            // 
            // KaydetBtn
            // 
            this.KaydetBtn.BackColor = System.Drawing.Color.Indigo;
            this.KaydetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KaydetBtn.FlatAppearance.BorderSize = 0;
            this.KaydetBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(27)))));
            this.KaydetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KaydetBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.KaydetBtn.ForeColor = System.Drawing.Color.White;
            this.KaydetBtn.Location = new System.Drawing.Point(12, 382);
            this.KaydetBtn.Margin = new System.Windows.Forms.Padding(4);
            this.KaydetBtn.Name = "KaydetBtn";
            this.KaydetBtn.Size = new System.Drawing.Size(145, 54);
            this.KaydetBtn.TabIndex = 53;
            this.KaydetBtn.Text = "Kaydet";
            this.KaydetBtn.UseVisualStyleBackColor = false;
            this.KaydetBtn.Click += new System.EventHandler(this.KaydetBtn_Click);
            // 
            // aciklamaTxt
            // 
            this.aciklamaTxt.Location = new System.Drawing.Point(139, 257);
            this.aciklamaTxt.Multiline = true;
            this.aciklamaTxt.Name = "aciklamaTxt";
            this.aciklamaTxt.Size = new System.Drawing.Size(181, 89);
            this.aciklamaTxt.TabIndex = 52;
            // 
            // sayfaSayisiTxt
            // 
            this.sayfaSayisiTxt.Location = new System.Drawing.Point(139, 224);
            this.sayfaSayisiTxt.Name = "sayfaSayisiTxt";
            this.sayfaSayisiTxt.Size = new System.Drawing.Size(181, 22);
            this.sayfaSayisiTxt.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label10.Location = new System.Drawing.Point(30, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 27);
            this.label10.TabIndex = 50;
            this.label10.Text = "Açıklama:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label12.Location = new System.Drawing.Point(7, 219);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 27);
            this.label12.TabIndex = 49;
            this.label12.Text = "Sayfa Sayısı:";
            // 
            // yayinEviTxt
            // 
            this.yayinEviTxt.Location = new System.Drawing.Point(139, 190);
            this.yayinEviTxt.Name = "yayinEviTxt";
            this.yayinEviTxt.Size = new System.Drawing.Size(181, 22);
            this.yayinEviTxt.TabIndex = 48;
            // 
            // baskiYiliTxt
            // 
            this.baskiYiliTxt.Location = new System.Drawing.Point(139, 156);
            this.baskiYiliTxt.Name = "baskiYiliTxt";
            this.baskiYiliTxt.Size = new System.Drawing.Size(181, 22);
            this.baskiYiliTxt.TabIndex = 47;
            // 
            // yazarTxt
            // 
            this.yazarTxt.Location = new System.Drawing.Point(139, 88);
            this.yazarTxt.Name = "yazarTxt";
            this.yazarTxt.Size = new System.Drawing.Size(181, 22);
            this.yazarTxt.TabIndex = 46;
            // 
            // adTxt
            // 
            this.adTxt.Location = new System.Drawing.Point(139, 54);
            this.adTxt.Name = "adTxt";
            this.adTxt.Size = new System.Drawing.Size(181, 22);
            this.adTxt.TabIndex = 45;
            // 
            // ISBNTxt
            // 
            this.ISBNTxt.Location = new System.Drawing.Point(139, 20);
            this.ISBNTxt.MaxLength = 13;
            this.ISBNTxt.Name = "ISBNTxt";
            this.ISBNTxt.Size = new System.Drawing.Size(181, 22);
            this.ISBNTxt.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label6.Location = new System.Drawing.Point(34, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 27);
            this.label6.TabIndex = 43;
            this.label6.Text = "Yayın Evi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label5.Location = new System.Drawing.Point(34, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 27);
            this.label5.TabIndex = 42;
            this.label5.Text = "Baskı Yılı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label4.Location = new System.Drawing.Point(35, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 27);
            this.label4.TabIndex = 41;
            this.label4.Text = "Kategori:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label3.Location = new System.Drawing.Point(59, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 27);
            this.label3.TabIndex = 40;
            this.label3.Text = "Yazarı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label2.Location = new System.Drawing.Point(29, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 27);
            this.label2.TabIndex = 39;
            this.label2.Text = "Kitap Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label1.Location = new System.Drawing.Point(69, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 27);
            this.label1.TabIndex = 38;
            this.label1.Text = "ISBN:";
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
            this.guncelleBtn.Location = new System.Drawing.Point(175, 382);
            this.guncelleBtn.Margin = new System.Windows.Forms.Padding(4);
            this.guncelleBtn.Name = "guncelleBtn";
            this.guncelleBtn.Size = new System.Drawing.Size(145, 54);
            this.guncelleBtn.TabIndex = 59;
            this.guncelleBtn.Text = "Güncelle";
            this.guncelleBtn.UseVisualStyleBackColor = false;
            this.guncelleBtn.Click += new System.EventHandler(this.guncelleBtn_Click);
            // 
            // FormKitapIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1015, 508);
            this.Controls.Add(this.guncelleBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.kategoriComboBox);
            this.Controls.Add(this.araBtn);
            this.Controls.Add(this.kitapAraTxt);
            this.Controls.Add(this.KaydetBtn);
            this.Controls.Add(this.aciklamaTxt);
            this.Controls.Add(this.sayfaSayisiTxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.yayinEviTxt);
            this.Controls.Add(this.baskiYiliTxt);
            this.Controls.Add(this.yazarTxt);
            this.Controls.Add(this.adTxt);
            this.Controls.Add(this.ISBNTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormKitapIslemleri";
            this.Text = "FormKitapIslemleri";
            this.Load += new System.EventHandler(this.FormKitapIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox kategoriComboBox;
        private System.Windows.Forms.Button araBtn;
        private System.Windows.Forms.TextBox kitapAraTxt;
        private System.Windows.Forms.Button KaydetBtn;
        private System.Windows.Forms.TextBox aciklamaTxt;
        private System.Windows.Forms.TextBox sayfaSayisiTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox yayinEviTxt;
        private System.Windows.Forms.TextBox baskiYiliTxt;
        private System.Windows.Forms.TextBox yazarTxt;
        private System.Windows.Forms.TextBox adTxt;
        private System.Windows.Forms.TextBox ISBNTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button guncelleBtn;
    }
}