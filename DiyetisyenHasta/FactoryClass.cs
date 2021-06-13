using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace DiyetisyenHasta
{
    public class FactoryClass
    {
        public Diyet nesneolustur(string hangidiyet)
        {
            if (hangidiyet == "Akdeniz")
            {
                return new Akdeniz();
            }
            else if (hangidiyet == "Gluten")
            {
                return new Gluten();
            }

            else if (hangidiyet == "Yeşillikler Dünyası")
            {
                return new YesilliklerDunyasi();
            }
            else
            {
                return new DenizUrunleri();
            }
        }
    }
}
