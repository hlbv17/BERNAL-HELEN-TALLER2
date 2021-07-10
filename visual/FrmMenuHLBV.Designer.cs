
namespace Ejercicio04HLBV.visual
{
    partial class FrmMenuHLBV
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mniBecaInternacional = new System.Windows.Forms.ToolStripMenuItem();
            this.mniRegistrar = new System.Windows.Forms.ToolStripMenuItem();
            this.mniListar = new System.Windows.Forms.ToolStripMenuItem();
            this.mniEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mniVisualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniBecaInternacional});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mniBecaInternacional
            // 
            this.mniBecaInternacional.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniRegistrar,
            this.mniListar,
            this.mniEliminar,
            this.mniVisualizar,
            this.mniSalir});
            this.mniBecaInternacional.Name = "mniBecaInternacional";
            this.mniBecaInternacional.Size = new System.Drawing.Size(116, 20);
            this.mniBecaInternacional.Text = "Beca Internacional";
            // 
            // mniRegistrar
            // 
            this.mniRegistrar.Name = "mniRegistrar";
            this.mniRegistrar.Size = new System.Drawing.Size(180, 22);
            this.mniRegistrar.Text = "Registrar";
            this.mniRegistrar.Click += new System.EventHandler(this.mniRegistrar_Click);
            // 
            // mniListar
            // 
            this.mniListar.Name = "mniListar";
            this.mniListar.Size = new System.Drawing.Size(180, 22);
            this.mniListar.Text = "Listar";
            this.mniListar.Click += new System.EventHandler(this.mniListar_Click);
            // 
            // mniEliminar
            // 
            this.mniEliminar.Name = "mniEliminar";
            this.mniEliminar.Size = new System.Drawing.Size(180, 22);
            this.mniEliminar.Text = "Eliminar";
            this.mniEliminar.Click += new System.EventHandler(this.mniEliminar_Click);
            // 
            // mniSalir
            // 
            this.mniSalir.Name = "mniSalir";
            this.mniSalir.Size = new System.Drawing.Size(180, 22);
            this.mniSalir.Text = "Salir";
            this.mniSalir.Click += new System.EventHandler(this.mniSalir_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // mniVisualizar
            // 
            this.mniVisualizar.Name = "mniVisualizar";
            this.mniVisualizar.Size = new System.Drawing.Size(180, 22);
            this.mniVisualizar.Text = "Visualizar";
            this.mniVisualizar.Click += new System.EventHandler(this.mniVisualizar_Click);
            // 
            // FrmMenuHLBV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenuHLBV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenuHLBV";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mniBecaInternacional;
        private System.Windows.Forms.ToolStripMenuItem mniRegistrar;
        private System.Windows.Forms.ToolStripMenuItem mniListar;
        private System.Windows.Forms.ToolStripMenuItem mniEliminar;
        private System.Windows.Forms.ToolStripMenuItem mniSalir;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mniVisualizar;
    }
}