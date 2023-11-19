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
            DialogResult resultado = MessageBox.Show("¿Desea eliminar este registro?", "!Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            tabla.RowTemplate.Height = 40;
            //Fuente de datos.
            tabla.DataSource = rutinas.Mostrar(filtro).Tables["programar_rutinas"];
            //AGREGAR BOTONES.
            //EDITAR
            tabla.Columns.Insert(4, grafico.Boton("Editar", ColorTranslator.FromHtml("#4467cc")));
            //BORRAR
            tabla.Columns.Insert(5, grafico.Boton("Eliminar", ColorTranslator.FromHtml("#f96767")));
            //OCULTAR ID
            tabla.Columns[0].Visible = false;
            tabla.Columns[2].Width = 240;
            tabla.Columns[3].Width = 210;
        }

        public void ExtraerDatos(ComboBox caja)
        {
            //Si el nombre del ComboBox es x o y:
            //Ejecuta la consulta de la tabla x
            //Trae a la vista del combobox el elemento x de la tabla.
            //toma el valor x de la tabla para el combobox.
            if(caja.Name == "cmbVehiculos")
            {
                caja.DataSource = rutinas.MostrarCmb("SELECT id_vehiculos, modelo FROM vehiculos;", "vehiculos").Tables["vehiculos"];
                caja.DisplayMember = "modelo";
                caja.ValueMember = "id_vehiculos";
            }
            if(caja.Name == "cmbRutinas")
            {
                caja.DataSource = rutinas.MostrarCmb("SELECT id_rutinas, nombre FROM rutinas;", "rutinas").Tables["rutinas"];
                caja.DisplayMember = "nombre";
                caja.ValueMember = "id_rutinas";
            }
        }
        public void Notificaciones(DataGridView tabla)
        {
            tabla.Visible = false;
            tabla.DataSource = rutinas.MostrarNoti().Tables["programar_rutinas"];

            // Lista para almacenar los números de día como enteros
            if (tabla != null)
            {
                // Recorrer las filas del control de interfaz gráfica (DataGridView)
                try
                {
                    foreach (DataGridViewRow fila in tabla.Rows)
                    {
                        if (!fila.IsNewRow) // Evitar la última fila (fila nueva en blanco)
                        {
                            object valorCeldaFecha = fila.Cells["fecha"].Value;
                            object valorCeldaModelo = fila.Cells["modelo"].Value;
                            object valorCeldaDescripcion = fila.Cells["descripcion"].Value;

                            if (valorCeldaFecha != null && valorCeldaModelo != null && valorCeldaDescripcion != null)
                            {
                                string fechaEnCadena = valorCeldaFecha.ToString();
                                string modeloVehiculo = valorCeldaModelo.ToString();
                                string descripcionRutina = valorCeldaDescripcion.ToString();

                                if (DateTime.TryParse(fechaEnCadena, out DateTime fecha))
                                {
                                    int fechaActual = DateTime.Now.Day;
                                    int numeroDeDia = fecha.Day;

                                    if (fechaActual == (numeroDeDia - 1))
                                    {
                                        string mensaje = $"El vehículo ({modeloVehiculo}) tiene una rutina ({descripcionRutina}) que debe ser hecha el {fechaEnCadena}";
                                        MessageBox.Show(mensaje, "Alerta de rutina", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error: " + ex.Message);
                }
            }

        }

    }
}
