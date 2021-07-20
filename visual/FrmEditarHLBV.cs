using Ejercicio04HLBV.control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio04HLBV.visual
{
    
    public partial class FrmEditarHLBV : Form
    {
        AdmBecaInternacionalHLBV adm = AdmBecaInternacionalHLBV.GetAdm();
        public FrmEditarHLBV()
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
               monto = txtMonto.Text, tiempo = txtTiempo.Text, lugar = cmbPais.Text, foto = pbFoto.ImageLocation;
            DateTime fecha = dtpFechaViaje.Value.Date;
            adm.Modificar(cedula, nombre, monto, tiempo, fecha, lugar, universidad, rdbNacional, rdbInternacional, foto);

            /*errorP.Clear();
            if (adm.Validar(txtCedula, txtNombres, txtTiempo, txtMonto, cmbPais, cmbUniv, pbFoto, errorP))
            {
                errorP.Clear();
                adm.Modificar(cedula, nombre, monto, tiempo, fecha, lugar, universidad, rdbNacional, rdbInternacional, foto);
                //admBecaI.agregar(txtContenido);
            }*/
        }

        private void btnPresentar_Click(object sender, EventArgs e)
        {
            adm.LlenarCampos(dgvBecas, txtCedula, txtNombres, txtMonto, txtTiempo, cmbPais, cmbUniv, dtpFechaViaje,
                rdbInternacional, rdbNacional, pbFoto, lblFecha, lblPais);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string apellido = txtApellido.Text.Trim(), monto = txtMontoB.Text.Trim();
            dgvBecas.Rows.Clear();
            adm.Buscar(dgvBecas, apellido, monto);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            adm.LimpiarCampos(txtNombres, txtMonto, txtTiempo, cmbPais, cmbUniv, dtpFechaViaje, rdbInternacional, rdbNacional, 
                txtApellido, txtMontoB, dgvBecas, pbFoto);
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

        private void txtMontoB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (char.IsLetter(c) && c != ',' && (e.KeyChar != Convert.ToChar(Keys.Back)) && c != '*')
            {
                e.Handled = true;
                return;
            }
        }
    }
}
