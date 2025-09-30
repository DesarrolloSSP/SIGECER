using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Sigecer.Modelo;

namespace Sigecer
{
    public partial class Frmrutaxml : Form
    {
        public Frmrutaxml()
        {
            InitializeComponent();
            MostrarRuta();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    tbrutalxml.Text = folderBrowserDialog1.SelectedPath;
                    //Inicia();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            using (DBCERCEISEntities ctx = new DBCERCEISEntities())
            {
                tb_configuracion rutaxml = ctx.tb_configuracion.Where(x => x.idtconfiguracion == 1).First();
                if (rutaxml != null)
                {
                    rutaxml.rutaxml = tbrutalxml.Text.Trim();
                    ctx.SaveChanges();
                    MessageBox.Show("La ruta fué actualizada exitosamente", "Gestión de certificados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        protected void MostrarRuta()
        {
            try
            {
                using (DBCERCEISEntities ctx = new DBCERCEISEntities())
                {
                    tb_configuracion ruta = ctx.tb_configuracion.Where(x => x.idtconfiguracion == 1).First();
                    if (ruta != null)
                    {
                        lblruta.Text = ruta.rutaxml.Trim().ToUpper();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frmrutaxml_Load(object sender, EventArgs e)
        {

        }
    }
}
