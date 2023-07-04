using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Cryptography;
using log4net;
using log4net.Config;
using static Org.BouncyCastle.Bcpg.Attr.ImageAttrib;

namespace CapaDatos.Clases
{
    public  class Usuario : Persona
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Usuario));


        private string user;
        public string User
        {
            get { return user; }
            set { user = value; }
        }

        private string contrasena;
        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }

        private Rol rol;
        public Rol Rol
        {
            get { return rol; }
            set { rol = value; }

        }
        private string Estado;
        public string estado
        {
            get { return Estado; }
            set { Estado = value; }
        }
        public Usuario VerificarCredenciales(string usuario, string contrasena)
        {
            try
            {
                using (MySqlConnection connection = new ConexionBd().ObtenerConexion())
                {
                    string query = "SELECT usuario.*, rol.nombre_rol FROM usuario INNER JOIN rol ON usuario.id_rol = rol.id_rol WHERE usuario.usuario = @usuario";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@usuario", usuario);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string contrasenaAlmacenada = reader.GetString("contrasena");
                            string estadoCuenta = reader.GetString("estado");

                            string contrasenaEncriptadaIngresada = EncriptarContrasena(contrasena);

                            if (contrasenaEncriptadaIngresada == contrasenaAlmacenada)
                            {
                                if (estadoCuenta == "Habilitado")
                                {
                                    Usuario usuarioAutenticado = new Usuario
                                    {
                                        nombre = reader.GetString("nombre"),
                                        apellidos = reader.GetString("apellidos"),
                                        Rol = new Rol { nombreRol = reader.GetString("nombre_rol") }
                                    };

                                    // Log de información: Credenciales verificadas correctamente
                                    log.Info($"Las credenciales del usuario '{usuario}' han sido verificadas correctamente.");

                                    return usuarioAutenticado;
                                }
                                else
                                {
                                    // Log de alerta: Cuenta inhabilitada
                                    log.Warn($"La cuenta del usuario '{usuario}' está inhabilitada.");

                                    throw new ApplicationException("Usted se encuentra inhabilitado. Por favor, contacte con el Administrador.");
                                }
                            }
                            else
                            {
                                // Log de alerta: Credenciales incorrectas
                                log.Warn($"Las credenciales ingresadas para el usuario '{usuario}' no son válidas.");

                                return null;
                            }
                        }
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                // Log de error: Error al verificar las credenciales
                log.Error($"Error al verificar las credenciales del usuario '{usuario}': {ex.Message}");

                throw ex;
            }
        }

        private string EncriptarContrasena(string contrasena)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Convertir la contraseña en un arreglo de bytes utilizando la codificación UTF-8
                byte[] bytes = Encoding.UTF8.GetBytes(contrasena);

                // Calcular el hash SHA-256 de los bytes de la contraseña
                byte[] hash = sha256.ComputeHash(bytes);

                // Crear un StringBuilder para almacenar el hash en formato hexadecimal
                StringBuilder stringBuilder = new StringBuilder();

                // Recorrer cada byte del hash y convertirlo a su representación hexadecimal
                for (int i = 0; i < hash.Length; i++)
                {
                    // Agregar el byte convertido a hexadecimal al StringBuilder
                    stringBuilder.Append(hash[i].ToString("x2"));
                }

                // Devolver el hash como una cadena en formato hexadecimal
                return stringBuilder.ToString();
            }
        }
        public List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            try
            {
                using (MySqlConnection connection = new ConexionBd().ObtenerConexion())
                {
                    string query = "SELECT u.nombre, u.apellidos, u.ci, u.usuario, u.id_rol, r.nombre_rol, u.estado FROM usuario u INNER JOIN rol r ON u.id_rol = r.id_rol";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Usuario usuario = new Usuario
                            {
                                nombre = reader.GetString("nombre"),
                                apellidos = reader.GetString("apellidos"),
                                ci = reader.GetString("ci"),
                                User = reader.GetString("usuario"),
                                Rol = new Rol { Id_rol = reader.GetInt32("id_rol"), nombreRol = reader.GetString("nombre_rol") },
                                Estado = reader.GetString("estado")
                            };

                            usuarios.Add(usuario);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al obtener los usuarios.", ex);
            }

            return usuarios;
        }
        public void ActualizarEstadoUsuario(string usuario, string nuevoEstado)
        {
            try
            {
                using (MySqlConnection connection = new ConexionBd().ObtenerConexion())
                {
                    string query = "UPDATE usuario SET estado = @nuevoEstado WHERE usuario = @usuario";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@nuevoEstado", nuevoEstado);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al actualizar el estado del usuario.", ex);
            }
        }
        
    }
}
