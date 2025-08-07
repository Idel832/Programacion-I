using ProyectoFinal_GestionAlmacen.Funciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_GestionAlmacen
{
    public partial class Form_InicioProductos : Form
    {
        public Form_InicioProductos()
        {
            InitializeComponent();
            MostrarResumen();
        }

        private void MostrarResumen()
        {
            int TotalProds = Almacen.Productos.Count;

            int TotalCantidad = Almacen.Productos.Values
                .Sum(p => int.TryParse(p.Cantidad, out int c) ? c : 0);

            int ProdsProxVencer = Almacen.Productos.Values.Count(p => p.Estado == "Próximo a terminar");

            decimal ValorTotal = Almacen.Productos.Values
                .Sum(p =>
                    decimal.TryParse(p.Precio, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal PrecioTotal) &&
                    int.TryParse(p.Cantidad, out int cantidad)
                        ? PrecioTotal * cantidad
                        : 0);

            Label_ProductosRegistrados.Text = $"{TotalProds}.";
            Label_StockTotal.Text = $"{TotalCantidad}.";
            Label_ItemsAlerta.Text = $"{ProdsProxVencer}.";
            Label_InvValor.Text = $"RD${ValorTotal:N2}.";

        }
    }
}
