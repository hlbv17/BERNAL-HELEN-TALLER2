using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio04HLBV
{
    class BecaHLBV
    {
        private string cedula;
        private string nombres;
        private string universidad;
        private double monto;
        private int tiempoEstudio;
        private string foto;


        /*public Beca()  //tipeado
        {
            this.cedula = "000000000";
            this.nombres = "S/N";
            this.universidad = "Universidad de Guayaquil";
            this.monto = 1000;
            this.tiempoEstudio = 10;
        }*/

        public BecaHLBV(string cedula, string nombres, string universidad, double monto, int tiempoEstudio, string foto)
        { //generado
            Cedula = cedula;
            Nombres = nombres;
            Universidad = universidad;
            Monto = monto;
            TiempoEstudio = tiempoEstudio;
            Foto = foto;
        }

        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Universidad { get => universidad; set => universidad = value; }
        public double Monto { get => monto; set => monto = value; }
        public int TiempoEstudio { get => tiempoEstudio; set => tiempoEstudio = value; }
        public string Foto { get => foto; set => foto = value; }

        public double MontoPago(int partes)
        {
            return monto / partes;
        }

        public int TiempoRestante(int tiempo)
        {
            return tiempoEstudio - tiempo;
        }

        public override string ToString()
        {
            return "\r\nCedula: "+cedula+ "\r\nNombres: " + nombres+ "\r\nUniversidad: " + universidad+
                "\r\nMonto: " + monto+ "\r\nTiempo de estudio: " + tiempoEstudio + "\r\nRuta de la foto: " +foto;
        }

        public virtual string Conferencias()  /*permite que la subclase lo sobrescriba*/
        {
            return nombres+" asiste a algunas conferencias en "+universidad;
        }


    }
}
