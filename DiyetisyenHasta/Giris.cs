using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiyetisyenHasta
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void GirisButton_Click(object sender, EventArgs e)
        {
            if (ID.Text == "diyetisyen" && SifreText.Text == "123")
            {
                Diyetisyen diyetisyen = new Diyetisyen();
                diyetisyen.Show();
                this.Hide();
            }
            else if(ID.Text =="admin" && SifreText.Text =="123")
            {
                AdminFormu admingiris = new AdminFormu();
                admingiris.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatali Giris Yaptiniz.");
            }
                
        }
    }
}
