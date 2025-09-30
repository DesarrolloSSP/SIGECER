using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using Sigecer.Modelo;
using XSDToXML.Utils;
using System.Xml.Schema;
using System.Xml.Serialization;
using Sigecer.Clases;
using Sigecer.Logica;

namespace Sigecer
{
    public partial class Alumnos : Form
    {
        int id;
        string rutaxml = "";
        public string login { get; set; }
        public dataLog _dataLog { get; set; }
        string mensaje = string.Empty;
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
                        rutacer = ruta.rutallaves.Trim().ToUpper();
                        if (!Directory.Exists(rutaxml))
                        {
                            MessageBox.Show("La carpeta destino de los XML no ya existe. Favor de validar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.Close();
                        }
                        if (!Directory.Exists(rutacer))
                        {
                            MessageBox.Show("La carpeta de los archivos llave no ya existe. Favor de validar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void Alumnos_Load(object sender, EventArgs e)
        {
            using (DBCERCEISEntities ctx = new DBCERCEISEntities())
            {
                var query = ctx.sel_alumnos().ToList();
                dgv_alumnos.DataSource = query;
                if (dgv_alumnos.Rows.Count != 0)
                {
                    dgv_alumnos.Rows[0].Selected = true;
                    Dgv_alumnos_CellClick(dgv_alumnos, new DataGridViewCellEventArgs(0, 0));
                }


                else
                {
                    MessageBox.Show("No existen alumnos en la base de datos", "Gestión de titulos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
            }
            BuscaRuta();
            validaToken();
        }

        public void buscarAlum()
        {
            using (DBCERCEISEntities ctx = new DBCERCEISEntities())
            {
                var query = ctx.sel_alumnos().ToList();
                dgv_alumnos.DataSource = query;
                if (dgv_alumnos.Rows.Count != 0)
                {
                    dgv_alumnos.Rows[0].Selected = true;
                    Dgv_alumnos_CellClick(dgv_alumnos, new DataGridViewCellEventArgs(0, 0));
                }


                else
                {
                    MessageBox.Show("No existen alumnos en la base de datos", "Gestión de titulos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
            }
        }

        public void validaToken()
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
                            Btn_xml.Enabled = true;
                        }
                        else
                        {
                            token.activo = false;
                            ctx.SaveChanges();
                            Btn_xml.Enabled = false;
                            MessageBox.Show("El token a caducado, generar nuevo token para el sellado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No existe token para generar el sellado de los certificados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Btn_xml.Enabled = false;
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

        private void Btn_xml_Click(object sender, EventArgs e)
        {
            validaToken();
            int id = csValorCompartido.IdTitulo;
            MostrarDatos(id);
        }

        protected void MostrarDatos(int valor)
        {
            using (DBCERCEISEntities ctx = new DBCERCEISEntities())
            {
               
                var query = ctx.sp_selladoXML(valor).FirstOrDefault();
                string curp_ = query.curp;
                string CadenaOriginal;

                var Certificado = string.Empty;
                var Sello = string.Empty;
                //string strSello = string.Empty;
                var firma_key_private = string.Empty;
                //var firma_key_private = @"" + txtKey.Text.Trim();
                var firma_cer_public = string.Empty;
                var firma_e = "capimora";

                tb_configuracion rutallaves = ctx.tb_configuracion.Where(x => x.idtconfiguracion == 1).First();
                if (rutallaves != null)
                {
                    firma_key_private = @"" + rutallaves.rutallaves + "\\" + "llave_MOHA.key";
                    firma_cer_public = @"" + rutallaves.rutallaves + "\\" + "cert_MOHA.cer";
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
                textBox1.Text = CadenaOriginal;

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
                MessageBox.Show("Se genero archivo XML de manera satisfactoria", "Gestión de titulos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var _actualizarTitulos = ctx.tb_titulosEmitidos.Where(a => a.IdTitulo == valor).FirstOrDefault();
                if (_actualizarTitulos != null)
                {
                    _actualizarTitulos.status = true;
                    _actualizarTitulos.fecha_gen = DateTime.Now;
                    _actualizarTitulos.sello = Sello;
                    _actualizarTitulos.firma = Certificado;
                    _actualizarTitulos.folio_electronico = Guid.NewGuid();
                    ctx.SaveChanges();
                }
                buscarAlum();

                _dataLog = new dataLog();
                _dataLog.usuario = string.Format("{0}", login);
                _dataLog.Modulo = "VISTA DE ALUMNOS";
                _dataLog.Tipo = "XML";
                _dataLog.Modificacion = "SE GENERA EL XML DEL ALUMNO: " + valor;
                int InLog = Log.Instancia.LogInsert(_dataLog, out mensaje);
            }
        }

        private void Dgv_alumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_alumnos.Rows.Count != 0)
            {
                try
                {
                    dgv_alumnos.CurrentRow.Selected = true;
                    int idSolicitud = int.Parse(dgv_alumnos.Rows[e.RowIndex].Cells["IdTitulo"].Value.ToString());
                    //Guid guidSello = Guid.Parse(dgv_alumnos.Rows[e.RowIndex].Cells["folio_electronico"].Value.ToString());
                    csValorCompartido.IdTitulo = idSolicitud;
                    //csValorCompartido.Guid = guidSello;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
            {
                MessageBox.Show("No existen alumnos en la base de datos", "Gestión de titulos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idtitulo = csValorCompartido.IdTitulo;
            //Form Modificar = new NuevoAlumno(idtitulo);
            NuevoAlumno Modificar = new NuevoAlumno(idtitulo);
            Modificar.user = string.Format("{0}", login);
            Modificar.ShowDialog();
            //    RecuperaDatos(id);
        }

        private void dgv_alumnos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgv_alumnos.Rows[e.RowIndex].Cells[0].Value);
        }
    }
}
