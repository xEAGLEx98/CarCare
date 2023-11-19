using System;
using System.Windows.Forms;
using MCarCare;
using ECarCare;
using System.Text.RegularExpressions;
using System.Drawing;

namespace PresenteacionCarCare
{
    public partial class FrmVehiculosAdd : Form
    {
        ManejadorVehiculos mv;
        public FrmVehiculosAdd()
        {
            InitializeComponent();
            //Variable del manejador.
            mv = new ManejadorVehiculos();
            //Comprobacion para editar.
            if (FrmVehiculos.vehiculo.IdVehiculo > 0)
            {
                //Valores de texto de la fila para traerlos al textbox.
                txtMarca.Text = FrmVehiculos.vehiculo.Marca.ToString();
                txtModelo.Text = FrmVehiculos.vehiculo.Modelo.ToString();
                cmbTipoVehiculo.Text = FrmVehiculos.vehiculo.TipoVehiculo.ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Validar que las marcas de los vehiculos comiencen con una letra mayúscula seguido de minúsculas o números.
            //Validar que los modelos tengan el nombre de su modelo con mayuscula al inicio y después minúscula, un espacio y el año del vehículo.
            //Validar que haya texto en el comboBox, para poder guardar el registro.
            if (Validar(@"\A[A-Z]+[a-z]*[0-9]*?\Z", txtMarca.Text, lblMarcaError, "Error, coloque una marca comenzando con una letra mayúscula") &&
                Validar(@"\A[A-Z]+[a-z]*\s\d{4}$\Z", txtModelo.Text, lblModeloError, "Error, coloque un modelo comenzando\ncon una letra mayúscula y con un año de modelo.") &&
                Validar(@"\A.+?\Z", cmbTipoVehiculo.Text, lblErrorTipoVehiculo, "Error, seleccione un tipo de vehiculo para guardar el registro."))
            {
                mv.Guardar(new Vehiculos(FrmVehiculos.vehiculo.IdVehiculo, txtMarca.Text, txtModelo.Text, cmbTipoVehiculo.Text));
                Close();
            }
        }

        bool Validar(string regex, string textbox, Label label, string error)
        {
            Regex marca = new Regex(regex);
            if (!marca.IsMatch(textbox))
            {
                label.Text = error;
                return false;
            }
            return true;
        }
        //Limpiar los textos de error.
        void LimpiarErrores()
        {
            lblMarcaError.Text = "";
            lblModeloError.Text = "";
            lblErrorTipoVehiculo.Text = "";
        }
        //Limpiar los textos de error cuando las cajas de texto se cambien.
        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            LimpiarErrores();
        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {
            LimpiarErrores();
        }

        private void FrmVehiculosAdd_Load(object sender, EventArgs e)
        {
            LimpiarErrores();
            Style();

        }
        public void Style()
        {
            btnGuardar.BackColor = ColorTranslator.FromHtml("#3d67dd");
            btnCancelar.ForeColor = ColorTranslator.FromHtml("#f6686c");
            txtMarca.ForeColor = ColorTranslator.FromHtml("#565656");
            txtMarca.BackColor = ColorTranslator.FromHtml("#cfd2d7");
            txtModelo.BackColor = ColorTranslator.FromHtml("#cfd2d7");
            cmbTipoVehiculo.BackColor = ColorTranslator.FromHtml("#cfd2d7");
            lblErrorTipoVehiculo.ForeColor = ColorTranslator.FromHtml("#f6686c");
            lblMarcaError.ForeColor = ColorTranslator.FromHtml("#f6686c");
            lblModeloError.ForeColor = ColorTranslator.FromHtml("#f6686c");
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
