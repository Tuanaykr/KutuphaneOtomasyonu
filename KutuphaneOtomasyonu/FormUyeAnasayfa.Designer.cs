namespace KutuphaneOtomasyonu
{
    partial class FormUyeAnasayfa
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
            this.profilIslemBtn = new System.Windows.Forms.Button();
            this.uzerimdekilerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // profilIslemBtn
            // 
            this.profilIslemBtn.BackColor = System.Drawing.Color.Indigo;
            this.profilIslemBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profilIslemBtn.FlatAppearance.BorderSize = 0;
            this.profilIslemBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(27)))));
            this.profilIslemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profilIslemBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.profilIslemBtn.ForeColor = System.Drawing.Color.White;
            this.profilIslemBtn.Location = new System.Drawing.Point(246, 82);
            this.profilIslemBtn.Margin = new System.Windows.Forms.Padding(4);
            this.profilIslemBtn.Name = "profilIslemBtn";
            this.profilIslemBtn.Size = new System.Drawing.Size(165, 78);
            this.profilIslemBtn.TabIndex = 17;
            this.profilIslemBtn.Text = "Profil İşlemleri";
            this.profilIslemBtn.UseVisualStyleBackColor = false;
            this.profilIslemBtn.Click += new System.EventHandler(this.profilIslemBtn_Click);
            // 
            // uzerimdekilerBtn
            // 
            this.uzerimdekilerBtn.BackColor = System.Drawing.Color.Indigo;
            this.uzerimdekilerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uzerimdekilerBtn.FlatAppearance.BorderSize = 0;
            this.uzerimdekilerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(27)))));
            this.uzerimdekilerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uzerimdekilerBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uzerimdekilerBtn.ForeColor = System.Drawing.Color.White;
            this.uzerimdekilerBtn.Location = new System.Drawing.Point(58, 82);
            this.uzerimdekilerBtn.Margin = new System.Windows.Forms.Padding(4);
            this.uzerimdekilerBtn.Name = "uzerimdekilerBtn";
            this.uzerimdekilerBtn.Size = new System.Drawing.Size(165, 78);
            this.uzerimdekilerBtn.TabIndex = 15;
            this.uzerimdekilerBtn.Text = "Üzerimdeki Kitaplar";
            this.uzerimdekilerBtn.UseVisualStyleBackColor = false;
            this.uzerimdekilerBtn.Click += new System.EventHandler(this.uzerimdekilerBtn_Click);
            // 
            // FormUyeAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(481, 240);
            this.Controls.Add(this.profilIslemBtn);
            this.Controls.Add(this.uzerimdekilerBtn);
            this.Name = "FormUyeAnasayfa";
            this.Text = "FormUyeAnasayfa";
            this.Load += new System.EventHandler(this.FormUyeAnasayfa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button profilIslemBtn;
        private System.Windows.Forms.Button uzerimdekilerBtn;
    }
}