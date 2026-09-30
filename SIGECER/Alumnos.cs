using Sigecer.Clases;
using Sigecer.Logica;
using Sigecer.Modelo;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using XSDToXML.Utils;

namespace Sigecer
{
    public partial class Alumnos : Form
    {
        #region Campos Privados
        private int _selectedIdTitulo;
        private DataTable _alumnosData;
        private bool _isLoading = false;
        private string _currentFilter = string.Empty;
        int id;
        string rutaxml = "";
        public string login { get; set; }
        public dataLog _dataLog { get; set; }
        string mensaje = string.Empty;
        #endregion
        public Alumnos()
        {
            InitializeComponent();
        }

        public void BuscaRuta()
        {
            try
            {
                using (DBCERCEISEntities ctx = new DBCERCEISEntities())
                {
                    tb_configuracion ruta = ctx.tb_configuracion.Where(x => x.idtconfiguracion == 1).First();
                    if (ruta != null)
                    {
                        string rutacer;
                        rutaxml = ruta.rutaxml.Trim().ToUpper();
                        //rutaxml = "C:\\.trash\\XMLCEIS";
                        rutacer = ruta.rutallaves.Trim().ToUpper();
                        //rutacer = "C:\\RHUERTAC\\FIEL_HUCR7906297U4_20220426133755";
                        if (!Directory.Exists(rutaxml))
                        {
                            MessageBox.Show("La carpeta destino de los archivos XML no existe.", "Validar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.Close();
                        }
                        if (!Directory.Exists(rutacer))
                        {
                            MessageBox.Show("La carpeta de los archivos llave no existe.", "Validar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        #region Eventos del Formulario
        private void Alumnos_Load(object sender, EventArgs e)
        {
            using (DBCERCEISEntities ctx = new DBCERCEISEntities())
            {
                var query = ctx.sel_alumnos().ToList();
                dgvAlumnos.DataSource = query;
                if (dgvAlumnos.Rows.Count != 0)
                {
                    dgvAlumnos.Rows[0].Selected = true;
                    DgvAlumnos_CellClick(dgvAlumnos, new DataGridViewCellEventArgs(0, 0));
                }


                else
                {
                    MessageBox.Show("No existen alumnos en la base de datos", "Gestión de titulos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
            }
            BuscaRuta();
            ValidaToken();
        }
        private void Alumnos_Shown(object sender, EventArgs e)
        {
            txtBuscar.Focus();
        }
        private void Alumnos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {
                txtBuscar.Focus();
                txtBuscar.SelectAll();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btnCancelar.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.F5)
            {
                RefreshData();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter && txtBuscar.Focused)
            {
                btnBuscar.PerformClick();
                e.Handled = true;
            }
        }

        #endregion

        public void BuscarAlum()
        {
            using (DBCERCEISEntities ctx = new DBCERCEISEntities())
            {
                var query = ctx.sel_alumnos().ToList();
                dgvAlumnos.DataSource = query;
                if (dgvAlumnos.Rows.Count != 0)
                {
                    dgvAlumnos.Rows[0].Selected = true;
                    DgvAlumnos_CellClick(dgvAlumnos, new DataGridViewCellEventArgs(0, 0));
                }

                else
                {
                    MessageBox.Show("No existen alumnos en la base de datos", "Gestión de titulos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
            }
        }

        public void ValidaToken()
        {
            try
            {
                var horaActual = DateTime.Now.ToString("HH:mm");
                var fechaActual = DateTime.Now.ToShortDateString();


                using (DBCERCEISEntities ctx = new DBCERCEISEntities())
                {
                    tb_token token = ctx.tb_token.Where(x => x.activo == true).FirstOrDefault();
                    if (token != null)
                    {
                        var fecha_token = Convert.ToString(token.fehcaExpira);

                        DateTime fecha_date = Convert.ToDateTime(fecha_token);
                        var f_token = fecha_date.ToString("dd/MM/yyyy");
                        var h_token = fecha_date.ToString("HH:mm");

                        TimeSpan r = TimeSpan.Parse(horaActual);
                        TimeSpan a = TimeSpan.Parse(h_token);


                        if (fechaActual == f_token && r <= a)
                        {
                            btnSellar.Enabled = true;
                        }
                        else
                        {
                            token.activo = false;
                            ctx.SaveChanges();
                            btnSellar.Enabled = false;
                            MessageBox.Show("El token ha caducado, generar nuevo token para el sellado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No existe token para generar el sellado de los certificados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        btnSellar.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSellarXML_Click(object sender, EventArgs e)
        {
            ValidaToken();
            int id = csValorCompartido.IdTitulo;
            MostrarDatos(/*id*/);
        }
        protected void MostrarDatos(/*int valor*/)
        {
            using (DBCERCEISEntities ctx = new DBCERCEISEntities())
            {
                var query = ctx.sp_selladoXML(_selectedIdTitulo).FirstOrDefault();
                string curp_ = query.curp.Trim();
                string CadenaOriginal;

                var Certificado = string.Empty;
                var Sello = string.Empty;
                //string strSello = string.Empty;
                var firma_key_private = string.Empty;
                //var firma_key_private = @"" + txtKey.Text.Trim();
                var firma_cer_public = string.Empty;
                //var firma_e = "capimora";

                var firma_e = "Mogolla79";

                tb_configuracion rutallaves = ctx.tb_configuracion.Where(x => x.idtconfiguracion == 1).First();
                if (rutallaves != null)
                {
                    //firma_key_private = @"" + rutallaves.rutallaves + "\\" + "llave_MOHA.key";
                    //firma_cer_public = @"" + rutallaves.rutallaves + "\\" + "cert_MOHA.cer";

                    //rutallaves.rutallaves = "C:\\RHUERTAC\\FIEL 2030";

                    firma_key_private = @"" + rutallaves.rutallaves + "\\" + "Claveprivada_FIEL_HUCR7906297U4_20260413_140136.key";
                    firma_cer_public = @"" + rutallaves.rutallaves + "\\" + "00001000000724000346.cer";
                }
                string fecha = "";
                if (query.ID_MODALIDAD_TITULACION == 1)
                {
                    fecha = query.fechaExamenProfesional.ToString().Substring(6, 4) + "-" + query.fechaExamenProfesional.ToString().Substring(3, 2) + "-" + query.fechaExamenProfesional.ToString().Substring(0, 2) + "|";
                }
                else
                {
                    fecha = "|" + query.fechaExencionExamenProfesional.ToString().Substring(6, 4) + "-" + query.fechaExencionExamenProfesional.ToString().Substring(3, 2) + "-" + query.fechaExencionExamenProfesional.ToString().Substring(0, 2);
                }

                CadenaOriginal = "||1.0|" + query.folioControl.Trim() + "|" + query.CURPAutorizante.Trim() + "|" + query.IdCargo.ToString().Trim() + "|" + query.CargoFirmante.Trim() +
                "|" + query.AbrebiaturaTitulo.Trim() + "|" + query.cveInstitucion.Trim() + "|" + query.nombreInstitucion.Trim() + "|" + query.CVE_CARRERA.Trim() + "|" + query.DESC_TITULO.Trim() + "|" + query.fechaInicio.ToString().Substring(6, 4) + "-" + query.fechaInicio.ToString().Substring(3, 2) + "-" + query.fechaInicio.ToString().Substring(0, 2) +
                "|" + query.fechaTerminacion.ToString().Substring(6, 4) + "-" + query.fechaTerminacion.ToString().Substring(3, 2) + "-" + query.fechaTerminacion.ToString().Substring(0, 2) +
                "|" + query.idAutoRec.ToString().Trim() + "|" + query.Autorizacion_reconocimiento.Trim() + "|" + query.numeroRvoe.Trim() + "|" + query.curp.Trim() + "|" + query.nombre.Trim() +
                "|" + query.primerApellido.Trim() + "|" + query.segundoApellido.Trim() + "|" + query.correoElectronico.Trim() + "|" + query.fechaExpedicion.ToString().Substring(6, 4) + "-" + query.fechaExpedicion.ToString().Substring(3, 2) + "-" + query.fechaExpedicion.ToString().Substring(0, 2) +
                "|" + query.ID_MODALIDAD_TITULACION.ToString().Trim() + "|" + query.Modo_titulacion.Trim() + "|" + fecha +
                "|" + query.cumplioServicioSocial.ToString().Trim() + "|" + query.ID_FUNDAMENTO_LEGAL_SERVICIO_SOCIAL.ToString().Trim() + "|" + query.Fundamento_legal.Trim() + "|" + query.idEntidad.ToString().Trim() +
                //"|" + query.NombreEnti.Trim() + "|" + query.institucionProcedencia.Trim() + "|" + query.IdTipo_estudio_antecedente.ToString().Trim() + "|" + query.tipo_estudio.Trim() + "|" + query.IdEntidadExp.ToString().Trim() + "|" + query.NombreEntiExp.Trim() + "|" + query.fechaInicioAnte.ToString().Substring(6, 4) + "-" + query.fechaInicioAnte.ToString().Substring(3, 2) + "-" + query.fechaInicioAnte.ToString().Substring(0, 2) +
                "|" + query.NombreEnti.Trim() + "|" + query.institucionProcedencia.Trim() + "|" + query.IdTipo_estudio_antecedente.ToString().Trim() + "|" + query.tipo_estudio.Trim() + "|" + query.IdEntExpCat.ToString().Trim() + "|" + query.NombreEntiExp.Trim() + "|" + query.fechaInicioAnte.ToString().Substring(6, 4) + "-" + query.fechaInicioAnte.ToString().Substring(3, 2) + "-" + query.fechaInicioAnte.ToString().Substring(0, 2) +
                "|" + query.fechaTerminacionAnte.ToString().Substring(6, 4) + "-" + query.fechaTerminacionAnte.ToString().Substring(3, 2) + "-" + query.fechaTerminacionAnte.ToString().Substring(0, 2) + "|" + query.noCedula.Trim() + "||";
                txtLog.Text = CadenaOriginal;

                //openssl_pkey_get_public
                SelloDigital oSelloDigital = new SelloDigital();
                //archivo cer
                Certificado = oSelloDigital.Certificado(firma_cer_public);

                //firma
                Sello = oSelloDigital.Sellar(CadenaOriginal, firma_key_private, firma_e);

                XmlSerializerNamespaces xmlNameSpace = new XmlSerializerNamespaces();
                xmlNameSpace.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");

                XmlDocument doc = new XmlDocument();
                XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                XmlElement root = doc.DocumentElement;
                doc.InsertBefore(xmlDeclaration, root);
                XmlElement Titulo = doc.CreateElement("TituloElectronico");
                Titulo.SetAttribute("xmlns", "https://www.siged.sep.gob.mx/titulos/");
                Titulo.SetAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
                Titulo.SetAttribute("version", "1.0");
                Titulo.SetAttribute("folioControl", query.folioControl.Trim());
                Titulo.SetAttribute("schemaLocation", "http://www.w3.org/2001/XMLSchema-instance", "https://www.siged.sep.gob.mx/titulos/ schema.xsd");
                doc.AppendChild(Titulo);
                ////Encabezado
                XmlElement firmares = doc.CreateElement("FirmaResponsables");
                Titulo.InsertAfter(firmares, Titulo.FirstChild);
                XmlElement FirmaResponsables = doc.CreateElement("FirmaResponsable");
                FirmaResponsables.SetAttribute("nombre", query.NombreAutorizado.Trim());
                FirmaResponsables.SetAttribute("primerApellido", query.APatenroAutorizado.Trim());
                FirmaResponsables.SetAttribute("segundoApellido", query.AMaternoAutorizado.Trim());
                FirmaResponsables.SetAttribute("curp", query.CURPAutorizante.Trim());
                FirmaResponsables.SetAttribute("idCargo", query.IdCargo.ToString().Trim());
                FirmaResponsables.SetAttribute("cargo", query.CargoFirmante.Trim());
                FirmaResponsables.SetAttribute("abrTitulo", query.AbrebiaturaTitulo.Trim());
                FirmaResponsables.SetAttribute("sello", Sello);
                FirmaResponsables.SetAttribute("certificadoResponsable", Certificado);
                FirmaResponsables.SetAttribute("noCertificadoResponsable", query.NumCertidicado.Trim());
                firmares.InsertAfter(FirmaResponsables, firmares.FirstChild);
                ////Institución
                XmlElement institucion = doc.CreateElement("Institucion");
                institucion.SetAttribute("cveInstitucion", query.cveInstitucion.Trim());
                institucion.SetAttribute("nombreInstitucion", query.nombreInstitucion.Trim());
                Titulo.InsertAfter(institucion, Titulo.LastChild);
                ////Carrera
                XmlElement carrera = doc.CreateElement("Carrera");
                carrera.SetAttribute("cveCarrera", query.CVE_CARRERA.Trim());
                carrera.SetAttribute("nombreCarrera", query.DESC_TITULO.Trim());
                carrera.SetAttribute("fechaInicio", query.fechaInicio.ToString().Substring(6, 4) + "-" + query.fechaInicio.ToString().Substring(3, 2) + "-" + query.fechaInicio.ToString().Substring(0, 2));
                carrera.SetAttribute("fechaTerminacion", query.fechaTerminacion.ToString().Substring(6, 4) + "-" + query.fechaTerminacion.ToString().Substring(3, 2) + "-" + query.fechaTerminacion.ToString().Substring(0, 2));
                carrera.SetAttribute("idAutorizacionReconocimiento", query.idAutoRec.ToString().Trim());
                carrera.SetAttribute("autorizacionReconocimiento", query.Autorizacion_reconocimiento.Trim());
                carrera.SetAttribute("numeroRvoe", query.numeroRvoe.Trim());
                Titulo.InsertAfter(carrera, Titulo.LastChild);
                ////Profesionista
                XmlElement profesionista = doc.CreateElement("Profesionista");
                profesionista.SetAttribute("curp", query.curp.Trim());
                profesionista.SetAttribute("nombre", query.nombre.Trim());
                profesionista.SetAttribute("primerApellido", query.primerApellido.Trim());
                profesionista.SetAttribute("segundoApellido", query.segundoApellido.Trim());
                profesionista.SetAttribute("correoElectronico", query.correoElectronico.Trim());
                Titulo.InsertAfter(profesionista, Titulo.LastChild);
                ////Expedicion
                XmlElement Expedicion = doc.CreateElement("Expedicion");
                Expedicion.SetAttribute("fechaExpedicion", query.fechaExpedicion.ToString().Substring(6, 4) + "-" + query.fechaExpedicion.ToString().Substring(3, 2) + "-" + query.fechaExpedicion.ToString().Substring(0, 2));
                Expedicion.SetAttribute("idModalidadTitulacion", query.ID_MODALIDAD_TITULACION.ToString().Trim());
                Expedicion.SetAttribute("modalidadTitulacion", query.Modo_titulacion.Trim());
                if (query.ID_MODALIDAD_TITULACION == 1)
                {
                    fecha = query.fechaExamenProfesional.ToString().Substring(6, 4) + "-" + query.fechaExamenProfesional.ToString().Substring(3, 2) + "-" + query.fechaExamenProfesional.ToString().Substring(0, 2) + "|";
                    Expedicion.SetAttribute("fechaExamenProfesional", fecha);
                    //Expedicion.SetAttribute("fechaExencionExamenProfesional", "");
                }
                else
                {
                    fecha = query.fechaExencionExamenProfesional.ToString().Substring(6, 4) + "-" + query.fechaExencionExamenProfesional.ToString().Substring(3, 2) + "-" + query.fechaExencionExamenProfesional.ToString().Substring(0, 2);
                    //Expedicion.SetAttribute("fechaExamenProfesional", "");
                    Expedicion.SetAttribute("fechaExencionExamenProfesional", fecha);
                }
                Expedicion.SetAttribute("cumplioServicioSocial", query.cumplioServicioSocial.ToString().Trim());
                Expedicion.SetAttribute("idFundamentoLegalServicioSocial", query.ID_FUNDAMENTO_LEGAL_SERVICIO_SOCIAL.ToString().Trim());
                Expedicion.SetAttribute("fundamentoLegalServicioSocial", query.Fundamento_legal.Trim());
                Expedicion.SetAttribute("idEntidadFederativa", query.idEntidad.ToString().Trim());
                Expedicion.SetAttribute("entidadFederativa", query.NombreEnti.Trim());
                Titulo.InsertAfter(Expedicion, Titulo.LastChild);
                ////Antecedente
                XmlElement Antecedente = doc.CreateElement("Antecedente");
                Antecedente.SetAttribute("institucionProcedencia", query.institucionProcedencia.Trim());
                Antecedente.SetAttribute("idTipoEstudioAntecedente", query.IdTipo_estudio_antecedente.ToString().Trim());
                Antecedente.SetAttribute("tipoEstudioAntecedente", query.tipo_estudio.Trim());
                //Antecedente.SetAttribute("idEntidadFederativa", query.IdEntidadExp.ToString().Trim());
                Antecedente.SetAttribute("idEntidadFederativa", query.IdEntExpCat.ToString().Trim());
                Antecedente.SetAttribute("entidadFederativa", query.NombreEntiExp.Trim());
                Antecedente.SetAttribute("fechaInicio", query.fechaInicioAnte.ToString().Substring(6, 4) + "-" + query.fechaInicioAnte.ToString().Substring(3, 2) + "-" + query.fechaInicioAnte.ToString().Substring(0, 2));
                Antecedente.SetAttribute("fechaTerminacion", query.fechaTerminacionAnte.ToString().Substring(6, 4) + "-" + query.fechaTerminacionAnte.ToString().Substring(3, 2) + "-" + query.fechaTerminacionAnte.ToString().Substring(0, 2));
                Antecedente.SetAttribute("noCedula", query.noCedula.Trim());
                Titulo.InsertAfter(Antecedente, Titulo.LastChild);
                //string sss = @"C:\\Users\\CPONCEM\\DESKTOP\\TITULOS ELECTRONICOS";
                //doc.Save(sss + "\\" + query.curp.Trim() + ".xml");
                doc.Save(rutaxml + "\\" + query.curp.Trim() + ".xml");
                MessageBox.Show("Se generó archivo XML de manera satisfactoria", "Gestión de titulos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var _actualizarTitulos = ctx.tb_titulosEmitidos.Where(a => a.IdTitulo == _selectedIdTitulo).FirstOrDefault();
                if (_actualizarTitulos != null)
                {
                    _actualizarTitulos.status = true;
                    _actualizarTitulos.fecha_gen = DateTime.Now;
                    _actualizarTitulos.sello = Sello;
                    _actualizarTitulos.firma = Certificado;
                    _actualizarTitulos.folio_electronico = Guid.NewGuid();
                    ctx.SaveChanges();
                }
                BuscarAlum();

                _dataLog = new dataLog
                {
                    usuario = string.Format("{0}", login),
                    Modulo = "VISTA DE ALUMNOS",
                    Tipo = "XML",
                    Modificacion = "SE GENERA EL XML DEL ALUMNO: " + _selectedIdTitulo
                };
                int InLog = Log.Instancia.LogInsert(_dataLog, out mensaje);
            }
        }

        #region Eventos del DataGridView
        private void DgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvAlumnos.Rows.Count > 0)
            {
                SelectAlumno(e.RowIndex);
            }
        }
        private void DgvAlumnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                OpenEditForm();
            }
        }

        private void SelectAlumno(int rowIndex)
        {
            try
            {
                if (rowIndex < 0 || rowIndex >= dgvAlumnos.Rows.Count)
                    return;

                // Limpiar selección anterior
                dgvAlumnos.ClearSelection();

                // Seleccionar la fila
                dgvAlumnos.Rows[rowIndex].Selected = true;

                // Establecer CurrentCell en la primera columna visible
                // Usamos LINQ para encontrar la primera columna visible
                var primeraColumnaVisible = dgvAlumnos.Columns
                    .Cast<DataGridViewColumn>()
                    .FirstOrDefault(c => c.Visible);

                if (primeraColumnaVisible != null)
                {
                    dgvAlumnos.CurrentCell = dgvAlumnos.Rows[rowIndex].Cells[primeraColumnaVisible.Index];
                }

                // Hacer scroll a la fila seleccionada
                if (rowIndex >= 0)
                {
                    dgvAlumnos.FirstDisplayedScrollingRowIndex = rowIndex;
                }

                // Obtener el ID de la columna oculta
                var idCell = dgvAlumnos.Rows[rowIndex].Cells["colIdTitulo"];
                if (idCell?.Value != null && idCell.Value != DBNull.Value)
                {
                    _selectedIdTitulo = Convert.ToInt32(idCell.Value);
                }
                else
                {
                    _selectedIdTitulo = -1;
                }
            }
            catch (Exception ex)
            {
                ShowError("Error al seleccionar el registro del alumno.", ex);
            }
        }

        #endregion

        #region Acciones CRUD

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void OpenEditForm()
        {
            try
            {
                NuevoAlumno editForm = new NuevoAlumno(_selectedIdTitulo);
                editForm.user = this.login;
                editForm.ShowDialog(this);
                RefreshData();
            }
            catch (Exception ex)
            {
                ShowError("Error al abrir el formulario de edición", ex);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion

        #region Búsqueda

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ApplyFilter(txtBuscar.Text.Trim());
        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnBuscar.PerformClick();
                e.Handled = true;
            }
        }

        private void ApplyFilter(string filterText)
        {
            try
            {
                _currentFilter = filterText;

                if (_alumnosData != null)
                {
                    if (string.IsNullOrEmpty(filterText))
                    {
                        _alumnosData.DefaultView.RowFilter = string.Empty;
                    }
                    else
                    {
                        string safeFilter = filterText.Replace("'", "''");
                        string filter = string.Format(
                            "nombre LIKE '%{0}%' OR primerApellido LIKE '%{0}%' OR " +
                            "segundoApellido LIKE '%{0}%' OR curp LIKE '%{0}%' OR " +
                            "desc_titulo LIKE '%{0}%'",
                            safeFilter);
                        _alumnosData.DefaultView.RowFilter = filter;
                    }

                    int count = _alumnosData.DefaultView.Count;
                    UpdateRowCount(count);
                }
            }
            catch (Exception ex)
            {
                ShowError("Error al aplicar el filtro", ex);
            }
        }

        #endregion
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            int idtitulo = csValorCompartido.IdTitulo;
            //Form Modificar = new NuevoAlumno(idtitulo);
            NuevoAlumno Modificar = new NuevoAlumno(idtitulo);
            Modificar.user = string.Format("{0}", login);
            Modificar.ShowDialog();
            //    RecuperaDatos(id);
        }

        private void DgvAlumnos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvAlumnos.Rows[e.RowIndex].Cells[0].Value);
        }

        #region Carga de Datos

        private void LoadAlumnosData()
        {
            try
            {
                using (var ctx = new DBCERCEISEntities())
                {
                    var query = ctx.sel_alumnos().ToList();

                    if (query == null || query.Count == 0)
                    {
                        ShowWarning("No existen alumnos en la base de datos");
                        this.Close();
                        return;
                    }

                    // Convertir a DataTable
                    _alumnosData = new DataTable();
                    _alumnosData.Columns.Add("IdTitulo", typeof(int));
                    _alumnosData.Columns.Add("folio_electronico", typeof(string));
                    _alumnosData.Columns.Add("curp", typeof(string));
                    _alumnosData.Columns.Add("nombre", typeof(string));
                    _alumnosData.Columns.Add("primerApellido", typeof(string));
                    _alumnosData.Columns.Add("segundoApellido", typeof(string));
                    _alumnosData.Columns.Add("desc_titulo", typeof(string));
                    _alumnosData.Columns.Add("estatus", typeof(string));

                    foreach (var item in query)
                    {
                        _alumnosData.Rows.Add(
                            item.IdTitulo,
                            item.folio_electronico,
                            item.curp,
                            item.nombre,
                            item.primerapellido,
                            item.segundoapellido,
                            item.DESC_TITULO,
                            "Activo" 
                        );
                    }

                    dgvAlumnos.DataSource = _alumnosData;

                    // Seleccionar primer registro
                    if (dgvAlumnos.Rows.Count > 0)
                    {
                        dgvAlumnos.Rows[0].Selected = true;
                        SelectAlumno(0);
                    }

                    UpdateRowCount(_alumnosData.Rows.Count);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar los datos de alumnos", ex);
            }
        }
        private void RefreshData()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                LoadAlumnosData();
                UpdateStatus("Datos actualizados correctamente");
                ShowInfo("Datos actualizados correctamente");
            }
            catch (Exception ex)
            {
                ShowError("Error al actualizar los datos", ex);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        #endregion

        #region Métodos UI

        private void UpdateStatus(string message)
        {
            this.Text = $"🎓 Gestión de Alumnos - {message}";
        }

        private void UpdateRowCount(int count)
        {
            lblRegistros.Text = $"📊 Total de registros: {count}";
        }

        private void ShowError(string message, Exception ex = null)
        {
            string errorMsg = message;
            if (ex != null)
            {
                errorMsg += $"\n\nDetalle: {ex.Message}";
                if (ex.InnerException != null)
                    errorMsg += $"\nInner: {ex.InnerException.Message}";
            }

            MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowWarning(string message)
        {
            MessageBox.Show(message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ShowInfo(string message)
        {
            MessageBox.Show(message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion
    }
}
