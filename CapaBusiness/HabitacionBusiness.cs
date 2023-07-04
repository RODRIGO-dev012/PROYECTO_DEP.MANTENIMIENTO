using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Http.Headers;
using CapaDatos;
using CapaDatos.Clases;
using MySql.Data.MySqlClient;

public class HabitacionBusiness
{
    private Habitacion Hab;

    public HabitacionBusiness()
    {
        Hab = new Habitacion();
    }

    public List<Habitacion> ObtenerHabitaciones()
    {
        List<Habitacion> habitaciones = new List<Habitacion>();

        try
        {
            ConexionBd conexion = new ConexionBd();
            using (MySqlConnection cn = conexion.ObtenerConexion())
            {
                string query = "SELECT id_habitacion, numhabitacion, estado FROM habitacion";

                using (MySqlCommand cmd = new MySqlCommand(query, cn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Habitacion hab = new Habitacion();
                            hab.id_Habitacion = reader.GetString("id_habitacion");
                            hab.numhab = reader.GetString("numhabitacion");
                            hab.estadohab = reader.GetString("estado");
                            habitaciones.Add(hab);
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            // Manejar la excepción según tus necesidades.
            Console.WriteLine("Error al obtener las habitaciones: " + ex.Message);
        }

        return habitaciones;
    }
    public List<AsignacionHabitacion> Obtenerdatosdehabitacion(string numhabitacion)
    {
        List<AsignacionHabitacion> habitaciones = new List<AsignacionHabitacion>();

        try
        {
            ConexionBd conexion = new ConexionBd();
            using (MySqlConnection cn = conexion.ObtenerConexion())
            {
                
                string query = "SELECT c.nombre, a.estado " +
                                "FROM componentes c " +
                                "INNER JOIN asignacion a on a.id_componente = c.id_componente " +
                                "INNER JOIN habitacion h on a.id_habitacion = h.id_habitacion " +
                                $"WHERE h.numhabitacion = '{numhabitacion}'";
                MySqlCommand command = new MySqlCommand(query, cn);

                //command.Parameters.AddWithValue("@numhabitacion", numhabitacion);

                using (MySqlCommand cmd = new MySqlCommand(query, cn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        AsignacionHabitacion hab;
                        int contro = 0;
                        while (reader.Read())
                        {
                            contro++;
                            hab = new AsignacionHabitacion(reader.GetString("nombre"), reader.GetString("estado"));
                            //hab.nombre = reader.GetString("c.nombre");
                            //hab.numhab = reader.GetString("h.numhabitacion");
                            habitaciones.Add(hab);
                        }

                    }
                }
            }
        }
        catch (Exception ex)
        {
            // Manejar la excepción según tus necesidades.
            Console.WriteLine("Error al obtener las habitaciones: " + ex.Message);
        }

        return habitaciones;
    }
    public void UpdateInspecciones(string estado, string habitacionid, int componenteid)
    {
        try
        {
            using (MySqlConnection connection = new ConexionBd().ObtenerConexion())
            {
                string query = "UPDATE asignacion SET estado = @estado WHERE id_habitacion = @habitacionid AND id_componente = @componenteid";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@estado", estado);
                command.Parameters.AddWithValue("@habitacionid", habitacionid);
                command.Parameters.AddWithValue("@componenteid", componenteid);
                command.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            throw new ApplicationException("Error al actualizar la asignacion.", ex);
        }
    }

    public void Updatecargarfechaobservacion(DateTime fecha, string observaciones)
    {
        try
        {
            using (MySqlConnection connection = new ConexionBd().ObtenerConexion())
            {
                string query = "UPDATE inspeccion SET fecha = @fecha, observaciones = @observaciones WHERE id_inspeccion = @id_inspeccion;";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@fecha", fecha);
                command.Parameters.AddWithValue("@observaciones", observaciones);
                command.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            throw new ApplicationException("Error al actualizar la carga fecha y observacion.", ex);
        }
    }

}
