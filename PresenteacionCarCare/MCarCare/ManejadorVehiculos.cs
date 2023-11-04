using System;
using System.Drawing;
using System.Windows.Forms;
using ACarCare;

namespace MCarCare
{
    public class ManejadorVehiculos : ICrud
    {
        AccesoVehiculos vehiculos = new AccesoVehiculos();
        public void Borrar(dynamic entidad)
        {
            //Tomar el resultado del messagebox.
            DialogResult resultado = MessageBox.Show(String.Format("¿Desea eliminar este registro {0}?", entidad.Marca), "!Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //Si el resultado es si en la pregunta de desea eliminar.
            if (resultado == DialogResult.Yes)
                //Borrar registro.
                vehiculos.Borrar(entidad);
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
            vehiculos.Guardar(entidad);
            MessageBox.Show("Rutina guardada correctamente", "!Información!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            //Limpiar tabla
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            //Fuente de datos.
            tabla.DataSource = vehiculos.Mostrar(filtro).Tables["vehiculos"];
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
