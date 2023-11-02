using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECarCare
{
    public class Vehiculos
    {
        public Vehiculos(int idVehiculo, string marca, string modelo, string tipoVehiculo)
        {
            IdVehiculo = idVehiculo;
            Marca = marca;
            Modelo = modelo;
            TipoVehiculo = tipoVehiculo;
        }

        public int IdVehiculo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string TipoVehiculo { get; set; }
    }
}
