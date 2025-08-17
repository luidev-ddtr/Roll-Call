using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roll_Call.BNL
{
    internal class Cursa
    {
        public int Matricula { get; set; }
        public int ID_Asignatura { get; set; }
        public string Periodo { get; set; }
        public float calificacion { get; set; }

        public Cursa()
        {
            // Constructor vacío válido
            // Las propiedades se inicializan automáticamente con valores default
        }
    }
}
