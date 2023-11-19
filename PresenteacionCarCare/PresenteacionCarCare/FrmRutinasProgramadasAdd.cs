using System;
using System.Windows.Forms;
using MCarCare;
using ECarCare;
using System.Drawing;

namespace PresenteacionCarCare
{
    public partial class FrmRutinasProgramadasAdd : Form
    {
        ManejadorRutinasProgramadas mrp;
        
        public FrmRutinasProgramadasAdd()
        {
            InitializeComponent();
            mrp = new ManejadorRutinasProgramadas();
            //Llamar desde el manejador a la función Extraer para traer los datos de la base de datos al comboBox.
            mrp.ExtraerDatos(cmbVehiculos);
            mrp.ExtraerDatos(cmbRutinas);
            if (FrmProgramacionRutinas.rutinas.IdRutProgramadas > 0)
            {
                //Tomar los datos seleccionados al editar.
                cmbVehiculos.Text = FrmProgramacionRutinas.modeloVehiculo;
                cmbRutinas.Text = FrmProgramacionRutinas.descripcionRutina;
            }
        }

        void Limpiar()
        {
            lblFechaError.Text = "";
        }
        bool Validar(DateTimePicker fecha, Label error)
        {
            DateTime fechaHoy = DateTime.Now.Date;
            DateTime fechaSeleccionada = fecha.Value;

            // Compara las fechas
            if (fechaSeleccionada < fechaHoy)
            {
                error.Text= "No puedes seleccionar una fecha anterior a hoy.";
                return false;
            }
            return true;
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            //Guardar la información.
            if (Validar(dtpFecha, lblFechaError))
            {
                mrp.Guardar(new ProgramarRutinas(FrmProgramacionRutinas.rutinas.IdRutProgramadas, int.Parse(cmbVehiculos.SelectedValue.ToString()), int.Parse(cmbRutinas.SelectedValue.ToString()), dtpFecha.Text));
                Close();
            }
        }

        private void FrmRutinasProgramadasAdd_Load(object sender, EventArgs e)
        {
            Limpiar();
            Style();
        }
        void Style()
        {
            btnAñadir.BackColor = ColorTranslator.FromHtml("#3d67dd");
            btnCancelar.ForeColor = ColorTranslator.FromHtml("#f6686c");
            cmbVehiculos.ForeColor = ColorTranslator.FromHtml("#565656");
            cmbRutinas.BackColor = ColorTranslator.FromHtml("#cfd2d7");
            cmbVehiculos.BackColor = ColorTranslator.FromHtml("#cfd2d7");
            dtpFecha.BackColor = ColorTranslator.FromHtml("#cfd2d7");
            dtpFecha.CalendarForeColor = ColorTranslator.FromHtml("#f5f5f5");
            lblFechaError.ForeColor = ColorTranslator.FromHtml("#f6686c");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
