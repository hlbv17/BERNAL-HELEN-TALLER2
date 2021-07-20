
namespace Ejercicio04HLBV.visual
{
    partial class FrmFiltrarHLBV
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.rdbInternacional = new System.Windows.Forms.RadioButton();
            this.rdbNacional = new System.Windows.Forms.RadioButton();
            this.dtgvBecas = new System.Windows.Forms.DataGridView();
            this.colNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaIda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUniversidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblLugar = new System.Windows.Forms.Label();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBecas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbTodos);
            this.groupBox1.Controls.Add(this.rdbInternacional);
            this.groupBox1.Controls.Add(this.rdbNacional);
            this.groupBox1.Location = new System.Drawing.Point(62, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Becas";
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Checked = true;
            this.rdbTodos.Location = new System.Drawing.Point(317, 28);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(55, 17);
            this.rdbTodos.TabIndex = 2;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "Todos";
            this.rdbTodos.UseVisualStyleBackColor = true;
            // 
            // rdbInternacional
            // 
            this.rdbInternacional.AutoSize = true;
            this.rdbInternacional.Location = new System.Drawing.Point(181, 28);
            this.rdbInternacional.Name = "rdbInternacional";
            this.rdbInternacional.Size = new System.Drawing.Size(86, 17);
            this.rdbInternacional.TabIndex = 1;
            this.rdbInternacional.Text = "Internacional";
            this.rdbInternacional.UseVisualStyleBackColor = true;
            // 
            // rdbNacional
            // 
            this.rdbNacional.AutoSize = true;
            this.rdbNacional.Location = new System.Drawing.Point(53, 28);
            this.rdbNacional.Name = "rdbNacional";
            this.rdbNacional.Size = new System.Drawing.Size(67, 17);
            this.rdbNacional.TabIndex = 0;
            this.rdbNacional.Text = "Nacional";
            this.rdbNacional.UseVisualStyleBackColor = true;
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
            this.dtgvBecas.Location = new System.Drawing.Point(21, 175);
            this.dtgvBecas.Name = "dtgvBecas";
            this.dtgvBecas.ReadOnly = true;
            this.dtgvBecas.Size = new System.Drawing.Size(754, 236);
            this.dtgvBecas.TabIndex = 1;
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
            this.colPais.HeaderText = "Pais/Ciudad";
            this.colPais.Name = "colPais";
            this.colPais.ReadOnly = true;
            // 
            // colUniversidad
            // 
            this.colUniversidad.HeaderText = "Universidad";
            this.colUniversidad.Name = "colUniversidad";
            this.colUniversidad.ReadOnly = true;
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Location = new System.Drawing.Point(62, 123);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(65, 13);
            this.lblLugar.TabIndex = 2;
            this.lblLugar.Text = "Ciudad/Pais";
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(155, 120);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(100, 20);
            this.txtLugar.TabIndex = 3;
            this.txtLugar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLugar_KeyPress);
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(437, 120);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 20);
            this.txtMonto.TabIndex = 5;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(344, 123);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(37, 13);
            this.lblMonto.TabIndex = 4;
            this.lblMonto.Text = "Monto";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(637, 111);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(91, 37);
            this.btnFiltrar.TabIndex = 6;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(692, 425);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(55, 13);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "________";
            // 
            // errorP
            // 
            this.errorP.ContainerControl = this;
            // 
            // FrmFiltrarHLBV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.txtLugar);
            this.Controls.Add(this.lblLugar);
            this.Controls.Add(this.dtgvBecas);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmFiltrarHLBV";
            this.Text = "FrmFiltrar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBecas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.RadioButton rdbInternacional;
        private System.Windows.Forms.RadioButton rdbNacional;
        private System.Windows.Forms.DataGridView dtgvBecas;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaIda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPais;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUniversidad;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ErrorProvider errorP;
    }
}