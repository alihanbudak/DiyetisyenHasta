
namespace DiyetisyenHasta
{
    partial class Giris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GirisButton = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.TextBox();
            this.SifreText = new System.Windows.Forms.TextBox();
            this.IDText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GirisButton
            // 
            this.GirisButton.Location = new System.Drawing.Point(287, 252);
            this.GirisButton.Name = "GirisButton";
            this.GirisButton.Size = new System.Drawing.Size(127, 43);
            this.GirisButton.TabIndex = 0;
            this.GirisButton.Text = "Giriş Yap";
            this.GirisButton.UseVisualStyleBackColor = true;
            this.GirisButton.Click += new System.EventHandler(this.GirisButton_Click);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(287, 97);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(127, 23);
            this.ID.TabIndex = 1;
            // 
            // SifreText
            // 
            this.SifreText.Location = new System.Drawing.Point(287, 168);
            this.SifreText.Name = "SifreText";
            this.SifreText.Size = new System.Drawing.Size(127, 23);
            this.SifreText.TabIndex = 2;
            this.SifreText.UseSystemPasswordChar = true;
            // 
            // IDText
            // 
            this.IDText.AutoSize = true;
            this.IDText.Location = new System.Drawing.Point(171, 100);
            this.IDText.Name = "IDText";
            this.IDText.Size = new System.Drawing.Size(73, 15);
            this.IDText.TabIndex = 3;
            this.IDText.Text = "Kullanıcı Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sifre";
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 413);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDText);
            this.Controls.Add(this.SifreText);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.GirisButton);
            this.Name = "Giris";
            this.Text = "Giris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GirisButton;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox SifreText;
        private System.Windows.Forms.Label IDText;
        private System.Windows.Forms.Label label1;
    }
}

