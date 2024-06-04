namespace Combobox_nesnesi
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_gunsec = new System.Windows.Forms.Label();
            this.btn_gunsec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pazartesi",
            "Salı",
            "Çarşamba"});
            this.comboBox1.Location = new System.Drawing.Point(199, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl_gunsec
            // 
            this.lbl_gunsec.AutoSize = true;
            this.lbl_gunsec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_gunsec.Location = new System.Drawing.Point(26, 69);
            this.lbl_gunsec.Name = "lbl_gunsec";
            this.lbl_gunsec.Size = new System.Drawing.Size(103, 20);
            this.lbl_gunsec.TabIndex = 1;
            this.lbl_gunsec.Text = "Gün Seçiniz :";
            // 
            // btn_gunsec
            // 
            this.btn_gunsec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_gunsec.Location = new System.Drawing.Point(43, 132);
            this.btn_gunsec.Name = "btn_gunsec";
            this.btn_gunsec.Size = new System.Drawing.Size(261, 40);
            this.btn_gunsec.TabIndex = 2;
            this.btn_gunsec.Text = "Gün Seç";
            this.btn_gunsec.UseVisualStyleBackColor = true;
            this.btn_gunsec.Click += new System.EventHandler(this.btn_gunsec_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 255);
            this.Controls.Add(this.btn_gunsec);
            this.Controls.Add(this.lbl_gunsec);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_gunsec;
        private System.Windows.Forms.Button btn_gunsec;
    }
}

