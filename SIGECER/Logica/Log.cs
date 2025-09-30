using Sigecer.Clases;
using Sigecer.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigecer.Logica
{
    internal class Log
    {

        public static Log _log = null;

        public Log()
        {

        }

        public static Log Instancia
        {
            get
            {
                if (_log == null) _log = new Log();
                return _log;
            }
        }

        public int LogInsert(dataLog log, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;
            try
            {
                using (DBCERCEISEntities ctx = new DBCERCEISEntities())
                {
                    tb_log Nlog = new   tb_log();
                    Nlog.usuario = log.usuario.Trim();
                    Nlog.Tipo = log.Tipo.Trim();
                    Nlog.Modulo = log.Modulo.Trim();
                    Nlog.Modificacion = log.Modificacion.Trim();
                    Nlog.FechaModificacion = DateTime.Now;
                    ctx.tb_log.Add(Nlog);
                    ctx.SaveChanges();
                    respuesta = 1;
                }
            }
            catch (Exception ex)
            {
                respuesta = 0;
                mensaje = "Problemas al guardar";
            }
            return respuesta;
        }
    }
}
