using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DiyetisyenHasta
{
    public class Diyetisyenler
    {
        public string diyetisyentc { get; set; }
        public string diyetisyenisim { get; set; }
        public string calistigihastane { get; set; }
        public string diyetisyenadresi { get; set; }
        public string diyetisyenumarasi { get; set; }
        public string diyetisyennumarasi { get; internal set; }
    }
}
