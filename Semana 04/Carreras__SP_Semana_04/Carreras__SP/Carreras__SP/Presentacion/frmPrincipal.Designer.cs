namespace Carreras__SP.Presentacion
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carrerasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaCarreraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCarreraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignaturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarAsignaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verReporteDeCarrerasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.carrerasToolStripMenuItem,
            this.asignaturasToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(978, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // carrerasToolStripMenuItem
            // 
            this.carrerasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaCarreraToolStripMenuItem,
            this.consultarCarreraToolStripMenuItem});
            this.carrerasToolStripMenuItem.Name = "carrerasToolStripMenuItem";
            this.carrerasToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.carrerasToolStripMenuItem.Text = "Carreras";
            // 
            // nuevaCarreraToolStripMenuItem
            // 
            this.nuevaCarreraToolStripMenuItem.Name = "nuevaCarreraToolStripMenuItem";
            this.nuevaCarreraToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.nuevaCarreraToolStripMenuItem.Text = "Nueva Carrera";
            this.nuevaCarreraToolStripMenuItem.Click += new System.EventHandler(this.nuevaCarreraToolStripMenuItem_Click);
            // 
            // consultarCarreraToolStripMenuItem
            // 
            this.consultarCarreraToolStripMenuItem.Name = "consultarCarreraToolStripMenuItem";
            this.consultarCarreraToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.consultarCarreraToolStripMenuItem.Text = "Consultar Carrera";
            this.consultarCarreraToolStripMenuItem.Click += new System.EventHandler(this.consultarCarreraToolStripMenuItem_Click);
            // 
            // asignaturasToolStripMenuItem
            // 
            this.asignaturasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarAsignaturaToolStripMenuItem});
            this.asignaturasToolStripMenuItem.Name = "asignaturasToolStripMenuItem";
            this.asignaturasToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.asignaturasToolStripMenuItem.Text = "Asignaturas";
            // 
            // cargarAsignaturaToolStripMenuItem
            // 
            this.cargarAsignaturaToolStripMenuItem.Name = "cargarAsignaturaToolStripMenuItem";
            this.cargarAsignaturaToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.cargarAsignaturaToolStripMenuItem.Text = "Cargar Asignatura";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verReporteDeCarrerasToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // verReporteDeCarrerasToolStripMenuItem
            // 
            this.verReporteDeCarrerasToolStripMenuItem.Name = "verReporteDeCarrerasToolStripMenuItem";
            this.verReporteDeCarrerasToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.verReporteDeCarrerasToolStripMenuItem.Text = "Ver Reporte De Carreras";
            this.verReporteDeCarrerasToolStripMenuItem.Click += new System.EventHandler(this.verReporteDeCarrerasToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(978, 501);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carrerasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaCarreraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarCarreraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignaturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarAsignaturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verReporteDeCarrerasToolStripMenuItem;
    }
}

