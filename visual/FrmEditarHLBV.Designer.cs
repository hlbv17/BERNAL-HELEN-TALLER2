
namespace Ejercicio04HLBV.visual
{
    partial class FrmEditarHLBV
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
            this.gpbBeca = new System.Windows.Forms.GroupBox();
            this.rdbInternacional = new System.Windows.Forms.RadioButton();
            this.rdbNacional = new System.Windows.Forms.RadioButton();
            this.btnCargarFoto = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtMontoB = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dgvBecas = new System.Windows.Forms.DataGridView();
            this.colNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaIda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUniversidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.cmbUniv = new System.Windows.Forms.ComboBox();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.dtpFechaViaje = new System.Windows.Forms.DateTimePicker();
            this.btnPresentar = new System.Windows.Forms.Button();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpbBeca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBecas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbBeca
            // 
            this.gpbBeca.Controls.Add(this.rdbInternacional);
            this.gpbBeca.Controls.Add(this.rdbNacional);
            this.gpbBeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBeca.Location = new System.Drawing.Point(504, 404);
            this.gpbBeca.Name = "gpbBeca";
            this.gpbBeca.Size = new System.Drawing.Size(256, 56);
            this.gpbBeca.TabIndex = 39;
            this.gpbBeca.TabStop = false;
            this.gpbBeca.Text = "Beca";
            // 
            // rdbInternacional
            // 
            this.rdbInternacional.AutoSize = true;
            this.rdbInternacional.Enabled = false;
            this.rdbInternacional.Location = new System.Drawing.Point(123, 22);
            this.rdbInternacional.Name = "rdbInternacional";
            this.rdbInternacional.Size = new System.Drawing.Size(109, 22);
            this.rdbInternacional.TabIndex = 1;
            this.rdbInternacional.Text = "Internacional";
            this.rdbInternacional.UseVisualStyleBackColor = true;
            // 
            // rdbNacional
            // 
            this.rdbNacional.AutoSize = true;
            this.rdbNacional.Enabled = false;
            this.rdbNacional.Location = new System.Drawing.Point(12, 21);
            this.rdbNacional.Name = "rdbNacional";
            this.rdbNacional.Size = new System.Drawing.Size(84, 22);
            this.rdbNacional.TabIndex = 0;
            this.rdbNacional.Text = "Nacional";
            this.rdbNacional.UseVisualStyleBackColor = true;
            // 
            // btnCargarFoto
            // 
            this.btnCargarFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarFoto.Location = new System.Drawing.Point(588, 612);
            this.btnCargarFoto.Name = "btnCargarFoto";
            this.btnCargarFoto.Size = new System.Drawing.Size(104, 26);
            this.btnCargarFoto.TabIndex = 41;
            this.btnCargarFoto.Text = "Cargar foto";
            this.btnCargarFoto.UseVisualStyleBackColor = true;
            this.btnCargarFoto.Click += new System.EventHandler(this.btnCargarFoto_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(556, 468);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(169, 133);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 40;
            this.pbFoto.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(588, 677);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(117, 36);
            this.btnGuardar.TabIndex = 37;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(546, 21);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 37);
            this.btnBuscar.TabIndex = 48;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtMontoB
            // 
            this.txtMontoB.Location = new System.Drawing.Point(394, 30);
            this.txtMontoB.Name = "txtMontoB";
            this.txtMontoB.Size = new System.Drawing.Size(100, 20);
            this.txtMontoB.TabIndex = 47;
            this.txtMontoB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoB_KeyPress);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(301, 33);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(37, 13);
            this.lblMonto.TabIndex = 46;
            this.lblMonto.Text = "Monto";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(158, 30);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 45;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(65, 33);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 44;
            this.lblNombre.Text = "Apellido";
            // 
            // dgvBecas
            // 
            this.dgvBecas.AllowUserToAddRows = false;
            this.dgvBecas.AllowUserToDeleteRows = false;
            this.dgvBecas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBecas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNro,
            this.colCedula,
            this.colNombres,
            this.colTiempo,
            this.colMonto,
            this.colFechaIda,
            this.colPais,
            this.colUniversidad});
            this.dgvBecas.Location = new System.Drawing.Point(24, 85);
            this.dgvBecas.Name = "dgvBecas";
            this.dgvBecas.ReadOnly = true;
            this.dgvBecas.Size = new System.Drawing.Size(754, 236);
            this.dgvBecas.TabIndex = 43;
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
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(675, 21);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(91, 37);
            this.btnLimpiar.TabIndex = 49;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(57, 410);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Cédula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(57, 459);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(57, 504);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Universidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(57, 551);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tiempo de estudio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(57, 603);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Monto";
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(245, 404);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(5);
            this.txtCedula.MaxLength = 10;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(161, 24);
            this.txtCedula.TabIndex = 28;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // txtNombres
            // 
            this.txtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(245, 453);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(5);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(161, 24);
            this.txtNombres.TabIndex = 29;
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombres_KeyPress);
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(245, 598);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(5);
            this.txtMonto.MaxLength = 10;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(143, 24);
            this.txtMonto.TabIndex = 30;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblFecha.Location = new System.Drawing.Point(57, 686);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(111, 16);
            this.lblFecha.TabIndex = 31;
            this.lblFecha.Text = "Fecha de viaje";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblPais.Location = new System.Drawing.Point(57, 648);
            this.lblPais.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(39, 16);
            this.lblPais.TabIndex = 32;
            this.lblPais.Text = "País";
            // 
            // txtTiempo
            // 
            this.txtTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiempo.Location = new System.Drawing.Point(245, 545);
            this.txtTiempo.Margin = new System.Windows.Forms.Padding(5);
            this.txtTiempo.MaxLength = 3;
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(161, 24);
            this.txtTiempo.TabIndex = 33;
            this.txtTiempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // cmbUniv
            // 
            this.cmbUniv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUniv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUniv.FormattingEnabled = true;
            this.cmbUniv.Items.AddRange(new object[] {
            "Universidad de Guayaquil",
            "Universidad de Cambridge",
            "Universidad de Palermo",
            "Universidad de Oxford"});
            this.cmbUniv.Location = new System.Drawing.Point(245, 498);
            this.cmbUniv.Name = "cmbUniv";
            this.cmbUniv.Size = new System.Drawing.Size(221, 26);
            this.cmbUniv.TabIndex = 34;
            // 
            // cmbPais
            // 
            this.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Items.AddRange(new object[] {
            "Ecuador",
            "Argentina",
            "Estados Unidos"});
            this.cmbPais.Location = new System.Drawing.Point(245, 638);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(143, 26);
            this.cmbPais.TabIndex = 35;
            // 
            // dtpFechaViaje
            // 
            this.dtpFechaViaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaViaje.Location = new System.Drawing.Point(245, 682);
            this.dtpFechaViaje.Name = "dtpFechaViaje";
            this.dtpFechaViaje.Size = new System.Drawing.Size(181, 20);
            this.dtpFechaViaje.TabIndex = 36;
            // 
            // btnPresentar
            // 
            this.btnPresentar.Location = new System.Drawing.Point(335, 337);
            this.btnPresentar.Name = "btnPresentar";
            this.btnPresentar.Size = new System.Drawing.Size(117, 36);
            this.btnPresentar.TabIndex = 50;
            this.btnPresentar.Text = "Presentar";
            this.btnPresentar.UseVisualStyleBackColor = true;
            this.btnPresentar.Click += new System.EventHandler(this.btnPresentar_Click);
            // 
            // errorP
            // 
            this.errorP.ContainerControl = this;
            // 
            // FrmEditarHLBV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 749);
            this.Controls.Add(this.btnPresentar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtMontoB);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dgvBecas);
            this.Controls.Add(this.gpbBeca);
            this.Controls.Add(this.btnCargarFoto);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dtpFechaViaje);
            this.Controls.Add(this.cmbPais);
            this.Controls.Add(this.cmbUniv);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmEditarHLBV";
            this.Text = "FrmEditarHLBV";
            this.gpbBeca.ResumeLayout(false);
            this.gpbBeca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBecas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbBeca;
        private System.Windows.Forms.RadioButton rdbInternacional;
        private System.Windows.Forms.RadioButton rdbNacional;
        private System.Windows.Forms.Button btnCargarFoto;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtMontoB;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dgvBecas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaIda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPais;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUniversidad;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.ComboBox cmbUniv;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.DateTimePicker dtpFechaViaje;
        private System.Windows.Forms.Button btnPresentar;
        private System.Windows.Forms.ErrorProvider errorP;
    }
}