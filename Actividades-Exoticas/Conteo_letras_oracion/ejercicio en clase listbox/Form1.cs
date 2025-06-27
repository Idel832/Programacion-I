namespace ejercicio_en_clase_listbox
{
    public partial class Title : Form
    {
        public Title()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
        
            string oracion = TxtBox_Escribe.Text.ToUpper();

          
            Dictionary<char, int> conteo = new Dictionary<char, int>();

            
            foreach (char c in oracion)
            {
                
                if (char.IsLetter(c))
                {
                    
                    if (conteo.ContainsKey(c))
                    {
                        conteo[c]++;
                    }
                    
                    else
                    {
                        conteo[c] = 1;
                    }
                }
            }

            ListBox_Analizar.Items.Clear();

            foreach (var letra in conteo)
            {
                
                ListBox_Analizar.Items.Add(letra.Key + ": " + letra.Value);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListBox_Analizar.Items.Clear();
            TxtBox_Escribe.Clear();
        }
    }
}
