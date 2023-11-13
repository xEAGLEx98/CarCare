using ECarCare;
using MCarCare;
using System;
using System.Windows.Forms;

namespace PresenteacionCarCare
{
    public partial class FrmRutinas : Form
    {
        ManejadorRutinas mR;
        //Inicialización de variable de la entidad rutinas.
        public static Rutinas rutina = new Rutinas(0, "", "");
        //Varibale de fila y columna para la tabla.
        int fila = 0, col = 0;
        public FrmRutinas()
        {
            InitializeComponent();
            mR = new ManejadorRutinas();
        }
        //Función de actualizar tabla.
        void actualizar()
        {
            mR.Mostrar(dtgRutinas, txtBuscar.Text);
        }

        //Controlar el click de cada celda.
        private void dtgRutinas_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //Asignación de columnas con los valores de nuestra entidad.
            rutina.IdRutinas = int.Parse(dtgRutinas.Rows[fila].Cells[0].Value.ToString());
            rutina.Nombre = dtgRutinas.Rows[fila].Cells[1].Value.ToString();
            rutina.Descripcion = dtgRutinas.Rows[fila].Cells[2].Value.ToString();
            //Switch para botones editar (3) y borrar (4).
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
            //Actualizar cada que el texto cambie.
            actualizar();
        }

        private void dtgRutinas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Obtención del valor de fila y columna.
            fila = e.RowIndex;
            col = e.ColumnIndex;
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            //-1 para insertar datos.
            rutina.IdRutinas = -1;
            FrmAddRutinas far = new FrmAddRutinas();
            //Mostrar formulario.
            far.ShowDialog();
        }
    }
}
