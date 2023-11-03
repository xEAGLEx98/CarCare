using ConectarBd;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACarCare
{
    internal class AccesoVehiculos : ICrud
    {
        Base baseDatos = new Base("localhost", "root", "", "car_care");
        public void Borrar(dynamic entidad)
        {
            baseDatos.Comando(String.Format("CALL eliminar_vehiculos({0})", entidad.IdVehiculo));
        }

        public void Guardar(dynamic entidad)
        {
            baseDatos.Comando(String.Format("CALL insertar_vehiculos('{0}', '{1}', '{2}', {3})", entidad.Marca, entidad.Modelo, entidad.TipoVehiculo, entidad.IdVehiculo));
        }

        public DataSet Mostrar(string filtro)
        {
            return baseDatos.Obtener(string.Format("call mostrar_vehiculos('%{0}%')", filtro), "vehiculos");
        }
    }
}
