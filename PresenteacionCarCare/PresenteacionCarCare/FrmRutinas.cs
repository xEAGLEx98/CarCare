using ECarCare;
using MCarCare;
using System;
using System.Windows.Forms;

namespace PresenteacionCarCare
{
    public partial class FrmRutinas : Form
    {
        ManejadorRutinas mR;
        public static Rutinas rutina = new Rutinas(0, "", "");
        int fila = 0, col = 0;
        public FrmRutinas()
        {
            InitializeComponent();
            mR = new ManejadorRutinas();
        }
        void actualizar()
        {
            mR.Mostrar(dtgRutinas, txtBuscar.Text);
        }


        private void dtgRutinas_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            rutina.IdRutinas = int.Parse(dtgRutinas.Rows[fila].Cells[0].Value.ToString());
            rutina.Nombre = dtgRutinas.Rows[fila].Cells[1].Value.ToString();
            rutina.Descripcion = dtgRutinas.Rows[fila].Cells[2].Value.ToString();

            switch (col)
            {
                case 3:
                    {
                        FrmAddRutinas far = new FrmAddRutinas();
                        far.ShowDialog();
                        txtBuscar.Text = "";
                        actualizar();
                    }
                    break;
                case 4:
                    {
                        mR.Borrar(rutina);
                        txtBuscar.Text = "";
                        actualizar();
                    }
                    break;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            actualizar();
        }

        private void dtgRutinas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            col = e.ColumnIndex;
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            rutina.IdRutinas = -1;
            FrmAddRutinas far = new FrmAddRutinas();
            far.ShowDialog();
        }
    }
}
