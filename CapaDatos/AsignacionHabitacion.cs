using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class AsignacionHabitacion
    {
        public string nombre { get; set; }
        public string estado { get ; set; }

        public AsignacionHabitacion(string nombre, string estado)
        {
            this.nombre = nombre;
            this.estado = estado;
        }
    }
}
