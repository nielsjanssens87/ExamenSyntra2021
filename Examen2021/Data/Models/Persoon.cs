using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Persoon
    {
        public int ID { get; set; }
        
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Telefoonnummer { get; set; }
        public string Adres { get; set; }
        public string Opmerking { get; set; }
        public double LengteInM { get; set; }

    }
}
