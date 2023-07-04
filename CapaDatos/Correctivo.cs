using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Correctivo
    {
        public Correctivo(int id_correctivo, string solucion, Empleado id_empleado)
        {
            Id_correctivo = id_correctivo;
            Solucion = solucion;
            Empleado = id_empleado;
        }
        public int Id_correctivo { get; set; }
        public string Solucion { get; set; }
        public Empleado Empleado { get; set; }
    }
}
