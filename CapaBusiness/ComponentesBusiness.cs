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
    public class ComponentesBusiness
    {
        private ConexionBd conexion;

        public ComponentesBusiness()
        {
            conexion = new ConexionBd();
        }

        public List<Componente> ObtenerComponentesPorHabitacion(string numHabitacion)
        {
            List<Componente> componentes = new List<Componente>();

            try
            {
                using (MySqlConnection cn = conexion.ObtenerConexion())
                {
                    string query = "SELECT id_componente, nombre FROM componente " +
                                   "INNER JOIN asignacion ON componente.id_componente = asignacion.id_componente " +
                                   "INNER JOIN habitacion ON asignacion.id_habitacion = habitacion.id_habitacion " +
                                   "WHERE habitacion.numhabitacion = @numHabitacion";

                    using (MySqlCommand cmd = new MySqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@numHabitacion", numHabitacion);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Componente componente = new Componente();
                                componente.id_componente = reader.GetString("id_componente");
                                componente.nombre = reader.GetString("nombre");
                                componentes.Add(componente);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción según tus necesidades.
                Console.WriteLine("Error al obtener los componentes: " + ex.Message);
            }

            return componentes;
        }
        public int ObtenerComponenteId(string nombrecomponente)
        {
            List<Componente> componentes = new List<Componente>();
            int id = 0;
            try
            {
                using (MySqlConnection cn = conexion.ObtenerConexion())
                {
                    string query = "SELECT id_componente " +
                                   "FROM componentes " +
                                   "WHERE nombre = @nombre";

                    using (MySqlCommand cmd = new MySqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombrecomponente);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                id = int.Parse(reader.GetString("id_componente"));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción según tus necesidades.
                Console.WriteLine("Error al obtener los componentes: " + ex.Message);
            }

            return id;
        }
    }
}

