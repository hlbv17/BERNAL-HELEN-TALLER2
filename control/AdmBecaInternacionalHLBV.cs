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
        ValidacionHLBV val = null;
        BecaHLBV b = null;

        internal BecaHLBV B { get => b; set => b = value; }
        internal List<BecaHLBV> Lista { get => lista; set => lista = value; }

        private AdmBecaInternacionalHLBV()
        {
            lista = new List<BecaHLBV>();
            val = new ValidacionHLBV();
        }

        public static AdmBecaInternacionalHLBV GetAdm()
        {
            if (adm == null)
            {
                adm = new AdmBecaInternacionalHLBV();
            }
            return adm;
        }

        internal void Buscar(DataGridView dgvBecas, string apellido, string montoB)
        {
            int v = 0, i = 1;
            string lugar = "";
            double dMonto = 0.0;
            bool bandera = false;
            if (montoB.CompareTo("*") != 0)
            {
                dMonto = val.AReal(montoB);
                bandera = true;
            }
            foreach (BecaHLBV x in lista)
            {
                if (bandera)
                {
                    if (x.Monto >= dMonto)
                    {
                        if (x.GetType() == typeof(BecaInternacionalHLBV))
                        {
                            v = 2;
                            LlenarFilas(v, i, x, dgvBecas, lugar, apellido);

                        }
                        if (x.GetType() == typeof(BecaNacionalHLBV))
                        {
                            v = 1;
                            LlenarFilas(v, i, x, dgvBecas, lugar, apellido);
                        }
                    }
                    
                }
                else
                {
                    v = 0;
                    LlenarFilas(v, i, x, dgvBecas, lugar, apellido);
                }
                i++;
            }
        }

        internal void LimpiarCampos(TextBox txtNombres, TextBox txtMonto, TextBox txtTiempo, ComboBox cmbPais, ComboBox cmbUniv, DateTimePicker dtpFechaViaje, RadioButton rdbInternacional, RadioButton rdbNacional, TextBox txtApellido, TextBox txtMontoB, DataGridView dgvBecas, PictureBox pbFoto)
        {
            txtNombres.Clear();
            txtMonto.Clear();
            txtApellido.Clear();
            txtMontoB.Clear();
            txtTiempo.Clear();
            cmbPais.Text = "";
            cmbUniv.Text = "";
            dtpFechaViaje.Value = DateTime.Now;
            pbFoto.Image = null;
            rdbNacional.Checked = false;
            rdbInternacional.Checked = false;
            dgvBecas.Rows.Clear();

        }

        internal void LlenarCampos(DataGridView dgvBecas, TextBox txtCedula, TextBox txtNombres, TextBox txtMonto, TextBox txtTiempo, 
            ComboBox cmbPais, ComboBox cmbUniv, DateTimePicker dtpFechaViaje, RadioButton rdbInternacional, RadioButton rdbNacional, 
            PictureBox pbFoto, Label lblFecha, Label lblPais)
        {
            BecaNacionalHLBV bn = null;
            BecaInternacionalHLBV bi = null;
            int indiceT = dgvBecas.CurrentCell.RowIndex, index = 0;
            string cedula = dgvBecas.Rows[indiceT].Cells["colCedula"].Value.ToString();
            txtCedula.Enabled = false;
            foreach (BecaHLBV b in lista)
            {
                if (b.GetType() == typeof(BecaNacionalHLBV))
                {
                    bn = (BecaNacionalHLBV)b;
                    if (bn.Cedula.CompareTo(cedula) == 0)
                    {
                        txtCedula.Text = bn.Cedula.ToString();
                        txtNombres.Text = bn.Nombres.ToString();
                        txtMonto.Text = bn.Monto.ToString();
                        txtTiempo.Text = bn.TiempoEstudio.ToString();
                        rdbNacional.Checked = true;
                        LlenarCmbNacional(lblFecha, lblPais, dtpFechaViaje, cmbPais, cmbUniv);
                        index = cmbPais.Items.IndexOf(bn.Ciudad.ToString());
                        cmbPais.SelectedIndex = index;
                        index = cmbUniv.Items.IndexOf(bn.Universidad.ToString());
                        cmbUniv.SelectedIndex = index;
                        pbFoto.ImageLocation = bn.Foto.ToString();

                    }
                }
                else if (b.GetType() == typeof(BecaInternacionalHLBV))
                {
                    bi = (BecaInternacionalHLBV)b;
                    if (bi.Cedula.CompareTo(cedula) == 0)
                    {
                        txtCedula.Text = bi.Cedula.ToString();
                        txtNombres.Text = bi.Nombres.ToString();
                        txtMonto.Text = bi.Monto.ToString();
                        txtTiempo.Text = bi.TiempoEstudio.ToString();
                        rdbInternacional.Checked = true;
                        LlenarCmbInternacional(lblFecha, lblPais, dtpFechaViaje, cmbPais, cmbUniv);
                        index = cmbPais.Items.IndexOf(bi.Pais.ToString());
                        cmbPais.SelectedIndex = index;
                        index = cmbUniv.Items.IndexOf(bi.Universidad.ToString());
                        cmbUniv.SelectedIndex = index;
                        dtpFechaViaje.Value = bi.FechaViaje;
                        pbFoto.ImageLocation = bi.Foto.ToString();
                    }

                }
            }
        }

        internal void LlenarCmbInternacional(Label lblFecha, Label lblPais, DateTimePicker dtpFechaViaje, ComboBox cmbPais, ComboBox cmbUniv)
        {
            lblFecha.Visible = true;
            dtpFechaViaje.Visible = true;
            lblPais.Text = "Pais";
            cmbPais.Items.Clear();
            cmbPais.Items.Add("Ecuador");
            cmbPais.Items.Add("Argentina");
            cmbPais.Items.Add("Brasil");
            cmbPais.Items.Add("Estados Unidos");
            cmbUniv.Items.Clear();
            cmbUniv.Items.Add("Universidad de Cambridge");
            cmbUniv.Items.Add("Universidad de Palermo");
            cmbUniv.Items.Add("Universidad de Oxford");
            cmbUniv.Items.Add("Universidad de Harvard");
        }

        internal void LlenarCmbNacional(Label lblFecha, Label lblPais, DateTimePicker dtpFechaViaje, ComboBox cmbPais, ComboBox cmbUniv)
        {
            lblFecha.Visible = false;
            dtpFechaViaje.Visible = false;
            lblPais.Text = "Ciudad";
            cmbPais.Items.Clear();
            cmbPais.Items.Add("Guayaquil");
            cmbPais.Items.Add("Cuenca");
            cmbPais.Items.Add("Ambato");
            cmbPais.Items.Add("Loja");
            cmbUniv.Items.Clear();
            cmbUniv.Items.Add("Universidad de Guayaquil");
            cmbUniv.Items.Add("Universidad de Loja");
            cmbUniv.Items.Add("Universidad Central del Ecuador");
            cmbUniv.Items.Add("Universidad Politécnica Salesiana");
        }

        internal void Modificar(string cedula, string nombre, string monto, string tiempo, DateTime fechaViaje, 
            string lugar, string univ, RadioButton rdbNacional, RadioButton rdbInternacional, string foto)
        {
            int indice = 0, iTiempo = val.AEntero(tiempo);
            double dMonto = val.AReal(monto);
            BecaNacionalHLBV bn = null;
            BecaInternacionalHLBV bi = null;
            if (rdbNacional.Checked == true)
            {
                indice = lista.FindIndex(x => x.Cedula == cedula);
                bn = (BecaNacionalHLBV)lista[indice];
                bn.Nombres = nombre;
                bn.Monto = dMonto;
                bn.TiempoEstudio = iTiempo;
                bn.Ciudad = lugar;
                bn.Universidad = univ;
                bn.Foto = foto;

            }
            else if (rdbInternacional.Checked == true)
            {
                indice = lista.FindIndex(x => x.Cedula == cedula);
                bi = (BecaInternacionalHLBV)lista[indice];
                bi.Nombres = nombre;
                bi.Monto = dMonto;
                bi.TiempoEstudio = iTiempo;
                bi.Pais = lugar;
                bi.Universidad = univ;
                bi.FechaViaje = fechaViaje;
                bi.Foto = foto;
            }
        }

        internal void Eliminar(DataGridView dtgvBecas, int posicion, Label lblTotal)
        {
            dtgvBecas.Rows.RemoveAt(posicion);  // elimina del DataGridView
            lista.RemoveAt(posicion);           // elimina de la lista
            lblTotal.Text = lista.Count + "";
        }

        internal void Filtrar(string lugar, string monto, DataGridView dgvBecas, int v)
        {
            ValidacionHLBV val = new ValidacionHLBV();
            int i = 1;
            double dMonto = 0.0;
            bool bandera = false;
            string apellido = "";
            dgvBecas.Rows.Clear();
            if (monto.CompareTo("*") != 0)
            {
                dMonto = val.AReal(monto);
                bandera = true;
            }
            foreach (BecaHLBV x in lista)
            {
                if (bandera)
                {
                    if (x.Monto >= dMonto)
                    {
                        LlenarFilas(v, i, x, dgvBecas, lugar, apellido);
                    }
                }
                else
                {
                    LlenarFilas(v, i, x, dgvBecas, lugar, apellido);
                }
                i++;
            }
        }

        internal void LlenarFilas(int v, int i, BecaHLBV x, DataGridView dgvBecas, string lugar, string apellido)
        {
            //int i = 1;
            BecaInternacionalHLBV bi = null;
            BecaNacionalHLBV bn = null;
            if (v == 2)
            {
                if (x.GetType() == typeof(BecaInternacionalHLBV))
                {
                    bi = (BecaInternacionalHLBV)x;
                    if (bi.Pais.CompareTo(lugar) == 0 || bi.Nombres.Contains(apellido))
                    {
                        dgvBecas.Rows.Add(i, x.Cedula, x.Nombres, x.TiempoEstudio, x.Monto, bi.FechaViaje.ToShortDateString(), bi.Pais, x.Universidad);
                        i++;
                    }
                }
            }
            else if (v == 1)
            {
                if (x.GetType() == typeof(BecaNacionalHLBV))
                {
                    bn = (BecaNacionalHLBV)x;
                    if (bn.Ciudad.CompareTo(lugar) == 0 || bn.Nombres.Contains(apellido))
                    {
                        dgvBecas.Rows.Add(i, x.Cedula, x.Nombres, x.TiempoEstudio, x.Monto, " ", bn.Ciudad, x.Universidad);
                        i++;
                    }

                }
            }
            else if (v == 0)
            {
                if (x.GetType() == typeof(BecaInternacionalHLBV))
                {
                    bi = (BecaInternacionalHLBV)x;
                    if (bi.Pais.CompareTo(lugar) == 0 || bi.Nombres.Contains(apellido))
                    {
                        dgvBecas.Rows.Add(i, x.Cedula, x.Nombres, x.TiempoEstudio, x.Monto, bi.FechaViaje.ToShortDateString(), bi.Pais, x.Universidad);
                        i++;
                    }
                }
                if (x.GetType() == typeof(BecaNacionalHLBV))
                {
                    bn = (BecaNacionalHLBV)x;
                    if (bn.Ciudad.CompareTo(lugar) == 0 || bn.Nombres.Contains(apellido))
                    {
                        dgvBecas.Rows.Add(i, x.Cedula, x.Nombres, x.TiempoEstudio, x.Monto, " ", bn.Ciudad, x.Universidad);
                        i++;
                    }
                }
            }
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


        internal bool ValidarF(TextBox txtLugar, TextBox txtMonto, ErrorProvider errorP)
        {
            bool no_error = true;
            if (String.IsNullOrEmpty(txtLugar.Text.Trim()))
            {
                errorP.SetError(txtLugar, "Ingrese un País/Ciudad");
                no_error = false;
            }
            if (String.IsNullOrEmpty(txtMonto.Text.Trim()))
            {
                errorP.SetError(txtLugar, "Ingrese un monto o (*)");
                no_error = false;
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
            if (estaCedula(cedula))
            {
                errorP.SetError(txtCedula, "Ya existe esta cédula");
                no_error = false;
            }
            if (cedula.Length < 10)
            {
                errorP.SetError(txtCedula, "La cédula debe ser de 10 dígitos");
                no_error = false;
            }
            if (String.IsNullOrEmpty(txtNombres.Text))
            {
                errorP.SetError(txtNombres, "Ingrese un nombre");
                no_error = false;
            }
            if (String.IsNullOrEmpty(txtTiempo.Text))
            {
                errorP.SetError(txtTiempo, "Ingrese el tiempo");
                no_error = false;
            }
            if (String.IsNullOrEmpty(txtMonto.Text))
            {
                errorP.SetError(txtMonto, "Ingrese el monto");
                no_error = false;
            }
            if (String.IsNullOrEmpty(cmbPais.Text))
            {
                errorP.SetError(cmbPais, "Seleccione un país");
                no_error = false;
            }
            if (String.IsNullOrEmpty(cmbUniv.Text))
            {
                errorP.SetError(cmbUniv, "Seleccione una universidad");
                no_error = false;
            }
            if (image.ImageLocation == null )
            {
                errorP.SetError(image, "Suba una foto");
                no_error = false;
            }
            return no_error;
        }

        internal void guardar(string nombre, string cedula, string universidad, string monto, string lugar, 
            string tiempo, string foto, DateTime fecha, RadioButton rdbNacional, RadioButton rdbInternacional)
        {
            if (rdbInternacional.Checked == true)
            {
                BecaInternacionalHLBV bi = null;
                double dMonto = val.AReal(monto);
                int iTiempo = val.AEntero(tiempo);
                bi = new BecaInternacionalHLBV(lugar, cedula, nombre, universidad, dMonto, iTiempo, foto, fecha);
                lista.Add(bi);
            }
            else if (rdbNacional.Checked == true)
            {
                BecaNacionalHLBV bn = null;
                double dMonto = val.AReal(monto);
                int iTiempo = val.AEntero(tiempo);
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
            int i = 0;
            foreach (BecaHLBV b in lista)
            {
                if (b.GetType() == typeof(BecaNacionalHLBV) && chkNacional.Checked == true)
                {
                    i++;
                }
                else
                {
                    lblNacional.Text = "_______";
                }
            }
            lblNacional.Text = i + "";
        }

        internal void TotalI(Label lblInternacional, CheckBox chkInternacional)
        {
            int i = 0;
            foreach (BecaHLBV b in lista)
            {
                if (b.GetType() == typeof(BecaInternacionalHLBV) && chkInternacional.Checked == true)
                {
                    i++;
                }
                else
                {
                    lblInternacional.Text = "_______";
                }
            }
            lblInternacional.Text = i + "";
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
            BecaNacionalHLBV bn = null;
            foreach (BecaHLBV x in lista)
            {
                if(x.GetType() == typeof(BecaInternacionalHLBV))
                {
                    bi = (BecaInternacionalHLBV)x;
                    dgvBecas.Rows.Add(i, x.Cedula, x.Nombres, x.TiempoEstudio, x.Monto, bi.FechaViaje.ToShortDateString(), bi.Pais, x.Universidad);
                    i++;
                }
                if (x.GetType() == typeof(BecaNacionalHLBV))
                {
                    bn = (BecaNacionalHLBV)x;
                    dgvBecas.Rows.Add(i, x.Cedula, x.Nombres, x.TiempoEstudio, x.Monto, "" , bn.Ciudad, x.Universidad);
                    i++;
                }
            }
            lblTotal.Text = (i-1) + "";
        }
    }
}


/*internal void Buscar(string cedula, TextBox txtNombres, TextBox txtMonto, TextBox txtTiempo, ComboBox cmbPais, 
    ComboBox cmbUniv, DateTimePicker dtpFechaIda, RadioButton rdbInternacional, RadioButton rdbNacional)
{
    int indice = 0;
    BecaNacionalHLBV bn = null;
    BecaInternacionalHLBV bi = null;
    indice = lista.FindIndex(x => x.Cedula == cedula);
    foreach (BecaHLBV b in lista)
    {
        if (b.GetType() == typeof(BecaNacionalHLBV))
        {
            bn = (BecaNacionalHLBV)b;
            if (bn.Cedula.CompareTo(cedula) == 0)
            {
                txtNombres.Text = bn.Nombres.ToString();
                txtMonto.Text = bn.Monto.ToString();
                txtTiempo.Text = bn.TiempoEstudio.ToString();
                cmbPais.SelectedText = bn.Ciudad.ToString();
                cmbUniv.SelectedText = bn.Universidad.ToString();
                rdbNacional.Checked = true;
            }
        }
        else if (b.GetType() == typeof(BecaInternacionalHLBV))
        {
            bi = (BecaInternacionalHLBV)b;
            if (bi.Cedula.CompareTo(cedula) == 0)
            {
                txtNombres.Text = bi.Nombres.ToString();
                txtMonto.Text = bi.Monto.ToString();
                txtTiempo.Text = bi.TiempoEstudio.ToString();
                cmbPais.SelectedText = bi.Pais.ToString();
                cmbUniv.SelectedText = bi.Universidad.ToString();
                dtpFechaIda.Value = bi.FechaViaje;
                rdbInternacional.Checked = true;
            }

        }
    }

}*/