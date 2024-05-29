namespace KutuphaneOtomasyonu
{
    partial class FormGirisYap
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.girisBtn = new System.Windows.Forms.Button();
            this.radioKullanici = new System.Windows.Forms.RadioButton();
            this.radioAdmin = new System.Windows.Forms.RadioButton();
            this.sifreTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label2.Location = new System.Drawing.Point(149, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 27);
            this.label2.TabIndex = 24;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label1.Location = new System.Drawing.Point(132, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 27);
            this.label1.TabIndex = 23;
            this.label1.Text = "E-mail:";
            // 
            // girisBtn
            // 
            this.girisBtn.BackColor = System.Drawing.Color.Indigo;
            this.girisBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.girisBtn.FlatAppearance.BorderSize = 0;
            this.girisBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(27)))));
            this.girisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.girisBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.girisBtn.ForeColor = System.Drawing.Color.White;
            this.girisBtn.Location = new System.Drawing.Point(305, 349);
            this.girisBtn.Margin = new System.Windows.Forms.Padding(4);
            this.girisBtn.Name = "girisBtn";
            this.girisBtn.Size = new System.Drawing.Size(145, 54);
            this.girisBtn.TabIndex = 22;
            this.girisBtn.Text = "Giriş Yap";
            this.girisBtn.UseVisualStyleBackColor = false;
            this.girisBtn.Click += new System.EventHandler(this.girisBtn_Click);
            // 
            // radioKullanici
            // 
            this.radioKullanici.AutoSize = true;
            this.radioKullanici.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.radioKullanici.Location = new System.Drawing.Point(255, 255);
            this.radioKullanici.Margin = new System.Windows.Forms.Padding(4);
            this.radioKullanici.Name = "radioKullanici";
            this.radioKullanici.Size = new System.Drawing.Size(111, 31);
            this.radioKullanici.TabIndex = 21;
            this.radioKullanici.TabStop = true;
            this.radioKullanici.Text = "Kullanıcı";
            this.radioKullanici.UseVisualStyleBackColor = true;
            // 
            // radioAdmin
            // 
            this.radioAdmin.AutoSize = true;
            this.radioAdmin.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.radioAdmin.Location = new System.Drawing.Point(255, 294);
            this.radioAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.radioAdmin.Name = "radioAdmin";
            this.radioAdmin.Size = new System.Drawing.Size(96, 31);
            this.radioAdmin.TabIndex = 20;
            this.radioAdmin.TabStop = true;
            this.radioAdmin.Text = "Admin";
            this.radioAdmin.UseVisualStyleBackColor = true;
            // 
            // sifreTxt
            // 
            this.sifreTxt.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreTxt.ForeColor = System.Drawing.Color.Black;
            this.sifreTxt.Location = new System.Drawing.Point(245, 186);
            this.sifreTxt.Margin = new System.Windows.Forms.Padding(4);
            this.sifreTxt.Multiline = true;
            this.sifreTxt.Name = "sifreTxt";
            this.sifreTxt.PasswordChar = '*';
            this.sifreTxt.Size = new System.Drawing.Size(292, 36);
            this.sifreTxt.TabIndex = 19;
            // 
            // emailTxt
            // 
            this.emailTxt.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emailTxt.ForeColor = System.Drawing.Color.Black;
            this.emailTxt.Location = new System.Drawing.Point(245, 89);
            this.emailTxt.Margin = new System.Windows.Forms.Padding(4);
            this.emailTxt.Multiline = true;
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(292, 36);
            this.emailTxt.TabIndex = 18;
            // 
            // FormGirisYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(736, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.girisBtn);
            this.Controls.Add(this.radioKullanici);
            this.Controls.Add(this.radioAdmin);
            this.Controls.Add(this.sifreTxt);
            this.Controls.Add(this.emailTxt);
            this.Name = "FormGirisYap";
            this.Text = "FormGirisYap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button girisBtn;
        private System.Windows.Forms.RadioButton radioKullanici;
        private System.Windows.Forms.RadioButton radioAdmin;
        private System.Windows.Forms.TextBox sifreTxt;
        private System.Windows.Forms.TextBox emailTxt;
    }
}