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
    public class ComparacionContraseñaTests
    {
        [Test]
        public void CompararContraseñas_ContraseñaEncriptada_RetornaTrue()
        {
            // Arrange
            string contraseñaPlana = "rodri123";
            string contraseñaEncriptada = EncriptarContraseña(contraseñaPlana);

            // Act
            bool resultado = CompararContraseñas(contraseñaPlana, contraseñaEncriptada);

            // Assert
            Assert.IsTrue(resultado);
        }

        private string EncriptarContraseña(string contraseña)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(contraseña));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private bool CompararContraseñas(string contraseñaPlana, string contraseñaEncriptada)
        {
            string encriptada = EncriptarContraseña(contraseñaPlana);
            return string.Equals(encriptada, contraseñaEncriptada);
        }
    }
}
