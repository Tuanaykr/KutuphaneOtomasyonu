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
    public partial class FormProfilIslemleri : Form
    {
        private ClassSql classSql;

        public FormProfilIslemleri()
        {
            InitializeComponent();
            classSql = ClassSql.GetInstance();
            LoadProfileData(ClassVeriler.UyeID);

        }

        private void FormProfilIslemleri_Load(object sender, EventArgs e)
        {

        }

        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string ad = adTxt.Text;
                string soyad = soyadTxt.Text;
                string email = mailTxt.Text;
                string sifre = sifreTxt.Text;
                string telefon = telefonTxt.Text;
                string adres = adresTxt.Text;

                bool basarili = classSql.UyeBilgileriGuncelle(ClassVeriler.UyeID, ad, soyad, email, sifre, telefon, adres);
                if (basarili)
                {
                    MessageBox.Show("Üye bilgileri başarıyla güncellendi.");
                }
                else
                {
                    MessageBox.Show("Üye bilgileri güncellenirken bir hata oluştu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Üye bilgileri güncellenirken bir hata oluştu: " + ex.Message);
            }
        }


        private void LoadProfileData(int uyeID)
        {
            DataTable userData = classSql.GetUyeDataByID(uyeID);

            if (userData.Rows.Count > 0)
            {
                DataRow row = userData.Rows[0];
                adTxt.Text = row["ad"].ToString();
                soyadTxt.Text = row["soyad"].ToString();
                mailTxt.Text = row["email"].ToString();
                sifreTxt.Text = row["sifre"].ToString();
                telefonTxt.Text = row["telefon"].ToString();
                adresTxt.Text = row["adres"].ToString();
            }
        }
    }
}
