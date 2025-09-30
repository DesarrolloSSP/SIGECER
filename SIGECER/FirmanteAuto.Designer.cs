
namespace Sigecer
{
    partial class FirmanteAuto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirmanteAuto));
            this.gbfirmante = new System.Windows.Forms.GroupBox();
            this.tbcerxml = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbcertificado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbabrevia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbcargo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbcurp = new System.Windows.Forms.TextBox();
            this.tbapemat = new System.Windows.Forms.TextBox();
            this.tbapepat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_firmante = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apepat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apemat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numcert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gbfirmante.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_firmante)).BeginInit();
            this.SuspendLayout();
            // 
            // gbfirmante
            // 
            this.gbfirmante.Controls.Add(this.tbcerxml);
            this.gbfirmante.Controls.Add(this.label8);
            this.gbfirmante.Controls.Add(this.label7);
            this.gbfirmante.Controls.Add(this.tbcertificado);
            this.gbfirmante.Controls.Add(this.label6);
            this.gbfirmante.Controls.Add(this.tbabrevia);
            this.gbfirmante.Controls.Add(this.label5);
            this.gbfirmante.Controls.Add(this.cbcargo);
            this.gbfirmante.Controls.Add(this.label4);
            this.gbfirmante.Controls.Add(this.tbcurp);
            this.gbfirmante.Controls.Add(this.tbapemat);
            this.gbfirmante.Controls.Add(this.tbapepat);
            this.gbfirmante.Controls.Add(this.label3);
            this.gbfirmante.Controls.Add(this.label2);
            this.gbfirmante.Controls.Add(this.tbnombre);
            this.gbfirmante.Controls.Add(this.label1);
            this.gbfirmante.Location = new System.Drawing.Point(12, 208);
            this.gbfirmante.Name = "gbfirmante";
            this.gbfirmante.Size = new System.Drawing.Size(567, 179);
            this.gbfirmante.TabIndex = 0;
            this.gbfirmante.TabStop = false;
            this.gbfirmante.Text = "Firmante";
            // 
            // tbcerxml
            // 
            this.tbcerxml.Enabled = false;
            this.tbcerxml.Location = new System.Drawing.Point(331, 146);
            this.tbcerxml.MaxLength = 40;
            this.tbcerxml.Name = "tbcerxml";
            this.tbcerxml.Size = new System.Drawing.Size(227, 20);
            this.tbcerxml.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(328, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Valor para el XML";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Número de Certificado:";
            // 
            // tbcertificado
            // 
            this.tbcertificado.Enabled = false;
            this.tbcertificado.Location = new System.Drawing.Point(10, 146);
            this.tbcertificado.MaxLength = 40;
            this.tbcertificado.Name = "tbcertificado";
            this.tbcertificado.Size = new System.Drawing.Size(268, 20);
            this.tbcertificado.TabIndex = 7;
            this.tbcertificado.TextChanged += new System.EventHandler(this.Tbcertificado_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(378, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Abreviatura del título";
            // 
            // tbabrevia
            // 
            this.tbabrevia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbabrevia.Enabled = false;
            this.tbabrevia.Location = new System.Drawing.Point(380, 94);
            this.tbabrevia.MaxLength = 40;
            this.tbabrevia.Name = "tbabrevia";
            this.tbabrevia.Size = new System.Drawing.Size(178, 20);
            this.tbabrevia.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cargo:";
            // 
            // cbcargo
            // 
            this.cbcargo.Enabled = false;
            this.cbcargo.FormattingEnabled = true;
            this.cbcargo.Location = new System.Drawing.Point(195, 93);
            this.cbcargo.Name = "cbcargo";
            this.cbcargo.Size = new System.Drawing.Size(177, 21);
            this.cbcargo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "CURP:";
            // 
            // tbcurp
            // 
            this.tbcurp.Enabled = false;
            this.tbcurp.Location = new System.Drawing.Point(10, 93);
            this.tbcurp.MaxLength = 18;
            this.tbcurp.Name = "tbcurp";
            this.tbcurp.Size = new System.Drawing.Size(178, 20);
            this.tbcurp.TabIndex = 4;
            // 
            // tbapemat
            // 
            this.tbapemat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbapemat.Enabled = false;
            this.tbapemat.Location = new System.Drawing.Point(380, 37);
            this.tbapemat.MaxLength = 40;
            this.tbapemat.Name = "tbapemat";
            this.tbapemat.Size = new System.Drawing.Size(178, 20);
            this.tbapemat.TabIndex = 3;
            // 
            // tbapepat
            // 
            this.tbapepat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbapepat.Enabled = false;
            this.tbapepat.Location = new System.Drawing.Point(194, 37);
            this.tbapepat.MaxLength = 40;
            this.tbapepat.Name = "tbapepat";
            this.tbapepat.Size = new System.Drawing.Size(178, 20);
            this.tbapepat.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Apellido Materno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Apellido Paterno:";
            // 
            // tbnombre
            // 
            this.tbnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbnombre.Enabled = false;
            this.tbnombre.Location = new System.Drawing.Point(10, 37);
            this.tbnombre.MaxLength = 40;
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(178, 20);
            this.tbnombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(424, 393);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 33);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Maroon;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(505, 394);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 32);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_firmante);
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(758, 161);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Firmantes Históricos";
            // 
            // dgv_firmante
            // 
            this.dgv_firmante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_firmante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_firmante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apepat,
            this.apemat,
            this.numcert});
            this.dgv_firmante.Location = new System.Drawing.Point(10, 19);
            this.dgv_firmante.Name = "dgv_firmante";
            this.dgv_firmante.Size = new System.Drawing.Size(729, 136);
            this.dgv_firmante.TabIndex = 0;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "NombreAutorizado";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apepat
            // 
            this.Apepat.DataPropertyName = "APatenroAutorizado";
            this.Apepat.HeaderText = "Apellido";
            this.Apepat.Name = "Apepat";
            // 
            // apemat
            // 
            this.apemat.DataPropertyName = "AMaternoAutorizado";
            this.apemat.HeaderText = "Apellido Materno";
            this.apemat.Name = "apemat";
            // 
            // numcert
            // 
            this.numcert.DataPropertyName = "NumCertidicado";
            this.numcert.HeaderText = "No. Certificado";
            this.numcert.Name = "numcert";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(696, 179);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // FirmanteAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(813, 429);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gbfirmante);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FirmanteAuto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Firmantes Autorizados";
            this.Load += new System.EventHandler(this.FirmanteAuto_Load);
            this.gbfirmante.ResumeLayout(false);
            this.gbfirmante.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_firmante)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbfirmante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbcargo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbcurp;
        private System.Windows.Forms.TextBox tbapemat;
        private System.Windows.Forms.TextBox tbapepat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbcertificado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbabrevia;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox tbcerxml;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_firmante;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apepat;
        private System.Windows.Forms.DataGridViewTextBoxColumn apemat;
        private System.Windows.Forms.DataGridViewTextBoxColumn numcert;
    }
}