using Sigecer.Clases;
using Sigecer.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Common.CommandTrees.ExpressionBuilder;
using System.Data.Objects;
using System.Data.Objects.SqlClient;
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
        //LISTA ANTERIOR
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
                                           Carrera = c.DESC_CEDULA
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
                                           Carrera = c.DESC_CEDULA
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

        public List<dataTitulosEmi> ListarConFiltrosAvanzados(out string mensaje, string folio, string nombre, string curp, int idCarrera, int idModTitu, DateTime? fechaCreacion, DateTime? fechaImpresion)
        {
            using (DBCERCEISEntities ctx = new DBCERCEISEntities())
            {
                mensaje = string.Empty;
                List<dataTitulosEmi> _ListaTitulos = new List<dataTitulosEmi>();

                try
                {
                    var query = from a in ctx.tb_titulosEmitidos
                                join b in ctx.cat_ModalidadTitulacion on a.idModTitu equals b.idModTitu
                                join c in ctx.tb_Carreras on a.IdCarrera equals c.IdCarrera
                                where a.status == true
                                select new { a, b, c };

                    // FILTROS DE TEXTO Y COMBOS 
                    if (!string.IsNullOrWhiteSpace(folio))
                    {
                        // Convertimos el texto ingresado
                        if (Guid.TryParse(folio.Trim(), out Guid guidFolio))
                        {
                            
                            query = query.Where(x => x.a.folio_electronico.HasValue && x.a.folio_electronico.Value == guidFolio);
                        }
                        else
                        {
                            
                            query = query.Where(x => false);
                        }
                    }
                    if (!string.IsNullOrWhiteSpace(nombre))
                    {
                        string n = nombre.Trim();
                        query = query.Where(x => (x.a.nombre + " " + x.a.primerApellido + " " + x.a.segundoApellido).Contains(n));
                    }
                    if (!string.IsNullOrWhiteSpace(curp))
                    {
                        string c = curp.Trim();
                        query = query.Where(x => x.a.curp.Contains(c));
                    }
                    if (idCarrera > 0)
                    {
                        query = query.Where(x => x.a.IdCarrera == idCarrera);
                    }
                    if (idModTitu > 0)
                    {
                        query = query.Where(x => x.a.idModTitu == idModTitu);
                    }

                    //FILTROS DE FECHA

                    if (fechaCreacion.HasValue)
                    {
                        DateTime fCreacion = fechaCreacion.Value.Date;
                        query = query.Where(x => EntityFunctions.TruncateTime(x.a.fecha_gen) == fCreacion);
                    }

                    if (fechaImpresion.HasValue)
                    {
                        DateTime fImpresion = fechaImpresion.Value.Date;
                        query = query.Where(x => EntityFunctions.TruncateTime(x.a.FechaImpreasion) == fImpresion);
                    }

                    var resultados = query.Select(x => new
                    {
                        Idtitulo = x.a.IdTitulo,
                        Folio = x.a.folio_electronico,
                        Nombre = x.a.nombre,
                        Paterno = x.a.primerApellido,
                        Materno = x.a.segundoApellido,
                        CURP = x.a.curp,
                        IdCarrera = x.a.IdCarrera,
                        fecha_gen = x.a.fecha_gen,
                        FechaImpreasion = x.a.FechaImpreasion,
                        nombre_Alumno = x.a.nombre.Trim() + " " + x.a.primerApellido.Trim() + " " + x.a.segundoApellido.Trim(),
                        ModTitu = x.b.Modo_titulacion,
                        Carrera = x.c.DESC_CEDULA
                    }).ToList();

                    foreach (var a in resultados)
                    {
                        _ListaTitulos.Add(new dataTitulosEmi()
                        {
                            IdTitulo = a.Idtitulo,
                            folio_electronico = Convert.ToString(a.Folio),
                            nombre = a.Nombre,
                            primerApellido = a.Paterno,
                            segundoApellido = a.Materno,
                            curp = a.CURP,
                            IdCarrera = a.IdCarrera,
                            fecha_gen = Convert.ToDateTime(a.fecha_gen).ToString("dd/MM/yyyy"),
                            FechaImpreasion = a.FechaImpreasion != null ? Convert.ToDateTime(a.FechaImpreasion).ToString("dd/MM/yyyy") : " ",
                            nombre_Alumno = a.nombre_Alumno,
                            ModTitu = a.ModTitu,
                            Carrera = a.Carrera
                        });
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
