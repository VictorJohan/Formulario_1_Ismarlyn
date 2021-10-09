using Formulario_1.DAL;
using Formulario_1.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario_1.BLL
{
    public class ArticulosBLL
    {

        public static bool Guardar(Articulos articulo)
        {
            if (!Existe(articulo.ArticuloId))
                return Insertar(articulo);
            else
                return Modificar(articulo);
        }

        private static bool Existe(int articuloId)
        {
            throw new NotImplementedException();
        }

        private static bool Modificar(Articulos articulo)
        {
            throw new NotImplementedException();
        }

        private static bool Insertar(Articulos articulo)
        {
            Contexto contexto = new Contexto();
            bool ok = false;

            try
            {
                contexto.Articulos.Add(articulo);
                ok = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return ok;
        }

        public static Articulos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Articulos articulo;

            try
            {
                articulo = contexto.Articulos.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return articulo;
        }

        public static bool Eliminar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
