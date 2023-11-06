using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECarCare;
using MCarCare;

namespace PresenteacionCarCare
{
    public partial class FrmVehiculos : Form
    {
        public static Vehiculos vehiculo = new Vehiculos(0, "", "", "");
        ManejadorVehiculos mv;
        int fila = 0, columna = 0;
        public FrmVehiculos()
        {
            InitializeComponent();
            mv = new ManejadorVehiculos();
        }

        private void FrmVehiculos_Load(object sender, EventArgs e)
        {
            Actualizar();
        }
        //Mostrar vehiculos por filtro
        void Actualizar()
        {
            mv.Mostrar(dtgVehiculos, txtBuscarMarca.Text);
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            vehiculo.IdVehiculo = -1;
            //FrmVehiculosAdd agregar = new FrmVehiculosAdd();
            //agregar.ShowDialog();
        }

        private void dtgVehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vehiculo.IdVehiculo = int.Parse(dtgVehiculos.Rows[fila].Cells[0].Value.ToString());
            vehiculo.Marca = dtgVehiculos.Rows[fila].Cells[1].Value.ToString();
            vehiculo.Modelo = dtgVehiculos.Rows[fila].Cells[2].Value.ToString();
            vehiculo.TipoVehiculo = dtgVehiculos.Rows[fila].Cells[3].Value.ToString();
            switch (columna)
            {
                case 4: {
                        //FrmVehiculosAdd agregar = new FrmVehiculosAdd();
                        //agregar.ShowDialog();
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
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }

        private void txtBuscarMarca_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }


    }
}
