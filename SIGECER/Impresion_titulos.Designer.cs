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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblalum = new System.Windows.Forms.Label();
            this.lblCantRe = new System.Windows.Forms.Label();
            this.IdTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaImpreasion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_gen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folio_electronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_Alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModTitu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQR = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnReporte = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnQuitar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdCarrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvTitulos)).BeginInit();
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
            this.ModTitu,
            this.curp,
            this.btnQR,
            this.btnReporte,
            this.btnQuitar,
            this.IdCarrera});
            this.gvTitulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gvTitulos.Location = new System.Drawing.Point(13, 120);
            this.gvTitulos.MultiSelect = false;
            this.gvTitulos.Name = "gvTitulos";
            this.gvTitulos.ReadOnly = true;
            this.gvTitulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvTitulos.Size = new System.Drawing.Size(1412, 403);
            this.gvTitulos.TabIndex = 0;
            this.gvTitulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTitulos_CellContentClick);
            this.gvTitulos.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.gvTitulos_CellPainting);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(13, 81);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(309, 21);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.Text = "Buscar...";
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
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
            this.btnBuscar.Location = new System.Drawing.Point(328, 81);
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
            this.lblalum.Location = new System.Drawing.Point(1170, 86);
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
            this.lblCantRe.Location = new System.Drawing.Point(1296, 86);
            this.lblCantRe.Name = "lblCantRe";
            this.lblCantRe.Size = new System.Drawing.Size(15, 16);
            this.lblCantRe.TabIndex = 6;
            this.lblCantRe.Text = "0";
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
            // ModTitu
            // 
            this.ModTitu.DataPropertyName = "ModTitu";
            this.ModTitu.HeaderText = "Modo titulación";
            this.ModTitu.Name = "ModTitu";
            this.ModTitu.ReadOnly = true;
            this.ModTitu.Width = 200;
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
            // Impresion_titulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 558);
            this.Controls.Add(this.lblCantRe);
            this.Controls.Add(this.lblalum);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.gvTitulos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Impresion_titulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impresión de titulos";
            this.Load += new System.EventHandler(this.Impresion_titulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvTitulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvTitulos;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblalum;
        private System.Windows.Forms.Label lblCantRe;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaImpreasion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_gen;
        private System.Windows.Forms.DataGridViewTextBoxColumn folio_electronico;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_Alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModTitu;
        private System.Windows.Forms.DataGridViewTextBoxColumn curp;
        private System.Windows.Forms.DataGridViewButtonColumn btnQR;
        private System.Windows.Forms.DataGridViewButtonColumn btnReporte;
        private System.Windows.Forms.DataGridViewButtonColumn btnQuitar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCarrera;
    }
}