
namespace Ejercicio04HLBV.visual
{
    partial class FrmVisualizarBecaHLBV
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
            this.rdbInternacional = new System.Windows.Forms.RadioButton();
            this.rdbNacional = new System.Windows.Forms.RadioButton();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.cmbBecas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNacional = new System.Windows.Forms.Label();
            this.lblInternacional = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkNacional = new System.Windows.Forms.CheckBox();
            this.chkInternacional = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstNacional = new System.Windows.Forms.ListBox();
            this.lstInternacional = new System.Windows.Forms.ListBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbInternacional);
            this.groupBox1.Controls.Add(this.rdbNacional);
            this.groupBox1.Location = new System.Drawing.Point(27, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Becas";
            // 
            // rdbInternacional
            // 
            this.rdbInternacional.AutoSize = true;
            this.rdbInternacional.Location = new System.Drawing.Point(155, 34);
            this.rdbInternacional.Name = "rdbInternacional";
            this.rdbInternacional.Size = new System.Drawing.Size(86, 17);
            this.rdbInternacional.TabIndex = 1;
            this.rdbInternacional.Text = "Internacional";
            this.rdbInternacional.UseVisualStyleBackColor = true;
            this.rdbInternacional.CheckedChanged += new System.EventHandler(this.rdbInternacional_CheckedChanged);
            // 
            // rdbNacional
            // 
            this.rdbNacional.AutoSize = true;
            this.rdbNacional.Checked = true;
            this.rdbNacional.Location = new System.Drawing.Point(22, 34);
            this.rdbNacional.Name = "rdbNacional";
            this.rdbNacional.Size = new System.Drawing.Size(67, 17);
            this.rdbNacional.TabIndex = 0;
            this.rdbNacional.TabStop = true;
            this.rdbNacional.Text = "Nacional";
            this.rdbNacional.UseVisualStyleBackColor = true;
            this.rdbNacional.CheckedChanged += new System.EventHandler(this.rdbNacional_CheckedChanged);
            // 
            // picImage
            // 
            this.picImage.Image = global::Ejercicio04HLBV.Properties.Resources.book_glasses_icon_icons_com_56355;
            this.picImage.Location = new System.Drawing.Point(401, 18);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(91, 83);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 1;
            this.picImage.TabStop = false;
            // 
            // cmbBecas
            // 
            this.cmbBecas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBecas.FormattingEnabled = true;
            this.cmbBecas.Location = new System.Drawing.Point(38, 111);
            this.cmbBecas.Name = "cmbBecas";
            this.cmbBecas.Size = new System.Drawing.Size(144, 21);
            this.cmbBecas.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total";
            // 
            // lblNacional
            // 
            this.lblNacional.AutoSize = true;
            this.lblNacional.Location = new System.Drawing.Point(101, 264);
            this.lblNacional.Name = "lblNacional";
            this.lblNacional.Size = new System.Drawing.Size(49, 13);
            this.lblNacional.TabIndex = 4;
            this.lblNacional.Text = "_______";
            // 
            // lblInternacional
            // 
            this.lblInternacional.AutoSize = true;
            this.lblInternacional.Location = new System.Drawing.Point(289, 264);
            this.lblInternacional.Name = "lblInternacional";
            this.lblInternacional.Size = new System.Drawing.Size(49, 13);
            this.lblInternacional.TabIndex = 6;
            this.lblInternacional.Text = "_______";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total";
            // 
            // chkNacional
            // 
            this.chkNacional.AutoSize = true;
            this.chkNacional.Location = new System.Drawing.Point(405, 200);
            this.chkNacional.Name = "chkNacional";
            this.chkNacional.Size = new System.Drawing.Size(68, 17);
            this.chkNacional.TabIndex = 7;
            this.chkNacional.Text = "Nacional";
            this.chkNacional.UseVisualStyleBackColor = true;
            this.chkNacional.CheckedChanged += new System.EventHandler(this.chkNacional_CheckedChanged);
            // 
            // chkInternacional
            // 
            this.chkInternacional.AutoSize = true;
            this.chkInternacional.Location = new System.Drawing.Point(405, 237);
            this.chkInternacional.Name = "chkInternacional";
            this.chkInternacional.Size = new System.Drawing.Size(87, 17);
            this.chkInternacional.TabIndex = 8;
            this.chkInternacional.Text = "Internacional";
            this.chkInternacional.UseVisualStyleBackColor = true;
            this.chkInternacional.CheckedChanged += new System.EventHandler(this.chkInternacional_CheckedChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(222, 102);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(78, 36);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstNacional
            // 
            this.lstNacional.FormattingEnabled = true;
            this.lstNacional.Location = new System.Drawing.Point(39, 153);
            this.lstNacional.Name = "lstNacional";
            this.lstNacional.Size = new System.Drawing.Size(133, 82);
            this.lstNacional.TabIndex = 10;
            // 
            // lstInternacional
            // 
            this.lstInternacional.FormattingEnabled = true;
            this.lstInternacional.Location = new System.Drawing.Point(221, 153);
            this.lstInternacional.Name = "lstInternacional";
            this.lstInternacional.Size = new System.Drawing.Size(134, 82);
            this.lstInternacional.TabIndex = 11;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // FrmVisualizarBeca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 450);
            this.Controls.Add(this.lstInternacional);
            this.Controls.Add(this.lstNacional);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.chkInternacional);
            this.Controls.Add(this.chkNacional);
            this.Controls.Add(this.lblInternacional);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNacional);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBecas);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmVisualizarBeca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Becas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbInternacional;
        private System.Windows.Forms.RadioButton rdbNacional;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.ComboBox cmbBecas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNacional;
        private System.Windows.Forms.Label lblInternacional;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkNacional;
        private System.Windows.Forms.CheckBox chkInternacional;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstNacional;
        private System.Windows.Forms.ListBox lstInternacional;
        private System.Windows.Forms.ErrorProvider error;
    }
}