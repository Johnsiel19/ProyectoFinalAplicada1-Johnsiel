﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        public string Descripcion { get; set; }
        public int ProveedorId { get; set; }
        public int UsuarioId { get; set; }
        public double Existencia { get; set; }
        public double Costo { get; set; }
        public double Precio { get; set; }
        public int ProductoItbis { get; set; }
        public DateTime Fecha { get; set; }

        public Productos()
        {
            ProductoId = 0;
            Descripcion = string.Empty;
            ProveedorId = 0;
            UsuarioId = 0;
            Existencia = 0;
            Costo = 0;
            Precio = 0;
            ProductoItbis = 0;
            Fecha = DateTime.Now;
        }
    }
}
