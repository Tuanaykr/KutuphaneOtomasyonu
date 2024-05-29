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
    public partial class FormUyeIslemleri : Form
    {
        private ClassSql classSql;
        public FormUyeIslemleri()
        {
            InitializeComponent();
            classSql = ClassSql.GetInstance();
        }   
        
        
        private void FormUyeIslemleri_Load(object sender, EventArgs e)
        {
            DataTable dataTable = classSql.TumUyeleriGetir();
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns["uyeID"].HeaderText = "Üye ID";
            dataGridView1.Columns["ad"].HeaderText = "Ad";
            dataGridView1.Columns["soyad"].HeaderText = "Soyad";
            dataGridView1.Columns["eMail"].HeaderText = "Email";
            dataGridView1.Columns["telefon"].HeaderText = "Telefon";
            dataGridView1.Columns["adres"].HeaderText = "Adres";
        }

        private void araBtn_Click(object sender, EventArgs e)
        {
            string anahtarKelime = uyeAraTxt.Text.Trim();

            ClassSql classSql = ClassSql.GetInstance();

            DataTable sonuclar = classSql.FiltreleUye(anahtarKelime);

            dataGridView1.DataSource = sonuclar;
        }

        private void kaydetBtn_Click(object sender, EventArgs e)
        {
            string ad = adTxt.Text.Trim();
            string soyad = soyadTxt.Text.Trim();
            string email = mailTxt.Text.Trim();
            string telefon = telefonTxt.Text.Trim();
            string adres = adresTxt.Text.Trim();

            ClassSql classSql = ClassSql.GetInstance();
            bool basarili = classSql.UyeEkle(ad, soyad, email, telefon, adres);

            if (basarili)
            {
                MessageBox.Show("Üye başarıyla eklendi.");
                DataTable uyeler = classSql.TumUyeleriGetir();
                dataGridView1.DataSource = uyeler;
            }
            else
            {
                MessageBox.Show("Bu e-posta adresiyle kayıtlı kullanıcı bulunmaktadır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                adTxt.Text = row.Cells["ad"].Value.ToString();
                soyadTxt.Text = row.Cells["soyad"].Value.ToString();
                mailTxt.Text = row.Cells["email"].Value.ToString();
                telefonTxt.Text = row.Cells["telefon"].Value.ToString();
                adresTxt.Text = row.Cells["adres"].Value.ToString();
            }
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                int uyeID = Convert.ToInt32(row.Cells["uyeID"].Value);

                string ad = adTxt.Text.Trim();
                string soyad = soyadTxt.Text.Trim();
                string email = mailTxt.Text.Trim();
                string telefon = telefonTxt.Text.Trim();
                string adres = adresTxt.Text.Trim();

                bool basarili = classSql.UyeGuncelle(uyeID, ad, soyad, email, telefon, adres);

                if (basarili)
                {
                    MessageBox.Show("Üye başarıyla güncellendi.");
                    DataTable uyeler = classSql.TumUyeleriGetir();
                    dataGridView1.DataSource = uyeler;
                }
                else
                {
                    MessageBox.Show("Üye güncellenirken bir hata oluştu.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz üyeyi seçin.");
            }
        }

        private void SilBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                int uyeID = Convert.ToInt32(row.Cells["uyeID"].Value);

                DialogResult dialogResult = MessageBox.Show("Bu üyeyi silmek istediğinizden emin misiniz?", "Üye Sil", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bool basarili = classSql.UyeSil(uyeID);

                    if (basarili)
                    {
                        MessageBox.Show("Üye başarıyla silindi.");
                        DataTable uyeler = classSql.TumUyeleriGetir();
                        dataGridView1.DataSource = uyeler;
                    }
                    else
                    {
                        MessageBox.Show("Üye silinirken bir hata oluştu.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz üyeyi seçin.");
            }
        }
    }
}
