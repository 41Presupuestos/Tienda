using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.Data;
using Tienda.Modelo;

namespace Tienda.Logica
{
    public static class CategoriaBL
    {
        static CategoriaDAO dao = new CategoriaDAO();
        public static List<Categoria> ListarTodos()
        {
            return dao.ListarTodos();
        }

        public static bool Crear(Categoria nuevaCategoria)
        {
            return dao.Crear(nuevaCategoria);
        }

        public static Categoria TraerPorId(int id)
        {
            return dao.ObtenerPorId(id);
        }

        public static bool Actualizar(Categoria cambiarCategoria)
        {
            return dao.Actualizar(cambiarCategoria);
        }

        public static bool Eliminar(int idCategoria)
        {
            return dao.Eliminar(idCategoria);
        }
    }
}
