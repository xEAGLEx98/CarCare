using System;
using System.Windows.Forms;
using MCarCare;
using ECarCare;
namespace PresenteacionCarCare
{
    public partial class FrmVehiculosAdd : Form
    {
        ManejadorVehiculos mv;
        public FrmVehiculosAdd()
        {
            InitializeComponent();
            mv = new ManejadorVehiculos();
            if (FrmVehiculos.vehiculo.IdVehiculo > 0)
            {
                txtMarca.Text = FrmVehiculos.vehiculo.Marca.ToString();
                txtModelo.Text = FrmVehiculos.vehiculo.Modelo.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mv.Guardar(new Vehiculos(FrmVehiculos.vehiculo.IdVehiculo, txtMarca.Text, txtModelo.Text, cmbTipoVehiculo.Text));
            Close();
        }
        void Limpiar()
        {
            txtMarca.Clear();
            txtModelo.Clear();
        }
    }
}
