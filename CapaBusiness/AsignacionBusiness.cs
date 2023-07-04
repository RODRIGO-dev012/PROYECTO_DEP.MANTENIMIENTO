using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace CapaBusiness
{
    public class AsignacionBusiness
    {
        public List<Componente> ObtenerComponentesPorHabitacion(string idHabitacion)
        {
            List<Componente> componentes = new List<Componente>();

            try
            {
                ConexionBd conexion = new ConexionBd();
                using (MySqlConnection cn = conexion.ObtenerConexion())
                {
                    string query = "SELECT c.* FROM componente c INNER JOIN asignacion a ON c.id_componente = a.id_componente WHERE a.id_habitacion = @idHabitacion";

                    using (MySqlCommand cmd = new MySqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@idHabitacion", idHabitacion);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Componente componente = new Componente();
                                componente.id_componente = reader.GetString("id_componente");
                                componente.nombre = reader.GetString("nombre");
                                // Agrega más propiedades si es necesario
                                componentes.Add(componente);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los componentes por habitación: " + ex.Message);
            }

            return componentes;
        }

        public string ObtenerEstadoComponente(string idComponente)
        {
            string estado = string.Empty;

            try
            {
                ConexionBd conexion = new ConexionBd();
                using (MySqlConnection cn = conexion.ObtenerConexion())
                {
                    string query = "SELECT estado FROM asignacion WHERE id_componente = @idComponente";

                    using (MySqlCommand cmd = new MySqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@idComponente", idComponente);

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            estado = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el estado del componente: " + ex.Message);
            }

            return estado;
        }

        public void ActualizarEstadoComponente(string idComponente, string nuevoEstado)
        {
            try
            {
                ConexionBd conexion = new ConexionBd();
                using (MySqlConnection cn = conexion.ObtenerConexion())
                {
                    string query = "UPDATE asignacion SET estado = @nuevoEstado WHERE id_componente = @idComponente";

                    using (MySqlCommand cmd = new MySqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@nuevoEstado", nuevoEstado);
                        cmd.Parameters.AddWithValue("@idComponente", idComponente);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar el estado del componente: " + ex.Message);
            }
        }
    }
}


