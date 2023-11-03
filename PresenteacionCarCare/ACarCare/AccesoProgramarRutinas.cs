using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectarBd;
namespace ACarCare
{
    public class AccesoProgramarRutinas:ICrud
    {
        Base baseDatos = new Base("localhost", "root", "", "car_care");
        public void Borrar(dynamic entidad)
        {
            baseDatos.Comando(String.Format("CALL borrar_rutinas_programadas({0})", entidad.IdRutProgramadas));
        }

        public void Guardar(dynamic entidad)
        {
            baseDatos.Comando(String.Format("CALL insertar_rutinas_programadas({0}, {1}, '{2}', {3})", entidad.FkIdVehiculos, entidad.FkIdRutinas, entidad.Fecha, entidad.IdRutProgramadas));
        }

        public DataSet Mostrar(string filtro)
        {
            return baseDatos.Obtener(string.Format("call mostrar_rutinas_programadas('%{0}%')", filtro), "programar_rutinas");
        }
    }
}
