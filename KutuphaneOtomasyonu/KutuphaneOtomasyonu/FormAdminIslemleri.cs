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
    public partial class FormAdminIslemleri : Form
    {
        private ClassSql classSql;
        public FormAdminIslemleri()
        {
            InitializeComponent();
            classSql = ClassSql.GetInstance();
        }

        private void FormAdminIslemleri_Load(object sender, EventArgs e)
        {
            DataTable dataTable = classSql.TumAdminleriGetir();
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns["adminID"].HeaderText = "Admin ID";
            dataGridView1.Columns["ad"].HeaderText = "Ad";
            dataGridView1.Columns["soyad"].HeaderText = "Soyad";
            dataGridView1.Columns["eMail"].HeaderText = "Email";
            dataGridView1.Columns["telefon"].HeaderText = "Telefon";
            dataGridView1.Columns["adres"].HeaderText = "Adres";
        }

        private void araBtn_Click(object sender, EventArgs e)
        {
            string anahtarKelime = adminAraTxt.Text.Trim();

            ClassSql classSql = ClassSql.GetInstance();

            DataTable sonuclar = classSql.FiltreleAdmin(anahtarKelime);

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
            bool basarili = classSql.AdminEkle(ad, soyad, email, telefon, adres);

            if (basarili)
            {
                MessageBox.Show("Admin başarıyla eklendi.");
                DataTable adminler = classSql.TumAdminleriGetir();
                dataGridView1.DataSource = adminler;
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
                int adminID = Convert.ToInt32(row.Cells["adminID"].Value);

                string ad = adTxt.Text.Trim();
                string soyad = soyadTxt.Text.Trim();
                string email = mailTxt.Text.Trim();
                string telefon = telefonTxt.Text.Trim();
                string adres = adresTxt.Text.Trim();

                bool basarili = classSql.AdminGuncelle(adminID, ad, soyad, email, telefon, adres);

                if (basarili)
                {
                    MessageBox.Show("Admin başarıyla güncellendi.");
                    DataTable adminler = classSql.TumAdminleriGetir();
                    dataGridView1.DataSource = adminler;
                }
                else
                {
                    MessageBox.Show("Admin güncellenirken bir hata oluştu.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz admini seçin.");
            }
        }

        private void SilBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                int adminID = Convert.ToInt32(row.Cells["adminID"].Value);

                DialogResult dialogResult = MessageBox.Show("Bu admini silmek istediğinizden emin misiniz?", "Admin Sil", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bool basarili = classSql.AdminSil(adminID);

                    if (basarili)
                    {
                        MessageBox.Show("Admin başarıyla silindi.");
                        DataTable adminler = classSql.TumAdminleriGetir();
                        dataGridView1.DataSource = adminler;
                    }
                    else
                    {
                        MessageBox.Show("Admin silinirken bir hata oluştu.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz admini seçin.");
            }
        }
    }
}
