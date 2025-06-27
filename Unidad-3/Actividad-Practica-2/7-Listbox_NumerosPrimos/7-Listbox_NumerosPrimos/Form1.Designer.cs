namespace _7_Listbox_NumerosPrimos
{
    partial class Form_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListBox_Resultado = new System.Windows.Forms.ListBox();
            this.Label_Titulo = new System.Windows.Forms.Label();
            this.Label_Inicio = new System.Windows.Forms.Label();
            this.Label_Final = new System.Windows.Forms.Label();
            this.Btn_Generar = new System.Windows.Forms.Button();
            this.MTxtBox_Inicio = new System.Windows.Forms.MaskedTextBox();
            this.MTxtBox_Final = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // ListBox_Resultado
            // 
            this.ListBox_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBox_Resultado.FormattingEnabled = true;
            this.ListBox_Resultado.ItemHeight = 20;
            this.ListBox_Resultado.Location = new System.Drawing.Point(34, 118);
            this.ListBox_Resultado.Name = "ListBox_Resultado";
            this.ListBox_Resultado.Size = new System.Drawing.Size(441, 164);
            this.ListBox_Resultado.TabIndex = 2;
            // 
            // Label_Titulo
            // 
            this.Label_Titulo.AutoSize = true;
            this.Label_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Titulo.Location = new System.Drawing.Point(30, 21);
            this.Label_Titulo.Name = "Label_Titulo";
            this.Label_Titulo.Size = new System.Drawing.Size(429, 24);
            this.Label_Titulo.TabIndex = 3;
            this.Label_Titulo.Text = "Indique el rango del cual desea extraer los primos";
            // 
            // Label_Inicio
            // 
            this.Label_Inicio.AutoSize = true;
            this.Label_Inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Inicio.Location = new System.Drawing.Point(31, 56);
            this.Label_Inicio.Name = "Label_Inicio";
            this.Label_Inicio.Size = new System.Drawing.Size(42, 18);
            this.Label_Inicio.TabIndex = 4;
            this.Label_Inicio.Text = "Inicio";
            // 
            // Label_Final
            // 
            this.Label_Final.AutoSize = true;
            this.Label_Final.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Final.Location = new System.Drawing.Point(201, 56);
            this.Label_Final.Name = "Label_Final";
            this.Label_Final.Size = new System.Drawing.Size(39, 18);
            this.Label_Final.TabIndex = 5;
            this.Label_Final.Text = "Final";
            // 
            // Btn_Generar
            // 
            this.Btn_Generar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Generar.Location = new System.Drawing.Point(378, 56);
            this.Btn_Generar.Name = "Btn_Generar";
            this.Btn_Generar.Size = new System.Drawing.Size(96, 50);
            this.Btn_Generar.TabIndex = 6;
            this.Btn_Generar.Text = "Generar";
            this.Btn_Generar.UseVisualStyleBackColor = true;
            this.Btn_Generar.Click += new System.EventHandler(this.Btn_Generar_Click);
            // 
            // MTxtBox_Inicio
            // 
            this.MTxtBox_Inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTxtBox_Inicio.Location = new System.Drawing.Point(34, 77);
            this.MTxtBox_Inicio.Mask = "000000000000";
            this.MTxtBox_Inicio.Name = "MTxtBox_Inicio";
            this.MTxtBox_Inicio.Size = new System.Drawing.Size(140, 29);
            this.MTxtBox_Inicio.TabIndex = 7;
            // 
            // MTxtBox_Final
            // 
            this.MTxtBox_Final.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTxtBox_Final.Location = new System.Drawing.Point(204, 77);
            this.MTxtBox_Final.Mask = "000000000000";
            this.MTxtBox_Final.Name = "MTxtBox_Final";
            this.MTxtBox_Final.Size = new System.Drawing.Size(140, 29);
            this.MTxtBox_Final.TabIndex = 8;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 315);
            this.Controls.Add(this.MTxtBox_Final);
            this.Controls.Add(this.MTxtBox_Inicio);
            this.Controls.Add(this.Btn_Generar);
            this.Controls.Add(this.Label_Final);
            this.Controls.Add(this.Label_Inicio);
            this.Controls.Add(this.Label_Titulo);
            this.Controls.Add(this.ListBox_Resultado);
            this.Name = "Form_Main";
            this.Text = "Mostrar todos los números primos dado un rango";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox ListBox_Resultado;
        private System.Windows.Forms.Label Label_Titulo;
        private System.Windows.Forms.Label Label_Inicio;
        private System.Windows.Forms.Label Label_Final;
        private System.Windows.Forms.Button Btn_Generar;
        private System.Windows.Forms.MaskedTextBox MTxtBox_Inicio;
        private System.Windows.Forms.MaskedTextBox MTxtBox_Final;
    }
}

