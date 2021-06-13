using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace DiyetisyenHasta
{
    public class Akdeniz : Diyet
    {
       public void Uygula(Hasta h)
        {
            h.diyet = "Akdeniz";
            MessageBox.Show("Akdeniz Diyeti Yapiliyor.");
        }
    }
}
