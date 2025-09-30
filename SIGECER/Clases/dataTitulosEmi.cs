using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigecer.Clases
{
    internal class dataTitulosEmi
    {
        public int? IdCarrera { get; set; }
        public int IdTitulo { get; set; }
        public string folio_electronico { get; set; }
        public string nombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public string curp { get; set; }
        public int carrera { get; set; }
        public string fecha_gen { get; set; }
        public string FechaImpreasion { get; set; } = null;

        public string nombre_Alumno { get; set; }
        public string ModTitu { get; set; }
        public string Carrera { get; set; }
    }
}
