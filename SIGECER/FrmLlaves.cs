using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sigecer.Modelo;

namespace Sigecer
{
    public partial class FrmLlaves : Form
    {
        public FrmLlaves()
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
                    tbrutallaves.Text = folderBrowserDialog1.SelectedPath;
                    //Inicia();
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

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            using (DBCERCEISEntities ctx = new DBCERCEISEntities())
            {
                tb_configuracion rutallaves = ctx.tb_configuracion.Where(x => x.idtconfiguracion == 1).First();
                if (rutallaves != null)
                {
                    rutallaves.rutallaves = tbrutallaves.Text.Trim();
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
                        lblruta.Text = ruta.rutallaves.Trim().ToUpper();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
