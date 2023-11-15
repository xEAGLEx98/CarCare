using ECarCare;
using MCarCare;
using System;
using System.Windows.Forms;

namespace PresenteacionCarCare
{
    public partial class FrmAddRutinas : Form
    {
        //Variable de manejador.
        ManejadorRutinas mR;
        public FrmAddRutinas()
        {
            InitializeComponent();
            //Inicialización de variable.
            mR = new ManejadorRutinas();
            //Si el idrutina es mayor a 0 simboliza edicion y recuperamos el valor de los textbox.
            if (FrmRutinas.rutina.IdRutinas > 0)
            {
                txtNombre.Text = FrmRutinas.rutina.Nombre;
                txtDescripcion.Text = FrmRutinas.rutina.Descripcion;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Valida que los textos estén entre un rango de caracteres y si es así guarda.
            if(Validar(txtNombre.Text,20,3,lblErrorNombre,"Error, su nombre de la rutina debe tener entre 3 y 20 caracteres.")&&
               Validar(txtDescripcion.Text,100,20,lblErrorDescripcion,"Error, ingrese una descripcion entre los 20 y 100 caracteres."))
            {
                //Guardar de la función del manejador.
                mR.Guardar(new Rutinas(FrmRutinas.rutina.IdRutinas, txtNombre.Text, txtDescripcion.Text));
                Close();
            }
        }
        //Funcion validar.
        bool Validar(string texto,int limiteMayor, int limiteMenor, Label etiqueta, string mensajeError)
        {
            if(texto.Length >= limiteMayor || texto.Length <= limiteMenor)
            {
                etiqueta.Text = mensajeError;
                return false;
            }
            return true;
        }
        //Función para limpiar los labels de los errores.
        void LimpiarErrores()
        {
            lblErrorDescripcion.Text = "";
            lblErrorNombre.Text = "";
        }
        //Al cambiar el texto de los textbox, se ejecuta la función limpiar errores.
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            LimpiarErrores();
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            LimpiarErrores();
        }
    }
}
