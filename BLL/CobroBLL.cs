using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entidades;
using System.Data.Entity;

namespace BLL
{
    public class CobroBLL
    {
        public static bool Guardar(Cobros cobro)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                RepositorioBase<Ventas> vent = new RepositorioBase<Ventas>();
                Ventas Venta;


                if (db.Cobros.Add(cobro) != null)
                {

                   paso = db.SaveChanges() > 0;
                   Venta = vent.Buscar(cobro.ClienteId);
                   Venta.Balance = Venta.Balance - cobro.MontoPagado;
                   vent.Modificar(Venta);

                }

            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            RepositorioBase<Ventas> vent = new RepositorioBase<Ventas>();
            RepositorioBase<Cobros> cobr = new RepositorioBase<Cobros>();

            try
            {
                
                var cobro = cobr.Buscar(id);
                var ventas = vent.Buscar(cobro.VentaId);
                ventas.Balance = ventas.Balance + cobro.MontoPagado;
                vent.Modificar(ventas);
                db.Entry(cobro).State = EntityState.Deleted;
                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

    }
}
