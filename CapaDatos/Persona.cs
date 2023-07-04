using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Clases
{
    public class Persona
    {
        private string Nombre;
        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        private string Apellidos;
        public string apellidos
        {
            get { return Apellidos; }
            set { Apellidos = value; }
        }

        private string Ci;
        public string ci
        {
            get { return Ci; }
            set { Ci = value; }
        }
    }
}
