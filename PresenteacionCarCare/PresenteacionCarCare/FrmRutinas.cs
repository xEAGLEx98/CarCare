using ECarCare;
using MCarCare;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PresenteacionCarCare
{
    public partial class FrmRutinas : Form
    {
        ManejadorRutinas mR;
        ManejadorRutinasProgramadas mrp;
        //Inicialización de variable de la entidad rutinas.
        public static Rutinas rutina = new Rutinas(0, "", "");
        //Varibale de fila y columna para la tabla.
        int fila = 0, col = 0;
        public FrmRutinas()
        {
            InitializeComponent();
            mR = new ManejadorRutinas();
            mrp = new ManejadorRutinasProgramadas();
        }
        //Función de actualizar tabla.
        void actualizar()
        {
            mR.Mostrar(dtgRutinas, txtBuscar.Text);
        }


        private void FrmRutinas_Load(object sender, EventArgs e)
        {
            Style();
        }
        void Style()
        {
            panel1.BackColor = ColorTranslator.FromHtml("#f5f5f5");
            //PANEL Info
            panel2.BackColor = ColorTranslator.FromHtml("#b5cbf4");
            lblNombreRutina.ForeColor = ColorTranslator.FromHtml("#3d547e");
            lblDescripcion.ForeColor = ColorTranslator.FromHtml("#3d547e");
            lblControl.ForeColor = ColorTranslator.FromHtml("#3d547e");

            txtBuscar.BackColor = ColorTranslator.FromHtml("#d1dbe7");
            this.BackColor = ColorTranslator.FromHtml("#eaedf2");
            lblVehiculos.ForeColor = ColorTranslator.FromHtml("#cdcdcd");
            lblRutinas.ForeColor = ColorTranslator.FromHtml("#676767");
            lblProgramarRutinas.ForeColor = ColorTranslator.FromHtml("#cdcdcd");
            btnAgregar.BackColor = ColorTranslator.FromHtml("#abd573");
            // Configurar el DataGridView
            dtgRutinas.BorderStyle = BorderStyle.None;
            dtgRutinas.BackgroundColor = ColorTranslator.FromHtml("#eaedf2");
            dtgRutinas.ForeColor = ColorTranslator.FromHtml("#676767");

            //dtgVehiculos.BackgroundColor = ColorTranslator.FromHtml("#eaedf2");
            dtgRutinas.CellBorderStyle = DataGridViewCellBorderStyle.None;
            // Ocultar encabezados de fila y columna
            dtgRutinas.RowHeadersVisible = false;
            dtgRutinas.ColumnHeadersVisible = false;

            lblSalir.ForeColor = ColorTranslator.FromHtml("#f86869");
        }
        //Controlar el click de cada celda.
        private void dtgRutinas_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void lblVehiculos_Click(object sender, EventArgs e)
        {
            FrmVehiculos vehiculo = new FrmVehiculos();
            vehiculo.ShowDialog();
        }

        private void lblRutinas_Click(object sender, EventArgs e)
        {
            FrmRutinas rutina = new FrmRutinas();
            rutina.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //-1 para insertar datos.
            rutina.IdRutinas = -1;
            FrmAddRutinas far = new FrmAddRutinas();
            //Mostrar formulario.
            far.ShowDialog();
        }

        private void dtgRutinas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Obtención del valor de fila y columna.
            fila = e.RowIndex;
            col = e.ColumnIndex;
        }

        private void lblProgramarRutinas_Click(object sender, EventArgs e)
        {
            FrmProgramacionRutinas rutina = new FrmProgramacionRutinas();
            rutina.ShowDialog();
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            //Actualizar cada que el texto cambie.
            actualizar();
        }

    }
}
