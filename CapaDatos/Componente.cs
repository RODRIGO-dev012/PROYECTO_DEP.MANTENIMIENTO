using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Componente
    {
        private string Id_componente;
        public string id_componente
        {
            get { return Id_componente; }
            set { Id_componente = value; }
        }
        private string Nombre;
        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
    }
}
