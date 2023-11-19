using System;
using System.Drawing;
using System.Windows.Forms;
using ECarCare;
using MCarCare;

namespace PresenteacionCarCare
{
    public partial class FrmVehiculos : Form
    {
        //entidad de vehiculos.
        public static Vehiculos vehiculo = new Vehiculos(0, "", "", "");
        ManejadorVehiculos mv;
        //Variable de la fila y columna de la tabla..
        int fila = 0, columna = 0;
        public FrmVehiculos()
        {
            InitializeComponent();
            mv = new ManejadorVehiculos();
        }
        //Mostrar vehiculos por filtro
        void Actualizar()
        {
            mv.Mostrar(dtgVehiculos, txtBuscarMarca.Text);
        }
        //Mostrar el formulario de inserción.
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            vehiculo.IdVehiculo = -1;
            FrmVehiculosAdd agregar = new FrmVehiculosAdd();
            agregar.ShowDialog();
        }

        private void dtgVehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Acomodar las columnas de la tabla vehiculos.
            //ID.
            vehiculo.IdVehiculo = int.Parse(dtgVehiculos.Rows[fila].Cells[0].Value.ToString());
            //Marca.
            vehiculo.Marca = dtgVehiculos.Rows[fila].Cells[1].Value.ToString();
            //Modelo
            vehiculo.Modelo = dtgVehiculos.Rows[fila].Cells[2].Value.ToString();
            //Tipo de vehiculo.
            vehiculo.TipoVehiculo = dtgVehiculos.Rows[fila].Cells[3].Value.ToString();
            //Botones de editar (4) y borrar (5) de cada fila.
            switch (columna)
            {
                case 4: {
                        FrmVehiculosAdd agregar = new FrmVehiculosAdd();
                        agregar.ShowDialog();
                        Actualizar();
                    }
                    break;
                case 5: {
                        mv.Borrar(vehiculo);
                        Actualizar();
                }break;
            }
        }

        private void dtgVehiculos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Tomar el valor de fila y columna.
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }

        private void FrmVehiculos_Load(object sender, EventArgs e)
        {
            Styles();
        }
        void Styles()
        {
            txtBuscarMarca.BackColor = ColorTranslator.FromHtml("#d1dbe7");
            this.BackColor = ColorTranslator.FromHtml("#eaedf2");
            lblVehiculos.ForeColor = ColorTranslator.FromHtml("#676767");
            lblRutinas.ForeColor = ColorTranslator.FromHtml("#cdcdcd");
            lblProgramarRutinas.ForeColor = ColorTranslator.FromHtml("#cdcdcd");
            btnAñadir.BackColor = ColorTranslator.FromHtml("#abd573");
            //dtgVehiculos.BackgroundColor = ColorTranslator.FromHtml("#eaedf2");
            // Configurar el DataGridView
            dtgVehiculos.BorderStyle = BorderStyle.None;
            dtgVehiculos.CellBorderStyle = DataGridViewCellBorderStyle.None;

            // Ocultar encabezados de fila y columna
            dtgVehiculos.RowHeadersVisible = false;
            dtgVehiculos.ColumnHeadersVisible = false;

            // Configurar el espaciado entre las filas
            dtgVehiculos.RowTemplate.Height = 60;
        }

        private void dtgVehiculos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Agregar líneas divisorias entre las filas
            if (e.RowIndex > -1 && e.RowIndex < dtgVehiculos.RowCount - 1)
            {
                using (Pen pen = new Pen(Color.White))
                {
                    e.Graphics.DrawLine(pen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right, e.CellBounds.Bottom - 1);
                }
            }
        }

        private void txtBuscarMarca_TextChanged(object sender, EventArgs e)
        {
            //Filtrar información al cambiar el texto.
            Actualizar();
        }


    }
}
