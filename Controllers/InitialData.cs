using API.Models;
using System;
using System.Linq;

namespace API.Controllers
{
    public static class InitialData
    {
        public static void Seed(this ContextBP dbContext)
        {

            if (dbContext.Clientes.Select(x => x.Cliente_ID.ToString() == "1717000000").Count() ==0 )
                {
                        if (!dbContext.Clientes.Any())
                        {
                            dbContext.Clientes.Add(new Cliente
                            {
                                CEDULA = "1717000000",
                                Nombre = "Jorge",
                                Apellidos = "Alvarez",
                                Correo = "jr@gmail.com",
                                Direccion = "Bangalore",
                                Fecha_Registro = DateTime.Now,
                                Fecha_Actualizacion = DateTime.Now,
                            });
                            dbContext.Clientes.Add(new Cliente
                            {
                                CEDULA = "1717000001",
                                Nombre = "Rafel",
                                Apellidos = "Alvarez",
                                Correo = "jr@gmail.com",
                                Direccion = "Bangalore",
                                Fecha_Registro = DateTime.Now,
                                Fecha_Actualizacion = DateTime.Now,
                            });
                            dbContext.SaveChanges();
                        }

            }
        }


    }
}
