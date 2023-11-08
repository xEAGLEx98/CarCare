using System;
using ACarCare;
using System.Windows.Forms;
using System.Drawing;
using Crud;
namespace MCarCare
{
    public class ManejadorRutinas:ICrud
    {
        AccesoRutinas rutinas = new AccesoRutinas();
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
            tabla.DataSource = rutinas.Mostrar(filtro).Tables["rutinas"];
            //AGREGAR BOTONES.
            //EDITAR
            tabla.Columns.Insert(3, grafico.Boton("Editar", Color.Green));
            //BORRAR
            tabla.Columns.Insert(4, grafico.Boton("Eliminar", Color.Red));
            //OCULTAR ID
            //tabla.Columns[0].Visible = false;
        }
    }
}
