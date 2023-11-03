using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACarCare
{
    public interface ICrud
    {
        void Guardar(dynamic entidad);
        void Borrar(dynamic entidad);
        DataSet Mostrar(string filtro);
    }
}
