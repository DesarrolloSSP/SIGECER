using Sigecer.Clases;
using Sigecer.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigecer.Logica
{
    internal class TitulosLogica
    {

        private static TitulosLogica _TitulosLogica = null;

        public TitulosLogica()
        {

        }

        public static TitulosLogica Instancia
        {
            get
            {
                if (_TitulosLogica == null) _TitulosLogica = new TitulosLogica();
                return _TitulosLogica;
            }
        }

        public List<dataTitulosEmi> Listar(out string mensaje, string texto)
        {
            using (DBCERCEISEntities ctx = new DBCERCEISEntities())
            {
                mensaje = string.Empty;

                string NombreAlumno = texto.Trim();
                List<dataTitulosEmi> _ListaTitulos = new List<dataTitulosEmi>();
                try
                {
                    if (NombreAlumno != "")
                    {
                        var titulos = (from a in ctx.tb_titulosEmitidos
                                       join b in ctx.cat_ModalidadTitulacion on a.idModTitu equals b.idModTitu
                                       join c in ctx.tb_Carreras on a.IdCarrera equals c.IdCarrera
                                       where a.status == true && (a.nombre + " " + a.primerApellido + " " + a.segundoApellido).Contains(NombreAlumno)
                                       select new
                                       {
                                           Idtitulo = a.IdTitulo,
                                           Folio = a.folio_electronico,
                                           Nombre = a.nombre,
                                           Paterno = a.primerApellido,
                                           Materno = a.segundoApellido,
                                           CURP = a.curp,
                                           IdCarrera = a.IdCarrera,
                                           fecha_gen = a.fecha_gen,
                                           FechaImpreasion = a.FechaImpreasion == null ? null : a.FechaImpreasion,
                                           nombre_Alumno = a.nombre.Trim() + " " + a.primerApellido.Trim() + " " + a.segundoApellido.Trim(),
                                           ModTitu = b.Modo_titulacion,
                                           Carrera = c.CARRERA
                                       }).ToList();
                        foreach (var a in titulos)
                        {
                            _ListaTitulos.Add(new dataTitulosEmi()
                            {
                                IdTitulo = a.Idtitulo,
                                folio_electronico = Convert.ToString(a.Folio),
                                nombre = a.Nombre.ToString(),
                                primerApellido = a.Paterno.ToString(),
                                segundoApellido = a.Materno.ToString(),
                                curp = a.CURP,
                                IdCarrera = a.IdCarrera,
                                fecha_gen = Convert.ToDateTime(a.fecha_gen).ToString("dd/MM/yyyy"),
                                FechaImpreasion = Convert.ToString(a.FechaImpreasion).ToString() == null ? Convert.ToDateTime(a.FechaImpreasion).ToString("dd/MM/yyyy") : " ",
                                nombre_Alumno = a.nombre_Alumno,
                                ModTitu = a.ModTitu,
                                Carrera = a.Carrera
                            });
                        }
                    }
                    else
                    {
                        var titulos = (from a in ctx.tb_titulosEmitidos
                                       join b in ctx.cat_ModalidadTitulacion on a.idModTitu equals b.idModTitu
                                       join c in ctx.tb_Carreras on a.IdCarrera equals c.IdCarrera
                                       where a.status == true
                                       select new
                                       {
                                           Idtitulo = a.IdTitulo,
                                           Folio = a.folio_electronico,
                                           Nombre = a.nombre,
                                           Paterno = a.primerApellido,
                                           Materno = a.segundoApellido,
                                           CURP = a.curp,
                                           IdCarrera = a.IdCarrera,
                                           fecha_gen = a.fecha_gen,
                                           FechaImpreasion = a.FechaImpreasion == null ? null : a.FechaImpreasion,
                                           nombre_Alumno = a.nombre.Trim() + " " + a.primerApellido.Trim() + " " + a.segundoApellido.Trim(),
                                           ModTitu = b.Modo_titulacion,
                                           Carrera = c.CARRERA
                                       }).ToList();
                        foreach (var a in titulos)
                        {
                            _ListaTitulos.Add(new dataTitulosEmi()
                            {
                                IdTitulo = a.Idtitulo,
                                folio_electronico = Convert.ToString(a.Folio),
                                nombre = a.Nombre.ToString(),
                                primerApellido = a.Paterno.ToString(),
                                segundoApellido = a.Materno.ToString(),
                                curp = a.CURP,
                                IdCarrera = a.IdCarrera,
                                fecha_gen = Convert.ToDateTime(a.fecha_gen).ToString("dd/MM/yyyy"),
                                FechaImpreasion = Convert.ToString(a.FechaImpreasion).ToString() == null ? Convert.ToDateTime(a.FechaImpreasion).ToString("dd/MM/yyyy") : " ",
                                nombre_Alumno = a.nombre_Alumno,
                                ModTitu = a.ModTitu,
                                Carrera = a.Carrera
                            });
                        }
                    }




                }
                catch (Exception ex)
                {
                    _ListaTitulos = new List<dataTitulosEmi>();
                    mensaje = ex.Message;
                }
                return _ListaTitulos;
            }
        }


        public int ConteoRegistros(out int mensaje, string texto)
        {
            mensaje = 0;
            string NombreAlumno = texto.Trim();
            try
            {
                var titulos = 0;
                using (DBCERCEISEntities ctx = new DBCERCEISEntities())
                {
                    if (NombreAlumno != "")
                    {
                        titulos = (from a in ctx.tb_titulosEmitidos
                                   where a.status == true && (a.nombre + " " + a.primerApellido + " " + a.segundoApellido).Contains(NombreAlumno)
                                   select a).Count();
                    }
                    else
                    {
                        titulos = (from a in ctx.tb_titulosEmitidos
                                   where a.status == true
                                   select a).Count();
                    }
                }

                mensaje = titulos;
            }
            catch (Exception ex)
            {
                throw;
                //respuesta = 0;
                //mensaje = "El usuario no fué grabado con existo";
            }
            return mensaje;
        }
        
    }
}
