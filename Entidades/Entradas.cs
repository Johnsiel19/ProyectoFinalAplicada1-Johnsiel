using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Entradas
    {
        [Key]
        public int EntradaId { get; set; }
        public int ProductoId { get; set; }
        public double Entrada { get; set; }
        public int UsuarioId { get; set; }
        public DateTime Fecha { get; set; }

        public Entradas()
        {
            EntradaId = 0;
            ProductoId = 0;
            Entrada = 0;
            UsuarioId = 0;
            Fecha = DateTime.Now;
        }
    }
}
