using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API;
using API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/AperturaCuenta")]
    [ApiController]
    public class AperturaCuentaController : ControllerBase
    {
        private readonly ContextBP _context;

        public AperturaCuentaController(ContextBP context)
        {
            _context = context;
        }


        //// GET: api/<AperturaCuentaController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET: api/Cuentas/5
        [HttpGet("{cedula}")]
        public async Task<ActionResult<AperturaCuenta>> GetAperturaCuenta(string cedula)
        {
            Cliente cliente = await _context.Clientes.SingleOrDefaultAsync(x => x.CEDULA == cedula);

            if (cliente == null)
            {
                return NotFound();
            }

            Cuenta cuenta = await _context.Cuentas.SingleOrDefaultAsync(x=> x.Cliente_ID == cliente.Cliente_ID);
            return new AperturaCuenta() { cliente=cliente, cuenta=cuenta};
        }



        // POST api/<AperturaCuentaController>
        [HttpPost]
        public async Task<ActionResult<AperturaCuenta>> PostCuenta(AperturaCuenta APCuenta)
        {
            Cuenta cuenta = null;
            Cliente cliente = null;
            cliente = _context.Clientes.SingleOrDefault(x => x.CEDULA == APCuenta.cliente.CEDULA);
            if ( cliente == null)
            {
                _context.Clientes.Add(APCuenta.cliente);
                await _context.SaveChangesAsync();
                cliente = APCuenta.cliente;
                cuenta = await _context.Cuentas.FirstOrDefaultAsync(x=> x.Cliente_ID == APCuenta.cliente.Cliente_ID);
            }
            APCuenta.cliente.Cliente_ID= cliente.Cliente_ID;
            if (cuenta == null)
            {
                Execute_PRO_REGISTRO_CUENTA(APCuenta);
                cuenta = await _context.Cuentas.FirstOrDefaultAsync(x => x.Cliente_ID == APCuenta.cliente.Cliente_ID);
                APCuenta.cuenta.Cuenta_ID = cuenta.Cuenta_ID;
                APCuenta.cuenta.Cliente_ID = cliente.Cliente_ID;
                APCuenta.GenerarReporte();
            }

            return APCuenta;
        }

        public void Execute_PRO_REGISTRO_CUENTA(AperturaCuenta APCuenta)
        {
            _context.Database.ExecuteSqlInterpolated($"EXEC PRO_REGISTRO_CUENTA {APCuenta.cliente.Cliente_ID}, {APCuenta.cuenta.TipoCuenta_ID}, {APCuenta.cuenta.Interes_ID}, {APCuenta.cuenta.Monto_Apertura}");
        }

    }
}
