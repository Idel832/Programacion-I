using _1_Ejercicio_Lab04;
using _1_Formulario_Simple;
using _10_MensajeEmergente;
using _11_MostrarFecha;
using _12_TransformarTemperaturas;
using _13_ProgressBar;
using _14_TabControl;
using _15_AbrirArchivosTexto;
using _16_CalculadoraSimple;
using _2_BotonCambiaTexto;
using _2_Temporizador;
using _3_ConvertirUnidades;
using _3_MostrarContenidoTxtBox_Label;
using _4_Palabra_Palindroma;
using _4_SumarUsandoTxtBox;
using _5_MostrarBotonSeleccionado;
using _5_Verificación_Primo;
using _6_CambiarBGColor;
using _6_NúmeroPerfecto;
using _7_AgregarElementosListBox;
using _7_Listbox_NumerosPrimos;
using _8_ConteoPalabras;
using _8_VecesPresionadasBoton;
using _9_ValidaciónTextBox;
using CalculadoraAritmetica;
using ContandoLetrasOracion;
using keylogger;
using Mostrar_TablaMultiplicar;
using Numero_to_Pixel;
using Pixel_to_Numero;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Visualizador_Web;

namespace Menu_Global
{
    public partial class Form_MenuMain : Form
    {
        public Form_MenuMain()
        {
            InitializeComponent();
            this.FormClosed += TerminarProceso;
        }

        private void TerminarProceso(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void botonCambiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BotonCambiaTexto2 form = new BotonCambiaTexto2();
            form.Show();
        }

        private void formularioSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioSimple1 form = new FormularioSimple1();
            form.Show();
        }

        private void actividad3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarContenidoTextBoxLabel3 form = new MostrarContenidoTextBoxLabel3();
            form.Show();
        }

        private void actividad4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SumarUsandoTxtBox4 form = new SumarUsandoTxtBox4();
            form.Show();
        }

        private void actividad5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarBotonSeleccionado5 form = new MostrarBotonSeleccionado5();
            form.Show();
        }

        private void actividad6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiarBGColor6 form = new CambiarBGColor6();
            form.Show();
        }

        private void actividad7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarElementosListBox7 form = new AgregarElementosListBox7();
            form.Show();
        }

        private void actividad8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VecesPresionadasBoton8 form = new VecesPresionadasBoton8();
            form.Show();
        }

        private void actividad9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ValidaciónTextBox9 form = new ValidaciónTextBox9();
            form.Show();
        }

        private void actividad10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MensajeEmergente10 form = new MensajeEmergente10();
            form.Show();
        }

        private void actividad11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFecha11 form = new MostrarFecha11();
            form.Show();
        }

        private void actividad12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransformarTemperaturas12 form = new TransformarTemperaturas12();
            form.Show();
        }

        private void actividad13ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProgressBar13 form = new ProgressBar13();
            form.Show();
        }

        private void actividad14ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabContro14 form = new TabContro14();
            form.Show();
        }

        private void actividad15ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirArchivosTexto15 form = new AbrirArchivosTexto15();
            form.Show();
        }

        private void actividad16ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalculadoraSimple16 form = new CalculadoraSimple16();
            form.Show();
        }

        private void actividad1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarTablaMultiplicar1 form = new MostrarTablaMultiplicar1();
            form.Show();
        }

        private void actividad2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Temporizador2 form = new Temporizador2();
            form.Show();
        }

        private void actividad3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConvertirUnidades3 form = new ConvertirUnidades3();
            form.Show();
        }

        private void actividad4ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VerificarPalindroma4 form = new VerificarPalindroma4();
            form.Show();
        }

        private void actividad5ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VerificacionPrimo5 form = new VerificacionPrimo5();
            form.Show();
        }

        private void actividad6ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VerificarNumPerfecto6 form = new VerificarNumPerfecto6();
            form.Show();
        }

        private void actividad7ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListBoxNumPrimo7 form = new ListBoxNumPrimo7();
            form.Show();
        }

        private void actividad8ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConteoPalabras8 form = new ConteoPalabras8();
            form.Show();
        }

        private void activdadLab04ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroAlumnosLab form = new RegistroAlumnosLab();
            form.Show();
        }

        private void actividadMenúGlobalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se encuentra dentro la actividad perteneciente a este trabajo");
        }

        private void calculadoraArimeticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalculadoraEspecial form = new CalculadoraEspecial();
            form.Show();
        }

        private void conteoDeLetrasEnOraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContandoLetras form = new ContandoLetras();
            form.Show();
        }

        private void keyloggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarEscritura form = new RegistrarEscritura();
            form.Show();
        }

        private void númeroAPixelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NumPixel form = new NumPixel();
            form.Show();
        }

        private void pixelANúmeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PixelNum form = new PixelNum();
            form.Show();
        }

        private void visualizadorWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualizadorWeb form = new VisualizadorWeb();
            form.Show();
        }
    }
}
