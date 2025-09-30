using Sigecer.Modelo;
using System;
using System.Linq;
using System.Windows.Forms;


namespace Sigecer
{
    public partial class FirmanteAuto : Form
    {
        public FirmanteAuto()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tbcertificado_TextChanged(object sender, EventArgs e)
        {
            if (tbcertificado.Text.Trim().Length == 40)
            {
                for (int i = 0; i <= 39; i++)
                {
                    if (i % 2 != 0)
                    {
                        tbcerxml.Text = tbcerxml.Text + tbcertificado.Text.Substring(i, 1);
                    }
                }
            }
        }

        private void FirmanteAuto_Load(object sender, EventArgs e)
        {
            tbnombre.Focus();
            using (DBCERCEISEntities ctx = new DBCERCEISEntities())
            {
                var query = ctx.sel_firmantes().ToList();
                dgv_firmante.DataSource = query;
                //dgv_alumnos.Rows[0].Selected = true;
                //dgv_alumnos_CellClick(dgv_alumnos, new DataGridViewCellEventArgs(0, 0));
            }
            Cargacargos(); 
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            tbnombre.Enabled = true;
            tbapepat.Enabled = true;
            tbapemat.Enabled = true;
            tbcurp.Enabled = true;
            cbcargo.Enabled = true;
            tbabrevia.Enabled = true;
            tbcertificado.Enabled = true;
            tbcerxml.Enabled = true;
            tbnombre.Focus();
        }

        protected void Cargacargos()
        {
            try
            {
                using (DBCERCEISEntities ctx = new DBCERCEISEntities())
                {
                    var query = ctx.cat_FirmAutorizado.ToList();
                    cbcargo.DataSource = query;
                    cbcargo.DisplayMember = "CargoFirmante";
                    cbcargo.ValueMember = "idAutorizado";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            guardarFirmante();
        }

        protected void guardarFirmante()
        {
            try
            {
                using (DBCERCEISEntities ctx = new DBCERCEISEntities())
                {
                    tb_Autorizados nuevo = new tb_Autorizados()
                    {
                        NombreAutorizado = tbnombre.Text.Trim(),
                        APatenroAutorizado = tbapemat.Text.Trim(),
                        AMaternoAutorizado = tbapemat.Text.Trim(),
                        CURPAutorizante = tbcurp.Text.Trim(), 
                        idAutizado = 0,
                        AbrebiaturaTitulo = tbabrevia.Text.Trim(),
                        NumCertidicado = tbcertificado.Text.Trim()
                    };
                    ctx.tb_Autorizados.Add(nuevo);
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                //throw;
            }
        }
    }
}
