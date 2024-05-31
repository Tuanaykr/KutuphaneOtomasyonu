namespace KutuphaneOtomasyonu
{
    partial class FormUzerimdekiKitaplar
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
            this.kitapUzatBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // kitapUzatBtn
            // 
            this.kitapUzatBtn.BackColor = System.Drawing.Color.Indigo;
            this.kitapUzatBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kitapUzatBtn.FlatAppearance.BorderSize = 0;
            this.kitapUzatBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(27)))));
            this.kitapUzatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kitapUzatBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.kitapUzatBtn.ForeColor = System.Drawing.Color.White;
            this.kitapUzatBtn.Location = new System.Drawing.Point(450, 26);
            this.kitapUzatBtn.Margin = new System.Windows.Forms.Padding(4);
            this.kitapUzatBtn.Name = "kitapUzatBtn";
            this.kitapUzatBtn.Size = new System.Drawing.Size(222, 48);
            this.kitapUzatBtn.TabIndex = 60;
            this.kitapUzatBtn.Text = "İade Tarihini Uzat";
            this.kitapUzatBtn.UseVisualStyleBackColor = false;
            this.kitapUzatBtn.Click += new System.EventHandler(this.kitapUzatBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(621, 382);
            this.dataGridView1.TabIndex = 62;
            // 
            // FormUzerimdekiKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(729, 475);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.kitapUzatBtn);
            this.Name = "FormUzerimdekiKitaplar";
            this.Text = "FormUzerimdekiKitaplar";
            this.Load += new System.EventHandler(this.FormUzerimdekiKitaplar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button kitapUzatBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}