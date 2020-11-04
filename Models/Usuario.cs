using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Usuario
    {
        public Usuario( string nombre, string apellido, int edad, string email, int cuentaId)
        {
           
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Email = email;
            CuentaId = cuentaId;
        }
       
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        [System.ComponentModel.DataAnnotations.Key]
        public string Email { get; set; }
        public int CuentaId { get; set; }
        public Cuenta Cuenta{ get; set; }


    }
}


