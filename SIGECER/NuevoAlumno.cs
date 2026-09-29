using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sigecer.Clases;
using Sigecer.Logica;
using Sigecer.Modelo;

namespace Sigecer
{
    public partial class NuevoAlumno : Form
    {
        public string login { get; set; }
        public string user { get; set; }
        public dataLog _dataLog { get; set; }
        string mensaje = string.Empty;
        public NuevoAlumno(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        int id;
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            switch (TbAlumno.SelectedIndex)
            {
                case 0:
                    TbAlumno.SelectedTab = TbAlumno.TabPages["tpPlan"];
                    btnSiguiente.Text = "Siguiente";
                    break;
                case 1:
                    TbAlumno.SelectedTab = TbAlumno.TabPages["tbAntecedentes"];
                    btnSiguiente.Text = "Siguiente";
                    break;
                case 2:
                    TbAlumno.SelectedTab = TbAlumno.TabPages["tbExpe"];
                    btnSiguiente.Text = "Guardar";
                    break;
                case 3:
                    GuardaAlumno();
                    break;
            }
        }

        private void TbAlumno_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TbAlumno.SelectedIndex)
            {
                case 0:
                    btnSiguiente.Text = "Siguiente";
                    tbnombre.Focus();
                    Enabled = true;
                    break;
                case 1:
                    btnSiguiente.Text = "Siguiente";
                    cbcarrera.Focus();
                    Enabled = true;
                    break;
                case 2:
                    btnSiguiente.Text = "Siguiente";
                    tbinsproc.Focus();
                    Enabled = true;
                    break;
                case 3:
                    btnSiguiente.Text = "Guardar";
                    dtpfaut.Focus();
                    Enabled = true;
                    break;
            }
        }

        private void NuevoAlumno_Load(object sender, EventArgs e)
        {
            TbAlumno.Focus();
            TbAlumno.SelectedIndex = 0;
            tbnombre.Select();
            CargaFunSersol();
            CargaAutorizacion();
            CargaCarreras();
            CargaAntecedente();
            CargaEntidad();
            CargaModalidad();
            rbcs.Checked = true;
            if (id != 0)
            {
                RecuperaDatos(id);
            }
        }

        public void RecuperaDatos(int id)
        {
            try
            {
                using (DBCERCEISEntities ctx = new DBCERCEISEntities())
                {
                    tb_titulosEmitidos titulo = ctx.tb_titulosEmitidos.Where(x => x.IdTitulo == id).First();
                    if (titulo != null)
                    {
                        tbnombre.Text = titulo.nombre.Trim();
                        tbapemat.Text = titulo.segundoApellido.Trim();
                        tbapepat.Text = titulo.primerApellido.Trim();
                        tbcurp.Text = titulo.curp.Trim();
                        tbemail.Text = titulo.correoElectronico.Trim();
                        tbmatricula.Text = titulo.folioControl.Trim();
                        cbcarrera.SelectedValue = titulo.IdCarrera;
                        dtpfipe.Value = Convert.ToDateTime(titulo.fechaInicio);
                        dtpffpe.Value = Convert.ToDateTime(titulo.fechaTerminacion);
                        cbautope.SelectedValue = titulo.idAutoRec;
                        tbinsproc.Text = titulo.institucionProcedencia.Trim();
                        cbtipestant.SelectedValue = titulo.idEstAntecedente;
                        cbefant.SelectedValue = titulo.idEntidadExpe;
                        dtpfiant.Value = Convert.ToDateTime(titulo.fechaInicioAnte);
                        dtpffant.Value = Convert.ToDateTime(titulo.fechaTerminacionAnte);
                        tbcedprof.Text = titulo.noCedula.Trim();
                        dtpfaut.Value = Convert.ToDateTime(titulo.fechaExpedicion);
                        cbmodtit.SelectedValue = titulo.idModTitu;
                        cbfunss.SelectedValue = titulo.idFundamento;
                        cbefant.SelectedValue = titulo.idEntidadAnte;
                        if (titulo.idModTitu == 1)
                        {
                            dtpfexa.Value = Convert.ToDateTime(titulo.fechaExamenProfesional);
                        }
                        else
                        {
                            dtpfexa.Value = Convert.ToDateTime(titulo.fechaExencionExamenProfesional);
                        }
                        if (titulo.cumplioServicioSocial == 1)
                        {
                            rbcs.Checked = true;
                        }
                        else
                        {
                            rbss.Checked = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }


        protected void GuardaAlumno()
        {
            try
            {

                if (ValidaDatos())
                {
                    using (DBCERCEISEntities ctx = new DBCERCEISEntities())
                    {
                        DateTime? dtfep = null;
                        DateTime? dtfee = null;
                        if (Convert.ToInt32(cbmodtit.SelectedValue) == 1)
                        {
                            dtfep = dtpfexa.Value;
                        }
                        else
                        {
                            dtfee = dtpfexa.Value; ;
                        }
                        int ss;
                        if (rbcs.Checked)
                        {
                            ss = 1;
                        }
                        else
                        {
                            ss = 0;
                        }
                        if (this.id == 0)
                        {
                            tb_titulosEmitidos titulo = new tb_titulosEmitidos()
                            {
                                folioControl = tbmatricula.Text.Trim(),
                                IdInstitucion = 1,
                                IdAutorizante = 1,
                                idEncargado = 12,
                                IdCarrera = Convert.ToInt32(cbcarrera.SelectedValue.ToString()),
                                fechaInicio = dtpfipe.Value,
                                fechaTerminacion = dtpffpe.Value,
                                idAutoRec = Convert.ToInt32(cbautope.SelectedValue.ToString()),
                                numeroRvoe = "",
                                curp = tbcurp.Text.Trim(),
                                nombre = tbnombre.Text.Trim(),
                                primerApellido = tbapepat.Text.Trim(),
                                segundoApellido = tbapemat.Text.Trim(),
                                correoElectronico = tbemail.Text.Trim(),
                                fechaExpedicion = dtpfaut.Value,
                                idModTitu = Convert.ToInt32(cbmodtit.SelectedValue.ToString()),
                                fechaExamenProfesional = dtfep,
                                fechaExencionExamenProfesional = dtfee,
                                cumplioServicioSocial = ss,
                                idFundamento = Convert.ToInt32(cbfunss.SelectedValue.ToString()),
                                idEntidadExpe = 30,
                                institucionProcedencia = tbinsproc.Text.Trim(),
                                idEstAntecedente = Convert.ToInt32(cbtipestant.SelectedValue.ToString()),
                                idEntidadAnte = Convert.ToInt32(cbefant.SelectedValue.ToString()),
                                fechaInicioAnte = dtpfiant.Value,
                                fechaTerminacionAnte = dtpffant.Value,
                                noCedula = tbcedprof.Text.Trim(),
                                status = false
                            };
                            ctx.tb_titulosEmitidos.Add(titulo);
                            ctx.SaveChanges();
                            _dataLog = new dataLog
                            {
                                usuario = string.Format("{0}", login),
                                Modulo = "INGRESAR NUEVO ALUMNO",
                                Tipo = "INSERT",
                                Modificacion = "SE HA CREADO UN NUEVO ALUMNO CON ID: " + titulo.IdTitulo
                            };
                            int InLog = Log.Instancia.LogInsert(_dataLog, out mensaje);
                            MessageBox.Show("El alumno fué grabado existosamente", "Gestión de títulos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            tb_titulosEmitidos titulo = ctx.tb_titulosEmitidos.Where(x => x.IdTitulo == this.id).First();
                            if (titulo != null)
                            {
                                titulo.nombre = tbnombre.Text.Trim();
                                titulo.segundoApellido = tbapemat.Text.Trim();
                                titulo.primerApellido = tbapepat.Text.Trim();
                                titulo.curp = tbcurp.Text.Trim();
                                titulo.correoElectronico = tbemail.Text.Trim();
                                titulo.folioControl = tbmatricula.Text.Trim();
                                titulo.IdCarrera = Convert.ToInt32(cbcarrera.SelectedValue);
                                titulo.fechaInicio = dtpfipe.Value;
                                titulo.fechaTerminacion = dtpffpe.Value;
                                titulo.idAutoRec = Convert.ToInt32(cbautope.SelectedValue);
                                titulo.institucionProcedencia = tbinsproc.Text.Trim();
                                titulo.idEstAntecedente = Convert.ToInt32(cbtipestant.SelectedValue);
                                titulo.idEntidadExpe = 30;
                                titulo.fechaInicioAnte = dtpfiant.Value;
                                titulo.fechaTerminacionAnte = dtpffant.Value;
                                titulo.noCedula = tbcedprof.Text.Trim();
                                titulo.fechaExpedicion = dtpfaut.Value;
                                titulo.idModTitu = Convert.ToInt32(cbmodtit.SelectedValue);
                                titulo.fechaExamenProfesional = dtfep;
                                titulo.fechaExencionExamenProfesional = dtfee;
                                titulo.idFundamento = Convert.ToInt32(cbfunss.SelectedValue.ToString());
                                titulo.cumplioServicioSocial = ss;
                                titulo.idEntidadAnte = Convert.ToInt32(cbefant.SelectedValue.ToString());
                                ctx.SaveChanges();
                                _dataLog = new dataLog();
                                _dataLog.usuario = string.Format("{0}", login);
                                _dataLog.Modulo = "INGRESAR NUEVO ALUMNO";
                                _dataLog.Tipo = "UPDATE";
                                _dataLog.Modificacion = "SE HA MODIFICADO EL ALUMNO CON ID: " + titulo.IdTitulo;
                                int InLog = Log.Instancia.LogInsert(_dataLog, out mensaje);
                                MessageBox.Show("El alumno fue actualizado existosamente", "Gestión de títulos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }



        protected void CargaFunSersol()
        {
            try
            {
                using (DBCERCEISEntities ctx = new DBCERCEISEntities())
                {
                    var query = ctx.cat_FundamentoLegal.ToList();
                    cbfunss.DataSource = query;
                    cbfunss.DisplayMember = "Fundamento_legal";
                    cbfunss.ValueMember = "idFundamento";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        protected void CargaAutorizacion()
        {
            try
            {
                using (DBCERCEISEntities ctx = new DBCERCEISEntities())
                {
                    var query = ctx.cat_AutoReconocimiento.ToList();
                    cbautope.DataSource = query;
                    cbautope.DisplayMember = "Autorizacion_reconocimiento";
                    cbautope.ValueMember = "idAutoRec";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        protected void CargaCarreras()
        {
            try
            {
                using (DBCERCEISEntities ctx = new DBCERCEISEntities())
                {
                    var query = ctx.tb_Carreras.ToList();
                    cbcarrera.DataSource = query;
                    cbcarrera.DisplayMember = "DESC_TITULO";
                    cbcarrera.ValueMember = "IdCarrera";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        protected void CargaAntecedente()
        {
            try
            {
                using (DBCERCEISEntities ctx = new DBCERCEISEntities())
                {
                    var query = ctx.cat_EstudioAntecedente.ToList();
                    cbtipestant.DataSource = query;
                    cbtipestant.DisplayMember = "tipo_estudio";
                    cbtipestant.ValueMember = "idEstAntecedente";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        protected void CargaEntidad()
        {
            try
            {
                using (DBCERCEISEntities ctx = new DBCERCEISEntities())
                {
                    var query = ctx.cat_entidadesFederativas.ToList();
                    cbefant.DataSource = query;
                    cbefant.DisplayMember = "NombreEnti";
                    cbefant.ValueMember = "idEntidad";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        protected void CargaModalidad()
        {
            try
            {
                using (DBCERCEISEntities ctx = new DBCERCEISEntities())
                {
                    var query = ctx.cat_ModalidadTitulacion.ToList();
                    cbmodtit.DataSource = query;
                    cbmodtit.DisplayMember = "Modo_titulacion";
                    cbmodtit.ValueMember = "IdModTitu";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

    

        public bool ValidaDatos()
        {

            // Validar Cajas de Texto Básicas
            if (string.IsNullOrWhiteSpace(tbmatricula.Text)) return MostrarError("El campo Matrícula/Folio Control es obligatorio.", tbmatricula);
            if (string.IsNullOrWhiteSpace(tbnombre.Text)) return MostrarError("El campo Nombre es obligatorio.", tbnombre);

            // VALIDACIÓN DE APELLIDOS: Al menos uno debe estar lleno
            bool tienePrimerApellido = !string.IsNullOrWhiteSpace(tbapepat.Text);
            bool tieneSegundoApellido = !string.IsNullOrWhiteSpace(tbapemat.Text);

            if (!tienePrimerApellido && !tieneSegundoApellido)
            {
                return MostrarError("El alumno debe contar con al menos un apellido (Primer o Segundo Apellido).", tbapepat);
            }

            // Continuación de Cajas de Texto
            if (string.IsNullOrWhiteSpace(tbcurp.Text)) return MostrarError("El campo CURP es obligatorio.", tbcurp);
            if (string.IsNullOrWhiteSpace(tbemail.Text)) return MostrarError("El Correo Electrónico es obligatorio.", tbemail);
            if (string.IsNullOrWhiteSpace(tbinsproc.Text)) return MostrarError("La Institución de Procedencia es obligatoria.", tbinsproc);

            // Validar ComboBoxes
            if (cbcarrera.SelectedValue == null || Convert.ToInt32(cbcarrera.SelectedValue) <= 0)
                return MostrarError("Debe seleccionar una Carrera válida.", cbcarrera);

            if (cbautope.SelectedValue == null || Convert.ToInt32(cbautope.SelectedValue) <= 0)
                return MostrarError("Debe seleccionar la Autorización del plan de estudios.", cbautope);

            if (cbmodtit.SelectedValue == null || Convert.ToInt32(cbmodtit.SelectedValue) <= 0)
                return MostrarError("Debe seleccionar una Modalidad de Titulación.", cbmodtit);

            if (cbfunss.SelectedValue == null || Convert.ToInt32(cbfunss.SelectedValue) <= 0)
                return MostrarError("Debe seleccionar el Fundamento de Servicio Social.", cbfunss);

            if (cbtipestant.SelectedValue == null || Convert.ToInt32(cbtipestant.SelectedValue) <= 0)
                return MostrarError("Debe seleccionar el Tipo de Estudio Antecedente.", cbtipestant);

            if (cbefant.SelectedValue == null || Convert.ToInt32(cbefant.SelectedValue) <= 0)
                return MostrarError("Debe seleccionar la Entidad Federativa Antecedente.", cbefant);

            return true;
        }

        private bool MostrarError(string mensajeError, Control controlInvalido)
        {
            MessageBox.Show(mensajeError, "Validación de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            controlInvalido.Focus();
            return false;


            ///----CODIGO ANTERIOR-- 
            //bool x = true;



            //if (string.IsNullOrWhiteSpace(tbnombre.Text))
            //{
            //    tbnombre.Focus();
            //    MessageBox.Show("El nombre no puede ser vacio", "Validación de alumno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    x = false;
            //}

            ////if (string.IsNullOrWhiteSpace(tbapepat.Text))
            ////{
            ////    //e.Cancel = true;
            ////    tbapepat.Focus();
            ////    //errorProvider1.SetError(tbapepat, "El Apellido Paterno no puede ser vacio");
            ////    MessageBox.Show("El Apellido Paterno no puede ser vacio", "Validación de alumno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ////    x = false;
            ////}
            //if (string.IsNullOrWhiteSpace(tbcurp.Text))
            //{
            //    tbapemat.Focus();
            //    MessageBox.Show("La CURP no puede ser vacio", "Validación de alumno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    x = false;
            //}
            //if (string.IsNullOrWhiteSpace(tbmatricula.Text))
            //{
            //    tbmatricula.Focus();
            //    MessageBox.Show("El folio no puede ser vacio", "Validación de alumno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    x = false;
            //}
            //if (string.IsNullOrWhiteSpace(tbinsproc.Text))
            //{
            //    MessageBox.Show("La institución de procedencia no puede ser vacio", "Validación de alumno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    x = false;
            //}
            //if ((cbtipestant.SelectedIndex == 0 || cbtipestant.SelectedIndex == 1) && (string.IsNullOrWhiteSpace(tbcedprof.Text)))
            //{
            //    MessageBox.Show("La cédula no puede no puede ser vacio", "Validación de alumno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    x = false;
            //}
            //return x;
        }

        private void Tbinsproc_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbinsproc.Text))
            {
                e.Cancel = true;
                tbinsproc.Focus();
                errorProvider1.SetError(tbinsproc, "El folio no puede ser vacio");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbinsproc, "");
            }
        }

        private void Cbtipestant_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbtipestant.SelectedIndex == 0 || cbtipestant.SelectedIndex == 1)
            {
                tbcedprof.Enabled = true;
            }
            else
            {
                tbcedprof.Enabled = false;
            }
        }
    }
}


#region  comentado

//private void Tbnombre_Validating(object sender, CancelEventArgs e)
//{
//    if (string.IsNullOrWhiteSpace(tbnombre.Text))
//    {
//        e.Cancel = true;
//        tbnombre.Focus();
//        errorProvider1.SetError(tbnombre, "El nombre no puede ser vacio");
//    }
//    else
//    {
//        e.Cancel = false;
//        errorProvider1.SetError(tbnombre, "");
//    }
//}

//private void Tbapepat_Validating(object sender, CancelEventArgs e)
//{
//    if (string.IsNullOrWhiteSpace(tbapepat.Text))
//    {
//        e.Cancel = true;
//        tbapepat.Focus();
//        errorProvider1.SetError(tbapepat, "El Apellido Paterno no puede ser vacio");
//    }
//    else
//    {
//        e.Cancel = false;
//        errorProvider1.SetError(tbapepat, "");
//    }
//}

//private void Tbapemat_Validating(object sender, CancelEventArgs e)
//{
//    if (string.IsNullOrWhiteSpace(tbapemat.Text))
//    {
//        e.Cancel = true;
//        tbapemat.Focus();
//        errorProvider1.SetError(tbapemat, "El Apellido Materno no puede ser vacio");
//    }
//    else
//    {
//        e.Cancel = false;
//        errorProvider1.SetError(tbapemat, "");
//    }
//}

//private void Tbcurp_Validating(object sender, CancelEventArgs e)
//{
//    if (string.IsNullOrWhiteSpace(tbcurp.Text))
//    {
//        e.Cancel = true;
//        tbapemat.Focus();
//        errorProvider1.SetError(tbcurp, "La CURP no puede ser vacio");
//    }
//    else
//    {
//        e.Cancel = false;
//        errorProvider1.SetError(tbcurp, "");
//    }
//}

//private void Tbemail_Validating(object sender, CancelEventArgs e)
//{
//    if (string.IsNullOrWhiteSpace(tbemail.Text))
//    {
//        e.Cancel = true;
//        tbemail.Focus();
//        errorProvider1.SetError(tbemail, "El email no puede ser vacio");
//    }
//    else
//    {
//        e.Cancel = false;
//        errorProvider1.SetError(tbemail, "");
//    }
//}

//private void Tbmatricula_Validating(object sender, CancelEventArgs e)
//{
//    if (string.IsNullOrWhiteSpace(tbmatricula.Text))
//    {
//        e.Cancel = true;
//        tbmatricula.Focus();
//        errorProvider1.SetError(tbmatricula, "El folio no puede ser vacio");
//    }
//    else
//    {
//        e.Cancel = false;
//        errorProvider1.SetError(tbmatricula, "");
//    }
//}

#endregion