
namespace NTB2
{
    partial class frmOgrenciBul
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
            this.gbOgrenciBulmaEkrani = new System.Windows.Forms.GroupBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.lblOgrenciNo = new System.Windows.Forms.Label();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.gbOgrenciBulmaEkrani.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOgrenciBulmaEkrani
            // 
            this.gbOgrenciBulmaEkrani.Controls.Add(this.txtNumara);
            this.gbOgrenciBulmaEkrani.Controls.Add(this.lblOgrenciNo);
            this.gbOgrenciBulmaEkrani.Location = new System.Drawing.Point(55, 41);
            this.gbOgrenciBulmaEkrani.Name = "gbOgrenciBulmaEkrani";
            this.gbOgrenciBulmaEkrani.Size = new System.Drawing.Size(302, 103);
            this.gbOgrenciBulmaEkrani.TabIndex = 0;
            this.gbOgrenciBulmaEkrani.TabStop = false;
            this.gbOgrenciBulmaEkrani.Text = "Öğrenci Bulma Ekranı";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(117, 159);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(150, 23);
            this.btnAra.TabIndex = 1;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // lblOgrenciNo
            // 
            this.lblOgrenciNo.AutoSize = true;
            this.lblOgrenciNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrenciNo.Location = new System.Drawing.Point(62, 20);
            this.lblOgrenciNo.Name = "lblOgrenciNo";
            this.lblOgrenciNo.Size = new System.Drawing.Size(146, 13);
            this.lblOgrenciNo.TabIndex = 0;
            this.lblOgrenciNo.Text = "Öğrenci Numarası Giriniz";
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(62, 51);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(147, 20);
            this.txtNumara.TabIndex = 1;
            this.txtNumara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumara_KeyPress);
            // 
            // frmOgrenciBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(397, 203);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.gbOgrenciBulmaEkrani);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOgrenciBul";
            this.Text = "frmOgrenciBul";
            this.gbOgrenciBulmaEkrani.ResumeLayout(false);
            this.gbOgrenciBulmaEkrani.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOgrenciBulmaEkrani;
        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.Label lblOgrenciNo;
        private System.Windows.Forms.Button btnAra;
    }
}