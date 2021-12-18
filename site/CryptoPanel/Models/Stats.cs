using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoPanel.Models
{
    public class Stats
    {
        public int Id { get; set; }
        public string Unique { get; set; }
        public string Country { get; set; }
        public string Video { get; set; }
        public string Cores { get; set; }
        public string Bit { get; set; }
        public string ToyCpuStatus { get; set; }
        public string ToyGpuStatus { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime Time { get; set; }
    }
}
