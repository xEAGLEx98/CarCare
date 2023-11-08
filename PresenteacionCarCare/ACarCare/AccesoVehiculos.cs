using System;
using System.Data;
using ConectarBd;
namespace ACarCare
{
    public class AccesoVehiculos : ICrud
    {
        Base baseDatos = new Base("localhost", "root", "", "car_care", 3306);
        public void Borrar(dynamic entidad)
        {
            baseDatos.comando(String.Format("CALL eliminar_vehiculos({0})", entidad.IdVehiculo));
        }

        public void Guardar(dynamic entidad)
        {
            baseDatos.comando(String.Format("CALL insertar_vehiculos('{0}', '{1}', '{2}', {3})",entidad.Marca, entidad.Modelo, entidad.TipoVehiculo, entidad.IdVehiculo));
        }

        public DataSet Mostrar(string filtro)//CALL mostrar_vehiculos('%{0}%')
        {
            return baseDatos.Obtener(string.Format("CALL mostrar_vehiculos('%{0}%')", filtro), "vehiculos");
        }
    }
}
