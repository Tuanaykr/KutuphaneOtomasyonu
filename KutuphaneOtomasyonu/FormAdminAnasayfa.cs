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
    public partial class FormAdminAnasayfa : Form
    {
        public FormAdminAnasayfa()
        {
            InitializeComponent();
        }

        private void kitapIslemBtn_Click(object sender, EventArgs e)
        {
            FormKitapIslemleri kitapIslemleri = new FormKitapIslemleri();
            kitapIslemleri.ShowDialog();
        }

        private void uyeIslemBtn_Click(object sender, EventArgs e)
        {
            FormUyeIslemleri uyeIslemleri = new FormUyeIslemleri();
            uyeIslemleri.ShowDialog();
        }

        private void emanetIslemBtn_Click(object sender, EventArgs e)
        {
            FormEmanetIslemleri emanetIslemleri = new FormEmanetIslemleri();
            emanetIslemleri.ShowDialog();
        }

        private void adminIslemBtn_Click(object sender, EventArgs e)
        {
            FormAdminIslemleri adminIslemleri = new FormAdminIslemleri();
            adminIslemleri.ShowDialog();
        }
    }
}
