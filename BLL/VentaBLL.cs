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
        /*public static bool Modificar(Ventas entity)
        {
            bool paso = false;
            Contexto db = new Contexto();
            RepositorioBase<Ventas> dbE = new RepositorioBase<Ventas>();


            try
            {


                var anterior = new RepositorioBase<Inscripcion>().Buscar(entity.InscripcionId);
                var estudiante = dbE.Buscar(entity.EstudianteId);

                estudiante.Balance -= anterior.MontoInscripcion;

                foreach (var item in anterior.Asignaturas)
                {
                    if (!entity.Asignaturas.Any(A => A.Id == item.Id))
                    {
                        db.Entry(item).State = EntityState.Deleted;

                    }

                }

                foreach (var item in entity.Asignaturas)
                {
                    if (item.Id == 0)
                    {
                        db.Entry(item).State = EntityState.Added;
                    }

                    else
                        db.Entry(item).State = EntityState.Modified;
                }


                entity.CalcularMonto();
                estudiante.Balance += entity.MontoInscripcion;
                dbE.Modificar(estudiante);

                db.Entry(entity).State = EntityState.Modified;

                paso = db.SaveChanges() > 0;


            }
            catch (Exception)
            {
                throw;
            }


            return paso;
        }*/

            /*
        public static Estudiantes Buscar(int id)
        {
            Estudiantes estudiantes = new Estudiantes();
            Contexto db = new Contexto();


            try
            {
                estudiantes = db.Estudiantes.Find(id);



            }
            catch (Exception)
            {
                MessageBox.Show("Se produjo un error al intentar Buscar");
            }
            finally
            {
                db.Dispose();
            }
            return estudiantes;

        }
        */

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
                var venta = vent.Buscar(ventas.VentasId);

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

            var Cliente = contexto.Clientes.Find(factura.VentasId);
            Cliente.Balance += modificado;
            client.Modificar(Cliente);
        }


        /*public static bool Modificar(Ventas venta)
        {
            bool paso = false;
            Contexto db = new Contexto();
            RepositorioBase<Clientes> client = new RepositorioBase<Clientes>();
            RepositorioBase<Ventas> vent = new RepositorioBase<Ventas>();
            RepositorioBase<Productos> prod = new RepositorioBase<Productos>();

            try
            {

                var anterior = vent.Buscar(venta.VentasId);
                var cliente = client.Buscar(venta.ClienteId);

                //cliente.Balance -= cliente.Balance + anterior.Total;

                foreach (var item in anterior.Productos)
                {
                    if (!venta.Productos.Any(A => A.VentaDetalleId == item.VentaDetalleId))
                    {
                        var producto = prod.Buscar(item.ProductoId);
                        producto.Existencia = producto.Existencia + item.Cantidad;
                        db.Entry(item).State = EntityState.Deleted;

                    }

                }

                foreach (var item in venta.Productos)
                {
                    if (item.VentaDetalleId == 0)
                    {
                        db.Entry(item).State = EntityState.Added;
                        var producto = prod.Buscar(item.ProductoId);
                        producto.Existencia = producto.Existencia - item.Cantidad;
                        prod.Modificar(producto);

                    }
              
                    else
                    {
                        var producto = prod.Buscar(item.ProductoId);
                        producto.Existencia = producto.Existencia  +(anterior.Cantidad - anterior.);
                        prod.Modificar(producto);


                        db.Entry(item).State = EntityState.Modified;

                    }

                }


           
                cliente.Balance = cliente.Balance + venta.Total;
                client.Modificar(cliente);

                db.Entry(venta).State = EntityState.Modified;

                paso = db.SaveChanges() > 0;


            }
            catch (Exception)
            {
                throw;
            }


            return paso;
        }
        */
    }
}
