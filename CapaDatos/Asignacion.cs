using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Asignacion
    {
        private string Estado;
        public String estado
        {
            get { return Estado; }
            set { Estado = value; }
        }
        private Habitacion Id_habitacion;
        public Habitacion id_habitacion
        {
            get { return Id_habitacion; }
            set {Id_habitacion = value; }
        }
        private Componente Id_Componente;
        public Componente id_componente
        {
            get { return Id_Componente; }
            set { Id_Componente = value; }
        }
    }
}
