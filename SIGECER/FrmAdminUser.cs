using Sigecer.Modelo;
using Sigecer.Models;
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
    public partial class FrmAdminUser : Form
    {

     
        public FrmAdminUser()
        {
            InitializeComponent();
        }

        private void btnNuevoUser_Click(object sender, EventArgs e)
        {
            FrmUser NuevoUser = new FrmUser();
            NuevoUser.ShowDialog();
            cargaGrid();
        }

        private void FrmAdminUser_Load(object sender, EventArgs e)
        {
            cargaGrid();

        }

        public void cargaGrid()
        {
            try
            {
                string mensaje = string.Empty;
                dtgvUser.AutoGenerateColumns = false;
                //using (DBCERCEISEntities ctx = new DBCERCEISEntities())
                //{
                //    var usuarios = (from a in ctx.tb_usuarios
                //                    join b in ctx.cat_roles
                //                    on a.idRol equals b.idRol
                //                    where a.idUser != 1
                //                    select new
                //                    {
                //                        IdUsuario = a.idUser,
                //                        Nombre = a.Nombre,
                //                        Paterno = a.Paterno,
                //                        Materno = a.Materno,
                //                        Usuario = a.Usuario,
                //                        Rol = b.NombreRol
                //                    }).ToList();

                //    dtgvUser.DataSource = usuarios;

                //}

                dtgvUser.DataSource = UsuariosLogica.Instancia.Listar(out mensaje);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void dtgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (dtgvUser.Columns[e.ColumnIndex].Name == "btnEditar")
            {

                if (index >= 0)
                {

                    dataUsuarios dataUser = new dataUsuarios()
                    {
                        IdUsuario = Convert.ToInt32(dtgvUser.Rows[index].Cells["IdUsuario"].Value),
                        Nombre = dtgvUser.Rows[index].Cells["Nombre"].Value.ToString(),
                        Paterno = dtgvUser.Rows[index].Cells["Paterno"].Value.ToString(),
                        Materno = dtgvUser.Rows[index].Cells["Materno"].Value.ToString(),
                        Usuario = dtgvUser.Rows[index].Cells["Usuario"].Value.ToString(),
                        Rol = dtgvUser.Rows[index].Cells["Rol"].Value.ToString(),
                    };



                    using (var formuser = new FrmUser())
                    {
                        formuser._Usuario = dataUser;
                        formuser._modo_editar = true;
                        var result = formuser.ShowDialog();
                        cargaGrid();
                    }
                }
            }
        }


        private void dtgvUser_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 6)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.editar.Width;
                var h = Properties.Resources.editar.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.editar, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            //string nombre_columna= txtbuscar.Text.Trim();
            //if (dtgvUser.Rows.Count > 0)
            //{
            //    foreach (DataGridView row in dtgvUser.Rows)
            //    {
            //        nombre_columna = dtgvUser.Columns[row.TabIndex].DataPropertyName.Trim();

            //    }
            //}


        }
    }
}
