using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Cuenta
    {
public Cuenta(int cuentaId, string tarjetaCredito, string nombreBanco, int saldo)
        {
            CuentaId = cuentaId;
            TarjetaCredito = tarjetaCredito;
            NombreBanco = nombreBanco;
            Saldo = saldo;
        }

        public int CuentaId { get; set; }
        public string TarjetaCredito { get; set; }
        public string NombreBanco { get; set; }
        public int Saldo { get; set; }
        public Usuario Usuario { get; set; }
    }
}