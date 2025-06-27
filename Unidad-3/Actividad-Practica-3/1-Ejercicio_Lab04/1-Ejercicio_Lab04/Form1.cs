using _1_Ejercicio_Lab04.Controllers;
using _1_Ejercicio_Lab04.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_Ejercicio_Lab04
{
    public partial class Form_Main : Form
    {   
        //Llamamos al controlador
        private AlumnoController alumnoController = new AlumnoController();

        public Form_Main()
        {
            InitializeComponent();
        }

        //Metodo mostrar
        private void MostrarAlumnos(Alumno[] alumnos)
        {
            DG_Alumnos.DataSource = null;
            DG_Alumnos.DataSource = alumnos;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Registrar_Click(object sender, EventArgs e)
        {
            //validar campos de entrada

            if(TxtBox_Codigo.Text == "" || TxtBox_Nombre.Text == "" || TxtBox_Promedio.Text == "")
            {
                MessageBox.Show("Complete todos los campos con *");
                return;
            }

            //Crear alumno
            Alumno alumno = new Alumno()
            {
                Codigo = TxtBox_Codigo.Text,
                Nombre = TxtBox_Nombre.Text,
                Promedio = double.Parse(TxtBox_Promedio.Text)
            };
            
            //Registrar al alumno en el arreglo
            alumnoController.Registrar(alumno);

            //Mostrar alumnos
            MostrarAlumnos(alumnoController.ListarTodo());

            //Limpiar campos
            LimpiarCampos();
        }

        public void LimpiarCampos()
        {
            TxtBox_Codigo.Clear();
            TxtBox_Nombre.Clear();
            TxtBox_Promedio.Clear();
            TxtBox_Buqueda.Clear();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            //Validando la selecion para eliminacion
            if (DG_Alumnos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un registro a eliminar.");
                return;
            }

            //Obtener el codigo
            String codigo = DG_Alumnos.SelectedRows[0].Cells[0].Value.ToString();

            //Eliminar la fila seleccionada
            alumnoController.Eliminar(codigo);

            //Mostrar los alumnos
            MostrarAlumnos(alumnoController.ListarTodo());

        }

        private void Btn_Ordenar_Click(object sender, EventArgs e)
        {
            //Mostrar los alumnos ordenados
            MostrarAlumnos(alumnoController.Ordenar());
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            //Validar el campo de busqueda
            if(TxtBox_Buqueda.Text == "")
            {
                MessageBox.Show("Ingrese el codigo del alumno a buscar"); 
                return;
            }
            
            //Obtener el codigo a buscar
            String codigo = TxtBox_Buqueda.Text;

            //Mostrar alumno que coincida con la busqueda
            MostrarAlumnos(alumnoController.BuscarPorCodigo(codigo));
        }
    }
}
