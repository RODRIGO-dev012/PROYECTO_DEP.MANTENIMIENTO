using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Clases
{
    public  class Rol
    {
        private int id_Rol;
        public int Id_rol
        {
            get { return id_Rol; }
            set { id_Rol = value; }
        }
        private string NombreRol;
        public string nombreRol
        {
            get { return NombreRol; }
            set { NombreRol = value; }
        }
    }
}
