using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System;

namespace API.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 Cliente_ID { get; set; }

        public string CEDULA { get; set; }

        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        public string Correo { get; set; }

        public string Direccion { get; set; }

        public DateTime Fecha_Registro { get; set; }

        public DateTime Fecha_Actualizacion { get; set; }
    }
}
