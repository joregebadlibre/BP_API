using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System;

namespace API.Models
{
    [Table("TipoCuenta")]
    public class TipoCuenta
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 TipoCuenta_ID { get; set; }

        public string Detalle_TipoCuenta { get; set; }

        public DateTime Fecha_Creacion { get; set; }

        public DateTime Fecha_Actualizacion { get; set; }
    }
}
