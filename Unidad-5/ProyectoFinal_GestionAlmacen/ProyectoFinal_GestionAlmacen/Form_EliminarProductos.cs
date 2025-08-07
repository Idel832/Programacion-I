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
    public partial class Form_EliminarProductos : Form
    {
        private void ClearTextBoxexContent()
        {
            MaskTextBox_Buscar_ID.Clear();
            TextBox_Borrar_Nombre.Clear();
            ComboTextBox_Borrar_Categoria.SelectedIndex = -1;
            ComboTextBox_Borrar_Necesidad.SelectedIndex = -1;
            MaskTextBox_Borrar_Cantidad.Clear();
            MaskTextBox_Borrar_Precio.Clear();
            MaskTextBox_Borrar_CantMin.Clear();
        }

        // Solo enteros para ID
        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private Form_MostrarProductos _formMostrar;
        public Form_EliminarProductos(Form_MostrarProductos formMostrar)
        {
            InitializeComponent();
            _formMostrar = formMostrar;


            this.MaskTextBox_Buscar_ID.KeyPress += SoloNumeros_KeyPress;
        }

        private void Btn_TrearContenido_Click(object sender, EventArgs e)
        {
            string id = MaskTextBox_Buscar_ID.Text;

            if (Almacen.Productos.ContainsKey(id))      //Buscar por ID
            {
                var producto = Almacen.Productos[id];

                TextBox_Borrar_Nombre.Text = producto.Nombre;
                ComboTextBox_Borrar_Categoria.Text = producto.Categoria;
                ComboTextBox_Borrar_Necesidad.Text = producto.Necesidad; 
                MaskTextBox_Borrar_Cantidad.Text = producto.Cantidad;
                MaskTextBox_Borrar_Precio.Text = producto.Precio;
                MaskTextBox_Borrar_CantMin.Text = producto.CantidadMinima;

            }
            else
            {
                MessageBox.Show("Producto no encontrado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearTextBoxexContent();
            }
        }

        private void Btn_Borrar_Click(object sender, EventArgs e)
        {
            string id = MaskTextBox_Buscar_ID.Text;

            if (!Almacen.Productos.ContainsKey(id))
            {
                MessageBox.Show("El producto no existe.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro de que desea eliminar este producto?",  // Confirmación
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion == DialogResult.Yes)
            {
                Almacen.Productos.Remove(id);
                MessageBox.Show("Producto eliminado correctamente.", "Eliminación exitosa", MessageBoxButtons.OK);

                ClearTextBoxexContent();

                _formMostrar?.CargarProductos();    // Recargar DataGridView en el formulario de mostrar
            }
            else
            {
                MessageBox.Show("Eliminación cancelada.");
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
