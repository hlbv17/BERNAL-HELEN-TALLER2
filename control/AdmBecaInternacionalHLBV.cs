using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Aplicar el patrón de diseño Singleton
//1. Crear un atributo estático del tipo de la clase
//2. Cambiar el constructor de public a private
//3. Crear un getter del atributo estático tipo de la clase
//Verificar si el atributo es null

namespace Ejercicio04HLBV.control
{
    class AdmBecaInternacionalHLBV
    {
        private static AdmBecaInternacionalHLBV adm = new AdmBecaInternacionalHLBV();
        List<BecaHLBV> lista = null;
        ValidacionHLBV v = null;
        BecaHLBV b = null;

        internal BecaHLBV B { get => b; set => b = value; }
        internal List<BecaHLBV> Lista { get => lista; set => lista = value; }

        private AdmBecaInternacionalHLBV()
        {
            lista = new List<BecaHLBV>();
            v = new ValidacionHLBV();
        }

        public static AdmBecaInternacionalHLBV GetAdm()
        {
            if(adm == null)
            {
                adm = new AdmBecaInternacionalHLBV();
            }
            return adm;
        }

        /*internal bool EsCorrecto(string nombre, string cedula, string universidad, string monto, string pais, string tiempo, DateTime fecha)
        {
            bool x = true;
            if (String.IsNullOrEmpty(nombre) && String.IsNullOrEmpty(cedula)&& String.IsNullOrEmpty(monto)
                && String.IsNullOrEmpty(pais) && String.IsNullOrEmpty(universidad) && String.IsNullOrEmpty(tiempo)
                && fecha != null && v.EsReal(monto))
            {
                x = true;
            }
            return x;
        }*/

        internal bool ValidarV(CheckBox chkNacional, CheckBox chkInternacional, ErrorProvider error)
        {
            bool no_error = true;
            if (chkNacional.Checked == false && chkInternacional.Checked == false)
            {
                error.SetError(chkNacional, "Requiere Selección");
                no_error = false;
            }
            else
            {
                error.Clear();
            }
            return no_error;
        }


        internal bool Validar(TextBox txtCedula, TextBox txtNombres, TextBox txtTiempo, TextBox txtMonto, ComboBox cmbPais,
            ComboBox cmbUniv, PictureBox image, ErrorProvider errorP)
        {
            bool no_error = true;
            string cedula = txtCedula.Text;
            if (String.IsNullOrEmpty(txtCedula.Text.Trim()))
            {
                errorP.SetError(txtCedula, "Ingrese una cédula");
                no_error = false;
            }
            else if (estaCedula(cedula))
            {
                errorP.SetError(txtCedula, "Ya existe esta cédula");
                no_error = false;
            }
            else if (cedula.Length < 10)
            {
                errorP.SetError(txtCedula, "La cédula debe ser de 10 dígitos");
                no_error = false;
            }
            else
            {
                errorP.SetError(txtCedula, "");
            }
            if (String.IsNullOrEmpty(txtNombres.Text))
            {
                errorP.SetError(txtNombres, "Ingrese un nombre");
                no_error = false;
            }
            else
            {
                errorP.SetError(txtNombres, "");
            }
            if (String.IsNullOrEmpty(txtTiempo.Text))
            {
                errorP.SetError(txtTiempo, "Ingrese el tiempo");
                no_error = false;
            }
            else
            {
                errorP.SetError(txtTiempo, "");
            }
            if (String.IsNullOrEmpty(txtMonto.Text))
            {
                errorP.SetError(txtMonto, "Ingrese el monto");
                no_error = false;
            }
            else
            {
                errorP.SetError(txtMonto, ""); ;
            }
            if (String.IsNullOrEmpty(cmbPais.Text))
            {
                errorP.SetError(cmbPais, "Seleccione un país");
                no_error = false;
            }
            else
            {
                errorP.SetError(cmbPais, ""); ;
            }
            if (String.IsNullOrEmpty(cmbUniv.Text))
            {
                errorP.SetError(cmbUniv, "Seleccione una universidad");
                no_error = false;
            }
            else
            {
                errorP.SetError(cmbUniv, ""); ;
            }
            if (image.ImageLocation == null )
            {
                errorP.SetError(image, "Suba una foto");
                no_error = false;
            }
            else
            {
                errorP.SetError(image, ""); ;
            }
            /*if (dtpFechaViaje == null)
            {
                errorP.SetError(dtpFechaViaje, "Seleccione una fecha");
                no_error = false;
            }
            else
            {
                errorDtpFecha.SetError(dtpFechaViaje, ""); ;
            }*/
            return no_error;
        }

        internal void guardar(string nombre, string cedula, string universidad, string monto, string lugar, 
            string tiempo, string foto, DateTime fecha, RadioButton rdbNacional, RadioButton rdbInternacional)
        {
            if (rdbInternacional.Checked == true)
            {
                BecaInternacionalHLBV bi = null;
                double dMonto = v.AReal(monto);
                int iTiempo = v.AEntero(tiempo);
                bi = new BecaInternacionalHLBV(lugar, cedula, nombre, universidad, dMonto, iTiempo, foto, fecha);
                lista.Add(bi);
            }
            else if (rdbNacional.Checked == true)
            {
                BecaNacionalHLBV bn = null;
                double dMonto = v.AReal(monto);
                int iTiempo = v.AEntero(tiempo);
                bn = new BecaNacionalHLBV(lugar, cedula, nombre, universidad, dMonto, iTiempo, foto);
                lista.Add(bn);
            }
            
        }

        private bool estaCedula(string cedula)
        {
            b = null;
            b = lista.Find(x => x.Cedula.Equals(cedula));
            if (b != null)
                return true;
            else
                return false;
        }

        internal void TotalN(Label lblNacional, CheckBox chkNacional)
        {
            foreach (BecaHLBV b in lista)
            {
                if (b.GetType() == typeof(BecaNacionalHLBV) && chkNacional.Checked == true)
                {
                    lblNacional.Text = adm.Lista.Count + "";
                }
                else
                {
                    lblNacional.Text = "_______";
                }
            }
        }

        internal void TotalI(Label lblInternacional, CheckBox chkInternacional)
        {
            foreach (BecaHLBV b in lista)
            {
                if (b.GetType() == typeof(BecaInternacionalHLBV) && chkInternacional.Checked == true)
                {
                    lblInternacional.Text = adm.Lista.Count + "";
                }
                else
                {
                    lblInternacional.Text = "_______";
                }
            }
        }

        internal void agregarV(ListBox lstNacional, ListBox lstInternacional, int indice)
        {
            b = lista[indice];
            if (b.GetType() == typeof(BecaNacionalHLBV))
            {
                lstNacional.Items.Add(b.Cedula);
            }
            else
            {
                lstInternacional.Items.Add(b.Cedula);
            }
        }

        internal void agregar(TextBox txtContenido)
        {
            txtContenido.Text += Lista[Lista.Count - 1].ToString() + "\r\n";
        }

        internal void LlenarGrid(DataGridView dgvBecas, Label lblTotal)
        {
            int i = 1;
            BecaInternacionalHLBV bi = null;
            foreach (BecaHLBV x in lista)
            {
                if(x.GetType() == typeof(BecaInternacionalHLBV))
                {
                    bi = (BecaInternacionalHLBV)x;
                    dgvBecas.Rows.Add(i, x.Cedula, x.Nombres, x.TiempoEstudio, x.Monto, bi.FechaViaje.ToShortDateString(), bi.Pais, x.Universidad);
                    i++;
                }                
            }
            lblTotal.Text = (i-1) + "";
        }
    }
}
