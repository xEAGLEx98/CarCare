using System;
using System.Windows.Forms;
using MCarCare;
using ECarCare;
namespace PresenteacionCarCare
{
    public partial class FrmRutinasProgramadasAdd : Form
    {
        ManejadorRutinasProgramadas mrp;
        
        public FrmRutinasProgramadasAdd()
        {
            InitializeComponent();
            mrp = new ManejadorRutinasProgramadas();
            //Llamar desde el manejador a la función Extraer para traer los datos de la base de datos al comboBox.
            mrp.ExtraerDatos(cmbVehiculos);
            mrp.ExtraerDatos(cmbRutinas);
            if (FrmProgramacionRutinas.rutinas.IdRutProgramadas > 0)
            {
                //Tomar los datos seleccionados al editar.
                cmbVehiculos.Text = FrmProgramacionRutinas.modeloVehiculo;
                cmbRutinas.Text = FrmProgramacionRutinas.descripcionRutina;
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            //Guardar la información.
            mrp.Guardar(new ProgramarRutinas(FrmProgramacionRutinas.rutinas.IdRutProgramadas, int.Parse(cmbVehiculos.SelectedValue.ToString()), int.Parse(cmbRutinas.SelectedValue.ToString()),dtpFecha.Text));
            Close();
        }
    }
}
