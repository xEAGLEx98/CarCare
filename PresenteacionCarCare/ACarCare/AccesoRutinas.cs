using ConectarBd;
using System;
using System.Data;

namespace ACarCare
{
    public class AccesoRutinas : ICrud
    {
        Base baseDatos = new Base("localhost", "root", "", "car_care");
        public void Borrar(dynamic entidad)
        {
            baseDatos.Comando(String.Format("CALL borrar_rutinas({0})", entidad.IdRutinas));
        }

        public void Guardar(dynamic entidad)
        {
            baseDatos.Comando(String.Format("CALL insertar_rutinas('{0}', '{1}', {2})", entidad.Nombre, entidad.Descripcion, entidad.IdRutinas));
        }

        public DataSet Mostrar(string filtro)
        {
            return baseDatos.Obtener(string.Format("CALL mostrar_rutinas('%{0}%')", filtro), "rutinas");
        }
    }
}
