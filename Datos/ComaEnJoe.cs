using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class ComaEnJoe
    {
        //Listar la lista de Cheffs de la pagina indicada con items x pagina.
        public static List<Cheffs> ListChefs(int pagina, int cantItemsXPagina)
        {
            var res = new List<Cheffs>();
            var contexto = new ComaEnJoeDBEntities();
            //Usando Linq ordenamos los datos
            //saltamos las paginas que indiquemos
            //y tomamos la cantidad de items por pagina
            res = contexto.Cheffs.OrderBy(o => o.Apellido).Skip((pagina) * cantItemsXPagina).Take(cantItemsXPagina).ToList();
            return res;
        }
        //Obtener un cheff por ID
        public static Cheffs GetCheff(int cheffId)
        {
            Cheffs res = null;
            var contexto = new ComaEnJoeDBEntities();
            res = contexto.Cheffs.FirstOrDefault(x => x.ID == cheffId);
            return res;
        }
        //Eliminar un cheff con solo el ID
        public static int DeleteCheff(int cheffId)
        {
            var res = 0;
            var contexto = new ComaEnJoeDBEntities();
            var dato = contexto.Cheffs.FirstOrDefault(x => x.ID == cheffId);
            contexto.Cheffs.Remove(dato);
            res = contexto.SaveChanges();

            return res;
        }
        //Actualizar cheff existente
        public static int UpdateCheff(Cheffs cheffAActualizar)
        {
            var res = 0;
            var contexto = new ComaEnJoeDBEntities();
            var dato = contexto.Cheffs.FirstOrDefault(e => e.ID == cheffAActualizar.ID);
            //dato = cheffAActualizar; --consultar con secretaria academica si podemos remediar esto en el libro

            //fix by mgonzalez
            dato.Apellido = cheffAActualizar.Apellido;
            dato.Nombre = cheffAActualizar.Nombre;
            dato.Telefono = cheffAActualizar.Telefono;
            dato.Especialidad = cheffAActualizar.Especialidad;
            contexto.Cheffs.AddOrUpdate(dato);

            res = contexto.SaveChanges();
            return res;
        }
        //Agregar nuevo Cheff
        public static int InsertCheff(Cheffs cheffAInsertar)
        {
            var res = 0;
            var contexto = new ComaEnJoeDBEntities();
            contexto.Cheffs.Add(cheffAInsertar);
            res = contexto.SaveChanges();

            return res;
        }

    }
}
