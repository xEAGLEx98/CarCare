using ConectarBd;
using System;
using System.Data;

namespace ACarCare
{
    public class AccesoProgramarRutinas : ICrud
    {
        Base baseDatos = new Base("localhost", "root", "","car_care",3306);
        public void Borrar(dynamic entidad)
        {
            baseDatos.comando(String.Format("CALL borrar_rutinas_programadas({0})", entidad.IdRutProgramadas));
        }

        public void Guardar(dynamic entidad)
        {
            baseDatos.comando(String.Format("CALL insertar_rutinas_programadas({0}, {1}, '{2}', {3})", entidad.FkIdVehiculos, entidad.FkIdRutinas, entidad.Fecha, entidad.IdRutProgramadas));
        }

        public DataSet Mostrar(string filtro)
        {
            return baseDatos.Obtener(string.Format("call mostrar_rutinas_programadas('%{0}%')", filtro), "programar_rutinas");
        }


        public DataSet MostrarCmb()
        {
            return baseDatos.Obtener("SELECT * FROM programar_rutinas ","programar_rutinas");
        }
    }
}
