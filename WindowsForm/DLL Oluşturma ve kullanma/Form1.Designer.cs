namespace DLL_Oluşturma_ve_kullanma
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_sayi1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sayi2 = new System.Windows.Forms.TextBox();
            this.btn_topla = new System.Windows.Forms.Button();
            this.btn_eksi = new System.Windows.Forms.Button();
            this.btn_bolme = new System.Windows.Forms.Button();
            this.btn_carpma = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Sayıyı Giriniz :";
            // 
            // txt_sayi1
            // 
            this.txt_sayi1.Location = new System.Drawing.Point(174, 65);
            this.txt_sayi1.Name = "txt_sayi1";
            this.txt_sayi1.Size = new System.Drawing.Size(100, 20);
            this.txt_sayi1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "2. Sayıyı Giriniz :";
            // 
            // txt_sayi2
            // 
            this.txt_sayi2.Location = new System.Drawing.Point(174, 110);
            this.txt_sayi2.Name = "txt_sayi2";
            this.txt_sayi2.Size = new System.Drawing.Size(100, 20);
            this.txt_sayi2.TabIndex = 1;
            // 
            // btn_topla
            // 
            this.btn_topla.Location = new System.Drawing.Point(74, 185);
            this.btn_topla.Name = "btn_topla";
            this.btn_topla.Size = new System.Drawing.Size(40, 23);
            this.btn_topla.TabIndex = 2;
            this.btn_topla.Text = "+";
            this.btn_topla.UseVisualStyleBackColor = true;
            this.btn_topla.Click += new System.EventHandler(this.btn_topla_Click);
            // 
            // btn_eksi
            // 
            this.btn_eksi.Location = new System.Drawing.Point(120, 185);
            this.btn_eksi.Name = "btn_eksi";
            this.btn_eksi.Size = new System.Drawing.Size(48, 23);
            this.btn_eksi.TabIndex = 2;
            this.btn_eksi.Text = "-";
            this.btn_eksi.UseVisualStyleBackColor = true;
            this.btn_eksi.Click += new System.EventHandler(this.btn_eksi_Click);
            // 
            // btn_bolme
            // 
            this.btn_bolme.Location = new System.Drawing.Point(174, 185);
            this.btn_bolme.Name = "btn_bolme";
            this.btn_bolme.Size = new System.Drawing.Size(52, 23);
            this.btn_bolme.TabIndex = 2;
            this.btn_bolme.Text = "/";
            this.btn_bolme.UseVisualStyleBackColor = true;
            this.btn_bolme.Click += new System.EventHandler(this.btn_bolme_Click);
            // 
            // btn_carpma
            // 
            this.btn_carpma.Location = new System.Drawing.Point(232, 185);
            this.btn_carpma.Name = "btn_carpma";
            this.btn_carpma.Size = new System.Drawing.Size(56, 23);
            this.btn_carpma.TabIndex = 2;
            this.btn_carpma.Text = "x";
            this.btn_carpma.UseVisualStyleBackColor = true;
            this.btn_carpma.Click += new System.EventHandler(this.btn_carpma_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "SONUÇ :";
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Location = new System.Drawing.Point(143, 146);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(13, 13);
            this.lbl_sonuc.TabIndex = 0;
            this.lbl_sonuc.Text = "0";
            this.lbl_sonuc.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 293);
            this.Controls.Add(this.btn_carpma);
            this.Controls.Add(this.btn_bolme);
            this.Controls.Add(this.btn_eksi);
            this.Controls.Add(this.btn_topla);
            this.Controls.Add(this.txt_sayi2);
            this.Controls.Add(this.lbl_sonuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_sayi1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sayi1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sayi2;
        private System.Windows.Forms.Button btn_topla;
        private System.Windows.Forms.Button btn_eksi;
        private System.Windows.Forms.Button btn_bolme;
        private System.Windows.Forms.Button btn_carpma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_sonuc;
    }
}

