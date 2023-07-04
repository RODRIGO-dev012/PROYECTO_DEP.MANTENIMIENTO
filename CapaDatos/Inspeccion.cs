using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Inspecciones
    {
        private string Id_inspecciones;
        public string id_inspecciones
        {
            get { return Id_inspecciones; }
            set { Id_inspecciones = value; }
        }
        private string Estado;
        public string estado
        {
            get { return Estado; }
            set { Estado = value; }
        }
        private DateTime Fecha;
        public DateTime fecha
        {
            get { return Fecha; }
            set { Fecha = value; }
        }
        private string Num;
        public string num
        {
            get { return Num; }
            set { Num = value; }
        }
        private string Obser;

        public Inspecciones(DateTime fecha)
        {
            this.fecha = fecha;
        }


        public string observaciones
        {
            get { return Obser; }
            set { Obser = value; }
        }

    }
}
