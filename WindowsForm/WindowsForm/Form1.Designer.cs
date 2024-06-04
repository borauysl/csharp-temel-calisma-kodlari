namespace WindowsForm
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
            this.txt_birincinot = new System.Windows.Forms.TextBox();
            this.txt_ikincinot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ortalamahesapla = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Notunuzu Giriniz :";
            // 
            // txt_birincinot
            // 
            this.txt_birincinot.Location = new System.Drawing.Point(178, 16);
            this.txt_birincinot.Name = "txt_birincinot";
            this.txt_birincinot.Size = new System.Drawing.Size(100, 20);
            this.txt_birincinot.TabIndex = 1;
            // 
            // txt_ikincinot
            // 
            this.txt_ikincinot.Location = new System.Drawing.Point(178, 57);
            this.txt_ikincinot.Name = "txt_ikincinot";
            this.txt_ikincinot.Size = new System.Drawing.Size(100, 20);
            this.txt_ikincinot.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "2. Notunuzu Giriniz :";
            // 
            // btn_ortalamahesapla
            // 
            this.btn_ortalamahesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ortalamahesapla.Location = new System.Drawing.Point(19, 111);
            this.btn_ortalamahesapla.Name = "btn_ortalamahesapla";
            this.btn_ortalamahesapla.Size = new System.Drawing.Size(173, 27);
            this.btn_ortalamahesapla.TabIndex = 4;
            this.btn_ortalamahesapla.Text = "Ortalamayı Bul";
            this.btn_ortalamahesapla.UseVisualStyleBackColor = true;
            this.btn_ortalamahesapla.Click += new System.EventHandler(this.btn_ortalamahesapla_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(218, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ortalamanız :";
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sonuc.Location = new System.Drawing.Point(320, 115);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(17, 18);
            this.lbl_sonuc.TabIndex = 5;
            this.lbl_sonuc.Text = "0";
            this.lbl_sonuc.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 364);
            this.Controls.Add(this.lbl_sonuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_ortalamahesapla);
            this.Controls.Add(this.txt_ikincinot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_birincinot);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_birincinot;
        private System.Windows.Forms.TextBox txt_ikincinot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ortalamahesapla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_sonuc;
    }
}

