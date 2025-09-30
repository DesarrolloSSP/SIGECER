using Microsoft.Reporting.WinForms;
using Sigecer.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sigecer
{
    public partial class Reporte : Form
    {
        public Reporte(string fol, int idc)
        {
            this.fol = fol;
            this.idc = idc;
            InitializeComponent();

        }

        string fol;
        int idc;
        //int idc; 

        private void Reporte_Load(object sender, EventArgs e)
        {
            try
            {
                string dominio = "sspver.gob.mx";
                string usuario = "cponcem";
                //string contraseña = "ANCETma#23";
                string contraseña = "W2N%/C+4v6";

                // Crea las credenciales de red
                NetworkCredential credenciales = new NetworkCredential(usuario, contraseña, dominio);

                // Crea un objeto ReportViewer
                //ReportViewer reportViewer1 = new ReportViewer();

                // Asigna las credenciales de red al ReportViewer
                reportViewer1.ServerReport.ReportServerCredentials.NetworkCredentials = credenciales;
                reportViewer1.ProcessingMode = ProcessingMode.Remote;
                reportViewer1.ServerReport.ReportServerUrl = new Uri("http://10.8.3.199/reportserver");

                DBCERCEISEntities ctx = new DBCERCEISEntities();

                var year = Convert.ToInt32(DateTime.Now.Year);
                string fecha = "30/04/2025";
                DateTime dt = DateTime.Parse(fecha);
                Guid folio = Guid.Parse(fol);

                //var consultaTitulo = ctx.vw_TitulosVista.Where(a => a.folio_electronico == folio && a.year <= year && a.fecha_gen <= dt).FirstOrDefault();
                var consultaTitulo = ctx.vw_TitulosVista.Where(a => a.folio_electronico == folio).FirstOrDefault();
                if (consultaTitulo != null)
                {

                    reportViewer1.ServerReport.ReportPath = "/Titulos/TituloTsu_N"; // Ruta del informe
                    //titulos con el viejo diseño
                    switch (idc)
                    {
                        case 11:
                            //reportViewer1.ServerReport.ReportPath = "/Titulos/TituloTsu"; //Técnico superior
                            reportViewer1.ServerReport.ReportPath = "/Titulos/TituloTsu_N"; // Ruta del informe
                            break;
                        default:
                            reportViewer1.ServerReport.ReportPath = "/Titulos/TituloTsu_N"; // Ruta del informe
                            break;

                            //case 7:
                            //case 9:
                            //case 13:
                            //    reportViewer1.ServerReport.ReportPath = "/Titulos/TituloL";  //Licenciatura
                            //    //reportViewer1.ServerReport.ReportPath = "/Titulos/TituloL_N"; // Ruta del informe
                            //    break;
                            //case 6:
                            //    reportViewer1.ServerReport.ReportPath = "/Titulos/TituloD"; //Doctorado
                            //    //reportViewer1.ServerReport.ReportPath = "/Titulos/TituloD_N"; // Ruta del informe
                            //    break;
                            //case 1:
                            //case 3:
                            //    reportViewer1.ServerReport.ReportPath = "/Titulos/TituloM"; //Maestria
                            //    //reportViewer1.ServerReport.ReportPath = "/Titulos/TituloM_N"; // Ruta del informe
                            //    break;
                    }

                }


                // Añadir parámetros si es necesario
                ReportParameter[] parameters = new ReportParameter[2];
                parameters[0] = new ReportParameter("folio", fol);
                parameters[1] = new ReportParameter("idc", Convert.ToString(idc));
                reportViewer1.ServerReport.SetParameters(parameters);
                this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                this.reportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
