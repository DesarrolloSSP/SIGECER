namespace Sigecer
{
    partial class Impresion_titulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Impresion_titulos));
            this.gvTitulos = new System.Windows.Forms.DataGridView();
            this.IdTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaImpreasion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_gen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folio_electronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_Alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modo_titulacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQR = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnReporte = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnQuitar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdCarrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblalum = new System.Windows.Forms.Label();
            this.lblCantRe = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaImpresion = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Folio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.cmbModoTitulacion = new System.Windows.Forms.ComboBox();
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.txtCurp = new System.Windows.Forms.TextBox();
            this.txtFolio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvTitulos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvTitulos
            // 
            this.gvTitulos.AllowUserToAddRows = false;
            this.gvTitulos.AllowUserToDeleteRows = false;
            this.gvTitulos.AllowUserToOrderColumns = true;
            this.gvTitulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTitulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTitulo,
            this.FechaImpreasion,
            this.fecha_gen,
            this.folio_electronico,
            this.nombre_Alumno,
            this.Carrera,
            this.Modo_titulacion,
            this.curp,
            this.btnQR,
            this.btnReporte,
            this.btnQuitar,
            this.IdCarrera});
            this.gvTitulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gvTitulos.Location = new System.Drawing.Point(13, 181);
            this.gvTitulos.MultiSelect = false;
            this.gvTitulos.Name = "gvTitulos";
            this.gvTitulos.ReadOnly = true;
            this.gvTitulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvTitulos.Size = new System.Drawing.Size(1412, 365);
            this.gvTitulos.TabIndex = 0;
            this.gvTitulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTitulos_CellContentClick);
            this.gvTitulos.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.gvTitulos_CellPainting);
            // 
            // IdTitulo
            // 
            this.IdTitulo.DataPropertyName = "IdTitulo";
            this.IdTitulo.HeaderText = "IdTitulo";
            this.IdTitulo.Name = "IdTitulo";
            this.IdTitulo.ReadOnly = true;
            this.IdTitulo.Visible = false;
            // 
            // FechaImpreasion
            // 
            this.FechaImpreasion.DataPropertyName = "FechaImpreasion";
            this.FechaImpreasion.HeaderText = "Fecha Impre";
            this.FechaImpreasion.Name = "FechaImpreasion";
            this.FechaImpreasion.ReadOnly = true;
            // 
            // fecha_gen
            // 
            this.fecha_gen.DataPropertyName = "fecha_gen";
            this.fecha_gen.HeaderText = "Fecha creación";
            this.fecha_gen.Name = "fecha_gen";
            this.fecha_gen.ReadOnly = true;
            // 
            // folio_electronico
            // 
            this.folio_electronico.DataPropertyName = "folio_electronico";
            this.folio_electronico.HeaderText = "Folio electronico";
            this.folio_electronico.Name = "folio_electronico";
            this.folio_electronico.ReadOnly = true;
            this.folio_electronico.Width = 250;
            // 
            // nombre_Alumno
            // 
            this.nombre_Alumno.DataPropertyName = "nombre_Alumno";
            this.nombre_Alumno.HeaderText = "Nombre del alumno";
            this.nombre_Alumno.Name = "nombre_Alumno";
            this.nombre_Alumno.ReadOnly = true;
            this.nombre_Alumno.Width = 300;
            // 
            // Carrera
            // 
            this.Carrera.DataPropertyName = "Carrera";
            this.Carrera.HeaderText = "Carrera";
            this.Carrera.Name = "Carrera";
            this.Carrera.ReadOnly = true;
            // 
            // Modo_titulacion
            // 
            this.Modo_titulacion.DataPropertyName = "ModTitu";
            this.Modo_titulacion.HeaderText = "Modo titulación";
            this.Modo_titulacion.Name = "Modo_titulacion";
            this.Modo_titulacion.ReadOnly = true;
            this.Modo_titulacion.Width = 200;
            // 
            // curp
            // 
            this.curp.DataPropertyName = "curp";
            this.curp.HeaderText = "CURP";
            this.curp.Name = "curp";
            this.curp.ReadOnly = true;
            this.curp.Width = 150;
            // 
            // btnQR
            // 
            this.btnQR.HeaderText = "QR";
            this.btnQR.Name = "btnQR";
            this.btnQR.ReadOnly = true;
            this.btnQR.Width = 65;
            // 
            // btnReporte
            // 
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReporte.HeaderText = "Titulo";
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.ReadOnly = true;
            this.btnReporte.ToolTipText = "Imprimir Título";
            this.btnReporte.Width = 65;
            // 
            // btnQuitar
            // 
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuitar.HeaderText = "Quitar alumno";
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.ReadOnly = true;
            this.btnQuitar.ToolTipText = "Quitar alumno";
            this.btnQuitar.Width = 65;
            // 
            // IdCarrera
            // 
            this.IdCarrera.DataPropertyName = "IdCarrera";
            this.IdCarrera.HeaderText = "IdCarrera";
            this.IdCarrera.Name = "IdCarrera";
            this.IdCarrera.ReadOnly = true;
            this.IdCarrera.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtAlumno
            // 
            this.txtAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlumno.Location = new System.Drawing.Point(358, 33);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.Size = new System.Drawing.Size(289, 21);
            this.txtAlumno.TabIndex = 1;
            this.txtAlumno.Enter += new System.EventHandler(this.txtBuscar_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(517, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lista de usuarios titulados";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Green;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(1015, 76);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblalum
            // 
            this.lblalum.AutoSize = true;
            this.lblalum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblalum.Location = new System.Drawing.Point(1167, 153);
            this.lblalum.Name = "lblalum";
            this.lblalum.Size = new System.Drawing.Size(131, 16);
            this.lblalum.TabIndex = 5;
            this.lblalum.Text = "Total de alumnos:";
            // 
            // lblCantRe
            // 
            this.lblCantRe.AutoSize = true;
            this.lblCantRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantRe.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblCantRe.Location = new System.Drawing.Point(1317, 153);
            this.lblCantRe.Name = "lblCantRe";
            this.lblCantRe.Size = new System.Drawing.Size(15, 16);
            this.lblCantRe.TabIndex = 6;
            this.lblCantRe.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtpFechaImpresion);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpFechaCreacion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Folio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.cmbModoTitulacion);
            this.groupBox1.Controls.Add(this.cmbCarrera);
            this.groupBox1.Controls.Add(this.txtCurp);
            this.groupBox1.Controls.Add(this.txtFolio);
            this.groupBox1.Controls.Add(this.txtAlumno);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Location = new System.Drawing.Point(60, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1221, 107);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Busqueda";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(842, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Fecha Impresión ";
            // 
            // dtpFechaImpresion
            // 
            this.dtpFechaImpresion.Checked = false;
            this.dtpFechaImpresion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaImpresion.Location = new System.Drawing.Point(845, 78);
            this.dtpFechaImpresion.Name = "dtpFechaImpresion";
            this.dtpFechaImpresion.ShowCheckBox = true;
            this.dtpFechaImpresion.Size = new System.Drawing.Size(138, 20);
            this.dtpFechaImpresion.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(660, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Fecha Creacion ";
            // 
            // dtpFechaCreacion
            // 
            this.dtpFechaCreacion.Checked = false;
            this.dtpFechaCreacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaCreacion.Location = new System.Drawing.Point(663, 77);
            this.dtpFechaCreacion.Name = "dtpFechaCreacion";
            this.dtpFechaCreacion.ShowCheckBox = true;
            this.dtpFechaCreacion.Size = new System.Drawing.Size(132, 20);
            this.dtpFechaCreacion.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(724, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "CURP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nombre:";
            // 
            // Folio
            // 
            this.Folio.AutoSize = true;
            this.Folio.Location = new System.Drawing.Point(3, 16);
            this.Folio.Name = "Folio";
            this.Folio.Size = new System.Drawing.Size(32, 13);
            this.Folio.TabIndex = 13;
            this.Folio.Text = "Folio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mdo de Titulación:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Carrera: ";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLimpiar.Location = new System.Drawing.Point(1110, 75);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar ";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbModoTitulacion
            // 
            this.cmbModoTitulacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModoTitulacion.FormattingEnabled = true;
            this.cmbModoTitulacion.Location = new System.Drawing.Point(383, 78);
            this.cmbModoTitulacion.Name = "cmbModoTitulacion";
            this.cmbModoTitulacion.Size = new System.Drawing.Size(232, 21);
            this.cmbModoTitulacion.TabIndex = 8;
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCarrera.FormattingEnabled = true;
            this.cmbCarrera.Location = new System.Drawing.Point(6, 78);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(289, 21);
            this.cmbCarrera.TabIndex = 7;
            // 
            // txtCurp
            // 
            this.txtCurp.Location = new System.Drawing.Point(724, 35);
            this.txtCurp.Name = "txtCurp";
            this.txtCurp.Size = new System.Drawing.Size(289, 20);
            this.txtCurp.TabIndex = 6;
            // 
            // txtFolio
            // 
            this.txtFolio.Location = new System.Drawing.Point(6, 33);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(289, 20);
            this.txtFolio.TabIndex = 5;
            // 
            // Impresion_titulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 558);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCantRe);
            this.Controls.Add(this.lblalum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gvTitulos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Impresion_titulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impresión de titulos";
            this.Load += new System.EventHandler(this.Impresion_titulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvTitulos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvTitulos;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblalum;
        private System.Windows.Forms.Label lblCantRe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.TextBox txtCurp;
        private System.Windows.Forms.ComboBox cmbCarrera;
        private System.Windows.Forms.ComboBox cmbModoTitulacion;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Folio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaImpreasion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_gen;
        private System.Windows.Forms.DataGridViewTextBoxColumn folio_electronico;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_Alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modo_titulacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn curp;
        private System.Windows.Forms.DataGridViewButtonColumn btnQR;
        private System.Windows.Forms.DataGridViewButtonColumn btnReporte;
        private System.Windows.Forms.DataGridViewButtonColumn btnQuitar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCarrera;
        private System.Windows.Forms.DateTimePicker dtpFechaCreacion;
        private System.Windows.Forms.DateTimePicker dtpFechaImpresion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}