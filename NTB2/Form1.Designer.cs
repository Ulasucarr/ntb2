
namespace NTB2
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.gbOgrenciBilgileri = new System.Windows.Forms.GroupBox();
            this.lblNumara = new System.Windows.Forms.Label();
            this.lblSoyadi = new System.Windows.Forms.Label();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.gbOgrenciBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOgrenciBilgileri
            // 
            this.gbOgrenciBilgileri.Controls.Add(this.lblNumara);
            this.gbOgrenciBilgileri.Controls.Add(this.lblSoyadi);
            this.gbOgrenciBilgileri.Controls.Add(this.txtNumara);
            this.gbOgrenciBilgileri.Controls.Add(this.txtSoyadi);
            this.gbOgrenciBilgileri.Controls.Add(this.txtAdi);
            this.gbOgrenciBilgileri.Controls.Add(this.lblAd);
            resources.ApplyResources(this.gbOgrenciBilgileri, "gbOgrenciBilgileri");
            this.gbOgrenciBilgileri.Name = "gbOgrenciBilgileri";
            this.gbOgrenciBilgileri.TabStop = false;
            // 
            // lblNumara
            // 
            resources.ApplyResources(this.lblNumara, "lblNumara");
            this.lblNumara.Name = "lblNumara";
            // 
            // lblSoyadi
            // 
            resources.ApplyResources(this.lblSoyadi, "lblSoyadi");
            this.lblSoyadi.Name = "lblSoyadi";
            // 
            // txtNumara
            // 
            resources.ApplyResources(this.txtNumara, "txtNumara");
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumara_KeyPress);
            // 
            // txtSoyadi
            // 
            resources.ApplyResources(this.txtSoyadi, "txtSoyadi");
            this.txtSoyadi.Name = "txtSoyadi";
            // 
            // txtAdi
            // 
            resources.ApplyResources(this.txtAdi, "txtAdi");
            this.txtAdi.Name = "txtAdi";
            // 
            // lblAd
            // 
            resources.ApplyResources(this.lblAd, "lblAd");
            this.lblAd.Name = "lblAd";
            // 
            // btnBul
            // 
            resources.ApplyResources(this.btnBul, "btnBul");
            this.btnBul.Name = "btnBul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnSil
            // 
            resources.ApplyResources(this.btnSil, "btnSil");
            this.btnSil.Name = "btnSil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            resources.ApplyResources(this.btnKaydet, "btnKaydet");
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnTemizle
            // 
            resources.ApplyResources(this.btnTemizle, "btnTemizle");
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.gbOgrenciBilgileri);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbOgrenciBilgileri.ResumeLayout(false);
            this.gbOgrenciBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOgrenciBilgileri;
        private System.Windows.Forms.Label lblNumara;
        private System.Windows.Forms.Label lblSoyadi;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Button btnBul;
        public System.Windows.Forms.TextBox txtNumara;
        public System.Windows.Forms.TextBox txtSoyadi;
        public System.Windows.Forms.TextBox txtAdi;
        public System.Windows.Forms.Button btnSil;
        public System.Windows.Forms.Button btnTemizle;
        public System.Windows.Forms.Button btnKaydet;
    }
}

