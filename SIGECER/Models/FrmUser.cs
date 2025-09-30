using Sigecer.Extensiones;
using Sigecer.Logica;
using Sigecer.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sigecer.Models
{
    public partial class FrmUser : Form
    {
        public bool _modo_editar { get; set; }

        public int iduser { get; set; }
        public dataUsuarios _Usuario { get; set; }
        public FrmUser()
        {
            InitializeComponent();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            CargaRAoles();


            if (_modo_editar)
            {
                //si entro
                iduser = _Usuario.IdUsuario;
                txtNombre.Text = _Usuario.Nombre;
                txtApPaterno.Text = _Usuario.Paterno;
                txtApMaterno.Text = _Usuario.Materno;
                txtUser.Text = _Usuario.Usuario;
                using (DBCERCEISEntities ctx = new DBCERCEISEntities())
                {
                    var rol = ctx.cat_roles.Where(a => a.NombreRol == _Usuario.Rol).FirstOrDefault();
                    if (rol != null)
                    {
                        ddlRol.SelectedValue = rol.idRol;
                    }
                }

            }
        }
        private void Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                string mensaje = string.Empty;

                if (!_modo_editar)
                { //nuevo
                    _Usuario = new dataUsuarios
                    {
                        Nombre = txtNombre.Text.Trim(),
                        Paterno = txtApPaterno.Text.Trim(),
                        Materno = txtApMaterno.Text.Trim(),
                        Usuario = txtUser.Text.Trim(),
                        password = txtpw.Text.Trim(),
                        idrol = Convert.ToInt32(ddlRol.SelectedValue.ToString())
                    };

                    int NuevoUser = UsuariosLogica.Instancia.Guardar(_Usuario, out mensaje);
                    if (NuevoUser > 0)
                    {
                        this.DialogResult = DialogResult.OK;
                        MessageBox.Show(mensaje, "Gestión de usuarios.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Gestión de usuarios.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
                else
                {
                    //editar
                    _Usuario.IdUsuario = iduser;
                    _Usuario.Nombre = txtNombre.Text.Trim();
                    _Usuario.Paterno = txtApPaterno.Text.Trim();
                    _Usuario.Materno = txtApMaterno.Text.Trim();
                    _Usuario.Usuario = txtUser.Text.Trim();
                    _Usuario.password = txtpw.Text.Trim();
                    _Usuario.idrol = Convert.ToInt32(ddlRol.SelectedValue.ToString());

                    int UsuArioEditado = UsuariosLogica.Instancia.Editar(_Usuario, out mensaje);
                    if (UsuArioEditado > 0)
                    {
                        this.DialogResult = DialogResult.OK;
                        MessageBox.Show(mensaje, "Gestión de usuarios.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Gestión de usuarios.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        protected void CargaRAoles()
        {
            try
            {
                using (DBCERCEISEntities ctx = new DBCERCEISEntities())
                {
                    var query = ctx.cat_roles.ToList();
                    ddlRol.Items.Add("-select-");
                    ddlRol.SelectedIndex = 0;
                    ddlRol.DataSource = query;
                    ddlRol.DisplayMember = "NombreRol";
                    ddlRol.ValueMember = "idRol";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                e.Cancel = true;
                txtNombre.Focus();
                errorProvider1.SetError(txtNombre, "El nombre del usuario no puede ser vacío.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNombre, "");
            }
        }

        private void txtUser_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text))
            {
                e.Cancel = true;
                txtUser.Focus();
                errorProvider1.SetError(txtUser, "El usuario no puede ser vacío.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUser, "");
            }
        }

        private void txtpw_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtpw.Text))
            {
                e.Cancel = true;
                txtpw.Focus();
                errorProvider1.SetError(txtpw, "La contraseña no puede ser vacía.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtpw, "");
            }
        }
    }
}
