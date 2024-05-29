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
   
    public partial class FormUyeAnasayfa : Form
    {
        private ClassSql classSql;
        

        public FormUyeAnasayfa()
        {
            InitializeComponent();
            classSql = ClassSql.GetInstance();
            
        }

        private void uzerimdekilerBtn_Click(object sender, EventArgs e)
        {
            int uyeID = ClassVeriler.UyeID;
            FormUzerimdekiKitaplar uzerimdekiler = new FormUzerimdekiKitaplar(uyeID);
            uzerimdekiler.ShowDialog();
        }
        private void profilIslemBtn_Click(object sender, EventArgs e)
        {
            FormProfilIslemleri profilIslemleri = new FormProfilIslemleri();
            profilIslemleri.ShowDialog();
        }

        private void FormUyeAnasayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
