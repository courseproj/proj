using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoPanel.Models
{
    [Serializable]
    public class Update
    {
        [Key]
        public int Version { get; set; }
        public string Link { get; set; }
        public string Name { get; set; }
    }
}
