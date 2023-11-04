using ACarCare;
using ECarCare;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCarCare
{
    public class ManejadorRutinasProgramadas : ICrud
    {
        AccesoProgramarRutinas rutinas = new AccesoProgramarRutinas();
        public void Borrar(dynamic entidad)
        {
            //Tomar el resultado del messagebox.
            DialogResult resultado = MessageBox.Show(String.Format("¿Desea eliminar este registro {0}?", entidad.Nombre), "!Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //Si el resultado es si en la pregunta de desea eliminar.
            if (resultado == DialogResult.Yes)
                //Borrar registro.
                rutinas.Borrar(entidad);
        }

        public DataGridViewColumn Boton(string texto, Color color)
        {
            // Crear una columna de botón
            DataGridViewButtonColumn boton = new DataGridViewButtonColumn();

            // Configurar la apariencia de la columna de botón
            boton.Text = texto;
            boton.UseColumnTextForButtonValue = true; // Usa el texto como valor del botón
            boton.FlatStyle = FlatStyle.Flat; // Estilo plano
            boton.DefaultCellStyle.BackColor = color; // Color de fondo
            return boton;
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
            tabla.Columns.Insert(3, Boton("Editar", Color.Green));
            //BORRAR
            tabla.Columns.Insert(4, Boton("Eliminar", Color.Red));
            //OCULTAR ID
            tabla.Columns[0].Visible = false;
        }
    }
}
