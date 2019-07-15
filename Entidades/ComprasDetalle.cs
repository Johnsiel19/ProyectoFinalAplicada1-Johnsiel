using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class ComprasDetalle
    {
        [Key]
        public int CompraDetalleId { get; set; }
        public int CompraId { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public double Costo { get; set; }

        public ComprasDetalle()
        {
            CompraDetalleId = 0;
            CompraId = 0;
            ProductoId = 0;
            Cantidad = 0;
            Costo = 0;
        }
    }
}
