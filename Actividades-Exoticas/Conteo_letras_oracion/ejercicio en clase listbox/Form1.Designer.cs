namespace ejercicio_en_clase_listbox
{
    partial class Title
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            TxtBox_Escribe = new TextBox();
            ListBox_Analizar = new ListBox();
            Btn_Analizar = new Button();
            Btn_clear = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 67);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Escribe";
            // 
            // TxtBox_Escribe
            // 
            TxtBox_Escribe.Location = new Point(33, 95);
            TxtBox_Escribe.Name = "TxtBox_Escribe";
            TxtBox_Escribe.Size = new Size(436, 23);
            TxtBox_Escribe.TabIndex = 1;
            // 
            // ListBox_Analizar
            // 
            ListBox_Analizar.FormattingEnabled = true;
            ListBox_Analizar.ItemHeight = 15;
            ListBox_Analizar.Location = new Point(33, 146);
            ListBox_Analizar.Name = "ListBox_Analizar";
            ListBox_Analizar.Size = new Size(436, 199);
            ListBox_Analizar.TabIndex = 2;
            // 
            // Btn_Analizar
            // 
            Btn_Analizar.Location = new Point(530, 94);
            Btn_Analizar.Name = "Btn_Analizar";
            Btn_Analizar.Size = new Size(75, 23);
            Btn_Analizar.TabIndex = 3;
            Btn_Analizar.Text = "Analizar";
            Btn_Analizar.UseVisualStyleBackColor = true;
            Btn_Analizar.Click += Button1_Click;
            // 
            // Btn_clear
            // 
            Btn_clear.Location = new Point(530, 165);
            Btn_clear.Name = "Btn_clear";
            Btn_clear.Size = new Size(75, 23);
            Btn_clear.TabIndex = 4;
            Btn_clear.Text = "Limpiar";
            Btn_clear.UseVisualStyleBackColor = true;
            Btn_clear.Click += button2_Click;
            // 
            // Title
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Btn_clear);
            Controls.Add(Btn_Analizar);
            Controls.Add(ListBox_Analizar);
            Controls.Add(TxtBox_Escribe);
            Controls.Add(label1);
            Name = "Title";
            Text = "Oración";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtBox_Escribe;
        private ListBox ListBox_Analizar;
        private Button Btn_Analizar;
        private Button Btn_clear;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
