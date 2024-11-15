using Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class ProductoService
    {
        private ProductoDAO productDAO = new ProductoDAO();

        public DataTable MostrarProductos()
        {
            return productDAO.ObtenerProductos();
        }

        public void InsertarProducto(string nombre, string descripcion, string marca, double precio, int inventario)
        {
            productDAO.Insertar(nombre, descripcion, marca, precio, inventario);
        }

        public void EditarProducto(string nombre, string descripcion, string marca, double precio, int inventario, int id)
        {
            productDAO.Editar(nombre, descripcion, marca, precio, inventario, id);
        }

        public void EliminarProducto(int id)
        {
            productDAO.Eliminar(id);
        }

        public DataTable ObtenerProductos()
        {
            return productDAO.ObtenerProductos();
        }
    }
}
