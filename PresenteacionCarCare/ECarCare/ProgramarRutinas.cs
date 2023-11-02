using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECarCare
{
    public class ProgramarRutinas
    {
        public ProgramarRutinas(int idRutProgramadas, int fkIdVehiculos, int fkIdRutinas, string fecha)
        {
            IdRutProgramadas = idRutProgramadas;
            FkIdVehiculos = fkIdVehiculos;
            FkIdRutinas = fkIdRutinas;
            Fecha = fecha;
        }

        public int IdRutProgramadas { get; set; }
        public int FkIdVehiculos { get; set; }
        public int FkIdRutinas { get; set; }
        public string Fecha { get; set; }
    }
}
