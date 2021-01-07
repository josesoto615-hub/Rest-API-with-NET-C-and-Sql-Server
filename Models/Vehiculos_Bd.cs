using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace apivehiculos.Models
{
    public class Vehiculos_Bd
    {
        [Key]
        public int id { get; set; }
        public string dominio { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public int anio { get; set; }
        public string color { get; set; }
    }
}
