using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Limpiar();
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
