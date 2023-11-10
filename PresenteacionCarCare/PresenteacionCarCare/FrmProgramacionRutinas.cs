using System;
using System.Windows.Forms;
using ECarCare;
using MCarCare;
namespace PresenteacionCarCare
{
    public partial class FrmProgramacionRutinas : Form
    {
        public static ProgramarRutinas rutinas = new ProgramarRutinas(0,"","","");
        public static string marcaVehiculo = "", nombreRutina = "";
        ManejadorRutinasProgramadas mrp;
        
        int fila = 0, columna = 0;
        public FrmProgramacionRutinas()
        {
            InitializeComponent();
            mrp = new ManejadorRutinasProgramadas();
        }
        void Actualizar()
        {
            mrp.Mostrar(dtgProgramacionRutinas, txtBuscarRutinas.Text);
        }

        private void dtgProgramacionRutinas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }

        private void dtgProgramacionRutinas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rutinas.IdRutProgramadas = int.Parse(dtgProgramacionRutinas.Rows[fila].Cells[0].Value.ToString());
            rutinas.FkIdVehiculos = dtgProgramacionRutinas.Rows[fila].Cells[1].Value.ToString();
            rutinas.FkIdRutinas = dtgProgramacionRutinas.Rows[fila].Cells[2].Value.ToString();
            rutinas.Fecha = dtgProgramacionRutinas.Rows[fila].Cells[3].Value.ToString();

            switch (columna)
            {
                case 4: {
                    FrmRutinasProgramadasAdd agregar = new FrmRutinasProgramadasAdd();
                    agregar.ShowDialog();
                    Actualizar();
                    }break;
                case 5: { mrp.Borrar(rutinas);
                          Actualizar();
                    }break;
            }

        }

        private void btnAñadirRutinas_Click(object sender, EventArgs e)
        {
            rutinas.IdRutProgramadas = -1;
          FrmRutinasProgramadasAdd agregar = new FrmRutinasProgramadasAdd();
            agregar.ShowDialog();
            
        }

        private void txtBuscarRutinas_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }
    }
}
