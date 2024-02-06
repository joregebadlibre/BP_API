using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System;

namespace API.Models
{
    [Table("Interes")]
    public class Intere
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 Interes_ID { get; set; }

        public string Detalle { get; set; }

        public string Porcentaje { get; set; }
    }
}
