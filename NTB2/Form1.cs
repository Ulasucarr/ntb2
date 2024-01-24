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

namespace NTB2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public int? OgrenciId { get; set; }
        private void btnBul_Click(object sender, EventArgs e)
        {
            frmOgrenciBul frmOgrenciBul = new frmOgrenciBul();
            frmOgrenciBul.mainForm = this;
            frmOgrenciBul.Show();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            OgrenciBLL ogrenciBAL = new OgrenciBLL(); 
            if (ogrenciBAL.sil(OgrenciId.Value))
            {
                MessageBox.Show("Öğrenci Bilgisi Silindi...");
                temizle();
            }
            else
            {
                MessageBox.Show(" Öğrenci Silinemedi");
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAdi.Text) || String.IsNullOrEmpty(txtSoyadi.Text) || String.IsNullOrEmpty(txtNumara.Text))
            {
                MessageBox.Show("Öğrenci adı,soyadı ve numarasını giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            OgrenciBLL ogrenciBAL = new OgrenciBLL();
            if (ogrenciBAL.ogrenciNumarasiVarmi(new Ogrenci() { Adi = txtAdi.Text, Soyadi = txtSoyadi.Text, Numara = Convert.ToInt32(txtNumara.Text), OgrenciId = OgrenciId }))
            {
                MessageBox.Show("Öğrenci Numarası kullanılmaktadır", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } 
            if (OgrenciId == null)
            {
                bool sonuc = ogrenciBAL.kaydet(new Ogrenci() { Adi = txtAdi.Text, Soyadi = txtSoyadi.Text, Numara = Convert.ToInt32(txtNumara.Text) });
                if (sonuc)
                {
                    MessageBox.Show("Kaydetme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                bool sonuc = ogrenciBAL.guncelle(new Ogrenci() { Adi = txtAdi.Text, Soyadi = txtSoyadi.Text, Numara = Convert.ToInt32(txtNumara.Text),OgrenciId=OgrenciId.Value });
                if (sonuc)
                {
                    MessageBox.Show("Güncelleme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            temizle();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnSil.Visible = false;
            btnTemizle.Visible = false;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void txtNumara_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        } 

        public void temizle()
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtNumara.Clear();
            txtAdi.Focus();
            btnKaydet.Text = "KAYDET";
            btnSil.Visible = false;
            btnTemizle.Visible = false;
            OgrenciId = null;
        }
    }
}
