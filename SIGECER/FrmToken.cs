using Sigecer.Clases;
using Sigecer.Logica;
using Sigecer.Modelo;
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
    public partial class FrmToken : Form
    {
        public dataLog _dataLog { get; set; }
        public string login { get; set; }

        string mensaje = string.Empty;
        public FrmToken()
        {
            InitializeComponent();
        }
        private void FrmToken_Load(object sender, EventArgs e)
        {
            lbltoken.Enabled = false;
            lblMensaje.Enabled = false;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                Guid id = Guid.NewGuid();
             
                Principal dt = new Principal();

                using (DBCERCEISEntities ctx = new DBCERCEISEntities())
                {
                    lbltoken.Enabled = true;
                    lblMensaje.Enabled = true;
                    tb_token Genear = new tb_token()
                    {
                        token = id,
                        fechaInicio = DateTime.Now,
                        fehcaExpira = DateTime.Now.AddMinutes(30),
                        activo = true,
                        user = dt.user
                        
                    };
                    ctx.tb_token.Add(Genear);
                    ctx.SaveChanges();
                    _dataLog = new dataLog();
                    _dataLog.usuario = string.Format("{0}", login);
                    _dataLog.Modulo = "GENERAR TOKEN";
                    _dataLog.Tipo = "NEW";
                    _dataLog.Modificacion = "EL TOKEN SE HA GENERADO EXITOSAMENTE.";
                    int InLog = Log.Instancia.LogInsert(_dataLog, out mensaje);
                    lblMensaje.Text = "El token se ha generado exitosamente.";
                    lblMensaje.ForeColor = Color.Green;
                    lbltoken.Text = id.ToString().Trim().ToUpper();
                }
            }
            catch (Exception error)
            {
                lblMensaje.Text = "El token no se genero";
                lblMensaje.ForeColor = Color.Red;

                _dataLog = new dataLog
                {
                    usuario = string.Format("{0}", login),
                    Modulo = "GENERAR TOKEN",
                    Tipo = "ERROR",
                    Modificacion = "ERROR AL GENERAR EL TOKEN"
                };
                int InLog = Log.Instancia.LogInsert(_dataLog, out mensaje);
                MessageBox.Show(error.Message);
            }
        }


    }
}
