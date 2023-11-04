using System.Drawing;
using System.Windows.Forms;

namespace MCarCare
{
    public interface ICrud
    {
        void Guardar(dynamic entidad);
        void Borrar(dynamic entidad);
        void Mostrar(DataGridView tabla, string filtro);
        DataGridViewColumn Boton(string texto, Color color);
    }
}
