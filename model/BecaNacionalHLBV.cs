using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio04HLBV
{
    class BecaNacionalHLBV : BecaHLBV
    {
        private string ciudad;

        public string Ciudad { get => ciudad; set => ciudad = value; }

        public BecaNacionalHLBV() : base("000000000", "S/N", "Universidad de Guayaquil", 1000, 10, "C:\\")   //invoca el constructor de la clase base
        {
            Ciudad = "Guayaquil";
        }

        public BecaNacionalHLBV(string ciudad, string cedula, string nombres, string universidad, double monto, 
            int tiempoEstudio, string foto) : base(cedula,  nombres,  universidad,  monto,  tiempoEstudio, foto)
        {
            this.Ciudad = ciudad;
        }

        
        public override string ToString()
        {
            return base.ToString() + "\r\nCiudad: " + ciudad;
        }

        public override string Conferencias()
        {
            return base.Conferencias();
        }
        internal string Mensaje()
        {
            return Nombres + " tiene una beca Nacional";
        }
    }
}
