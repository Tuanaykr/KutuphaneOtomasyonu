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
    public partial class FormKitapIslemleri : Form
    {

        private ClassSql classSql;
        public FormKitapIslemleri()
        {
            InitializeComponent();
            classSql = ClassSql.GetInstance();
        }
        
        private void FormKitapIslemleri_Load(object sender, EventArgs e)
        {
            DataTable dataTable = classSql.TumKitaplariGetir();
            dataGridView1.DataSource = dataTable;

            dataGridView1.Columns["kitapID"].Visible = false;
            dataGridView1.Columns["ISBN"].HeaderText = "ISBN";
            dataGridView1.Columns["ad"].HeaderText = "Kitap Adı";
            dataGridView1.Columns["yazar"].HeaderText = "Yazar";
            dataGridView1.Columns["baskiYili"].HeaderText = "Baskı Yılı";
            dataGridView1.Columns["yayinEvi"].HeaderText = "Yayın Evi";
            dataGridView1.Columns["sayfaSayisi"].HeaderText = "Sayfa Sayısı";
            dataGridView1.Columns["aciklama"].HeaderText = "Açıklama";
            dataGridView1.Columns["kategoriID"].Visible = false;

            DataTable kategoriler = classSql.TumKategorileriGetir();
            kategoriComboBox.DataSource = kategoriler;
            kategoriComboBox.DisplayMember = "kategoriAdi";
            kategoriComboBox.ValueMember = "kategoriID";
        }

        private void araBtn_Click(object sender, EventArgs e)
        {
            string anahtarKelime = kitapAraTxt.Text.Trim();
            ClassSql classSql = ClassSql.GetInstance();
            DataTable sonuclar = classSql.FiltreleKitap(anahtarKelime);
            dataGridView1.DataSource = sonuclar;
        }

        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            string isbn = ISBNTxt.Text.Trim();
            string kitapAdi = adTxt.Text.Trim();
            string yazar = yazarTxt.Text.Trim();
            string baskiYili = baskiYiliTxt.Text.Trim();
            string yayinEvi = yayinEviTxt.Text.Trim();
            string sayfaSayisi = sayfaSayisiTxt.Text.Trim();
            string aciklama = aciklamaTxt.Text.Trim();
            int kategoriID = Convert.ToInt32(kategoriComboBox.SelectedValue);

            ClassSql classSql = ClassSql.GetInstance();

            if (!classSql.BosKontrolu(ISBNTxt, adTxt, yazarTxt, baskiYiliTxt, yayinEviTxt, sayfaSayisiTxt, aciklamaTxt))
            {
                return;
            }

            bool kitapEklendi = classSql.KitapEkle(isbn, kitapAdi, yazar, baskiYili, yayinEvi, sayfaSayisi, aciklama, kategoriID);

            if (kitapEklendi)
            {
                MessageBox.Show("Kitap başarıyla eklendi.");
                DataTable kitaplar = classSql.TumKitaplariGetir();
                dataGridView1.DataSource = kitaplar;
            }
            else
            {
                MessageBox.Show("Kitap eklenirken bir hata oluştu.");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                ISBNTxt.Text = row.Cells["ISBN"].Value.ToString();
                adTxt.Text = row.Cells["ad"].Value.ToString();
                yazarTxt.Text = row.Cells["yazar"].Value.ToString();
                baskiYiliTxt.Text = row.Cells["baskiYili"].Value.ToString();
                yayinEviTxt.Text = row.Cells["yayinEvi"].Value.ToString();
                sayfaSayisiTxt.Text = row.Cells["sayfaSayisi"].Value.ToString();
                aciklamaTxt.Text = row.Cells["aciklama"].Value.ToString();

                if (row.Cells["kategoriID"].Value != DBNull.Value)
                {
                    kategoriComboBox.SelectedValue = row.Cells["kategoriID"].Value;
                }
                else
                {
                    kategoriComboBox.SelectedIndex = -1;
                }
            }
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            string isbn = ISBNTxt.Text.Trim();
            string kitapAdi = adTxt.Text.Trim();
            string yazar = yazarTxt.Text.Trim();
            string baskiYili = baskiYiliTxt.Text.Trim();
            string yayinEvi = yayinEviTxt.Text.Trim();
            string sayfaSayisi = sayfaSayisiTxt.Text.Trim();
            string aciklama = aciklamaTxt.Text.Trim();
            int kategoriID = Convert.ToInt32(kategoriComboBox.SelectedValue);

            DataGridViewRow selectedRow = dataGridView1.CurrentRow;
            int kitapID = Convert.ToInt32(selectedRow.Cells["kitapID"].Value);

            ClassSql classSql = ClassSql.GetInstance();
            bool kitapGuncellendi = classSql.KitapGuncelle(kitapID, isbn, kitapAdi, yazar, baskiYili, yayinEvi, sayfaSayisi, aciklama, kategoriID);

            if (kitapGuncellendi)
            {
                MessageBox.Show("Kitap başarıyla güncellendi.");
                DataTable kitaplar = classSql.TumKitaplariGetir();
                dataGridView1.DataSource = kitaplar;
            }
            else
            {
                MessageBox.Show("Kitap güncellenirken bir hata oluştu.");
            }
        }
    }
}
