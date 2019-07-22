using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;

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
                RepositorioBase<Productos> prod = new RepositorioBase<Productos>(new DAL.Contexto());
                Productos producto;
                

                if (db.Ventas.Add(venta) != null)
                {

                    
                  

      
      
                    paso = db.SaveChanges() > 0;


                    foreach (var item in venta.Productos)
                    {
                        producto = prod.Buscar(item.ProductoId);

                        producto.Existencia = producto.Existencia - item.Cantidad;
                        prod.Modificar(producto);


                    }
                }

            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

       /* public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            RepositorioBase<Estudiantes> dbEst = new RepositorioBase<Estudiantes>(new DAL.Contexto());
            try
            {
                var Inscripcion = db.Inscripcion.Find(id);
                var estudiante = dbEst.Buscar(Inscripcion.EstudianteId);
                estudiante.Balance = estudiante.Balance - Inscripcion.MontoInscripcion;
                dbEst.Modificar(estudiante);
                db.Entry(Inscripcion).State = EntityState.Deleted;
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
        */

    }
}
