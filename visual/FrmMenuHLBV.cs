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
    public partial class FrmMenuHLBV : Form
    {
        AdmBecaInternacionalHLBV adm = AdmBecaInternacionalHLBV.GetAdm();
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
            //FrmListarHLBV frm = new FrmListarHLBV();
            //frm.ShowDialog();
        }

        private void mniSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mniEliminar_Click(object sender, EventArgs e)
        {
            if (adm.Lista.Count > 0)
            {
                FrmListarHLBV frm = new FrmListarHLBV();
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("No existen datos registrados");
            }
            
        }

        private void mniFiltrar_Click(object sender, EventArgs e)
        {
            if (adm.Lista.Count > 0)
            {
                FrmFiltrarHLBV frm = new FrmFiltrarHLBV();
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("No existen datos registrados");
            }
        }

        private void mniVisualizar_Click(object sender, EventArgs e)
        {
            if (adm.Lista.Count > 0)
            {
                FrmVisualizarBecaHLBV frm = new FrmVisualizarBecaHLBV();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No existen datos registrados");
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (adm.Lista.Count > 0)
            {
                FrmEditarHLBV frm = new FrmEditarHLBV();
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("No existen datos registrados");
            }  
        }
    }
}

