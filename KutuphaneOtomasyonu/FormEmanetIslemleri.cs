using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace KutuphaneOtomasyonu
{
    public partial class FormEmanetIslemleri : Form
    {
        private ClassSql classSql;
        public FormEmanetIslemleri()
        {
            InitializeComponent();
            classSql = ClassSql.GetInstance();
        }
        private void FormEmanetIslemleri_Load(object sender, EventArgs e)
        {
            kitapIDTxt.Enabled = false;
            uyeIDTxt.Enabled = false;
            DataTable dataTable = classSql.TumUyeleriGetir();
            DataTable dataTable2 = classSql.TumRaftakiKitaplariGetir();
            DataTable dataTable3 = classSql.TumIslemleriGetir();

            // DataGridView'e tüm üyeleri yükler
            dataGridView1.DataSource = dataTable;
            dataGridView2.DataSource = dataTable2;
            dataGridView3.DataSource = dataTable3;

            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today.AddDays(15);

            //üye
            dataGridView1.Columns["uyeID"].HeaderText = "Üye ID";
            dataGridView1.Columns["ad"].HeaderText = "Ad";
            dataGridView1.Columns["soyad"].HeaderText = "Soyad";
            dataGridView1.Columns["eMail"].HeaderText = "Email";
            dataGridView1.Columns["telefon"].HeaderText = "Telefon";
            dataGridView1.Columns["adres"].HeaderText = "Adres";

            //kitap
            dataGridView2.Columns["kitapID"].HeaderText = "Kitap ID";
            dataGridView2.Columns["ISBN"].HeaderText = "ISBN";
            dataGridView2.Columns["ad"].HeaderText = "Kitap Adı";
            dataGridView2.Columns["yazar"].HeaderText = "Yazar";
            dataGridView2.Columns["baskiYili"].HeaderText = "Baskı Yılı";
            dataGridView2.Columns["yayinEvi"].HeaderText = "Yayın Evi";
            dataGridView2.Columns["sayfaSayisi"].HeaderText = "Sayfa Sayısı";
            dataGridView2.Columns["aciklama"].HeaderText = "Açıklama";
        }
        private void uyeAraBtn_Click(object sender, EventArgs e)
        {
            string anahtarKelime = uyeAraTxt.Text.Trim();
            ClassSql classSql = ClassSql.GetInstance();
            DataTable sonuclar = classSql.FiltreleUye(anahtarKelime);
            dataGridView1.DataSource = sonuclar;
        }

        private void kitapAraBtn_Click(object sender, EventArgs e)
        {
            string anahtarKelime = kitapAraTxt.Text.Trim();
            ClassSql classSql = ClassSql.GetInstance();
            DataTable sonuclar = classSql.FiltreleKitap(anahtarKelime);
            dataGridView2.DataSource = sonuclar;
        }

        private void islemAraBtn_Click(object sender, EventArgs e)
        {
            string anahtarKelime = islemAraTxt.Text.Trim();
            ClassSql classSql = ClassSql.GetInstance();
            DataTable sonuclar = classSql.FiltreleIslem(anahtarKelime);
            dataGridView3.DataSource = sonuclar;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                uyeIDTxt.Text = row.Cells["uyeID"].Value.ToString();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                kitapIDTxt.Text = row.Cells["kitapID"].Value.ToString();
            }
        }

        private void teslimVerBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int uyeID = int.Parse(uyeIDTxt.Text);
                int kitapID = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["kitapID"].Value);
                DateTime islemTarihi = dateTimePicker1.Value;
                DateTime iadeTarihi = dateTimePicker2.Value;
                int adminID = ClassVeriler.AdminID;

                ClassSql classSql = ClassSql.GetInstance();
                bool basarili = classSql.TeslimVer(uyeID, kitapID, islemTarihi, iadeTarihi, adminID);

                if (basarili)
                {
                    MessageBox.Show("Kitap başarıyla emanet verildi.");

                    dataGridView2.Rows.RemoveAt(dataGridView2.SelectedRows[0].Index);
                    DataTable islemTablosu = classSql.TumIslemleriGetir();
                    dataGridView3.DataSource = islemTablosu;
                }
                else
                {
                    MessageBox.Show("Kitap emanet verilirken bir hata oluştu.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen emanet vermek istediğiniz kitabı seçin.");
            }
        }

        private void teslimAlBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                int islemID = Convert.ToInt32(dataGridView3.SelectedRows[0].Cells["islemID"].Value);
                int kitapID = Convert.ToInt32(dataGridView3.SelectedRows[0].Cells["kitapID"].Value);

                ClassSql classSql = ClassSql.GetInstance();
                bool basarili = classSql.TeslimAl(islemID, kitapID);

                if (basarili)
                {
                    MessageBox.Show("Kitap başarıyla geri alındı.");

                    dataGridView3.Rows.RemoveAt(dataGridView3.SelectedRows[0].Index);
                    DataTable kitapTablosu = classSql.TumRaftakiKitaplariGetir();
                    dataGridView2.DataSource = kitapTablosu;
                }
                else
                {
                    MessageBox.Show("Kitap geri alınırken bir hata oluştu.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen geri almak istediğiniz işlemi seçin.");
            }
        }
    }
}

