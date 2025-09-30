using Sigecer.Clases;
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

namespace Sigecer
{
    public partial class Login : Form
    {

        DBCERCEISEntities ctx = new DBCERCEISEntities();
        public dataLog _dataLog { get; set; }
        public Login()
        {
            InitializeComponent();
        }
        public static string key = "=7382?123";

        private void btnSalir_Click(object sender, EventArgs e)
        {
            txtusuario.Text = "";
            txtclave.Text = "";
            this.Close();
            this.Dispose();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            var validar = true;
            var mensaje = "";
            var contraseña = "";
            var nombre = "";
            var usuario = "";
            _dataLog = new dataLog();
            try
            {
                if (txtusuario.Text.Trim() == "")
                {
                    mensaje += "Debe ingresar su usuario \n";
                    txtusuario.ForeColor = Color.Red;
                    validar = false;
                }
                if (txtclave.Text.Trim() == "")
                {
                    mensaje += "Debe ingresar su contraseña \n";
                    txtclave.ForeColor = Color.Red;
                    validar = false;
                }
                if (!validar)
                {
                    MessageBox.Show(mensaje, "Inicio se sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    contraseña = txtclave.Text.Trim();
                    usuario = txtusuario.Text.Trim();

                    //using (DBCERCEISEntities ctx = new DBCERCEISEntities())
                    //{
                    var buscar_user = ctx.tb_usuarios.Where(a => a.Usuario == usuario).FirstOrDefault();
                    if (buscar_user != null)
                    {
                        nombre = Convert.ToString(buscar_user.Nombre + " " + buscar_user.Paterno + " " + buscar_user.Materno);
                        contraseña = buscar_user.Password;
                        if (txtclave.Text.Trim() == DesEncriptar(contraseña))
                        {

                            Principal frmIni = new Principal();
                            frmIni.rol = Convert.ToInt32(buscar_user.idRol);
                            frmIni.user = nombre;
                            frmIni.login = usuario;
                            frmIni.Show();

                            _dataLog.usuario = usuario;
                            _dataLog.Modulo = "LOGIN";
                            _dataLog.Tipo = "LOG";
                            _dataLog.Modificacion = "INICIO DE SESIÓN AL SISTEMA";
                            this.Hide();

                        }
                        else
                        {

                            mensaje = "La constraseña no corresponde, verifique";
                            MessageBox.Show(mensaje, "Mensaje C.E.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            _dataLog.usuario = usuario;
                            _dataLog.Modulo = "LOGIN";
                            _dataLog.Tipo = "LOG";
                            _dataLog.Modificacion = mensaje + " del usuario: " + usuario;

                        }
                    }
                    else
                    {


                        mensaje = "No se encontraron coincidencias del usuario ";
                        MessageBox.Show(mensaje, "Mensaje C.E.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); _dataLog = new dataLog();
                        _dataLog.usuario = usuario;
                        _dataLog.Modulo = "LOGIN";
                        _dataLog.Tipo = "LOG";
                        _dataLog.Modificacion = mensaje + usuario;
                    }

                    int LogLogin = Log.Instancia.LogInsert(_dataLog, out mensaje);
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión", "Mensaje C.E.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        public static string DesEncriptar(string _cadenaAdesencriptar)
        {
            byte[] keyArray;
            byte[] Array_a_Descifrar = Convert.FromBase64String(_cadenaAdesencriptar);
            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            hashmd5.Clear();
            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(Array_a_Descifrar, 0, Array_a_Descifrar.Length);
            tdes.Clear();
            return UTF8Encoding.UTF8.GetString(resultArray);
        }
    }
}

