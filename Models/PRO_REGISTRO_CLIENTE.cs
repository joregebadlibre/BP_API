using System;

namespace API.Models
{
    public class PRO_REGISTRO_CLIENTE
    {
        string cedula {  get; set; }
        string nombre { get; set; }
        string apellidos { get; set; }
        string correo { get; set; }
        string direccion { get; set; }
        //DateTime fecha_registro { get; set; }
        //DateTime fecha_actualizacion { get; set; }
    }
}
