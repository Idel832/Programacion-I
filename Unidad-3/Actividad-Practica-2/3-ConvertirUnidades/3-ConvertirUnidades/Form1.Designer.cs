namespace _3_ConvertirUnidades
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
            this.ComboBox_Entrada = new System.Windows.Forms.ComboBox();
            this.ComboBox_Salida = new System.Windows.Forms.ComboBox();
            this.TxtBox_Entrada = new System.Windows.Forms.TextBox();
            this.Label_Titulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label_Salida = new System.Windows.Forms.Label();
            this.Btn_Calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComboBox_Entrada
            // 
            this.ComboBox_Entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Entrada.FormattingEnabled = true;
            this.ComboBox_Entrada.Items.AddRange(new object[] {
            "Metros",
            "Centímetros",
            "Pulgadas"});
            this.ComboBox_Entrada.Location = new System.Drawing.Point(26, 61);
            this.ComboBox_Entrada.Name = "ComboBox_Entrada";
            this.ComboBox_Entrada.Size = new System.Drawing.Size(121, 32);
            this.ComboBox_Entrada.TabIndex = 0;
            // 
            // ComboBox_Salida
            // 
            this.ComboBox_Salida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Salida.FormattingEnabled = true;
            this.ComboBox_Salida.Items.AddRange(new object[] {
            "Metros",
            "Centímetros",
            "Pulgadas"});
            this.ComboBox_Salida.Location = new System.Drawing.Point(171, 61);
            this.ComboBox_Salida.Name = "ComboBox_Salida";
            this.ComboBox_Salida.Size = new System.Drawing.Size(121, 32);
            this.ComboBox_Salida.TabIndex = 1;
            // 
            // TxtBox_Entrada
            // 
            this.TxtBox_Entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Entrada.Location = new System.Drawing.Point(26, 111);
            this.TxtBox_Entrada.Name = "TxtBox_Entrada";
            this.TxtBox_Entrada.Size = new System.Drawing.Size(121, 31);
            this.TxtBox_Entrada.TabIndex = 2;
            // 
            // Label_Titulo
            // 
            this.Label_Titulo.AutoSize = true;
            this.Label_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Titulo.Location = new System.Drawing.Point(22, 25);
            this.Label_Titulo.Name = "Label_Titulo";
            this.Label_Titulo.Size = new System.Drawing.Size(355, 24);
            this.Label_Titulo.TabIndex = 4;
            this.Label_Titulo.Text = "Seleccione el tipo de unidades a calcular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "=";
            // 
            // Label_Salida
            // 
            this.Label_Salida.AutoSize = true;
            this.Label_Salida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Salida.Location = new System.Drawing.Point(217, 117);
            this.Label_Salida.Name = "Label_Salida";
            this.Label_Salida.Size = new System.Drawing.Size(33, 25);
            this.Label_Salida.TabIndex = 6;
            this.Label_Salida.Text = "...";
            // 
            // Btn_Calcular
            // 
            this.Btn_Calcular.Location = new System.Drawing.Point(109, 148);
            this.Btn_Calcular.Name = "Btn_Calcular";
            this.Btn_Calcular.Size = new System.Drawing.Size(113, 36);
            this.Btn_Calcular.TabIndex = 7;
            this.Btn_Calcular.Text = "Calcular";
            this.Btn_Calcular.UseVisualStyleBackColor = true;
            this.Btn_Calcular.Click += new System.EventHandler(this.Btn_Calcular_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 196);
            this.Controls.Add(this.Btn_Calcular);
            this.Controls.Add(this.Label_Salida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label_Titulo);
            this.Controls.Add(this.TxtBox_Entrada);
            this.Controls.Add(this.ComboBox_Salida);
            this.Controls.Add(this.ComboBox_Entrada);
            this.Name = "Form_Main";
            this.Text = "Convertir unidades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBox_Entrada;
        private System.Windows.Forms.ComboBox ComboBox_Salida;
        private System.Windows.Forms.TextBox TxtBox_Entrada;
        private System.Windows.Forms.Label Label_Titulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label_Salida;
        private System.Windows.Forms.Button Btn_Calcular;
    }
}

