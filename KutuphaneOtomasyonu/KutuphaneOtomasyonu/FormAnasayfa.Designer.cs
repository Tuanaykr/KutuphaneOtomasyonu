namespace KutuphaneOtomasyonu
{
    partial class FormAnasayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.girisGitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.kayitOlBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // girisGitBtn
            // 
            this.girisGitBtn.BackColor = System.Drawing.Color.Indigo;
            this.girisGitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.girisGitBtn.FlatAppearance.BorderSize = 0;
            this.girisGitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(27)))));
            this.girisGitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.girisGitBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.girisGitBtn.ForeColor = System.Drawing.Color.White;
            this.girisGitBtn.Location = new System.Drawing.Point(168, 247);
            this.girisGitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.girisGitBtn.Name = "girisGitBtn";
            this.girisGitBtn.Size = new System.Drawing.Size(165, 78);
            this.girisGitBtn.TabIndex = 12;
            this.girisGitBtn.Text = "Giriş Yap";
            this.girisGitBtn.UseVisualStyleBackColor = false;
            this.girisGitBtn.Click += new System.EventHandler(this.girisGitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(141, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 50);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kütüphane Otomasyonu";
            // 
            // kayitOlBtn
            // 
            this.kayitOlBtn.BackColor = System.Drawing.Color.Indigo;
            this.kayitOlBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kayitOlBtn.FlatAppearance.BorderSize = 0;
            this.kayitOlBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(27)))));
            this.kayitOlBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kayitOlBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.kayitOlBtn.ForeColor = System.Drawing.Color.White;
            this.kayitOlBtn.Location = new System.Drawing.Point(390, 247);
            this.kayitOlBtn.Margin = new System.Windows.Forms.Padding(4);
            this.kayitOlBtn.Name = "kayitOlBtn";
            this.kayitOlBtn.Size = new System.Drawing.Size(165, 78);
            this.kayitOlBtn.TabIndex = 13;
            this.kayitOlBtn.Text = "Kayıt Ol";
            this.kayitOlBtn.UseVisualStyleBackColor = false;
            this.kayitOlBtn.Click += new System.EventHandler(this.kayitOlBtn_Click);
            // 
            // FormAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(758, 461);
            this.Controls.Add(this.kayitOlBtn);
            this.Controls.Add(this.girisGitBtn);
            this.Controls.Add(this.label1);
            this.Name = "FormAnasayfa";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button girisGitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button kayitOlBtn;
    }
}

