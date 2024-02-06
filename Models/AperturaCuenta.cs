using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;

namespace API.Models
{
    public class AperturaCuenta
    {
        public Cliente cliente {  get; set; }
        public Cuenta cuenta { get; set; }
        public List<ReporteAnual> Listareporte { get; set; }

        private decimal CalcularSaldo(decimal saldo)
        {
            decimal porcentaje = 0.03M;
            saldo = saldo + porcentaje * 12;
            return saldo;
        }
        public void GenerarReporte()
        {
            decimal saldo = CalcularSaldo(cuenta.Monto_Apertura);
            List<ReporteAnual> reporte = new List<ReporteAnual>();
            CalcularSaldo(cuenta.Monto_Apertura);

            reporte.Add(new ReporteAnual() { Mes = DateTime.Now.Month.ToString(), saldo = saldo });
            saldo = CalcularSaldo(saldo);
            reporte.Add(new ReporteAnual() { Mes = DateTime.Now.AddMonths(1).Month.ToString(), saldo =  saldo });
            saldo = CalcularSaldo(saldo);
            reporte.Add(new ReporteAnual() { Mes = DateTime.Now.AddMonths(2).Month.ToString(), saldo =  saldo });
            saldo = CalcularSaldo(saldo);
            reporte.Add(new ReporteAnual() { Mes = DateTime.Now.AddMonths(3).Month.ToString(), saldo =  saldo });
            saldo = CalcularSaldo(saldo);
            reporte.Add(new ReporteAnual() { Mes = DateTime.Now.AddMonths(4).Month.ToString(), saldo =  saldo });
            saldo = CalcularSaldo(saldo);
            reporte.Add(new ReporteAnual() { Mes = DateTime.Now.AddMonths(5).Month.ToString(), saldo =  saldo });
            saldo = CalcularSaldo(saldo);
            reporte.Add(new ReporteAnual() { Mes = DateTime.Now.AddMonths(6).Month.ToString(), saldo =  saldo });
            saldo = CalcularSaldo(saldo);
            reporte.Add(new ReporteAnual() { Mes = DateTime.Now.AddMonths(7).Month.ToString(), saldo =  saldo });
            saldo = CalcularSaldo(saldo);
            reporte.Add(new ReporteAnual() { Mes = DateTime.Now.AddMonths(8).Month.ToString(), saldo =  saldo });
            saldo = CalcularSaldo(saldo);
            reporte.Add(new ReporteAnual() { Mes = DateTime.Now.AddMonths(9).Month.ToString(), saldo =  saldo });
            saldo = CalcularSaldo(saldo);
            reporte.Add(new ReporteAnual() { Mes = DateTime.Now.AddMonths(10).Month.ToString(), saldo = saldo });
            saldo = CalcularSaldo(saldo);
            reporte.Add(new ReporteAnual() { Mes = DateTime.Now.AddMonths(11).Month.ToString(), saldo = saldo });
             Listareporte = reporte;
        }
    }

}
