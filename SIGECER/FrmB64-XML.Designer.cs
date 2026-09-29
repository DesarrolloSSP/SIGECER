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
            this.btnCopiarB64 = new System.Windows.Forms.Button();
            this.btnCargarXML = new System.Windows.Forms.Button();
            this.txtXml = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDecodificarXml = new System.Windows.Forms.Button();
            this.txtBase64 = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
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
            // btnCopiarB64
            // 
            this.btnCopiarB64.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCopiarB64.Location = new System.Drawing.Point(460, 29);
            this.btnCopiarB64.Name = "btnCopiarB64";
            this.btnCopiarB64.Size = new System.Drawing.Size(75, 23);
            this.btnCopiarB64.TabIndex = 2;
            this.btnCopiarB64.Text = "Copiar📑 ";
            this.btnCopiarB64.UseVisualStyleBackColor = false;
            this.btnCopiarB64.Click += new System.EventHandler(this.btnCopiarB64_Click);
            // 
            // btnCargarXML
            // 
            this.btnCargarXML.BackColor = System.Drawing.Color.Maroon;
            this.btnCargarXML.ForeColor = System.Drawing.Color.White;
            this.btnCargarXML.Location = new System.Drawing.Point(360, 29);
            this.btnCargarXML.Name = "btnCargarXML";
            this.btnCargarXML.Size = new System.Drawing.Size(75, 23);
            this.btnCargarXML.TabIndex = 1;
            this.btnCargarXML.Text = "XML";
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
            this.groupBox2.Controls.Add(this.btnDecodificarXml);
            this.groupBox2.Controls.Add(this.txtBase64);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(628, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(628, 565);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "B64 ➡️ XML ";
            // 
            // btnDecodificarXml
            // 
            this.btnDecodificarXml.BackColor = System.Drawing.Color.Maroon;
            this.btnDecodificarXml.ForeColor = System.Drawing.Color.White;
            this.btnDecodificarXml.Location = new System.Drawing.Point(527, 20);
            this.btnDecodificarXml.Name = "btnDecodificarXml";
            this.btnDecodificarXml.Size = new System.Drawing.Size(75, 23);
            this.btnDecodificarXml.TabIndex = 1;
            this.btnDecodificarXml.Text = "B64";
            this.btnDecodificarXml.UseVisualStyleBackColor = false;
            this.btnDecodificarXml.Click += new System.EventHandler(this.btnDecodificarXml_Click);
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
        private System.Windows.Forms.Button btnDecodificarXml;
        private System.Windows.Forms.Button btnLimpiar;
    }
}