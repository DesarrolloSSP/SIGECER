
namespace Sigecer
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Tsm_Nuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rutaDeLlavesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rutaDeXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catálogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmantesAutorizadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarTokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirTituloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.base64ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsm_Nuevo,
            this.catálogosToolStripMenuItem,
            this.alumnosToolStripMenuItem,
            this.administraciónToolStripMenuItem,
            this.generarTokenToolStripMenuItem,
            this.imprimirTituloToolStripMenuItem,
            this.base64ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Tsm_Nuevo
            // 
            this.Tsm_Nuevo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnoToolStripMenuItem,
            this.rutaDeLlavesToolStripMenuItem,
            this.rutaDeXMLToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.Tsm_Nuevo.Name = "Tsm_Nuevo";
            this.Tsm_Nuevo.Size = new System.Drawing.Size(54, 20);
            this.Tsm_Nuevo.Text = "&Nuevo";
            // 
            // alumnoToolStripMenuItem
            // 
            this.alumnoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("alumnoToolStripMenuItem.Image")));
            this.alumnoToolStripMenuItem.Name = "alumnoToolStripMenuItem";
            this.alumnoToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.alumnoToolStripMenuItem.Text = "&Alumno";
            this.alumnoToolStripMenuItem.Click += new System.EventHandler(this.AlumnoToolStripMenuItem_Click);
            // 
            // rutaDeLlavesToolStripMenuItem
            // 
            this.rutaDeLlavesToolStripMenuItem.Name = "rutaDeLlavesToolStripMenuItem";
            this.rutaDeLlavesToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.rutaDeLlavesToolStripMenuItem.Text = "Ruta de Llaves";
            this.rutaDeLlavesToolStripMenuItem.Click += new System.EventHandler(this.RutaDeLlavesToolStripMenuItem_Click);
            // 
            // rutaDeXMLToolStripMenuItem
            // 
            this.rutaDeXMLToolStripMenuItem.Name = "rutaDeXMLToolStripMenuItem";
            this.rutaDeXMLToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.rutaDeXMLToolStripMenuItem.Text = "Ruta de XML";
            this.rutaDeXMLToolStripMenuItem.Click += new System.EventHandler(this.RutaDeXMLToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // catálogosToolStripMenuItem
            // 
            this.catálogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firmantesAutorizadosToolStripMenuItem});
            this.catálogosToolStripMenuItem.Name = "catálogosToolStripMenuItem";
            this.catálogosToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.catálogosToolStripMenuItem.Text = "&Catálogos";
            // 
            // firmantesAutorizadosToolStripMenuItem
            // 
            this.firmantesAutorizadosToolStripMenuItem.Name = "firmantesAutorizadosToolStripMenuItem";
            this.firmantesAutorizadosToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.firmantesAutorizadosToolStripMenuItem.Text = "F&irmantes Autorizados ";
            this.firmantesAutorizadosToolStripMenuItem.Click += new System.EventHandler(this.FirmantesAutorizadosToolStripMenuItem_Click);
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verAlumnosToolStripMenuItem});
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.alumnosToolStripMenuItem.Text = "&Alumnos";
            // 
            // verAlumnosToolStripMenuItem
            // 
            this.verAlumnosToolStripMenuItem.Name = "verAlumnosToolStripMenuItem";
            this.verAlumnosToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.verAlumnosToolStripMenuItem.Text = "Ver Alumnos ...";
            this.verAlumnosToolStripMenuItem.Click += new System.EventHandler(this.VerAlumnosToolStripMenuItem_Click);
            // 
            // administraciónToolStripMenuItem
            // 
            this.administraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearUsuariosToolStripMenuItem});
            this.administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            this.administraciónToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.administraciónToolStripMenuItem.Text = "Administración";
            // 
            // crearUsuariosToolStripMenuItem
            // 
            this.crearUsuariosToolStripMenuItem.Name = "crearUsuariosToolStripMenuItem";
            this.crearUsuariosToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.crearUsuariosToolStripMenuItem.Text = "Crear usuarios";
            this.crearUsuariosToolStripMenuItem.Click += new System.EventHandler(this.crearUsuariosToolStripMenuItem_Click);
            // 
            // generarTokenToolStripMenuItem
            // 
            this.generarTokenToolStripMenuItem.Name = "generarTokenToolStripMenuItem";
            this.generarTokenToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.generarTokenToolStripMenuItem.Text = "Generar Token";
            this.generarTokenToolStripMenuItem.Click += new System.EventHandler(this.generarTokenToolStripMenuItem_Click);
            // 
            // imprimirTituloToolStripMenuItem
            // 
            this.imprimirTituloToolStripMenuItem.Name = "imprimirTituloToolStripMenuItem";
            this.imprimirTituloToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.imprimirTituloToolStripMenuItem.Text = "Imprimir titulo";
            this.imprimirTituloToolStripMenuItem.Click += new System.EventHandler(this.imprimirTituloToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Agregar a un nuevo alumno ...";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Salir del sistema";
            this.toolStripButton2.Click += new System.EventHandler(this.ToolStripButton2_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssl
            // 
            this.tssl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tssl.Name = "tssl";
            this.tssl.Size = new System.Drawing.Size(127, 17);
            this.tssl.Text = "toolStripStatusLabel1";
            // 
            // base64ToolStripMenuItem
            // 
            this.base64ToolStripMenuItem.Name = "base64ToolStripMenuItem";
            this.base64ToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.base64ToolStripMenuItem.Text = "B64 - XML";
            this.base64ToolStripMenuItem.Click += new System.EventHandler(this.base64ToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centro de Estudios e Investigación en Seguridad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Nuevo;
        private System.Windows.Forms.ToolStripMenuItem alumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catálogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmantesAutorizadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem verAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rutaDeLlavesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rutaDeXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarTokenToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssl;
        private System.Windows.Forms.ToolStripMenuItem imprimirTituloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem base64ToolStripMenuItem;
    }
}

