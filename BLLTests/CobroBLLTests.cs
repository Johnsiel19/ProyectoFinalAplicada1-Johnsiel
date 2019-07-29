﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace BLL.Tests
{
    [TestClass()]
    public class CobroBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
           


            Cobros ve = new  Cobros()
            {
                VentaId = 1,
                ClienteId = 1,
                UsuarioId = 3,
                MontoPagado = 9,
                Fecha = DateTime.Now
            };
            Assert.IsTrue(CobroBLL.Guardar(ve));
        }

        [TestMethod()]
        public void ModificarTest()
        {


            Cobros ve = new Cobros()
            {
                CobroId = 2,
                VentaId = 2,
                ClienteId = 1,
                UsuarioId = 1,
                MontoPagado = 200,
                Fecha = DateTime.Now
            };

            Assert.IsTrue(CobroBLL.Modificar(ve));
        }


        [TestMethod()]
        public void EliminarTest()
        {
            

            Assert.IsTrue(CobroBLL.Eliminar(2));
        }
    }
}