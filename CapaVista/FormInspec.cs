using CapaBusiness;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using log4net.Config;
using Hotel;

namespace CapaVista
{
    public partial class FormInspec : Form
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Form1));
        private AsignacionBusiness asignacionBusiness; // Instancia de la clase AsignacionBusiness
        private HabitacionBusiness habitacionBusiness = new HabitacionBusiness();
        ComponentesBusiness com = new ComponentesBusiness();
        private string numHabitacion, idhabitacion; // Variable para almacenar el número de habitación

        public FormInspec(string numHabitacion, string habitacion)
        {
            log4net.Config.XmlConfigurator.Configure();
            InitializeComponent();
            idhabitacion = habitacion;
            txt_noHabinspec.Text = numHabitacion;
            //MessageBox.Show(numHabitacion);
            // Obtener la lista de habitaciones utilizando el método ObtenerHabitaciones() en la clase HabitacionBusiness
            List<AsignacionHabitacion> habitaciones = habitacionBusiness.Obtenerdatosdehabitacion(numHabitacion);

            // Limpiar las filas existentes en el control DataGridView (dgv_menuhome)
            dgv_menucomponente.Rows.Clear();

            // Recorrer la lista de habitaciones y agregar cada habitación como una nueva fila en el DataGridView
            foreach (AsignacionHabitacion h in habitaciones)
            {
                //MessageBox.Show(h.nombre);
                dgv_menucomponente.Rows.Add(h.nombre, h.estado);
            }
        }

        // Método para cargar el número de habitación
        public void CargarHabitacion(string numHabitacion)
        {
            this.numHabitacion = numHabitacion;
            txt_noHabinspec.Text = numHabitacion;
        }

        private void FormInspec_Load(object sender, EventArgs e)
        {
            asignacionBusiness = new AsignacionBusiness();
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                log.Info("Iniciando proceso de guardar datos...");

                int count = 0;
                int num = dgv_menucomponente.Rows.Count;
                while (count < num - 2)
                {
                    count++;
                    string estado = dgv_menucomponente.Rows[count].Cells["estado"].Value.ToString();
                    string componente = dgv_menucomponente.Rows[count].Cells["Componente"].Value.ToString();
                    int componenteId = com.ObtenerComponenteId(componente);

                    log.Debug($"Actualizando inspecciones: estado={estado}, idhabitacion={idhabitacion}, componente={componente}, componenteId={componenteId}");

                    habitacionBusiness.UpdateInspecciones(estado, idhabitacion, componenteId);

                    Inspecciones inspecciones = new Inspecciones(DateTime.Now);
                }

                log.Info("Datos guardados exitosamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                log.Error("Error al guardar los datos.", ex);
                throw;
            }
        }

        public DateTime ObtenerFechaHoraActual()
        {
            return DateTime.UtcNow;
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_menucomponente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
