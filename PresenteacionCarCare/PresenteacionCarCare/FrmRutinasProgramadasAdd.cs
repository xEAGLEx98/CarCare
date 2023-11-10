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
            mrp.ExtraerDatos(cmbVehiculos);
            mrp.ExtraerDatos(cmbRutinas);
            if (FrmProgramacionRutinas.rutinas.IdRutProgramadas > 0)
            {
                cmbVehiculos.Text = FrmProgramacionRutinas.marcaVehiculo;
                cmbVehiculos.Text = FrmProgramacionRutinas.nombreRutina;
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            mrp.Guardar(new ProgramarRutinas(FrmProgramacionRutinas.rutinas.IdRutProgramadas, cmbVehiculos.SelectedValue.ToString(), cmbRutinas.SelectedValue.ToString(),dtpFecha.Text));
            Close();
        }
    }
}
