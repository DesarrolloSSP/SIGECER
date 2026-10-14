using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
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

        private void btnDecodificar_Click(object sender, EventArgs e)
        {
            string cadenaBase64Input = txtBase64.Text.Trim();

            if (string.IsNullOrWhiteSpace(cadenaBase64Input))
            {
                MessageBox.Show("Por favor, pega el código Base64 en el cuadro para poder decodificarlo.",
                                "Falta Código", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cadenaBase64Input.Contains(","))
            {
                cadenaBase64Input = cadenaBase64Input.Substring(cadenaBase64Input.IndexOf(",") + 1);
            }

            try
            {
                //  Convertir Base64 a bytes 
                byte[] zipBytes = Convert.FromBase64String(cadenaBase64Input);
                byte[] bytesExcelReal = null;
                string nombreArchivoInterno = "ResultadoCargaTitulos.xls"; 

                //  Descomprimir el ZIP 
                using (MemoryStream ms = new MemoryStream(zipBytes))
                using (ZipArchive archive = new ZipArchive(ms, ZipArchiveMode.Read))
                {
                  
                    if (archive.Entries.Count > 0)
                    {
                        ZipArchiveEntry entry = System.Linq.Enumerable.ElementAt(archive.Entries, 0);
                        nombreArchivoInterno = entry.Name; 

                        using (MemoryStream outputStream = new MemoryStream())
                        {
                            using (Stream zipStream = entry.Open())
                            {
                                zipStream.CopyTo(outputStream);
                            }
                            bytesExcelReal = outputStream.ToArray(); 
                        }
                    }
                }

                if (bytesExcelReal == null)
                {
                    MessageBox.Show("El código Base64 no contiene ningún archivo válido por dentro.", "Archivo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // guarda datos extraídos
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Archivos de Excel 97-2003 (*.xls)|*.xls|Todos los archivos (*.*)|*.*";
                    saveFileDialog.Title = "Guardar Reporte de Títulos Decodificado";
                    saveFileDialog.FileName = nombreArchivoInterno; 
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // 4. Guardar los bytes del Excel
                        File.WriteAllBytes(saveFileDialog.FileName, bytesExcelReal);

                        MessageBox.Show("¡Archivo extraído y guardado con éxito sin corrupciones!",
                                        "Decodificación Completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("El texto proporcionado no es una cadena Base64 válida.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al descomprimir o guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBase64.Clear();
            txtXml.Clear();
        }

        private void FrmB64_XML_Load(object sender, EventArgs e)
        {

        }
    }
}
