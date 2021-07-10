using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio04HLBV
{
    class BecaInternacionalHLBV : BecaHLBV
    {
        private string pais;
        private DateTime fechaViaje;
        public string Pais { get => pais; set => pais = value; }
        public DateTime FechaViaje { get => fechaViaje; set => fechaViaje = value; }

        public BecaInternacionalHLBV(string pais, string cedula, string nombres, string universidad, 
            double monto, int tiempoEstudio, string foto, DateTime fechaViaje)
            : base(cedula, nombres, universidad, monto, tiempoEstudio, foto)
        {
            this.pais = pais;
            this.fechaViaje = fechaViaje;
        }

        public override string ToString()
        {
            return base.ToString()+"\r\nPaís: "+pais+"\r\nFecha viaje de ida: "+fechaViaje.ToShortDateString();
        }

        public override string Conferencias()
        {
            return base.Conferencias() + " en " + pais;
        }
    }
}
