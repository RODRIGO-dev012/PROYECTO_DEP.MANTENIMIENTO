using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Habitacion
    {
        private string Id_habitacion;
        public string id_Habitacion
        {
            get { return Id_habitacion; }
            set { Id_habitacion = value; }
        }
        private string Numhab;
        public string numhab
        {
            get { return Numhab; }
            set { Numhab = value; }
        }
        private string Estadohab;
        public string estadohab
        {
            get { return Estadohab; }
            set { Estadohab = value; }
        }
    }
}
