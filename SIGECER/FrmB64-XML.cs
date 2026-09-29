using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sigecer
{
    public partial class FrmB64_XML : Form
    {
        public FrmB64_XML()
        {
            InitializeComponent();
        }

        private void btnCargarXML_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Archivos XML (*.xml)|*.xml";
                    openFileDialog.Title = "Seleccionar Archivo XML del Título";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        byte[] bytesXml = File.ReadAllBytes(openFileDialog.FileName);
                        string textoXml = Encoding.UTF8.GetString(bytesXml);
                        string resultadoBase64 = Convert.ToBase64String(bytesXml);

                        txtXml.Text = textoXml;      
                        txtBase64.Text = resultadoBase64; 

                        MessageBox.Show("Archivo XML cargado y codificado en Base64 con éxito.",
                                        "Codificación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar o codificar el archivo XML: " + ex.Message,
                                "Error Técnico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCopiarB64_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBase64.Text))
            {
                Clipboard.SetText(txtBase64.Text.Trim());
                MessageBox.Show("Código Base64 copiado al portapapeles.", "Copiado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No hay código Base64 generado para copiar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDecodificarXml_Click(object sender, EventArgs e)
        {
            string cadenaBase64Input = txtBase64.Text.Trim();

            if (string.IsNullOrWhiteSpace(cadenaBase64Input))
            {
                MessageBox.Show("Por favor, pega el código Base64 en el cuadro derecho para poder decodificarlo.",
                                "Falta Código", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                byte[] bytesXmlDecodificados = Convert.FromBase64String(cadenaBase64Input);
                txtXml.Text = Encoding.UTF8.GetString(bytesXmlDecodificados); // Muestra la vista previa del XML a la izquierda

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Archivos XML (*.xml)|*.xml";
                    saveFileDialog.Title = "Guardar Título Electrónico Decodificado";
                    saveFileDialog.FileName = "Titulo_DGP_Decodificado.xml";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllBytes(saveFileDialog.FileName, bytesXmlDecodificados);
                        MessageBox.Show("El archivo XML se ha decodificado y almacenado correctamente.",
                                        "Decodificación Completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("El texto proporcionado no es una cadena Base64 válida. Asegúrate de copiar el código completo.",
                                "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado al decodificar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBase64.Clear();
            txtXml.Clear();
        }
    }
}
