
namespace DiyetisyenHasta
{
    partial class Diyetisyen
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
            this.DiyetUygulaButon = new System.Windows.Forms.Button();
            this.DiyetBox = new System.Windows.Forms.ComboBox();
            this.HastaSira = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HastaBilgiButon = new System.Windows.Forms.Button();
            this.HastaEkleButon = new System.Windows.Forms.Button();
            this.TcText = new System.Windows.Forms.TextBox();
            this.İsimText = new System.Windows.Forms.TextBox();
            this.HastalikText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DiyetText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.JSON = new System.Windows.Forms.Button();
            this.girisedon2 = new System.Windows.Forms.Button();
            this.HTML = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DiyetUygulaButon
            // 
            this.DiyetUygulaButon.Location = new System.Drawing.Point(212, 196);
            this.DiyetUygulaButon.Name = "DiyetUygulaButon";
            this.DiyetUygulaButon.Size = new System.Drawing.Size(132, 39);
            this.DiyetUygulaButon.TabIndex = 0;
            this.DiyetUygulaButon.Text = "Diyet Uygula";
            this.DiyetUygulaButon.UseVisualStyleBackColor = true;
            this.DiyetUygulaButon.Click += new System.EventHandler(this.DiyetUygulaButon_Click);
            // 
            // DiyetBox
            // 
            this.DiyetBox.FormattingEnabled = true;
            this.DiyetBox.Items.AddRange(new object[] {
            "Akdeniz",
            "Gluten",
            "Yeşillikler Dünyası",
            "Deniz Ürünleri"});
            this.DiyetBox.Location = new System.Drawing.Point(212, 131);
            this.DiyetBox.Name = "DiyetBox";
            this.DiyetBox.Size = new System.Drawing.Size(132, 23);
            this.DiyetBox.TabIndex = 1;
            // 
            // HastaSira
            // 
            this.HastaSira.Location = new System.Drawing.Point(212, 84);
            this.HastaSira.Name = "HastaSira";
            this.HastaSira.Size = new System.Drawing.Size(132, 23);
            this.HastaSira.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta Sirasi";
            // 
            // HastaBilgiButon
            // 
            this.HastaBilgiButon.Location = new System.Drawing.Point(212, 12);
            this.HastaBilgiButon.Name = "HastaBilgiButon";
            this.HastaBilgiButon.Size = new System.Drawing.Size(475, 39);
            this.HastaBilgiButon.TabIndex = 4;
            this.HastaBilgiButon.Text = "Hasta Bilgilerini Göster";
            this.HastaBilgiButon.UseVisualStyleBackColor = true;
            this.HastaBilgiButon.Click += new System.EventHandler(this.HastaBilgiButon_Click);
            // 
            // HastaEkleButon
            // 
            this.HastaEkleButon.Location = new System.Drawing.Point(555, 290);
            this.HastaEkleButon.Name = "HastaEkleButon";
            this.HastaEkleButon.Size = new System.Drawing.Size(132, 39);
            this.HastaEkleButon.TabIndex = 5;
            this.HastaEkleButon.Text = "Hasta Ekle";
            this.HastaEkleButon.UseVisualStyleBackColor = true;
            this.HastaEkleButon.Click += new System.EventHandler(this.HastaEkleButon_Click);
            // 
            // TcText
            // 
            this.TcText.Location = new System.Drawing.Point(555, 84);
            this.TcText.Name = "TcText";
            this.TcText.Size = new System.Drawing.Size(132, 23);
            this.TcText.TabIndex = 6;
            // 
            // İsimText
            // 
            this.İsimText.Location = new System.Drawing.Point(555, 131);
            this.İsimText.Name = "İsimText";
            this.İsimText.Size = new System.Drawing.Size(132, 23);
            this.İsimText.TabIndex = 7;
            // 
            // HastalikText
            // 
            this.HastalikText.Location = new System.Drawing.Point(555, 182);
            this.HastalikText.Name = "HastalikText";
            this.HastalikText.Size = new System.Drawing.Size(132, 23);
            this.HastalikText.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "TC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(464, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Hasta İsim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(477, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hastalik";
            // 
            // DiyetText
            // 
            this.DiyetText.Location = new System.Drawing.Point(555, 236);
            this.DiyetText.Name = "DiyetText";
            this.DiyetText.Size = new System.Drawing.Size(132, 23);
            this.DiyetText.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(492, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Diyet";
            // 
            // JSON
            // 
            this.JSON.Location = new System.Drawing.Point(43, 324);
            this.JSON.Name = "JSON";
            this.JSON.Size = new System.Drawing.Size(132, 55);
            this.JSON.TabIndex = 14;
            this.JSON.Text = "JSON YAZDIR";
            this.JSON.UseVisualStyleBackColor = true;
            this.JSON.Click += new System.EventHandler(this.JSON_Click);
            // 
            // girisedon2
            // 
            this.girisedon2.Location = new System.Drawing.Point(13, 13);
            this.girisedon2.Name = "girisedon2";
            this.girisedon2.Size = new System.Drawing.Size(74, 58);
            this.girisedon2.TabIndex = 15;
            this.girisedon2.Text = "Giriş Sayfası";
            this.girisedon2.UseVisualStyleBackColor = true;
            this.girisedon2.Click += new System.EventHandler(this.girisedon2_Click);
            // 
            // HTML
            // 
            this.HTML.Location = new System.Drawing.Point(212, 324);
            this.HTML.Name = "HTML";
            this.HTML.Size = new System.Drawing.Size(132, 55);
            this.HTML.TabIndex = 16;
            this.HTML.Text = "HTML";
            this.HTML.UseVisualStyleBackColor = true;
            this.HTML.Click += new System.EventHandler(this.HTML_Click);
            // 
            // Diyetisyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 403);
            this.Controls.Add(this.HTML);
            this.Controls.Add(this.girisedon2);
            this.Controls.Add(this.JSON);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DiyetText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HastalikText);
            this.Controls.Add(this.İsimText);
            this.Controls.Add(this.TcText);
            this.Controls.Add(this.HastaEkleButon);
            this.Controls.Add(this.HastaBilgiButon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HastaSira);
            this.Controls.Add(this.DiyetBox);
            this.Controls.Add(this.DiyetUygulaButon);
            this.Name = "Diyetisyen";
            this.Text = "Diyetisyen";
            this.Load += new System.EventHandler(this.Diyetisyen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DiyetUygulaButon;
        private System.Windows.Forms.ComboBox DiyetBox;
        private System.Windows.Forms.TextBox HastaSira;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HastaBilgiButon;
        private System.Windows.Forms.Button HastaEkleButon;
        private System.Windows.Forms.TextBox TcText;
        private System.Windows.Forms.TextBox İsimText;
        private System.Windows.Forms.TextBox HastalikText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DiyetText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button JSON;
        private System.Windows.Forms.Button girisedon2;
        private System.Windows.Forms.Button HTML;
    }
}