using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECarCare
{
    public class Rutinas
    {
        public Rutinas(int idRutinas, string nombre, string descripcion)
        {
            IdRutinas = idRutinas;
            Nombre = nombre;
            Descripcion = descripcion;
        }

        public int IdRutinas { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

    }
}
