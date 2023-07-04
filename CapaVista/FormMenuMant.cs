using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class FormMenuMant : Form
    {
        public FormMenuMant()
        {
            InitializeComponent();
        }

        private void dgv_menumant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario FormHojaCorrectivo
            FormHojaCorrectivo formHojaCorrectivo = new FormHojaCorrectivo();

            // Mostrar el formulario FormHojaCorrectivo
            formHojaCorrectivo.Show();
        }
    }
}
