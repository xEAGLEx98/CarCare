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
    public partial class FrmRutinasProgramadasAdd : Form
    {
        ManejadorRutinasProgramadas mrp;
        
        public FrmRutinasProgramadasAdd()
        {
            InitializeComponent();
            mrp = new ManejadorRutinasProgramadas();
            /*mrp.ExtraerDatos(cmbVehiculos, "vehiculos", "marca", "id_vehiculos");
            mrp.ExtraerDatos(cmbRutinas, "rutinas", "nombre", "id_rutinas");*/
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
            mrp.Guardar(new ProgramarRutinas(FrmProgramacionRutinas.rutinas.IdRutProgramadas, int.Parse(cmbVehiculos.SelectedValue.ToString()), int.Parse(cmbRutinas.SelectedValue.ToString()),dtpFecha.Text));
            Close();
        }
    }
}
