using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace DiyetisyenHasta
{
    public class DenizUrunleri : Diyet
    {
       public void Uygula(Hasta h)
        {
            h.diyet = "Deniz Urunleri";
            MessageBox.Show("Deniz Ürünleri Diyeti Yapiliyor.");

        }
    }
}
