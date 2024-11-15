using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class ProductoDAO
    {
        private Conexion conn = new Conexion();

        MySqlCommand command = new MySqlCommand();
        MySqlDataReader reader;
        DataTable table = new DataTable();

        public DataTable ObtenerProductos()
        {
            command.Connection = conn.AbrirConexion();
            command.CommandText = "MostrarProductos";
            command.CommandType = CommandType.StoredProcedure;

            using (var reader = command.ExecuteReader())
            {
                table.Clear();
                table.Load(reader);
            }
            conn.CerrarConexion();
            return table;
        }

        public void Insertar(string nombre, string descripcion, string marca, double precio, int inventario)
        {
            command.Connection = conn.AbrirConexion();
            command.CommandText = "InsertarProductos";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@p_nombre", nombre);
            command.Parameters.AddWithValue("@p_descripcion", descripcion);
            command.Parameters.AddWithValue("@p_marca", marca);
            command.Parameters.AddWithValue("@p_precio", precio);
            command.Parameters.AddWithValue("@p_inventario", inventario);

            command.ExecuteNonQuery();
            command.Parameters.Clear();
            conn.CerrarConexion();
        }

        public void Editar(string nombre, string descripcion, string marca, double precio, int inventario, int id)
        {
            command.Connection = conn.AbrirConexion();
            command.CommandText = "EditarProductos";
            command.CommandType= CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@p_nombre", nombre);
            command.Parameters.AddWithValue("@p_descripcion", descripcion);
            command.Parameters.AddWithValue("@p_marca", marca);
            command.Parameters.AddWithValue("@p_precio", precio);
            command.Parameters.AddWithValue("@p_inventario", inventario);
            command.Parameters.AddWithValue("@p_id", id);

            command.ExecuteNonQuery();
            command.Parameters.Clear();
            conn.CerrarConexion();
        }

        public void Eliminar(int id)
        {
            command.Connection = conn.AbrirConexion();
            command.CommandText = "EliminarProducto";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id_producto", id);

            command.ExecuteNonQuery();
            command.Parameters.Clear();
            conn.CerrarConexion();
        }
    }
}
