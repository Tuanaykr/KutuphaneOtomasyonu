using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class FormUzerimdekiKitaplar : Form
    {
        
        private ClassSql classSql;
        private int uyeID;

        public FormUzerimdekiKitaplar(int uyeID)
        {
            InitializeComponent();
            classSql = ClassSql.GetInstance();
            this.uyeID = uyeID;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormUzerimdekiKitaplar_Load(object sender, EventArgs e)
        {
            DataTable uzerimdekiKitaplar = classSql.UzerimdekiKitaplariGetir(uyeID);
            dataGridView1.DataSource = uzerimdekiKitaplar;

            dataGridView1.AutoGenerateColumns = true;
        }

        private void kitapUzatBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DateTime iadeTarihi = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["IadeTarihi"].Value);

                DateTime yeniIadeTarihi = iadeTarihi.AddDays(15);

                dataGridView1.SelectedRows[0].Cells["IadeTarihi"].Value = yeniIadeTarihi.ToString("yyyy-MM-dd");

                int kitapID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["kitapID"].Value);

                ClassSql classSql = ClassSql.GetInstance();

                bool basarili = classSql.KitapIadeTarihiniGuncelle(kitapID, yeniIadeTarihi);

                if (basarili)
                {
                    MessageBox.Show("Kitap iade tarihi başarıyla güncellendi.");
                }
                else
                {
                    MessageBox.Show("Kitap iade tarihi güncellenirken bir hata oluştu.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir kitap seçin.");
            }
        }
    }
}
