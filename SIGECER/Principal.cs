using Sigecer.Clases;
using Sigecer.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sigecer
{
    public partial class Principal : Form
    {
        public int rol { get; set; }
        public string user { get; set; }
        public string login { get; set; }
        public dataLog _dataLog { get; set; }
        string mensaje = string.Empty;

        public Principal()
        {
            //string mensaje = string.Empty;
            //_dataLog.usuario = string.Format("{0}", login);
            //_dataLog.Modulo = "lOGIN";
            //_dataLog.Tipo = "LOG";
            //_dataLog.Modificacion = "INICIO DE SESIÓN AL SISTEMA";
            //int InLog = Log.Instancia.LogInsert(_dataLog, out mensaje);
            InitializeComponent();
        }

        private void FirmantesAutorizadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _dataLog = new dataLog();
            _dataLog.usuario = string.Format("{0}", login);
            _dataLog.Modulo = "FIRMA AUTORIZADO";
            _dataLog.Tipo = "IN";
            _dataLog.Modificacion = "INGRESO AL MODULO";
            int InLog = Log.Instancia.LogInsert(_dataLog, out mensaje);
            FirmanteAuto Firma = new FirmanteAuto();
            Firma.ShowDialog();
           
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _dataLog = new dataLog();
            _dataLog.usuario = string.Format("{0}", login);
            _dataLog.Modulo = "INGRESAR NUEVO ALUMNO";
            _dataLog.Tipo = "IN";
            _dataLog.Modificacion = "INGRESO AL MODULO";
            int InLog = Log.Instancia.LogInsert(_dataLog, out mensaje);
            NuevoAlumno Nuevo = new NuevoAlumno(0);
            Nuevo.login = string.Format("{0}", login);
            Nuevo.ShowDialog();
        
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            NuevoAlumno Nuevo = new NuevoAlumno(0);
            Nuevo.ShowDialog();
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void VerAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _dataLog = new dataLog();
            _dataLog.usuario = string.Format("{0}", login);
            _dataLog.Modulo = "VISTA DE ALUMNOS";
            _dataLog.Tipo = "IN";
            _dataLog.Modificacion = "INGRESO AL MODULO";
            int InLog = Log.Instancia.LogInsert(_dataLog, out mensaje);
            Alumnos vista = new Alumnos();
            vista.ShowDialog();
        }

        private void RutaDeLlavesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _dataLog = new dataLog();
            _dataLog.usuario = string.Format("{0}", login);
            _dataLog.Modulo = "REGISTRO DE LLAVES";
            _dataLog.Tipo = "IN";
            _dataLog.Modificacion = "INGRESO AL MODULO";
            int InLog = Log.Instancia.LogInsert(_dataLog, out mensaje);
            FrmLlaves Llaves = new FrmLlaves();
            Llaves.ShowDialog();
        }

        private void RutaDeXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _dataLog = new dataLog();
            _dataLog.usuario = string.Format("{0}", login);
            _dataLog.Modulo = "REGISTRO DE RUTA XML";
            _dataLog.Tipo = "IN";
            _dataLog.Modificacion = "INGRESO AL MODULO";
            int InLog = Log.Instancia.LogInsert(_dataLog, out mensaje);
            Frmrutaxml Rutaxml = new Frmrutaxml();
            Rutaxml.ShowDialog();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
           
            //lbluser.Text = string.Format("{0}", user);
            tssl.Text = string.Format("{0}", user);
            
            if (rol == 2)
            {
                administraciónToolStripMenuItem.Enabled = false;
                generarTokenToolStripMenuItem.Enabled = false;
            }

           

        }

        private void crearUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdminUser NuevoUser = new FrmAdminUser();
            NuevoUser.ShowDialog();
        }

        private void generarTokenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _dataLog = new dataLog();
            _dataLog.usuario = string.Format("{0}", login);
            _dataLog.Modulo = "GENERAR TOKEN";
            _dataLog.Tipo = "IN";
            _dataLog.Modificacion = "INGRESO AL MODULO";
            int InLog = Log.Instancia.LogInsert(_dataLog, out mensaje);
            FrmToken token = new FrmToken();
            token.login = string.Format("{0}", login);
            token.ShowDialog();
        }

        private void imprimirTituloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _dataLog = new dataLog();
            _dataLog.usuario = string.Format("{0}", login);
            _dataLog.Modulo = "IMPRIMIR TITULO";
            _dataLog.Tipo = "IN";
            _dataLog.Modificacion = "INGRESO AL MODULO";
            int InLog = Log.Instancia.LogInsert(_dataLog, out mensaje);
            Impresion_titulos impresion = new Impresion_titulos();
            impresion.login = string.Format("{0}", login);

            impresion.ShowDialog();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _dataLog = new dataLog();
            _dataLog.usuario = string.Format("{0}", login);
            _dataLog.Modulo = "REPORTES DE ALUMNOS";
            _dataLog.Tipo = "IN";
            _dataLog.Modificacion = "INGRESO AL MODULO";
            int InLog = Log.Instancia.LogInsert(_dataLog, out mensaje);
            Forms.Reportes.R_Alumnos R_alumnos = new Forms.Reportes.R_Alumnos();
            //impresion.login = string.Format("{0}", login);

            R_alumnos.ShowDialog();
        }

        private void base64ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmB64_XML B64XML = new FrmB64_XML();
            B64XML.ShowDialog();
        }
    }
}
