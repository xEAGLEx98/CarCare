using System;
using System.Windows.Forms;
using MCarCare;
using ECarCare;
using System.Text.RegularExpressions;

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
                cmbTipoVehiculo.Text = FrmVehiculos.vehiculo.TipoVehiculo.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Validar(@"\A[A-Z]+[a-z]*[0-9]*?\Z", txtMarca.Text, lblMarcaError, "Error, coloque una marca comenzando con una letra mayúscula");
            //Validar(@"\A[A-Z]+[a-z]*[0-9]+?\Z", txtModelo.Text, lblModeloError, "Error, coloque un modelo comenzando con una letra mayúscula y con un año de modelo.");
            mv.Guardar(new Vehiculos(FrmVehiculos.vehiculo.IdVehiculo, txtMarca.Text, txtModelo.Text, cmbTipoVehiculo.Text));
            Close();
        }

        void Validar(string regex, string textbox, Label label, string error)
        {
            Regex marca = new Regex(regex);
            if (!marca.IsMatch(textbox))
            {
                label.Text = error;
                MessageBox.Show(label.Text);
            }

            else if (lblModeloError.Text == "" && lblMarcaError.Text == "")
            {
                mv.Guardar(new Vehiculos(FrmVehiculos.vehiculo.IdVehiculo, txtMarca.Text, txtModelo.Text, cmbTipoVehiculo.Text));
                Close();
            }

        }
    }
}
