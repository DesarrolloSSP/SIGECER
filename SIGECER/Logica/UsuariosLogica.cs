using Sigecer.Extensiones;
using Sigecer.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sigecer.Logica
{
    internal class UsuariosLogica
    {

        private static UsuariosLogica _instancia = null;

        public UsuariosLogica()
        {

        }
        public static UsuariosLogica Instancia
        {
            get
            {
                if (_instancia == null) _instancia = new UsuariosLogica();
                return _instancia;
            }
        }

        public List<dataUsuarios> Listar(out string mensaje)
        {
            using (DBCERCEISEntities ctx = new DBCERCEISEntities())
            {
                mensaje = string.Empty;
                List<dataUsuarios> oLista = new List<dataUsuarios>();
                try
                {

                    var usuarios = (from a in ctx.tb_usuarios
                                    join b in ctx.cat_roles
                                    on a.idRol equals b.idRol
                                    where a.idUser != 1
                                    select new
                                    {
                                        IdUsuario = a.idUser,
                                        a.Nombre,
                                        a.Paterno,
                                        a.Materno,
                                        a.Usuario,
                                        Rol = b.NombreRol
                                    }).ToList();

                    foreach (var a in usuarios)
                    {


                        oLista.Add(new dataUsuarios()
                        {
                            IdUsuario = a.IdUsuario,
                            Nombre = a.Nombre.ToString(),
                            Paterno = a.Paterno.ToString(),
                            Materno = a.Materno.ToString(),
                            Usuario = a.Usuario,
                            Rol = a.Rol,
                        });
                    }
                }
                catch (Exception ex)
                {
                    oLista = new List<dataUsuarios>();
                    mensaje = ex.Message;
                }
                return oLista;
            }
        }

        public int Guardar(dataUsuarios usuarios, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;

            try
            {
                using (DBCERCEISEntities ctx = new DBCERCEISEntities())
                {
                    tb_usuarios nuevo = new tb_usuarios();
                    nuevo.Nombre = usuarios.Nombre.Trim();
                    nuevo.Paterno = usuarios.Paterno.Trim();
                    nuevo.Materno = usuarios.Materno.Trim();
                    nuevo.Usuario = usuarios.Usuario.Trim();
                    if (usuarios.password.Trim() != "")
                    {
                        nuevo.Password = Seguridad.Encriptar(usuarios.password);

                    }
                    nuevo.idRol = Convert.ToInt32(usuarios.idrol);
                    nuevo.fechaAcceso = DateTime.Now;
                    nuevo.Activo = true;
                    nuevo.NombreCompleto = usuarios.Nombre.Trim() + " " + usuarios.Paterno.Trim() + " " + usuarios.Materno.Trim();
                    ctx.tb_usuarios.Add(nuevo);
                    ctx.SaveChanges();
                    mensaje = "El usuario se ha creado con éxito.";
                    respuesta = 1;
                }
            }
            catch (Exception error)
            {
                respuesta = 0;
                mensaje = "Error: " + error.Message;
            }

            return respuesta;

        }
        public int Editar(dataUsuarios usuarios, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;
            try
            {
                using (DBCERCEISEntities ctx = new DBCERCEISEntities())
                {
                    int idUser = usuarios.IdUsuario;
                    var editarUser = ctx.tb_usuarios.Where(t => t.idUser == idUser).FirstOrDefault();
                    if (editarUser != null)                    {
                        editarUser.Nombre = usuarios.Nombre.Trim();
                        editarUser.Paterno = usuarios.Paterno.Trim();
                        editarUser.Materno = usuarios.Materno.Trim();
                        editarUser.Usuario = usuarios.Usuario.Trim();
                        if (usuarios.password.Trim() != "")
                        {
                            editarUser.Password = Seguridad.Encriptar(usuarios.password);

                        }
                        editarUser.idRol = Convert.ToInt32(usuarios.idrol);
                        editarUser.fechaAcceso = DateTime.Now;
                        editarUser.NombreCompleto = usuarios.Nombre.Trim() + " " + usuarios.Paterno.Trim() + " " + usuarios.Materno.Trim();
                        ctx.SaveChanges();
                        mensaje = "El usuario se ha modificado con éxito.";
                        respuesta = 1;
                    }
                }
            }
            catch (Exception error)
            {
                respuesta = 0;
                mensaje = "Error: " + error.Message ;
            }
            return respuesta;
        }
    }
}
