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
    public partial class Form_EditarProductos : Form
    {
        private void ClearTextBoxexContent()
        {
            MaskTextBox_Buscar_ID.Clear();
            TextBox_Editar_Nombre.Clear();
            ComboTextBox_Editar_Categoria.SelectedIndex = -1;
            ComboTextBox_Editar_Necesidad.SelectedIndex = -1;
            MaskTextBox_Editar_Cantidad.Clear();
            MaskTextBox_Editar_Precio.Clear();
            MaskTextBox_Editar_CantMin.Clear();
            Label_Estado.Text = "...";
        }

        // Solo enteros para ID, cantidad y cantidad min
        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Decimales con punto para precio
        private void SoloDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskedTextBox txt = sender as MaskedTextBox;

            if (char.IsControl(e.KeyChar)) return;

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }

            // No permitir mas de un punto
            if (e.KeyChar == '.' && txt.Text.Contains('.'))
            {
                e.Handled = true;
                return;
            }

            if (txt.Text.Contains('.'))
            {
                int index = txt.Text.IndexOf('.');
                string decimals = txt.Text.Substring(index + 1);

                if (txt.SelectionStart > index && decimals.Length >= 2)
                {
                    e.Handled = true;
                    return;
                }
            }
        }

        private Form_MostrarProductos _formMostrar;
        public Form_EditarProductos(Form_MostrarProductos formMostrar)
        {
            InitializeComponent();
            _formMostrar = formMostrar;

            this.MaskTextBox_Editar_Precio.KeyPress += SoloDecimal_KeyPress;

            this.MaskTextBox_Editar_Cantidad.KeyPress += SoloNumeros_KeyPress;
            this.MaskTextBox_Editar_CantMin.KeyPress += SoloNumeros_KeyPress;
            this.MaskTextBox_Buscar_ID.KeyPress += SoloNumeros_KeyPress;
        }

        private void Btn_TrearContenido_Click(object sender, EventArgs e)
        {
            string id = MaskTextBox_Buscar_ID.Text;

            if (Almacen.Productos.ContainsKey(id))      //Buscar por ID
            {
                var producto = Almacen.Productos[id];

                TextBox_Editar_Nombre.Text = producto.Nombre;
                ComboTextBox_Editar_Categoria.Text = producto.Categoria;
                ComboTextBox_Editar_Necesidad.Text = producto.Necesidad;
                MaskTextBox_Editar_Cantidad.Text = producto.Cantidad;
                MaskTextBox_Editar_Precio.Text = producto.Precio;
                MaskTextBox_Editar_CantMin.Text = producto.CantidadMinima;
                Label_Estado.Text = producto.Estado;

                MessageBox.Show("Producto cargado, puede modificar los campos.", "Carga exitosa", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Producto no encontrado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            string id = MaskTextBox_Buscar_ID.Text;

            if (!Almacen.Productos.ContainsKey(id))
            {
                MessageBox.Show("No se puede modificar porque el producto no existe.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TextBox_Editar_Nombre.Text) ||
                string.IsNullOrWhiteSpace(ComboTextBox_Editar_Categoria.Text) ||
                string.IsNullOrWhiteSpace(ComboTextBox_Editar_Necesidad.Text) ||
                string.IsNullOrWhiteSpace(MaskTextBox_Editar_Cantidad.Text) ||
                string.IsNullOrWhiteSpace(MaskTextBox_Editar_Precio.Text) ||
                string.IsNullOrWhiteSpace(MaskTextBox_Editar_CantMin.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal ValorPrecio = decimal.Parse(MaskTextBox_Editar_Precio.Text);
            decimal CalculoITBIS = ValorPrecio * 0.18m;         // Calculando ITBIS
            decimal RedITBIS = Math.Round(CalculoITBIS, 2);


            decimal CalculoPTotal = ValorPrecio + CalculoITBIS;    // Sumando ITBIS al precio total
            decimal RedCalculoPTotal = Math.Round(CalculoPTotal, 2);

            int C = int.Parse(MaskTextBox_Editar_Cantidad.Text);
            int CtnMin = int.Parse(MaskTextBox_Editar_CantMin.Text);
            string Ctn = "";

            if (C == 0)
            {
                Ctn = "Sin existencia";
            }
            else if (C <= CtnMin)
            {
                Ctn = "Próximo a terminar";
            }
            else
            {
                Ctn = "Disponible";
            }

            var producto = Almacen.Productos[id];

            producto.Nombre = TextBox_Editar_Nombre.Text;
            producto.Categoria = ComboTextBox_Editar_Categoria.Text;
            producto.Necesidad = ComboTextBox_Editar_Necesidad.Text;
            producto.Cantidad = MaskTextBox_Editar_Cantidad.Text;
            producto.Precio = MaskTextBox_Editar_Precio.Text;
            producto.ITBIS = RedITBIS.ToString();
            producto.PrecioTotal = RedCalculoPTotal.ToString();
            producto.CantidadMinima = MaskTextBox_Editar_CantMin.Text;
            producto.Estado =  Ctn;

            MessageBox.Show("Producto actualizado con éxito.", "Actualización exitosa", MessageBoxButtons.OK);

            _formMostrar?.CargarProductos();    // Recargar DataGridView en el formulario de mostrar

            ClearTextBoxexContent();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
