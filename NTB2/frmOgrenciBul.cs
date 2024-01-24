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
    public partial class frmOgrenciBul : Form
    {
        public frmMain mainForm;
        public frmOgrenciBul()
        {
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNumara.Text))
            {
                MessageBox.Show("Aramak istediğiniz öğrenci numarasını giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            OgrenciBLL ogrenciBAL = new OgrenciBLL();
            Ogrenci ogrenci = ogrenciBAL.ara(Convert.ToInt32(txtNumara.Text));

            if (ogrenci != null && ogrenci.Numara>0)
            {
                mainForm.OgrenciId = ogrenci.OgrenciId;
                mainForm.txtAdi.Text = ogrenci.Adi;
                mainForm.txtSoyadi.Text = ogrenci.Soyadi;
                mainForm.txtNumara.Text = ogrenci.Numara.ToString();
                mainForm.btnKaydet.Text = "GÜNCELLE";
                mainForm.btnSil.Visible = true;
                mainForm.btnTemizle.Visible = true;
                this.Close();

            }
            else
            {
                MessageBox.Show("Aramış olduğunuz numaraya sahib öğrenci bulunamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }  
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
    }
}
