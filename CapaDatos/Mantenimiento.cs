using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Mantenimiento
    {
        public Mantenimiento(int id_mantenimiento, DateTime fechamant, Empleado id_empleado)
        {
            Id_mantenimiento = id_mantenimiento;
            Fechamant = fechamant;
            Id_empleado = id_empleado;
        }
        public int Id_mantenimiento { get; set; }
        public DateTime Fechamant { get; set; }
        public Empleado Id_empleado { get; set; }
    }
}
