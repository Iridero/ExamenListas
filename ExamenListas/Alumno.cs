using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenListas
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public float Practicas { get; set; }
        public float Examen { get; set; }
        public float Participaciones { get; set; }
        public float Promedio
        {
            get
            {
                return Practicas + 0.5f + Examen * 0.4f + Participaciones * 0.1f;
            }
        }
    }
}
