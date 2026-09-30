namespace Sigecer
{
    partial class Alumnos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alumnos));

            // ==================== DATA GRID VIEW ====================
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();

            // ==================== COLUMNAS ====================
            this.colIdTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFolioElectronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCarrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();

            // ==================== PANELES ====================
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.panelAcciones = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSellar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();

            // ==================== AREA DE LOG ====================
            this.txtLog = new System.Windows.Forms.TextBox();

            // ==================== PANEL INFERIOR ====================
            this.panelInferior = new System.Windows.Forms.Panel();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.lblSeparador = new System.Windows.Forms.Label();

            // ==================== INICIALIZACIÓN ====================
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.panelSuperior.SuspendLayout();
            this.panelBusqueda.SuspendLayout();
            this.panelAcciones.SuspendLayout();
            this.panelInferior.SuspendLayout();
            this.SuspendLayout();

            // 
            // dgvAlumnos - DataGridView Principal
            // 
            this.dgvAlumnos.AllowUserToAddRows = false;
            this.dgvAlumnos.AllowUserToDeleteRows = false;
            this.dgvAlumnos.AllowUserToOrderColumns = true;
            this.dgvAlumnos.AllowUserToResizeColumns = false;
            this.dgvAlumnos.AllowUserToResizeRows = false;

            // Configuración visual moderna
            this.dgvAlumnos.BackgroundColor = System.Drawing.Color.White;
            this.dgvAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAlumnos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAlumnos.GridColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this.dgvAlumnos.RowHeadersVisible = false;

            // Comportamiento y auto-sizing
            this.dgvAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlumnos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvAlumnos.ColumnHeadersHeight = 40;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // Estilos de cabecera
            this.dgvAlumnos.EnableHeadersVisualStyles = false;
            this.dgvAlumnos.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.dgvAlumnos.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAlumnos.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvAlumnos.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;

            // Estilos de celdas
            this.dgvAlumnos.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvAlumnos.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.dgvAlumnos.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.dgvAlumnos.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

            // Estilos alternados
            this.dgvAlumnos.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);

            // Altura de filas
            this.dgvAlumnos.RowTemplate.Height = 35;
            this.dgvAlumnos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;

            // Selección
            this.dgvAlumnos.ReadOnly = true;
            this.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnos.ShowEditingIcon = false;
            this.dgvAlumnos.StandardTab = true;

            // Columnas
            this.dgvAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colIdTitulo,
                this.colFolioElectronico,
                this.colCurp,
                this.colNombre,
                this.colPaterno,
                this.colMaterno,
                this.colCarrera,
                this.colEstatus});

            // Ubicación y tamaño
            this.dgvAlumnos.Location = new System.Drawing.Point(12, 75);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.Size = new System.Drawing.Size(950, 400);
            this.dgvAlumnos.TabIndex = 0;

            // Eventos
            this.dgvAlumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAlumnos_CellClick);
            this.dgvAlumnos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAlumnos_CellDoubleClick);

            // 
            // Configuración de Columnas
            // 

            // colIdTitulo
            this.colIdTitulo.DataPropertyName = "IdTitulo";
            this.colIdTitulo.HeaderText = "ID";
            this.colIdTitulo.Name = "colIdTitulo";
            this.colIdTitulo.Visible = false;

            // colFolioElectronico
            this.colFolioElectronico.DataPropertyName = "folio_electronico";
            this.colFolioElectronico.HeaderText = "Folio Electrónico";
            this.colFolioElectronico.Name = "colFolioElectronico";
            this.colFolioElectronico.Visible = false;

            // colCurp
            this.colCurp.DataPropertyName = "curp";
            this.colCurp.FillWeight = 30F;
            this.colCurp.HeaderText = "CURP";
            this.colCurp.Name = "colCurp";
            this.colCurp.ReadOnly = true;

            // colNombre
            this.colNombre.DataPropertyName = "nombre";
            this.colNombre.FillWeight = 60F;
            this.colNombre.HeaderText = "Nombre(s)";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;

            // colPaterno
            this.colPaterno.DataPropertyName = "primerApellido";
            this.colPaterno.FillWeight = 80F;
            this.colPaterno.HeaderText = "Apellido Paterno";
            this.colPaterno.Name = "colPaterno";
            this.colPaterno.ReadOnly = true;

            // colMaterno
            this.colMaterno.DataPropertyName = "segundoApellido";
            this.colMaterno.FillWeight = 80F;
            this.colMaterno.HeaderText = "Apellido Materno";
            this.colMaterno.Name = "colMaterno";
            this.colMaterno.ReadOnly = true;

            // colCarrera
            this.colCarrera.DataPropertyName = "desc_titulo";
            this.colCarrera.FillWeight = 120F;
            this.colCarrera.HeaderText = "Carrera";
            this.colCarrera.Name = "colCarrera";
            this.colCarrera.ReadOnly = true;

            // colEstatus
            this.colEstatus.DataPropertyName = "estatus";
            this.colEstatus.FillWeight = 50F;
            this.colEstatus.HeaderText = "Estatus";
            this.colEstatus.Name = "colEstatus";

            // 
            // panelSuperior - Panel Principal Superior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(245, 246, 248);
            this.panelSuperior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSuperior.Controls.Add(this.panelBusqueda);
            this.panelSuperior.Controls.Add(this.panelAcciones);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Padding = new System.Windows.Forms.Padding(10);
            this.panelSuperior.Size = new System.Drawing.Size(1100, 65);
            this.panelSuperior.TabIndex = 1;

            // 
            // panelBusqueda - Panel de Búsqueda
            // 
            this.panelBusqueda.Controls.Add(this.btnBuscar);
            this.panelBusqueda.Controls.Add(this.txtBuscar);
            this.panelBusqueda.Controls.Add(this.lblBuscar);
            this.panelBusqueda.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBusqueda.Location = new System.Drawing.Point(10, 10);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(450, 43);
            this.panelBusqueda.TabIndex = 0;

            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.lblBuscar.Location = new System.Drawing.Point(3, 11);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(54, 19);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar:";

            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBuscar.Location = new System.Drawing.Point(63, 8);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(280, 25);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscar_KeyPress);

            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(84, 110, 122);
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(349, 7);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(90, 27);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "🔍 Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);

            // 
            // panelAcciones - Panel de Botones de Acción
            // 
            this.panelAcciones.Controls.Add(this.btnActualizar);
            this.panelAcciones.Controls.Add(this.btnSellar);
            this.panelAcciones.Controls.Add(this.btnEditar);
            this.panelAcciones.Controls.Add(this.btnCancelar);
            this.panelAcciones.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelAcciones.Location = new System.Drawing.Point(496, 10);
            this.panelAcciones.Name = "panelAcciones";
            this.panelAcciones.Size = new System.Drawing.Size(592, 43);
            this.panelAcciones.TabIndex = 1;

            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(96, 125, 107);
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(3, 5);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(110, 32);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.Text = "🔄 Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);

            // 
            // btnSellar
            // 
            this.btnSellar.BackColor = System.Drawing.Color.FromArgb(96, 125, 139);
            this.btnSellar.FlatAppearance.BorderSize = 0;
            this.btnSellar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSellar.ForeColor = System.Drawing.Color.White;
            this.btnSellar.Location = new System.Drawing.Point(119, 5);
            this.btnSellar.Name = "btnSellar";
            this.btnSellar.Size = new System.Drawing.Size(110, 32);
            this.btnSellar.TabIndex = 1;
            this.btnSellar.Text = "📄 Sellar XML";
            this.btnSellar.UseVisualStyleBackColor = false;
            this.btnSellar.Click += new System.EventHandler(this.BtnSellarXML_Click);

            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(138, 122, 74);
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(235, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(110, 32);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "✏️ Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);

            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(139, 92, 92);
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(480, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 32);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "❌ Cerrar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);

            // 
            // panelInferior - Panel Inferior con información
            // 
            this.panelInferior.BackColor = System.Drawing.Color.FromArgb(245, 246, 248);
            this.panelInferior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInferior.Controls.Add(this.lblRegistros);
            this.panelInferior.Controls.Add(this.lblSeparador);
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(0, 530);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Padding = new System.Windows.Forms.Padding(10);
            this.panelInferior.Size = new System.Drawing.Size(1100, 35);
            this.panelInferior.TabIndex = 3;

            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lblRegistros.Location = new System.Drawing.Point(18, 8);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(130, 15);
            this.lblRegistros.TabIndex = 0;
            this.lblRegistros.Text = "Total de registros: 0";

            // 
            // lblSeparador
            // 
            this.lblSeparador.AutoSize = true;
            this.lblSeparador.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lblSeparador.Location = new System.Drawing.Point(180, 8);
            this.lblSeparador.Name = "lblSeparador";
            this.lblSeparador.Size = new System.Drawing.Size(0, 15);
            this.lblSeparador.TabIndex = 1;

            // 
            // txtLog - Área de Log (oculta por defecto)
            // 
            this.txtLog.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLog.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtLog.Location = new System.Drawing.Point(12, 481);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(950, 40);
            this.txtLog.TabIndex = 2;
            this.txtLog.Visible = false;

            // 
            // Alumnos - Configuración del Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(1100, 565);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.dgvAlumnos);

            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Alumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "🎓 Gestión de Alumnos";

            this.Load += new System.EventHandler(this.Alumnos_Load);
            this.Shown += new System.EventHandler(this.Alumnos_Shown);

            // ==================== FINALIZACIÓN ====================
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.panelSuperior.ResumeLayout(false);
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            this.panelAcciones.ResumeLayout(false);
            this.panelInferior.ResumeLayout(false);
            this.panelInferior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        // ==================== CONTROLES ====================

        // DataGridView
        private System.Windows.Forms.DataGridView dgvAlumnos;

        // Paneles
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panelBusqueda;
        private System.Windows.Forms.Panel panelAcciones;
        private System.Windows.Forms.Panel panelInferior;

        // Controles de búsqueda
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;

        // Botones de acción
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSellar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;

        // Información
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Label lblSeparador;

        // Log
        private System.Windows.Forms.TextBox txtLog;

        // ==================== COLUMNAS ====================
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFolioElectronico;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstatus;
    }
}