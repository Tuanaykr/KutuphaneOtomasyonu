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
    public partial class FormGirisYap : Form
    {
        private ClassSql classSql;
        public FormGirisYap()
        {
            InitializeComponent();
            classSql = ClassSql.GetInstance();
        }

        private void girisBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string email = emailTxt.Text;
                string sifre = sifreTxt.Text;
                bool isAdminSelected = radioAdmin.Checked;
                bool isUserSelected = radioKullanici.Checked;

                ClassSql classSql = ClassSql.GetInstance();
                string rol = classSql.GirisKontrol(email, sifre);

                if (isAdminSelected && rol != "Admin")
                {
                    MessageBox.Show("Yanlış seçim yaptınız. Lütfen tekrar deneyiniz.");
                    return;
                }

                if (isUserSelected && rol != "Kullanici")
                {
                    MessageBox.Show("Yanlış seçim yaptınız. Lütfen tekrar deneyiniz.");
                    return;
                }

                if (rol == "Admin")
                {
                    int adminID = classSql.GetAdminIDByEmail(email);
                    ClassVeriler.AdminID = adminID;

                    FormAdminAnasayfa formAdminAnasayfa = new FormAdminAnasayfa();
                    formAdminAnasayfa.ShowDialog();
                    this.Hide();
                }
                else if (rol == "Kullanici")
                {
                    int uyeID = classSql.GetUyeIDByEmail(email);
                    ClassVeriler.UyeID = uyeID;

                    if (classSql.UyeIadeEdilmemisKitabiVarMi(uyeID))
                    {
                        MessageBox.Show("İade etmeniz gereken bir kitabınız bulunmaktadır. Kitap iadesi yapılana kadar hesabınıza giriş yapamazsınız.");
                        return;
                    }
                    else
                    {
                        FormUyeAnasayfa formUyeAnasayfa = new FormUyeAnasayfa();
                        formUyeAnasayfa.ShowDialog();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            /*
            if (radioAdmin.Checked)
            {
                FormAdminAnasayfa admin = new FormAdminAnasayfa();
                admin.ShowDialog();
            }
            if (radioKullanici.Checked)
            {
                FormUyeAnasayfa uye = new FormUyeAnasayfa();
                uye.ShowDialog();
            }*/



        }
    }
}
