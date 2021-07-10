
namespace Ejercicio04HLBV.visual
{
    partial class FrmListarHLBV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgvBecas = new System.Windows.Forms.DataGridView();
            this.colNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaIda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUniversidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBecas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvBecas
            // 
            this.dtgvBecas.AllowUserToAddRows = false;
            this.dtgvBecas.AllowUserToDeleteRows = false;
            this.dtgvBecas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBecas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNro,
            this.colCedula,
            this.colNombres,
            this.colTiempo,
            this.colMonto,
            this.colFechaIda,
            this.colPais,
            this.colUniversidad});
            this.dtgvBecas.Location = new System.Drawing.Point(12, 21);
            this.dtgvBecas.Name = "dtgvBecas";
            this.dtgvBecas.ReadOnly = true;
            this.dtgvBecas.Size = new System.Drawing.Size(841, 406);
            this.dtgvBecas.TabIndex = 0;
            // 
            // colNro
            // 
            this.colNro.HeaderText = "Nro.";
            this.colNro.Name = "colNro";
            this.colNro.ReadOnly = true;
            // 
            // colCedula
            // 
            this.colCedula.HeaderText = "Cédula";
            this.colCedula.Name = "colCedula";
            this.colCedula.ReadOnly = true;
            // 
            // colNombres
            // 
            this.colNombres.HeaderText = "Nombres";
            this.colNombres.Name = "colNombres";
            this.colNombres.ReadOnly = true;
            // 
            // colTiempo
            // 
            this.colTiempo.HeaderText = "Tiempo de estudio";
            this.colTiempo.Name = "colTiempo";
            this.colTiempo.ReadOnly = true;
            // 
            // colMonto
            // 
            this.colMonto.HeaderText = "Monto";
            this.colMonto.Name = "colMonto";
            this.colMonto.ReadOnly = true;
            // 
            // colFechaIda
            // 
            this.colFechaIda.HeaderText = "Fecha de Ida (meses)";
            this.colFechaIda.Name = "colFechaIda";
            this.colFechaIda.ReadOnly = true;
            // 
            // colPais
            // 
            this.colPais.HeaderText = "Pais";
            this.colPais.Name = "colPais";
            this.colPais.ReadOnly = true;
            // 
            // colUniversidad
            // 
            this.colUniversidad.HeaderText = "Universidad";
            this.colUniversidad.Name = "colUniversidad";
            this.colUniversidad.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(709, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(751, 451);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(55, 13);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "________";
            // 
            // FmrListarHLBV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 483);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvBecas);
            this.Name = "FmrListarHLBV";
            this.Text = "FmrListarHLBV";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBecas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvBecas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaIda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPais;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUniversidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
    }
}