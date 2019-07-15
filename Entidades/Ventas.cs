using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Ventas
    {
        [Key]
        public int VentasId { get; set; }
        public int ClienteId { get; set; }
        public int UsuarioId { get; set; }
        public string Modo { get; set; }
        public double SubTotal { get; set; }
        public double Itbis { get; set; }
        public double Total { get; set; }
        public double Balance { get; set; }
        public DateTime Fecha { get; set; }

        public Ventas()
        {
            VentasId = 0;
            ClienteId = 0;
            UsuarioId = 0;
            Modo = string.Empty;
            SubTotal = 0;
            Itbis = 0;
            Total = 0;
            Balance = 0;
            Fecha = DateTime.Now;
        }
    }
}
