using NUnit.Framework;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
using System.Text;

[TestFixture]
public class ConexionBdTests
{
    [Test]
    public void ProbarConexion_ConexionExitosa_RetornaTrue()
    {
        // Arrange
        string cadenaConexion = "server=localhost;database=proyecto_mantenimiento;uid=root;pwd=";

        // Act
        bool resultado;
        using (var conexion = new MySqlConnection(cadenaConexion))
        {
            conexion.Open();
            resultado = conexion.State == System.Data.ConnectionState.Open;
        }

        // Assert
        Assert.IsTrue(resultado);
    }
    [TestFixture]
    public class ComparacionContrase�aTests
    {
        [Test]
        public void CompararContrase�as_Contrase�aEncriptada_RetornaTrue()
        {
            // Arrange
            string contrase�aPlana = "rodri123";
            string contrase�aEncriptada = EncriptarContrase�a(contrase�aPlana);

            // Act
            bool resultado = CompararContrase�as(contrase�aPlana, contrase�aEncriptada);

            // Assert
            Assert.IsTrue(resultado);
        }

        private string EncriptarContrase�a(string contrase�a)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(contrase�a));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private bool CompararContrase�as(string contrase�aPlana, string contrase�aEncriptada)
        {
            string encriptada = EncriptarContrase�a(contrase�aPlana);
            return string.Equals(encriptada, contrase�aEncriptada);
        }
    }
}
