using System;
using System.Drawing;
using System.Windows.Forms;
using ACarCare;
using Crud;
namespace MCarCare
{
    public class ManejadorVehiculos : ICrud
    {
        AccesoVehiculos vehiculos = new AccesoVehiculos();
        Grafico grafico = new Grafico();
        public void Borrar(dynamic entidad)
        {
            //Tomar el resultado del messagebox.
            DialogResult resultado = MessageBox.Show(String.Format("¿Desea eliminar este registro {0}?", entidad.Marca), "!Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //Si el resultado es si en la pregunta de desea eliminar.
            if (resultado == DialogResult.Yes)
                //Borrar registro.
                vehiculos.Borrar(entidad);
        }

        public void Guardar(dynamic entidad)
        {
            //Guardar y mostrar mensaje de guardado.
            vehiculos.Guardar(entidad);
            MessageBox.Show("Vehículo guardado correctamente", "!Información!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            tabla.Columns.Insert(4, grafico.Boton("Editar", Color.Green));
            //BORRAR
            tabla.Columns.Insert(5, grafico.Boton("Eliminar", Color.Red));
            //OCULTAR ID
            tabla.Columns[0].Visible = false;
        }
    }
}
