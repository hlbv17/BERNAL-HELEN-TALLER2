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
    public partial class FrmMenuHLBV : Form
    {
        public FrmMenuHLBV()
        {
            InitializeComponent();
        }

        private void mniRegistrar_Click(object sender, EventArgs e)
        {
            FrmBecaInternacionalHLBV frm = new FrmBecaInternacionalHLBV();
            frm.ShowDialog();
        }

        private void mniListar_Click(object sender, EventArgs e)
        {
            FrmListarHLBV frm = new FrmListarHLBV();
            frm.ShowDialog();
        }

        private void mniSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mniEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void mniVisualizar_Click(object sender, EventArgs e)
        {
            FrmVisualizarBeca frm = new FrmVisualizarBeca();
            frm.ShowDialog();
        }
    }
}
