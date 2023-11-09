﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECarCare;
using MCarCare;
namespace PresenteacionCarCare
{
    public partial class FrmProgramacionRutinas : Form
    {
        public static ProgramarRutinas rutinas = new ProgramarRutinas(0,0,0,"");
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
            rutinas.FkIdVehiculos = int.Parse(dtgProgramacionRutinas.Rows[fila].Cells[1].Value.ToString());
            rutinas.FkIdRutinas = int.Parse(dtgProgramacionRutinas.Rows[fila].Cells[2].Value.ToString());
            rutinas.Fecha = dtgProgramacionRutinas.Rows[fila].Cells[3].Value.ToString();

            switch (columna)
            {
                case 5: {
                    FrmRutinasProgramadasAdd agregar = new FrmRutinasProgramadasAdd();
                     agregar.ShowDialog();
                    Actualizar();
                    }break;
                case 6: { mrp.Borrar(rutinas);
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
