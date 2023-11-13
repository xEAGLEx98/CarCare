using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresenteacionCarCare
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
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
    }
}
