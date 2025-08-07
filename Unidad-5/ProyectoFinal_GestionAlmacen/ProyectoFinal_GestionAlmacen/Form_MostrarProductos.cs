using ProyectoFinal_GestionAlmacen.Funciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_GestionAlmacen
{
    public partial class Form_MostrarProductos : Form
    {
        public void CargarProductos()
        {
            DataGrid_Productos.Rows.Clear();

            foreach (var producto in Almacen.Productos.Values)
            {
                DataGrid_Productos.Rows.Add(
                    producto.ID, producto.Nombre, producto.Categoria,
                    producto.Necesidad, producto.Cantidad, producto.Precio,
                    producto.ITBIS, producto.PrecioTotal, producto.CantidadMinima, producto.Estado
                    );
            }
        }
        public Form_MostrarProductos()
        {
            InitializeComponent();
            CargarProductos();
        }
    }
}
