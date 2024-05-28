namespace KutuphaneOtomasyonu
{
    partial class FormAdminAnasayfa
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
            this.uyeIslemBtn = new System.Windows.Forms.Button();
            this.emanetIslemBtn = new System.Windows.Forms.Button();
            this.kitapIslemBtn = new System.Windows.Forms.Button();
            this.adminIslemBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uyeIslemBtn
            // 
            this.uyeIslemBtn.BackColor = System.Drawing.Color.Indigo;
            this.uyeIslemBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uyeIslemBtn.FlatAppearance.BorderSize = 0;
            this.uyeIslemBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(27)))));
            this.uyeIslemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uyeIslemBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uyeIslemBtn.ForeColor = System.Drawing.Color.White;
            this.uyeIslemBtn.Location = new System.Drawing.Point(249, 65);
            this.uyeIslemBtn.Margin = new System.Windows.Forms.Padding(4);
            this.uyeIslemBtn.Name = "uyeIslemBtn";
            this.uyeIslemBtn.Size = new System.Drawing.Size(165, 78);
            this.uyeIslemBtn.TabIndex = 18;
            this.uyeIslemBtn.Text = "Üye İşlemleri";
            this.uyeIslemBtn.UseVisualStyleBackColor = false;
            this.uyeIslemBtn.Click += new System.EventHandler(this.uyeIslemBtn_Click);
            // 
            // emanetIslemBtn
            // 
            this.emanetIslemBtn.BackColor = System.Drawing.Color.Indigo;
            this.emanetIslemBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emanetIslemBtn.FlatAppearance.BorderSize = 0;
            this.emanetIslemBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(27)))));
            this.emanetIslemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emanetIslemBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.emanetIslemBtn.ForeColor = System.Drawing.Color.White;
            this.emanetIslemBtn.Location = new System.Drawing.Point(62, 166);
            this.emanetIslemBtn.Margin = new System.Windows.Forms.Padding(4);
            this.emanetIslemBtn.Name = "emanetIslemBtn";
            this.emanetIslemBtn.Size = new System.Drawing.Size(165, 78);
            this.emanetIslemBtn.TabIndex = 17;
            this.emanetIslemBtn.Text = "Emanet İşlemleri";
            this.emanetIslemBtn.UseVisualStyleBackColor = false;
            this.emanetIslemBtn.Click += new System.EventHandler(this.emanetIslemBtn_Click);
            // 
            // kitapIslemBtn
            // 
            this.kitapIslemBtn.BackColor = System.Drawing.Color.Indigo;
            this.kitapIslemBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kitapIslemBtn.FlatAppearance.BorderSize = 0;
            this.kitapIslemBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(27)))));
            this.kitapIslemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kitapIslemBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.kitapIslemBtn.ForeColor = System.Drawing.Color.White;
            this.kitapIslemBtn.Location = new System.Drawing.Point(62, 65);
            this.kitapIslemBtn.Margin = new System.Windows.Forms.Padding(4);
            this.kitapIslemBtn.Name = "kitapIslemBtn";
            this.kitapIslemBtn.Size = new System.Drawing.Size(165, 78);
            this.kitapIslemBtn.TabIndex = 16;
            this.kitapIslemBtn.Text = "Kitap İşlemleri";
            this.kitapIslemBtn.UseVisualStyleBackColor = false;
            this.kitapIslemBtn.Click += new System.EventHandler(this.kitapIslemBtn_Click);
            // 
            // adminIslemBtn
            // 
            this.adminIslemBtn.BackColor = System.Drawing.Color.Indigo;
            this.adminIslemBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminIslemBtn.FlatAppearance.BorderSize = 0;
            this.adminIslemBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(27)))));
            this.adminIslemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminIslemBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.adminIslemBtn.ForeColor = System.Drawing.Color.White;
            this.adminIslemBtn.Location = new System.Drawing.Point(249, 166);
            this.adminIslemBtn.Margin = new System.Windows.Forms.Padding(4);
            this.adminIslemBtn.Name = "adminIslemBtn";
            this.adminIslemBtn.Size = new System.Drawing.Size(165, 78);
            this.adminIslemBtn.TabIndex = 20;
            this.adminIslemBtn.Text = "Admin İşlemleri";
            this.adminIslemBtn.UseVisualStyleBackColor = false;
            this.adminIslemBtn.Click += new System.EventHandler(this.adminIslemBtn_Click);
            // 
            // FormAdminAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(509, 329);
            this.Controls.Add(this.adminIslemBtn);
            this.Controls.Add(this.uyeIslemBtn);
            this.Controls.Add(this.emanetIslemBtn);
            this.Controls.Add(this.kitapIslemBtn);
            this.Name = "FormAdminAnasayfa";
            this.Text = "FormAdminAnasayfa";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button uyeIslemBtn;
        private System.Windows.Forms.Button emanetIslemBtn;
        private System.Windows.Forms.Button kitapIslemBtn;
        private System.Windows.Forms.Button adminIslemBtn;
    }
}