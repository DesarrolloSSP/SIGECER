using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using Sigecer.Clases;
using Sigecer.Logica;
using Sigecer.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sigecer
{// esta es la buena jhon
    public partial class Impresion_titulos : Form
    {
        DBCERCEISEntities ctx = new DBCERCEISEntities();
        public dataLog _dataLog { get; set; }
        string mensaje = string.Empty;
        public string login { get; set; }

        public Impresion_titulos()
        {
            InitializeComponent();
        }

        private void Impresion_titulos_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }

       //protected void llenarComboBusqeuda()
       // {

       //     cbBusqueda.Items.Clear();

       //     //incluir datos
       //     cbBusqueda.Items.Add(new  )
       // }
        void cargarGrid()
        {
            try
            {
                int num = 0;
                string mensaje = string.Empty;
                string texto = string.Empty;
                gvTitulos.AutoGenerateColumns = false;
                gvTitulos.DataSource = TitulosLogica.Instancia.Listar(out mensaje, texto);
                lblCantRe.Text = Convert.ToString(TitulosLogica.Instancia.ConteoRegistros(out num, texto));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void gvTitulos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 8)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.qr.Width;
                var h = Properties.Resources.qr.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.qr, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            if (e.ColumnIndex == 9)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.impresora.Width;
                var h = Properties.Resources.impresora.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.impresora, new Rectangle(x, y, w, h));
                e.Handled = true;
            }

            if (e.ColumnIndex == 10)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.RM.Width;
                var h = Properties.Resources.RM.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.RM, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void gvTitulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qrCode = new QrCode();
            int index = e.RowIndex;
            if (gvTitulos.Columns[e.ColumnIndex].Name == "btnQR")
            {
                if (index >= 0)
                {
                    dataTitulosEmi titulos = new dataTitulosEmi()
                    {
                        IdTitulo = Convert.ToInt32(gvTitulos.Rows[index].Cells["IdTitulo"].Value),
                        folio_electronico = Convert.ToString(gvTitulos.Rows[index].Cells["folio_electronico"].Value),

                    };

                    string url = "https://www.veracruz.gob.mx/seguridad/validacion-de-titulos-electronicos/";
                    qrEncoder.TryEncode(url, out qrCode);
                    GraphicsRenderer render = new GraphicsRenderer(new FixedCodeSize
                        (400, QuietZoneModules.Zero), Brushes.Black, Brushes.White);

                    MemoryStream ms = new MemoryStream();
                    render.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);
                    var ImageTemporal = new Bitmap(ms);
                    var imagen = new Bitmap(ImageTemporal, new Size(new Point(200, 200)));
                    Image img = imagen;
                    byte[] arr;
                    ImageConverter converter = new ImageConverter();
                    arr = (byte[])converter.ConvertTo(img, typeof(byte[]));

                    var _editarQr = ctx.tb_titulosEmitidos.Where(t => t.IdTitulo == titulos.IdTitulo).FirstOrDefault();
                    if (_editarQr != null)
                    {
                        _editarQr.qr = arr;
                        _editarQr.qrGenerado = true;
                        ctx.SaveChanges();
                        MessageBox.Show("Se genero QR con exito", "Gestión de titulos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        _dataLog = new dataLog();
                        _dataLog.usuario = string.Format("{0}", login);
                        _dataLog.Modulo = "IMPRIMIR TITULO";
                        _dataLog.Tipo = "QR";
                        _dataLog.Modificacion = "SE GENERA EL QR DEL TITULO CON EL ID: " + _editarQr.IdTitulo;
                        int InLog = Log.Instancia.LogInsert(_dataLog, out mensaje);
                    }
                }
            }
            if (gvTitulos.Columns[e.ColumnIndex].Name == "btnReporte")
            {
                string folio;
                int carrera;
                Guid Fol;
                folio = Convert.ToString(gvTitulos.Rows[index].Cells["folio_electronico"].Value);

                Fol =  Guid.Parse(folio);

                carrera = Convert.ToInt32(gvTitulos.Rows[index].Cells["IdCarrera"].Value);
                Reporte titulo = new Reporte(folio, carrera);
                titulo.ShowDialog();
                var feca_titulo = ctx.tb_titulosEmitidos.Where(t => t.folio_electronico == Fol).FirstOrDefault();
                if (feca_titulo != null)
                {
                    feca_titulo.FechaImpreasion = DateTime.Now;
                    ctx.SaveChanges();
                }

                _dataLog = new dataLog();
                _dataLog.usuario = string.Format("{0}", login);
                _dataLog.Modulo = "IMPRIMIR TITULO";
                _dataLog.Tipo = "IMP";
                _dataLog.Modificacion = "SE GENERA EL TITULO PARA IMPRESIÓN CON EL FOLIO: "+ folio;
                int InLog = Log.Instancia.LogInsert(_dataLog, out mensaje);
            }

            if (gvTitulos.Columns[e.ColumnIndex].Name == "btnQuitar")
            {
                int titulo;
                titulo = Convert.ToInt32(gvTitulos.Rows[index].Cells["IdTitulo"].Value);
                var _editarT = ctx.tb_titulosEmitidos.Where(t => t.IdTitulo == titulo).FirstOrDefault();
                if (_editarT != null)
                {
                    _editarT.status = false;
                    _editarT.qrGenerado = false;
                    _editarT.folio_electronico = null;
                    ctx.SaveChanges();
                    _dataLog = new dataLog();
                    _dataLog.usuario = string.Format("{0}", login);
                    _dataLog.Modulo = "IMPRIMIR TITULO";
                    _dataLog.Tipo = "DL";
                    _dataLog.Modificacion = "SE QUITA EL ALUMNO DE LOS TITULOS Y SE REGRESA A EDICIÓN CON EL ID: " + titulo;
                    int InLog = Log.Instancia.LogInsert(_dataLog, out mensaje);
                    cargarGrid();
                    //MessageBox.Show(Convert.ToString(titulo), "Gestión de titulos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            string mesaje = string.Empty;
            int num = 0;
            string NombreBuscar = txtBuscar.Text;


            if (NombreBuscar != "")
            {
                _dataLog = new dataLog();
                _dataLog.usuario = string.Format("{0}", login);
                _dataLog.Modulo = "IMPRIMIR TITULO";
                _dataLog.Tipo = "BUSQUEDA";
                _dataLog.Modificacion = "SE BUSCA AL ALUMNO: " + NombreBuscar;
                int InLog = Log.Instancia.LogInsert(_dataLog, out mensaje);

            }

            gvTitulos.AutoGenerateColumns = false;
            gvTitulos.DataSource = TitulosLogica.Instancia.Listar(out mensaje, NombreBuscar);
            lblCantRe.Text = Convert.ToString(TitulosLogica.Instancia.ConteoRegistros(out num, NombreBuscar));

        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
        }
    }
}
