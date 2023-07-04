using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaVista;
using CapaNegocio;
using Hotel;
using log4net;
using log4net.Config;

namespace CapaVista
{
    public partial class Home : Form
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Form1));
        private HabitacionBusiness habitacionBusiness; // Instancia de la clase HabitacionBusiness

        public Home()
        {
            log4net.Config.XmlConfigurator.Configure();
            InitializeComponent();
        }

        private void Home_Load_1(object sender, EventArgs e)
        {
            Console.WriteLine("Cargando formulario Home...");
            habitacionBusiness = new HabitacionBusiness();
            CargarHabitaciones();
        }
        List<Habitacion> habitaciones;
        private void CargarHabitaciones()
        {
            try
            {
                log.Info("Cargando habitaciones...");

                // Obtener la lista de habitaciones utilizando el método ObtenerHabitaciones() en la clase HabitacionBusiness
                habitaciones = habitacionBusiness.ObtenerHabitaciones();

                // Limpiar las filas existentes en el control DataGridView (dgv_menuhome)
                dgv_menuhome.Rows.Clear();

                // Recorrer la lista de habitaciones y agregar cada habitación como una nueva fila en el DataGridView
                foreach (Habitacion h in habitaciones)
                {
                    if (h.estadohab == "En mantenimiento") // Agrega la condición para verificar el estado de mantenimiento
                    {
                        dgv_menuhome.Rows.Add(h.numhab, h.estadohab);
                    }
                }

                log.Info($"Se cargaron {dgv_menuhome.Rows.Count} filas en el DataGridView.");
            }
            catch (Exception ex)
            {
                log.Error("Error al cargar las habitaciones.", ex);
                MessageBox.Show("Ocurrió un error al cargar las habitaciones. Consulte el archivo de logs para obtener más información.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_menuhome_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                try
                {
                    log.Info("Celda del DataGridView seleccionada.");

                    string numhab = dgv_menuhome.Rows[e.RowIndex].Cells["numhab"].Value.ToString();
                    string habitacion = habitaciones[e.RowIndex].id_Habitacion.ToString();
                    //MessageBox.Show(habitacion);
                    FormInspec inspeccion = new FormInspec(numhab, habitacion);
                    inspeccion.ShowDialog();
                }
                catch (Exception ex)
                {
                    log.Error("Error al abrir el formulario de inspección.", ex);
                    MessageBox.Show("Ocurrió un error al abrir el formulario de inspección. Consulte el archivo de logs para obtener más información.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgv_menuhome_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {

        }
    }
}
