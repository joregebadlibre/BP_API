using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System;

namespace API.Models
{
    [Table("Cuenta")]
    public class Cuenta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 Cuenta_ID { get; set; }

        public Int64 Cliente_ID { get; set; }

        public int TipoCuenta_ID { get; set; }

        public int Interes_ID { get; set; }

        public string Numero_Cuenta { get; set; }

        public Decimal Monto_Apertura { get; set; }

        public DateTime Fecha_Apertura { get; set; }

        public DateTime Fecha_Actualizacion { get; set; }

    }
}
