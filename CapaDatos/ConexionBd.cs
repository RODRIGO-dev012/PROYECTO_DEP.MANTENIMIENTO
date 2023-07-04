using System.Data;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
    public class ConexionBd
    {
        private MySqlConnection conexion;

        public ConexionBd()
        {
            string servidor = "localhost";
            string baseDatos = "proyecto_mantenimiento";
            string usuario = "root";
            string contraseña = "";

            string cadenaConexion = $"server={servidor};database={baseDatos};uid={usuario};pwd={contraseña}";

            conexion = new MySqlConnection(cadenaConexion);
        }

        public MySqlConnection ObtenerConexion()
        {
            AbrirConexion();
            return conexion;
        }

        private void AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
        }

        public void CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }
}
