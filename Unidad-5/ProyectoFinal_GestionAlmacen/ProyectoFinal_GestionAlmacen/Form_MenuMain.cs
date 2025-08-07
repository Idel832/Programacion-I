using ProyectoFinal_GestionAlmacen.Funciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProyectoFinal_GestionAlmacen
{
    public partial class Form_MenuMain : Form
    {
        public Form_MenuMain()
        {
            InitializeComponent();
            CfgInicialSubmenus();
            CfgInicialColorMenus();

            ShowFormshijos(new Form_InicioProductos());
            Panel_Btn_Inicio.BackColor = Color.FromArgb(0, 0, 100);
        }

        private Form FormActivo = null;
        private void ShowFormshijos(Form FormHijo)
        {
            if (FormActivo != null)
                FormActivo.Close();
            FormActivo = FormHijo;
            FormHijo.TopLevel = false;
            FormHijo.FormBorderStyle = FormBorderStyle.None;
            FormHijo.Dock = DockStyle.Fill;
            Panel_Content.Controls.Add(FormHijo);
            Panel_Content.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();
        }
        private void CfgInicialColorMenus()
        {
            Panel_Btn_Inicio.BackColor = Color.FromArgb(7, 17, 44);
            Panel_Submenu_Prods.BackColor = Color.FromArgb(7, 17, 44);
            Panel_Btn_Exportar.BackColor = Color.FromArgb(7, 17, 44);

            Panel_Exit.BackColor = Color.FromArgb(7, 17, 44);
            Panel_MaxMin.BackColor = Color.FromArgb(7, 17, 44);
            Panel_Hide.BackColor = Color.FromArgb(7, 17, 44);
        }

        private void CfgInicialSubmenus() 
        { 
            Panel_Productos_Submenu.Visible = false;
        }

        private void HideSubmenus()
        {
            if (Panel_Productos_Submenu.Visible == true)
                Panel_Productos_Submenu.Visible = false;
        }
        
        private void ShowSubmenus(Panel Submenu)
        {
            if (Submenu.Visible == false)
            {
                HideSubmenus();
                Submenu.Visible = true;
            }
          
            else 
                Submenu.Visible = false;
        }

        private void Panel_Btn_Inicio_Click(object sender, EventArgs e)
        {
            ShowFormshijos(new Form_InicioProductos());

            HideSubmenus();

            //ChangetoFocusColorMenus 
            CfgInicialColorMenus();
            Panel_Btn_Inicio.BackColor = Color.FromArgb(0, 0, 100);

        }

        private void Panel_Submenu_Prods_Click(object sender, EventArgs e)
        {
            //ChangetoFocusColorMenus 
            CfgInicialColorMenus();
            Panel_Submenu_Prods.BackColor = Color.FromArgb(0, 0, 100);

            //ShowSubmenus 
            ShowSubmenus(Panel_Productos_Submenu);
        }

        private void Panel_Btn_Mostrar_Click(object sender, EventArgs e)
        {
            //ChangetoFocusColorMenus 
            CfgInicialColorMenus();
            Panel_Submenu_Prods.BackColor = Color.FromArgb(0, 0, 100);


            ShowFormshijos(new Form_MostrarProductos());
        }

        private Form_MostrarProductos formMostrar = null;
        private void Panel_Btn_Agregar_Click(object sender, EventArgs e)
        {
            //ChangetoFocusColorMenus 
            CfgInicialColorMenus();
            Panel_Submenu_Prods.BackColor = Color.FromArgb(0, 0, 100);


            if (formMostrar == null || formMostrar.IsDisposed)
            {
                formMostrar = new Form_MostrarProductos();
                ShowFormshijos(formMostrar);
            }

            var formAgregar = new Form_AgregarProductos(formMostrar);
            formAgregar.ShowDialog(); 
        }

        private void Panel_Btn_Editar_Click(object sender, EventArgs e)
        {
            //ChangetoFocusColorMenus 
            CfgInicialColorMenus();
            Panel_Submenu_Prods.BackColor = Color.FromArgb(0, 0, 100);


            if (formMostrar == null || formMostrar.IsDisposed)
            {
                formMostrar = new Form_MostrarProductos();
                ShowFormshijos(formMostrar);
            }

            var formEditar = new Form_EditarProductos(formMostrar);
            formEditar.ShowDialog();
        }
        

        private void Panel_Btn_Eliminar_Click(object sender, EventArgs e)
        {
            //ChangetoFocusColorMenus 
            CfgInicialColorMenus();
            Panel_Submenu_Prods.BackColor = Color.FromArgb(0, 0, 100);


            if (formMostrar == null || formMostrar.IsDisposed)
            {
                formMostrar = new Form_MostrarProductos();
                ShowFormshijos(formMostrar);
            }

            var formEditar = new Form_EliminarProductos(formMostrar);
            formEditar.ShowDialog();
        }

        private void Panel_Btn_Exportar_Click(object sender, EventArgs e)
        {
            //ChangetoFocusColorMenus 
            CfgInicialColorMenus();
            Panel_Btn_Exportar.BackColor = Color.FromArgb(0, 0, 100);

            //Exportar y verificación
            if (Almacen.Productos == null || Almacen.Productos.Count == 0)
            {
                MessageBox.Show("No existe contenido que exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV files (*.csv)|*.csv";
                sfd.Title = "QuisqueyaMarket - Exportar lista de productos";
                sfd.FileName = "ListaProductos.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter writer = new StreamWriter(sfd.FileName))
                        {
                            writer.WriteLine($"ID,Nombre,Categoria,Necesidad,Cantidad (Unidades),Precio,ITBIS (18%),Precio total,Cantidad mínima,Estado");

                            foreach (var entry in Almacen.Productos)
                            {
                                string key = $"\"{entry.Key.Replace("\"", "\"\"")}\"";

                                string Nom_CSV = $"\"{entry.Value.Nombre.Replace("\"", "\"\"")}\"";
                                string Cat_CSV = $"\"{entry.Value.Categoria.Replace("\"", "\"\"")}\"";
                                string Nec_CSV = $"\"{entry.Value.Necesidad.Replace("\"", "\"\"")}\"";
                                string Cant_CSV = $"\"{entry.Value.Cantidad.Replace("\"", "\"\"")}\"";
                                string Pre_CSV = $"\"{entry.Value.Precio.Replace("\"", "\"\"")}\"";
                                string ITB_CSV = $"\"{entry.Value.ITBIS.Replace("\"", "\"\"")}\"";
                                string Pto_CSV = $"\"{entry.Value.PrecioTotal.Replace("\"", "\"\"")}\"";
                                string CTMin_CSV = $"\"{entry.Value.CantidadMinima.Replace("\"", "\"\"")}\"";
                                string Est_CSV = $"\"{entry.Value.Estado.Replace("\"", "\"\"")}\"";
                                writer.WriteLine($"{key},{Nom_CSV},{Cat_CSV},{Nec_CSV},{Cant_CSV},{Pre_CSV},{ITB_CSV},{Pto_CSV},{CTMin_CSV},{Est_CSV}");
                            }
                        }
                        MessageBox.Show("Datos exportados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al exportar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        //Boton Cerrar
        private void Panel_Exit_MouseClick(object sender, MouseEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Panel_Exit_MouseEnter(object sender, EventArgs e)
        {
            Panel_Exit.BackColor = Color.FromArgb(128, 0, 0);
        }

        private void Panel_Exit_MouseLeave(object sender, EventArgs e)
        {
            Panel_Exit.BackColor = Color.FromArgb(7, 17, 44);
        }
        private void Panel_Exit_MouseDown(object sender, MouseEventArgs e)
        {
            Panel_Exit.BackColor = Color.FromArgb(128, 40, 30);
        }


        //Boton Minimizar
        private void Panel_Hide_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Panel_Hide_MouseEnter(object sender, EventArgs e)
        {
            Panel_Hide.BackColor = Color.FromArgb(21, 40, 100);
        }

        private void Panel_Hide_MouseLeave(object sender, EventArgs e)
        {
            Panel_Hide.BackColor = Color.FromArgb(7, 17, 44);
        }
        private void Panel_Hide_MouseDown(object sender, MouseEventArgs e)
        {
            Panel_Hide.BackColor = Color.FromArgb(21, 65, 100);
        }


        //Boton Maximizar
        private void Panel_MaxMin_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState==FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState=FormWindowState.Maximized;
            }
        }
        private void Panel_MaxMin_MouseEnter(object sender, EventArgs e)
        {
            Panel_MaxMin.BackColor = Color.FromArgb(21, 40, 100);
        }

        private void Panel_MaxMin_MouseLeave(object sender, EventArgs e)
        {
            Panel_MaxMin.BackColor = Color.FromArgb(7, 17, 44);
        }
        private void Panel_MaxMin_MouseDown(object sender, MouseEventArgs e)
        {
            Panel_MaxMin.BackColor = Color.FromArgb(21, 65, 100);
        }


        //Arrastrar el formulario
        int m, mx,my;
        private void Panel_TopBar_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X; 
            my = e.Y;
        }

        private void Panel_TopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void Panel_TopBar_MouseUp(object sender, MouseEventArgs e)
        {
            m= 0;
        }
    }
}
                                                       