
namespace Sigecer
{
    partial class Alumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alumnos));
            this.dgv_alumnos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_xml = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.idtitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folio_electronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_alumnos
            // 
            this.dgv_alumnos.AllowUserToAddRows = false;
            this.dgv_alumnos.AllowUserToDeleteRows = false;
            this.dgv_alumnos.AllowUserToOrderColumns = true;
            this.dgv_alumnos.AllowUserToResizeColumns = false;
            this.dgv_alumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_alumnos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgv_alumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_alumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtitulo,
            this.folio_electronico,
            this.Curp,
            this.Nombre,
            this.Paterno,
            this.Materno,
            this.Carrera});
            this.dgv_alumnos.Location = new System.Drawing.Point(12, 69);
            this.dgv_alumnos.Name = "dgv_alumnos";
            this.dgv_alumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_alumnos.ShowEditingIcon = false;
            this.dgv_alumnos.Size = new System.Drawing.Size(875, 345);
            this.dgv_alumnos.TabIndex = 0;
            this.dgv_alumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_alumnos_CellClick);
            this.dgv_alumnos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_alumnos_CellEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(875, 51);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // Btn_xml
            // 
            this.Btn_xml.Location = new System.Drawing.Point(904, 69);
            this.Btn_xml.Name = "Btn_xml";
            this.Btn_xml.Size = new System.Drawing.Size(91, 57);
            this.Btn_xml.TabIndex = 2;
            this.Btn_xml.Text = "&Sellar XML";
            this.Btn_xml.UseVisualStyleBackColor = true;
            this.Btn_xml.Click += new System.EventHandler(this.Btn_xml_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.Location = new System.Drawing.Point(904, 384);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(91, 30);
            this.btncancelar.TabIndex = 3;
            this.btncancelar.Text = "&Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.Btncancelar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 433);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(875, 71);
            this.textBox1.TabIndex = 4;
            // 
            // btnEditar
            // 
            this.btnEditar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEditar.Location = new System.Drawing.Point(904, 132);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(91, 30);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // idtitulo
            // 
            this.idtitulo.DataPropertyName = "IdTitulo";
            this.idtitulo.HeaderText = "idtitulo";
            this.idtitulo.Name = "idtitulo";
            this.idtitulo.Visible = false;
            // 
            // folio_electronico
            // 
            this.folio_electronico.DataPropertyName = "folio_electronico";
            this.folio_electronico.HeaderText = "folio_electronico";
            this.folio_electronico.Name = "folio_electronico";
            this.folio_electronico.ReadOnly = true;
            this.folio_electronico.Visible = false;
            // 
            // Curp
            // 
            this.Curp.DataPropertyName = "curp";
            this.Curp.FillWeight = 37.25962F;
            this.Curp.HeaderText = "CURP";
            this.Curp.Name = "Curp";
            this.Curp.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.FillWeight = 74.29253F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Paterno
            // 
            this.Paterno.DataPropertyName = "primerApellido";
            this.Paterno.FillWeight = 104.0475F;
            this.Paterno.HeaderText = "Paterno";
            this.Paterno.Name = "Paterno";
            this.Paterno.ReadOnly = true;
            // 
            // Materno
            // 
            this.Materno.DataPropertyName = "segundoApellido";
            this.Materno.FillWeight = 135.1416F;
            this.Materno.HeaderText = "Materno";
            this.Materno.Name = "Materno";
            this.Materno.ReadOnly = true;
            // 
            // Carrera
            // 
            this.Carrera.DataPropertyName = "desc_titulo";
            this.Carrera.FillWeight = 149.2588F;
            this.Carrera.HeaderText = "Carrera";
            this.Carrera.Name = "Carrera";
            this.Carrera.ReadOnly = true;
            // 
            // Alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btncancelar;
            this.ClientSize = new System.Drawing.Size(1007, 554);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.Btn_xml);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_alumnos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Alumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.Alumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_alumnos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_xml;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn folio_electronico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera;
    }
}