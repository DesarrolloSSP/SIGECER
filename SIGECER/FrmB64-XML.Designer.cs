namespace Sigecer
{
    partial class FrmB64_XML
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCopiarB64 = new System.Windows.Forms.Button();
            this.btnCargarXML = new System.Windows.Forms.Button();
            this.txtXml = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDecodificar = new System.Windows.Forms.Button();
            this.txtBase64 = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCopiarB64);
            this.groupBox1.Controls.Add(this.btnCargarXML);
            this.groupBox1.Controls.Add(this.txtXml);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 565);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "XML ➡️ B64";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecciona el archivo a codificar :";
            // 
            // btnCopiarB64
            // 
            this.btnCopiarB64.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCopiarB64.Location = new System.Drawing.Point(388, 20);
            this.btnCopiarB64.Name = "btnCopiarB64";
            this.btnCopiarB64.Size = new System.Drawing.Size(185, 23);
            this.btnCopiarB64.TabIndex = 2;
            this.btnCopiarB64.Text = "Copiar archivo en Base64📑 ";
            this.btnCopiarB64.UseVisualStyleBackColor = false;
            this.btnCopiarB64.Click += new System.EventHandler(this.btnCopiarB64_Click);
            // 
            // btnCargarXML
            // 
            this.btnCargarXML.BackColor = System.Drawing.Color.Maroon;
            this.btnCargarXML.ForeColor = System.Drawing.Color.White;
            this.btnCargarXML.Location = new System.Drawing.Point(214, 24);
            this.btnCargarXML.Name = "btnCargarXML";
            this.btnCargarXML.Size = new System.Drawing.Size(94, 23);
            this.btnCargarXML.TabIndex = 1;
            this.btnCargarXML.Text = "Buscar XML";
            this.btnCargarXML.UseVisualStyleBackColor = false;
            this.btnCargarXML.Click += new System.EventHandler(this.btnCargarXML_Click);
            // 
            // txtXml
            // 
            this.txtXml.Location = new System.Drawing.Point(6, 58);
            this.txtXml.Multiline = true;
            this.txtXml.Name = "txtXml";
            this.txtXml.Size = new System.Drawing.Size(567, 501);
            this.txtXml.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnDecodificar);
            this.groupBox2.Controls.Add(this.txtBase64);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(628, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(628, 565);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Decodificar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pega en el recuadro el código B64";
            // 
            // btnDecodificar
            // 
            this.btnDecodificar.BackColor = System.Drawing.Color.Maroon;
            this.btnDecodificar.ForeColor = System.Drawing.Color.White;
            this.btnDecodificar.Location = new System.Drawing.Point(489, 25);
            this.btnDecodificar.Name = "btnDecodificar";
            this.btnDecodificar.Size = new System.Drawing.Size(93, 23);
            this.btnDecodificar.TabIndex = 1;
            this.btnDecodificar.Text = "Decodificar";
            this.btnDecodificar.UseVisualStyleBackColor = false;
            this.btnDecodificar.Click += new System.EventHandler(this.btnDecodificar_Click);
            // 
            // txtBase64
            // 
            this.txtBase64.Location = new System.Drawing.Point(16, 58);
            this.txtBase64.Multiline = true;
            this.txtBase64.Name = "txtBase64";
            this.txtBase64.Size = new System.Drawing.Size(596, 501);
            this.txtBase64.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Yellow;
            this.btnLimpiar.Location = new System.Drawing.Point(534, 583);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(164, 21);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FrmB64_XML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 616);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmB64_XML";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "B64 - XML";
            this.Load += new System.EventHandler(this.FrmB64_XML_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtXml;
        private System.Windows.Forms.TextBox txtBase64;
        private System.Windows.Forms.Button btnCargarXML;
        private System.Windows.Forms.Button btnCopiarB64;
        private System.Windows.Forms.Button btnDecodificar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}