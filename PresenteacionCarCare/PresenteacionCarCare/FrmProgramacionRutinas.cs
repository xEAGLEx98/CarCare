using System;
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

        private void dtgProgramacionRutinas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Asignación de filas y columnas de la tabla.
            fila = e.RowIndex;
            columna = e.ColumnIndex;
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
            //ID -1 para insertar a la base de datos de acuerdo al procedure.
            rutinas.IdRutProgramadas = -1;

            FrmRutinasProgramadasAdd agregar = new FrmRutinasProgramadasAdd();
            //Mostrar el formulario.
            agregar.ShowDialog();
            
        }

        private void txtBuscarRutinas_TextChanged(object sender, EventArgs e)
        {
            //Actualizar cada que el texto cambie.
            Actualizar();
        }
    }
}
