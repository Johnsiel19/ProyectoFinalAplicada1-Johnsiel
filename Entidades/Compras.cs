using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Compras
    {
        [Key]
        public int CompraId { get; set; }
        public int ProveedorId { get; set; }
        public int UsuarioId { get; set; }
        public double Total { get; set; }
        public DateTime Fecha { get; set; }

        public Compras()
        {
            CompraId = 0;
            ProveedorId = 0;
            UsuarioId = 0;
            Total = 0;
            Fecha = DateTime.Now;
        }
    }
}
