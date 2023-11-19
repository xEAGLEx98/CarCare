using System;
using System.Drawing;
using System.Windows.Forms;
using ECarCare;
using MCarCare;
namespace PresenteacionCarCare
{
    public partial class FrmProgramacionRutinas : Form
    {
        //Variable de entidad para accesar a nuestras propiedades de la entidad Programar rutinas.
        public static ProgramarRutinas rutinas = new ProgramarRutinas(0,0,0,"");
        //Variable para almacenar el valor del modelo de vehículo y la descripcion de la rutina por cada fila.
        public static string modeloVehiculo = "", descripcionRutina = "";
        //Acceso a nuestro manejador de rutinas.
        ManejadorRutinasProgramadas mrp;
        //Capturar la fila y columna de la tabla.
        int fila = 0, columna = 0;
        public static int contador = 0;
        public FrmProgramacionRutinas()
        {
            InitializeComponent();
            //Inicialización de la variable de nuestro manejador.
            mrp = new ManejadorRutinasProgramadas();
        }
        //Función de actualizar que llama con el manejador a la función mostrar.
        void Actualizar()
        {
            mrp.Mostrar(dtgProgramacionRutinas, txtBuscarRutinas.Text);
        }

        private void FrmProgramacionRutinas_Load(object sender, EventArgs e)
        {
            if (contador==0)
            {
                mrp.Notificaciones(dtgNotificaciones);
                // Marcar que la función ya se ejecutó
                contador++;
            }
            Style();
        }

        private void txtBuscarRutinas_TextChanged(object sender, EventArgs e)
        {
            //Actualizar cada que el texto cambie.
            Actualizar();
        }

        private void dtgProgramacionRutinas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Asignación de columnas de la tabla.
            //ID.
            rutinas.IdRutProgramadas = int.Parse(dtgProgramacionRutinas.Rows[fila].Cells[0].Value.ToString());
            //Modelo.
            modeloVehiculo = dtgProgramacionRutinas.Rows[fila].Cells[1].Value.ToString();
            //Rutina.
            descripcionRutina = dtgProgramacionRutinas.Rows[fila].Cells[2].Value.ToString();
            //Fecha
            rutinas.Fecha = dtgProgramacionRutinas.Rows[fila].Cells[3].Value.ToString();
            //Switch de columna para los 2 botones de editar (4) y borrar (5)
            switch (columna)
            {
                case 4:
                    {
                        FrmRutinasProgramadasAdd agregar = new FrmRutinasProgramadasAdd();
                        agregar.ShowDialog();
                        Actualizar();
                    }
                    break;
                case 5:
                    {
                        mrp.Borrar(rutinas);
                        Actualizar();
                    }
                    break;
            }
        }

        private void dtgProgramacionRutinas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Asignación de filas y columnas de la tabla.
            fila = e.RowIndex;
            columna = e.ColumnIndex;
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

        private void lblProgramarRutinas_Click(object sender, EventArgs e)
        {
            FrmProgramacionRutinas rutina = new FrmProgramacionRutinas();
            rutina.ShowDialog();
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAñadirRutinas_Click(object sender, EventArgs e)
        {
            //ID -1 para insertar a la base de datos de acuerdo al procedure.
            rutinas.IdRutProgramadas = -1;

            FrmRutinasProgramadasAdd agregar = new FrmRutinasProgramadasAdd();
            //Mostrar el formulario.
            agregar.ShowDialog();
        }

        void Style()
        {
            //PANEL
            panel1.BackColor = ColorTranslator.FromHtml("#f5f5f5");
            //PANEL INFO
            panel2.BackColor = ColorTranslator.FromHtml("#b5cbf4");
            lblVehiculo.ForeColor = ColorTranslator.FromHtml("#39507c");
            lblDescripcion.ForeColor = ColorTranslator.FromHtml("#39507c");
            lblFecha.ForeColor = ColorTranslator.FromHtml("#39507c");
            lblControl.ForeColor = ColorTranslator.FromHtml("#39507c");


            txtBuscarRutinas.BackColor = ColorTranslator.FromHtml("#d1dbe7");
            this.BackColor = ColorTranslator.FromHtml("#eaedf2");
            //NAV
            lblVehiculos.ForeColor = ColorTranslator.FromHtml("#cdcdcd");
            lblRutinas.ForeColor = ColorTranslator.FromHtml("#cdcdcd");
            lblProgramarRutinas.ForeColor = ColorTranslator.FromHtml("#676767");
            btnAñadirRutinas.BackColor = ColorTranslator.FromHtml("#abd573");
            // Configurar el DataGridView
            dtgProgramacionRutinas.BorderStyle = BorderStyle.None;
            dtgProgramacionRutinas.BackgroundColor = ColorTranslator.FromHtml("#eaedf2");
            dtgProgramacionRutinas.ForeColor = ColorTranslator.FromHtml("#676767");

            //dtgVehiculos.BackgroundColor = ColorTranslator.FromHtml("#eaedf2");
            dtgProgramacionRutinas.CellBorderStyle = DataGridViewCellBorderStyle.None;
            // Ocultar encabezados de fila y columna
            dtgProgramacionRutinas.RowHeadersVisible = false;
            dtgProgramacionRutinas.ColumnHeadersVisible = false;
            lblSalir.ForeColor = ColorTranslator.FromHtml("#f86869");
            dtgNotificaciones.Visible= false;
        }
    }
}
