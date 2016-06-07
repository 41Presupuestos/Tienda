using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.Modelo;
using System.Data;
using System.Data.SqlClient;

namespace Tienda.Data
{
    public class CategoriaDAO
    {
        public List<Categoria> ListarTodos()
        {
            var listado = new List<Categoria>();
            using(SqlConnection conexion = new SqlConnection(ConexionUtil.CadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("ListarCategorias", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader lector = cmd.ExecuteReader();
                if(lector!=null && lector.HasRows)
                {
                    Categoria cat;
                    while(lector.Read())
                    {
                        cat = new Categoria();
                        cat.Id = int.Parse(lector["Id"].ToString());
                        cat.Nombre = lector["Nombre"].ToString();
                        cat.Codigo = lector["Codigo"].ToString();
                        cat.Observacion = lector["Observacion"].ToString();
                        listado.Add(cat);
                    }
                }
            }
            return listado;
        }

        public bool Crear(Categoria nuevaCategoria)
        {
            bool exito = false;
            using (SqlConnection conexion = new SqlConnection(ConexionUtil.CadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("InsertarCategoria", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo", nuevaCategoria.Codigo);
                cmd.Parameters.AddWithValue("@Nombre", nuevaCategoria.Nombre);
                cmd.Parameters.AddWithValue("@Observacion", nuevaCategoria.Observacion);
                exito = cmd.ExecuteNonQuery() > 0;
            }
            return exito;
        }

        public Categoria ObtenerPorId(int id)
        {
            Categoria cate = null;
            using (SqlConnection conexion = new SqlConnection(ConexionUtil.CadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("TraerCategoriaPorId", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                SqlDataReader lector = cmd.ExecuteReader();
                if (lector != null && lector.HasRows)
                {
                    lector.Read(); cate = new Categoria();
                    cate.Id = int.Parse(lector["Id"].ToString());
                    cate.Codigo = lector["Codigo"].ToString();
                    cate.Nombre = lector["Nombre"].ToString();
                    cate.Observacion = lector["Observacion"].ToString();
                }
            }
            return cate;
        }

        public bool Actualizar(Categoria cambiarCategoria)
        {
            bool exito = false;
            using (SqlConnection conexion = new SqlConnection(ConexionUtil.CadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("ActualizarCategoria", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo", cambiarCategoria.Codigo);
                cmd.Parameters.AddWithValue("@Nombre", cambiarCategoria.Nombre);
                cmd.Parameters.AddWithValue("@Observacion", cambiarCategoria.Observacion);
                cmd.Parameters.AddWithValue("@Id", cambiarCategoria.Id);
                exito = cmd.ExecuteNonQuery() > 0;
            }
            return exito;
        }

        public bool Eliminar(int idCategoria)
        {
            bool exito = false;
            using (SqlConnection conexion = new SqlConnection(ConexionUtil.CadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("EliminarCategoria", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", idCategoria);
                exito = cmd.ExecuteNonQuery() > 0;
            }
            return exito;
        }
    }
}
