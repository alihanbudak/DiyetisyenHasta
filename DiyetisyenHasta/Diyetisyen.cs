using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DiyetisyenHasta
{
    public partial class Diyetisyen : Form
    {
        List<Hasta> hastalist = new List<Hasta>();
        

        public object JsonConvert { get; private set; }
        public string diyetisyentc { get; internal set; }
        public string diyetisyenisim { get; internal set; }
        public string calistigihastane { get; internal set; }
        public string diyetisyenadresi { get; internal set; }
        public string diyetisyennumarasi { get; internal set; }

        public Diyetisyen()
        {
            InitializeComponent();
        }

        private void DiyetUygulaButon_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < hastalist.Count; i++)
            {
                if (hastalist[i].sira == Convert.ToInt32(HastaSira.Text))
                {
                    FactoryClass factoryClass = new FactoryClass();
                    Diyet diyet = factoryClass.nesneolustur(DiyetBox.Text.ToString());
                    diyet.Uygula(hastalist[i]);
                }
            }
            
        }

        private void Diyetisyen_Load(object sender, EventArgs e)
        {
            hastalist.Add(new Hasta()
            {
                tc = 412.ToString(),
                sira = 1,
                hastaismi = "Uygar Taş",
                hastalik = "Obez",
                diyet = "Gluten",
            });
            hastalist.Add(new Hasta()
            {
                sira = 2,
                tc = 314.ToString(),
                hastaismi = "Alper Kaya",
                hastalik = "Çölyak",
                diyet = "Yeşillikler Dünyası",
            });
           
        }

        private void HastaBilgiButon_Click(object sender, EventArgs e)
        {
            string mesaj = "";
            for (int i = 0; i < hastalist.Count; i++)
            {

                mesaj += hastalist[i].sira +"--"+ hastalist[i].tc +"--"+ hastalist[i].hastalik +"--"+ hastalist[i].hastaismi +"--"+ hastalist[i].diyet +"--"+ Environment.NewLine;
            }

            MessageBox.Show("Diyet Uygulanabilecek Hastalar\n" + mesaj);
        }

        private void HastaEkleButon_Click(object sender, EventArgs e)
        {
            hastalist.Add(new Hasta()
            {
                sira = hastalist.Count + 1,
                tc = TcText.Text,
                hastaismi = İsimText.Text,
                hastalik = HastalikText.Text,
                diyet = DiyetText.Text,
            }) ;
            MessageBox.Show("Hasta Eklendi.");
        }

        private void JSON_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < hastalist.Count; i++)
            {
                if (hastalist[i].sira == Convert.ToInt32(HastaSira.Text))
                {
                    string strResultJson = Newtonsoft.Json.JsonConvert.SerializeObject(hastalist[i]);
                    File.WriteAllText(@"data.json", strResultJson);
                }
            }
            MessageBox.Show("Uygulanan diyet yazdirildi.");
        }

        private void girisedon2_Click(object sender, EventArgs e)
        {
            Giris girisedon2 = new Giris();
            girisedon2.Show();
            this.Hide();
        }

        private void HTML_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < hastalist.Count; i++)
            {
                if (hastalist[i].sira == Convert.ToInt32(HastaSira.Text))
                {
                    string strResultJson = Newtonsoft.Json.JsonConvert.SerializeObject(hastalist[i]);
                    File.WriteAllText(@"data.html", strResultJson);
                }
            }
            MessageBox.Show("Uygulanan diyet yazdirildi.");
        }
    }
}
