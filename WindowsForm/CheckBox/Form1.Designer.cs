namespace CheckBox
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
            this.checkbox_cay = new System.Windows.Forms.CheckBox();
            this.checkbox_kahve = new System.Windows.Forms.CheckBox();
            this.checkbox_hamburger = new System.Windows.Forms.CheckBox();
            this.checkbox_pizza = new System.Windows.Forms.CheckBox();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_tutar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkbox_cay
            // 
            this.checkbox_cay.AutoSize = true;
            this.checkbox_cay.Location = new System.Drawing.Point(25, 28);
            this.checkbox_cay.Name = "checkbox_cay";
            this.checkbox_cay.Size = new System.Drawing.Size(69, 17);
            this.checkbox_cay.TabIndex = 0;
            this.checkbox_cay.Text = "Çay 2 TL";
            this.checkbox_cay.UseVisualStyleBackColor = true;
            // 
            // checkbox_kahve
            // 
            this.checkbox_kahve.AutoSize = true;
            this.checkbox_kahve.Location = new System.Drawing.Point(25, 63);
            this.checkbox_kahve.Name = "checkbox_kahve";
            this.checkbox_kahve.Size = new System.Drawing.Size(82, 17);
            this.checkbox_kahve.TabIndex = 0;
            this.checkbox_kahve.Text = "Kahve 4 TL";
            this.checkbox_kahve.UseVisualStyleBackColor = true;
            // 
            // checkbox_hamburger
            // 
            this.checkbox_hamburger.AutoSize = true;
            this.checkbox_hamburger.Location = new System.Drawing.Point(25, 99);
            this.checkbox_hamburger.Name = "checkbox_hamburger";
            this.checkbox_hamburger.Size = new System.Drawing.Size(109, 17);
            this.checkbox_hamburger.TabIndex = 0;
            this.checkbox_hamburger.Text = "Hamburger 10 TL";
            this.checkbox_hamburger.UseVisualStyleBackColor = true;
            // 
            // checkbox_pizza
            // 
            this.checkbox_pizza.AutoSize = true;
            this.checkbox_pizza.Location = new System.Drawing.Point(25, 140);
            this.checkbox_pizza.Name = "checkbox_pizza";
            this.checkbox_pizza.Size = new System.Drawing.Size(82, 17);
            this.checkbox_pizza.TabIndex = 0;
            this.checkbox_pizza.Text = "Pizza 25 TL";
            this.checkbox_pizza.UseVisualStyleBackColor = true;
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Location = new System.Drawing.Point(25, 179);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(109, 56);
            this.btn_hesapla.TabIndex = 1;
            this.btn_hesapla.Text = "Tutarı Hesapla :";
            this.btn_hesapla.UseVisualStyleBackColor = true;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tutar : ";
            // 
            // lbl_tutar
            // 
            this.lbl_tutar.AutoSize = true;
            this.lbl_tutar.Location = new System.Drawing.Point(286, 29);
            this.lbl_tutar.Name = "lbl_tutar";
            this.lbl_tutar.Size = new System.Drawing.Size(29, 13);
            this.lbl_tutar.TabIndex = 2;
            this.lbl_tutar.Text = "0 TL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 277);
            this.Controls.Add(this.lbl_tutar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_hesapla);
            this.Controls.Add(this.checkbox_pizza);
            this.Controls.Add(this.checkbox_hamburger);
            this.Controls.Add(this.checkbox_kahve);
            this.Controls.Add(this.checkbox_cay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkbox_cay;
        private System.Windows.Forms.CheckBox checkbox_kahve;
        private System.Windows.Forms.CheckBox checkbox_hamburger;
        private System.Windows.Forms.CheckBox checkbox_pizza;
        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_tutar;
    }
}

