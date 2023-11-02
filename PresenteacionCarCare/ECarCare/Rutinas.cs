using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECarCare
{
    public class Rutinas
    {
        public Rutinas(int idRutinas, string descripcion)
        {
            IdRutinas = idRutinas;
            Descripcion = descripcion;
        }

        public int IdRutinas { get; set; }
        public string Descripcion { get; set; }
    }
}
