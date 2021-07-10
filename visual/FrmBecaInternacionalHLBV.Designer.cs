
namespace Ejercicio04HLBV.visual
{
    partial class FrmBecaInternacionalHLBV
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpbBeca = new System.Windows.Forms.GroupBox();
            this.rdbInternacional = new System.Windows.Forms.RadioButton();
            this.rdbNacional = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnCargarFoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.gpbBeca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(34, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cédula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(34, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(34, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Universidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(34, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tiempo de estudio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(34, 222);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Monto";
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(222, 23);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(5);
            this.txtCedula.MaxLength = 10;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(161, 24);
            this.txtCedula.TabIndex = 5;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // txtNombres
            // 
            this.txtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(222, 72);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(5);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(161, 24);
            this.txtNombres.TabIndex = 6;
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombres_KeyPress);
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(222, 217);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(5);
            this.txtMonto.MaxLength = 10;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(143, 24);
            this.txtMonto.TabIndex = 8;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblFecha.Location = new System.Drawing.Point(34, 305);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(111, 16);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "Fecha de viaje";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblPais.Location = new System.Drawing.Point(34, 267);
            this.lblPais.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(39, 16);
            this.lblPais.TabIndex = 10;
            this.lblPais.Text = "País";
            // 
            // txtTiempo
            // 
            this.txtTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiempo.Location = new System.Drawing.Point(222, 164);
            this.txtTiempo.Margin = new System.Windows.Forms.Padding(5);
            this.txtTiempo.MaxLength = 3;
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(161, 24);
            this.txtTiempo.TabIndex = 11;
            this.txtTiempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
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
            this.cmbUniv.Location = new System.Drawing.Point(222, 117);
            this.cmbUniv.Name = "cmbUniv";
            this.cmbUniv.Size = new System.Drawing.Size(221, 26);
            this.cmbUniv.TabIndex = 14;
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
            this.cmbPais.Location = new System.Drawing.Point(222, 257);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(143, 26);
            this.cmbPais.TabIndex = 15;
            // 
            // dtpFechaViaje
            // 
            this.dtpFechaViaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaViaje.Location = new System.Drawing.Point(222, 301);
            this.dtpFechaViaje.Name = "dtpFechaViaje";
            this.dtpFechaViaje.Size = new System.Drawing.Size(181, 20);
            this.dtpFechaViaje.TabIndex = 16;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(550, 350);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(117, 36);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtContenido
            // 
            this.txtContenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContenido.Location = new System.Drawing.Point(46, 356);
            this.txtContenido.Multiline = true;
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.ReadOnly = true;
            this.txtContenido.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContenido.Size = new System.Drawing.Size(397, 159);
            this.txtContenido.TabIndex = 19;
            // 
            // errorP
            // 
            this.errorP.ContainerControl = this;
            // 
            // gpbBeca
            // 
            this.gpbBeca.Controls.Add(this.rdbInternacional);
            this.gpbBeca.Controls.Add(this.rdbNacional);
            this.gpbBeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBeca.Location = new System.Drawing.Point(478, 12);
            this.gpbBeca.Name = "gpbBeca";
            this.gpbBeca.Size = new System.Drawing.Size(256, 56);
            this.gpbBeca.TabIndex = 20;
            this.gpbBeca.TabStop = false;
            this.gpbBeca.Text = "Beca";
            // 
            // rdbInternacional
            // 
            this.rdbInternacional.AutoSize = true;
            this.rdbInternacional.Checked = true;
            this.rdbInternacional.Location = new System.Drawing.Point(123, 22);
            this.rdbInternacional.Name = "rdbInternacional";
            this.rdbInternacional.Size = new System.Drawing.Size(109, 22);
            this.rdbInternacional.TabIndex = 1;
            this.rdbInternacional.TabStop = true;
            this.rdbInternacional.Text = "Internacional";
            this.rdbInternacional.UseVisualStyleBackColor = true;
            this.rdbInternacional.CheckedChanged += new System.EventHandler(this.rdbInternacional_CheckedChanged);
            // 
            // rdbNacional
            // 
            this.rdbNacional.AutoSize = true;
            this.rdbNacional.Location = new System.Drawing.Point(12, 21);
            this.rdbNacional.Name = "rdbNacional";
            this.rdbNacional.Size = new System.Drawing.Size(84, 22);
            this.rdbNacional.TabIndex = 0;
            this.rdbNacional.Text = "Nacional";
            this.rdbNacional.UseVisualStyleBackColor = true;
            this.rdbNacional.CheckedChanged += new System.EventHandler(this.rdbNacional_CheckedChanged);
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(530, 76);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(169, 133);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 21;
            this.pbFoto.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnCargarFoto
            // 
            this.btnCargarFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarFoto.Location = new System.Drawing.Point(562, 220);
            this.btnCargarFoto.Name = "btnCargarFoto";
            this.btnCargarFoto.Size = new System.Drawing.Size(104, 26);
            this.btnCargarFoto.TabIndex = 22;
            this.btnCargarFoto.Text = "Cargar foto";
            this.btnCargarFoto.UseVisualStyleBackColor = true;
            this.btnCargarFoto.Click += new System.EventHandler(this.btnCargarFoto_Click);
            // 
            // FrmBecaInternacionalHLBV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 544);
            this.Controls.Add(this.btnCargarFoto);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.gpbBeca);
            this.Controls.Add(this.txtContenido);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmBecaInternacionalHLBV";
            this.Text = "Helen Lisbeth Bernal Vera";
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.gpbBeca.ResumeLayout(false);
            this.gpbBeca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtContenido;
        private System.Windows.Forms.ErrorProvider errorP;
        private System.Windows.Forms.GroupBox gpbBeca;
        private System.Windows.Forms.RadioButton rdbInternacional;
        private System.Windows.Forms.RadioButton rdbNacional;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnCargarFoto;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}