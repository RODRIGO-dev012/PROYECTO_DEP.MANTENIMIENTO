using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaDatos.Clases;

namespace CapaNegocio
{
    public class UsuarioBusiness
    {
        private Usuario usuarioDatos;

        public UsuarioBusiness()
        {
            usuarioDatos = new Usuario();
        }
        public Usuario IniciarSesion(string usuario, string contrasena)
        {
            try
            {
                // Verificar las credenciales llamando al método VerificarCredenciales() en el objeto usuarioDatos
                Usuario usuarioAutenticado = usuarioDatos.VerificarCredenciales(usuario, contrasena);

                if (usuarioAutenticado != null)
                {
                    // Si las credenciales son válidas, se retorna el objeto Usuario autenticado con su respectivo rol
                    return usuarioAutenticado;
                }
                else
                {
                    // Si las credenciales no son válidas, se lanza una excepción de tipo ApplicationException con un mensaje descriptivo
                    throw new ApplicationException("Las credenciales ingresadas no son válidas.");
                }
            }
            catch (ApplicationException ex)
            {
                // Si se produce una ApplicationException, se lanza una nueva ApplicationException con un mensaje personalizado
                throw ex;
            }
            catch (Exception ex)
            {
                // Si se produce cualquier otra excepción durante el inicio de sesión, se lanza una ApplicationException con un mensaje personalizado
                throw ex;
            }
        }
        public List<Usuario> ObtenerUsuarios()
        {
            try
            {
                return usuarioDatos.ObtenerUsuarios();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al obtener los usuarios.", ex);
            }
        }
        public void CambiarEstadoUsuario(string idUsuario, string estado)
        {
            try
            {
                // Llamar al método en tu capa de datos para cambiar el estado del usuario
                usuarioDatos.ActualizarEstadoUsuario(idUsuario, estado);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al cambiar el estado del usuario.", ex);
            }
        }
        public class RegistroUsuarioException : Exception
        {
            public RegistroUsuarioException(string message) : base(message)
            {
            }

            public RegistroUsuarioException(string message, Exception innerException) : base(message, innerException)
            {
            }
        }

        public class ExisteUsuarioException : Exception
        {
            public ExisteUsuarioException(string message) : base(message)
            {
            }

            public ExisteUsuarioException(string message, Exception innerException) : base(message, innerException)
            {
            }
        }
    }
}
