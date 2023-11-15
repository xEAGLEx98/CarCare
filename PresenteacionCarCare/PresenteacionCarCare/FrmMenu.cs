using MCarCare;
using System;
using System.Windows.Forms;
namespace PresenteacionCarCare
{
    public partial class FrmMenu : Form
    {
        ManejadorRutinasProgramadas mrp;
        public FrmMenu()
        {
            InitializeComponent();
            mrp = new ManejadorRutinasProgramadas();
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            FrmVehiculos vehiculo = new FrmVehiculos();
            vehiculo.ShowDialog();
        }

        private void btnRutinas_Click(object sender, EventArgs e)
        {
            FrmRutinas rutina = new FrmRutinas();
            rutina.ShowDialog();
        }

        private void btnProgramarRutinas_Click(object sender, EventArgs e)
        {
            FrmProgramacionRutinas rutina = new FrmProgramacionRutinas();
            rutina.ShowDialog();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            mrp.Notificaciones(dtgNotificaciones);
        }
    }
}
