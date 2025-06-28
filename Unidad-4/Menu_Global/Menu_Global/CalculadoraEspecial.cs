using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraAritmetica
{
    public partial class CalculadoraEspecial : Form
    {
        Dictionary<string, string> numeros = new Dictionary<string, string>()
        {
            {"cero", "0"}, { "uno", "1"}, { "dos", "2"}, {"do", "2"}, { "tres", "3"}, 
            { "tre", "3"}, { "cuatro", "4"},{ "cinco", "5"}, { "seis", "6"}, { "sei", "6"}, 
            { "siete", "7"}, { "ocho", "8"}, { "nueve", "9"}, { "diez", "10"}, { "die", "10"}, 
            { "dies", "10"}, { "once", "11"}, { "doce", "12"}, { "trece", "13"}, { "catorce", "14"}, 
            { "quince", "15" }, { "dieciseis", "16"}, { "diecisiete", "17"}, { "dieciocho", "18"}, 
            { "diesinueve", "19"}, { "veinte", "20"}, { "veintiuno", "21"}, { "veintidos", "22"}, { "veintitres", "23"},
            { "veinticuatro", "24"}, { "veinticinco", "25" }
        };

        Dictionary<string, string> operadores = new Dictionary<string, string>()
        {
            {"más", "+"}, {"mas", "+"}, {"sumado", "+"}, {"sumando", "+"}, {"suma", "+"}, 
            {"menos", "-"}, {"resta", "-"}, {"restando", "-"}, {"substrayendo", "-"}, {"substraer", "-"}, 
            {"por", "*"}, {"multiplicado", "*"}, {"x", "*"}, {"multiplicar", "*"},
            {"entre", "/"},{"dividido", "/"},{"dividiendo", "/"}, {"dividir", "/"},
            {"elevado", "^"}, {"elevar", "^"}, {"ala", "^"}, {"potencia", "^"}
        };

        public CalculadoraEspecial()
        {
            InitializeComponent();
        }

        private string InsertarEspacios(string expresion)
        {
            string simbolos = "+-*/^()";
            string resultado = "";

            foreach (char c in expresion)
            {
                if (simbolos.Contains(c))
                {
                    resultado += $" {c} ";
                }
                else
                {
                    resultado += c;
                }
            }

            return resultado.Replace("  ", " ").Trim();
        }

        private void Btn_Operar_Click(object sender, EventArgs e)
        {
            try
            {
                string Entrada = TxtBox_Resultado.Text.ToLower();
                string TxtEspaciado = InsertarEspacios(Entrada);
                string Traducida = TraducirAExpresionMatematica(TxtEspaciado);
                string ExpresionOperable = ResolverPotencias(Traducida);
                object Resultado = new DataTable().Compute(ExpresionOperable, "");
                Label_Resultado.Text = $"Resultado: {Resultado}";
            }
            catch
            {
                Label_Resultado.Text = "Error: expresión invalida";
            }
        }

        private string TraducirAExpresionMatematica(string entrada)
        {
            string[] palabras = entrada.Split(' ');
            List<string> Traducir = new List<string>();

            foreach (var Palabra in palabras)
            {
                if (numeros.ContainsKey(Palabra))
                    Traducir.Add(numeros[Palabra]);
                else if (operadores.ContainsKey(Palabra))
                    Traducir.Add(operadores[Palabra]);
                else
                    Traducir.Add(Palabra);
            }

            return string.Join(" ", Traducir);
        }


        private string ResolverPotencias(string expresion)
        {
            while (expresion.Contains("^"))
            {
                var Token = expresion.Split(' ').ToList();
                for (int i = 0; i < Token.Count; i++)
                {
                    if (Token[i] == "^")
                    {
                        if (i == 0 || i == Token.Count - 1)
                            throw new Exception("Potencia mal formada");

                        double BaseNum = Convert.ToDouble(Token[i - 1]);
                        double Exponente = Convert.ToDouble(Token[i + 1]);
                        double Potencia = Math.Pow(BaseNum, Exponente);

                        Token[i - 1] = Potencia.ToString();
                        Token.RemoveAt(i);
                        Token.RemoveAt(i);
                        break;
                    }
                }
                expresion = string.Join(" ", Token);
            }
            return expresion;
        }
    }
}