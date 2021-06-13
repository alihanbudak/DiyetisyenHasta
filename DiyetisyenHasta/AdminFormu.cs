using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DiyetisyenHasta
{
    public partial class AdminFormu : Form
    {
        List<Diyetisyenler> diyetisyenlerlist = new List<Diyetisyenler>();
        public AdminFormu()
        {
            InitializeComponent();
        }

        private void AdminFormu_Load(object sender, EventArgs e)
        {
            diyetisyenlerlist.Add(new Diyetisyenler()
            {
                diyetisyentc = 414.ToString(),
                diyetisyenisim = "Dr.Yusuf Özbey",
                calistigihastane = "İbni Sina Hastanesi",
                diyetisyenadresi = "Ankara/Ulus",
                diyetisyennumarasi = "05555555555",
            });
            diyetisyenlerlist.Add(new Diyetisyenler()
            {
                diyetisyentc = 626.ToString(),
                diyetisyenisim = "Dr.Kadir Sönmez",
                calistigihastane = "Ankara Üniversitesi",
                diyetisyenadresi = "Ankara/Yenimahalle",
                diyetisyennumarasi = "05554444444",
            });
        }

        private void DiyetisyenEkle_Click(object sender, EventArgs e)
        {
            diyetisyenlerlist.Add(new Diyetisyenler()
            {
                diyetisyentc = diyetisyentc.Text,
                diyetisyenisim = Diyetisyenİsim.Text,
                calistigihastane = HastaneAdi.Text,
                diyetisyenadresi = AdresText.Text,
                diyetisyennumarasi = NumaraText.Text,
            }) ;
            MessageBox.Show("Diyetisyen Eklendi.");
        }

        private void DiyetisyenBilgi_Click(object sender, EventArgs e)
        {
            string mesaj = "";
            for (int i = 0; i < diyetisyenlerlist.Count; i++)
            {

                mesaj += diyetisyenlerlist[i].diyetisyentc +"-İsim:-"+ diyetisyenlerlist[i].diyetisyenisim+"-Hastane:-"+ diyetisyenlerlist[i].calistigihastane +"-Adresi:-"+ diyetisyenlerlist[i].diyetisyenadresi +"-NO:-"+ diyetisyenlerlist[i].diyetisyennumarasi +"--"+ Environment.NewLine;
            }

            MessageBox.Show("Çalışan Diyetisyenler\n" + mesaj);
        }

        private void girisedon_Click(object sender, EventArgs e)
        {
            Giris girisedon = new Giris();
            girisedon.Show();
            this.Hide();
        }
    }
}
