using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Empleado
    {
        public Empleado(int id_empleado, string nombre_emp, string apellido)
        {
            Id_empleado = id_empleado;
            Nombre_emp = nombre_emp;
            Apellido = apellido;
        }
        public int Id_empleado { get; set; }
        public string Nombre_emp { get; set; }
        public string Apellido { get; set; }
    }
}
