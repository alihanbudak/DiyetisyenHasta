using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace DiyetisyenHasta
{
    public class Hasta
    {
        public int sira { get; set; }
        public string tc { get; set; }
        public string hastaismi { get; set; }
        public string hastalik { get; set; }
        public string diyet { get; set; }
    }
}
