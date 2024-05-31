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
    public partial class FormKayitOl : Form
    {
        private ClassSql classSql;
        public FormKayitOl()
        {
            InitializeComponent();
            classSql = ClassSql.GetInstance();
        }

        private void kayitOlBtn_Click(object sender, EventArgs e)
        {
            string ad = adTxt.Text;
            string soyad = soyadTxt.Text;
            string email = emailTxt.Text;
            string sifre = sifreTxt.Text;
            string telefon = telefonTxt.Text;
            string adres = adresTxt.Text;

            ClassSql sqlInstance = ClassSql.GetInstance();
            bool kayitBasarili = sqlInstance.KayitOl("uye", ad, soyad, email, sifre, telefon, adres);

            if (kayitBasarili)
            {
                MessageBox.Show("Kayıt işlemi başarıyla gerçekleştirildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Kayıt işlemi sırasında bir hata oluştu. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
