using Ejercicio04HLBV.control;
using System;
using System.IO;
using System.Windows.Forms;

namespace Ejercicio04HLBV.visual
{
    public partial class FrmBecaInternacionalHLBV : Form
    {
        AdmBecaInternacionalHLBV admBecaI = AdmBecaInternacionalHLBV.GetAdm();
        public FrmBecaInternacionalHLBV()
        {
            InitializeComponent();
        }


        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (char.IsLetter(c) && (e.KeyChar != Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (char.IsDigit(c) && c != ' ' && (e.KeyChar != Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (char.IsLetter(c) && c != ',' && (e.KeyChar != Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                return;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombres.Text.Trim(), cedula = txtCedula.Text, universidad = cmbUniv.Text,
                monto = txtMonto.Text, tiempo = txtTiempo.Text, pais = cmbPais.Text, foto = pbFoto.ImageLocation;             
            DateTime fecha = dtpFechaViaje.Value.Date;
            errorP.Clear();
            if (admBecaI.Validar(txtCedula, txtNombres, txtTiempo, txtMonto, cmbPais, cmbUniv, pbFoto, errorP))
            {
                errorP.Clear();
                admBecaI.guardar(nombre, cedula, universidad, monto, pais, tiempo, foto, fecha, rdbNacional, rdbInternacional);
                admBecaI.agregar(txtContenido);
            }
        }

        private void rdbNacional_CheckedChanged(object sender, EventArgs e)
        {
            admBecaI.LlenarCmbNacional(lblFecha, lblPais, dtpFechaViaje, cmbPais, cmbUniv);
        }

        private void rdbInternacional_CheckedChanged(object sender, EventArgs e)
        {
            admBecaI.LlenarCmbInternacional(lblFecha, lblPais, dtpFechaViaje, cmbPais, cmbUniv);
        }

        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog cargarFoto = new OpenFileDialog();
            cargarFoto.InitialDirectory = "C:\\";
            cargarFoto.Filter = "Archivos *.jpg *.png |*.jpg; *.png";
            if (cargarFoto.ShowDialog() == DialogResult.OK)
            {
                pbFoto.ImageLocation = cargarFoto.FileName;
            }

        }
    }
}
