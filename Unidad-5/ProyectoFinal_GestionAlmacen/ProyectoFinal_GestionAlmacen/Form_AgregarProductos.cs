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
    public partial class Form_AgregarProductos : Form
    {
        private void ClearTextBoxexContent()
        {
            MaskTextBox_ID.Clear();
            TextBox_Nombre.Clear();
            ComboTextBox_Categoria.SelectedIndex = -1;
            ComboTextBox_Necesidad.SelectedIndex = -1;
            MaskTextBox_Cantidad.Clear();
            MaskTextBox_Precio.Clear();
            MaskTextBox_CantidadMinima.Clear();
        }

        // Solo enteros paara ID, cantidad y cantidad min
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
        public Form_AgregarProductos(Form_MostrarProductos formMostrar)
        {
            InitializeComponent();
            _formMostrar = formMostrar;

            this.MaskTextBox_Precio.KeyPress += SoloDecimal_KeyPress;

            this.MaskTextBox_Cantidad.KeyPress += SoloNumeros_KeyPress;
            this.MaskTextBox_CantidadMinima.KeyPress += SoloNumeros_KeyPress;
            this.MaskTextBox_ID.KeyPress += SoloNumeros_KeyPress;
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(MaskTextBox_ID.Text) ||
                string.IsNullOrWhiteSpace(TextBox_Nombre.Text) ||
                string.IsNullOrWhiteSpace(ComboTextBox_Categoria.Text) ||
                string.IsNullOrWhiteSpace(ComboTextBox_Necesidad.Text) ||
                string.IsNullOrWhiteSpace(MaskTextBox_Cantidad.Text) ||
                string.IsNullOrWhiteSpace(MaskTextBox_Precio.Text) ||
                string.IsNullOrWhiteSpace(MaskTextBox_CantidadMinima.Text))
            {
                MessageBox.Show("Por favor, rellene todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                decimal ValorPrecio = decimal.Parse(MaskTextBox_Precio.Text);
                decimal CalculoITBIS = ValorPrecio * 0.18m;         // Calculando ITBIS
                decimal RedITBIS = Math.Round(CalculoITBIS, 2);


                decimal CalculoPTotal = ValorPrecio + CalculoITBIS;    // Sumando ITBIS al precio total
                decimal RedCalculoPTotal = Math.Round(CalculoPTotal, 2);


                int C = int.Parse(MaskTextBox_Cantidad.Text);
                int CtnMin = int.Parse(MaskTextBox_CantidadMinima.Text);
                string Ctn = "";

                if (C == 0)
                {
                     Ctn = "Sin existencia"; 
                }
                else if(C <= CtnMin)
                {
                    Ctn = "Próximo a terminar";
                }
                else
                {
                    Ctn = "Disponible";
                }



                    var producto = new Producto
                    {
                        ID = MaskTextBox_ID.Text,
                        Nombre = TextBox_Nombre.Text,
                        Categoria = ComboTextBox_Categoria.Text,
                        Necesidad = ComboTextBox_Necesidad.Text,
                        Cantidad = MaskTextBox_Cantidad.Text,
                        Precio = MaskTextBox_Precio.Text,
                        ITBIS = RedITBIS.ToString(),
                        PrecioTotal = RedCalculoPTotal.ToString(),
                        CantidadMinima = MaskTextBox_CantidadMinima.Text,
                        Estado = Ctn,
                    };

                if (!Almacen.Productos.ContainsKey(producto.ID))
                {
                    Almacen.Productos.Add(producto.ID, producto);
                    MessageBox.Show("Producto agregado con éxito", "Agregado exitoso", MessageBoxButtons.OK);

                    
                    _formMostrar?.CargarProductos();    // Recargar DataGridView en el formulario de mostrar
                    ClearTextBoxexContent();
                }
                else
                {
                    MessageBox.Show("Este ID ya existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
      
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
