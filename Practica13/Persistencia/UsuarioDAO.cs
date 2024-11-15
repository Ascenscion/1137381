using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Persistencia
{
    public class UsuarioDAO
    {
        private Conexion conn = new Conexion();

        MySqlCommand command = new MySqlCommand();
        MySqlDataReader reader;
        DataTable table = new DataTable();
        

        public bool BuscarUsuario(string usuario, string pass)
        {
            bool existsValido = false;
            command.Connection = conn.AbrirConexion();
            command.CommandText = "VerificarUsuario";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@p_nombre", usuario);
            command.Parameters.AddWithValue("@p_contra", pass);
            reader = command.ExecuteReader();
            existsValido = reader.HasRows;

            reader.Close();
            command.Parameters.Clear();
            conn.CerrarConexion();
            return existsValido;
        }
    }
}
