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
    public partial class FrmFiltrarHLBV : Form
    {
        AdmBecaInternacionalHLBV adm = AdmBecaInternacionalHLBV.GetAdm();
        public FrmFiltrarHLBV()
        {
            InitializeComponent();
            adm.LlenarGrid(dtgvBecas, lblTotal);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string lugar = txtLugar.Text.Trim(), monto = txtMonto.Text.Trim();
            errorP.Clear();
            if (adm.ValidarF(txtLugar, txtMonto, errorP))
            {
                errorP.Clear();
                if (rdbNacional.Checked == true)
                {
                    adm.Filtrar(lugar, monto, dtgvBecas, 1);
                }
                else if (rdbInternacional.Checked == true)
                {
                    adm.Filtrar(lugar, monto, dtgvBecas, 2);
                }
                else
                {
                    adm.Filtrar(lugar, monto, dtgvBecas, 0);
                }
            }     
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (char.IsLetter(c) && c != ',' && (e.KeyChar != Convert.ToChar(Keys.Back)) && c != '*')
            {
                e.Handled = true;
                return;
            }
        }

        private void txtLugar_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (char.IsDigit(c) && c != ' ' && (e.KeyChar != Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
