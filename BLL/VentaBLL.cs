using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;
using System.Data.Entity;
using System.Linq.Expressions;

namespace BLL
{
    public class VentaBLL
    {
      
        

        public static bool Guardar(Ventas venta)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                RepositorioBase<Productos> prod = new RepositorioBase<Productos>();
                RepositorioBase<Clientes> client = new RepositorioBase<Clientes>();



                if (db.Ventas.Add(venta) != null)
                {

                    foreach (var item in venta.Productos)
                    {
                        var producto = prod.Buscar(item.ProductoId);
                        producto.Existencia = producto.Existencia - item.Cantidad;
                        prod.Modificar(producto);

                    }

                    var cliente = client.Buscar(venta.ClienteId);
                    cliente.Balance = cliente.Balance + venta.Balance;
                    client.Modificar(cliente);

                    paso = db.SaveChanges() > 0;
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
            RepositorioBase<Productos> prod = new RepositorioBase<Productos>();
            RepositorioBase<Clientes> client = new RepositorioBase<Clientes>();

            try
            {
                var venta = db.Ventas.Find(id);
                var cliente = client.Buscar(venta.ClienteId);
                cliente.Balance = cliente.Balance - venta.Total;
                client.Modificar(cliente);

                foreach (var item in venta.Productos)
                {
                    var producto = prod.Buscar(item.ProductoId);
                    producto.Existencia = producto.Existencia + item.Cantidad;
                    prod.Modificar(producto);

                }


                db.Entry(venta).State = EntityState.Deleted;
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

        public static void ModificarBien(Ventas ventas, Ventas VentasAnteriores)
        {
            Contexto contexto = new Contexto();

            RepositorioBase<Clientes> client = new RepositorioBase<Clientes>();
            RepositorioBase<Ventas> vent = new RepositorioBase<Ventas>();
            RepositorioBase<Productos> prod = new RepositorioBase<Productos>();

      


            var Cliente = client.Buscar(ventas.ClienteId);
            var ClientesAnteriores = client.Buscar( VentasAnteriores.ClienteId);

            Cliente.Balance += ventas.Total;
            ClientesAnteriores.Balance -= VentasAnteriores.Total;
            client.Modificar(Cliente);
            client.Modificar(ClientesAnteriores);

        }

        public static bool Modificar(Ventas ventas)
        {
            bool paso = false;
            Contexto db = new Contexto();
            RepositorioBase<Clientes> client = new RepositorioBase<Clientes>();
            RepositorioBase<Ventas> vent = new RepositorioBase<Ventas>();
            RepositorioBase<Productos> prod = new RepositorioBase<Productos>();
            try
            {
                var venta = vent.Buscar(ventas.VentaId);

                if (ventas.ClienteId != venta.ClienteId)
                {
                    ModificarBien(ventas, venta);
                }

                if (ventas != null)
                {
                    foreach (var item in venta.Productos)
                    {
                        db.Productos.Find(item.ProductoId).Existencia += item.Cantidad;

                        if (!ventas.Productos.ToList().Exists(v => v.VentaDetalleId == item.VentaDetalleId))
                        {
                            
                            db.Entry(item).State = EntityState.Deleted;
                        }
                    }

                    foreach (var item in ventas.Productos)
                    {
                        db.Productos.Find(item.ProductoId).Existencia -= item.Cantidad;
                        var estado = item.VentaDetalleId > 0 ? EntityState.Modified : EntityState.Added;
                        db.Entry(item).State = estado;
                    }

                    db.Entry(ventas).State = EntityState.Modified;
                }

                Modifica(ventas, venta, db);

                if (db.SaveChanges() > 0)
                {
                    paso = true;
                }
                db.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static void Modifica(Ventas factura, Ventas FactAnt, Contexto contexto)
        {
            RepositorioBase<Clientes> client = new RepositorioBase<Clientes>();
            double modificado = factura.Total - FactAnt.Total;

            var Cliente = contexto.Clientes.Find(factura.VentaId);
            Cliente.Balance += modificado;
            client.Modificar(Cliente);
        }


    }
}
