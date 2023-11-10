using ECarCare;
using MCarCare;
using System;
using System.Windows.Forms;

namespace PresenteacionCarCare
{
    public partial class FrmAddRutinas : Form
    {
        ManejadorRutinas mR;
        public FrmAddRutinas()
        {
            InitializeComponent();
            mR = new ManejadorRutinas();
            if (FrmRutinas.rutina.IdRutinas > 0)
            {
                txtNombre.Text = FrmRutinas.rutina.Nombre;
                txtDescripcion.Text = FrmRutinas.rutina.Descripcion;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            mR.Guardar(new Rutinas(FrmRutinas.rutina.IdRutinas, txtNombre.Text, txtDescripcion.Text));
            Close();
        }
    }
}
