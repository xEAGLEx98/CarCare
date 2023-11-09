using ACarCare;
using System;
using System.Drawing;
using System.Windows.Forms;
using Crud;
namespace MCarCare
{
    public class ManejadorRutinasProgramadas : ICrud
    {
        AccesoProgramarRutinas rutinas = new AccesoProgramarRutinas();
        Grafico grafico = new Grafico();
        public void Borrar(dynamic entidad)
        {
            //Tomar el resultado del messagebox.
            DialogResult resultado = MessageBox.Show(String.Format("¿Desea eliminar este registro {0}?", entidad.Nombre), "!Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //Si el resultado es si en la pregunta de desea eliminar.
            if (resultado == DialogResult.Yes)
                //Borrar registro.
                rutinas.Borrar(entidad);
        }


        public void Guardar(dynamic entidad)
        {
            //Guardar y mostrar mensaje de guardado.
            rutinas.Guardar(entidad);
            MessageBox.Show("Rutina guardada correctamente", "!Información!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            //Limpiar tabla
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            //Fuente de datos.
            tabla.DataSource = rutinas.Mostrar(filtro).Tables["programar_rutinas"];
            //AGREGAR BOTONES.
            //EDITAR
            tabla.Columns.Insert(5, grafico.Boton("Editar", Color.Green));
            //BORRAR
            tabla.Columns.Insert(6, grafico.Boton("Eliminar", Color.Red));
            //OCULTAR ID
            tabla.Columns[0].Visible = false;
        }

        /*public void ExtraerDatos(ComboBox caja, string tabla, string tituloColumna, string elementoDb)
        {
            caja.DataSource = rutinas.MostrarCmb().Tables[tabla];
            MessageBox.Show(caja.ToString());
            caja.DisplayMember = tituloColumna;
            caja.ValueMember = elementoDb;
        }*/

        public void ExtraerDatos(ComboBox caja)
        {
            if(caja.Name == "cmbVehiculos")
            {
                caja.DataSource = rutinas.MostrarCmb("SELECT id_vehiculos, modelo FROM vehiculos;", "vehiculos").Tables["vehiculos"];
                MessageBox.Show(caja.ToString());
                caja.DisplayMember = "modelo";
                caja.ValueMember = "id_vehiculos";
            }
            if(caja.Name == "cmbRutinas")
            {
                caja.DataSource = rutinas.MostrarCmb("SELECT id_rutinas, nombre FROM rutinas;", "rutinas").Tables["rutinas"];
                MessageBox.Show(caja.ToString());
                caja.DisplayMember = "nombre";
                caja.ValueMember = "id_rutinas";
            }
        }
    }
}
