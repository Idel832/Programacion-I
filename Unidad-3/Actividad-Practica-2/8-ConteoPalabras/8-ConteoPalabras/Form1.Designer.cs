namespace _8_ConteoPalabras
{
    partial class Form1
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
            this.TxtBox_Entrada = new System.Windows.Forms.TextBox();
            this.Btn_Verificar = new System.Windows.Forms.Button();
            this.Label_Tiene = new System.Windows.Forms.Label();
            this.Label_Resultado = new System.Windows.Forms.Label();
            this.Label_Titulo = new System.Windows.Forms.Label();
            this.Label_RptOra = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtBox_Entrada
            // 
            this.TxtBox_Entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Entrada.Location = new System.Drawing.Point(37, 71);
            this.TxtBox_Entrada.Name = "TxtBox_Entrada";
            this.TxtBox_Entrada.Size = new System.Drawing.Size(353, 26);
            this.TxtBox_Entrada.TabIndex = 0;
            // 
            // Btn_Verificar
            // 
            this.Btn_Verificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Verificar.Location = new System.Drawing.Point(396, 57);
            this.Btn_Verificar.Name = "Btn_Verificar";
            this.Btn_Verificar.Size = new System.Drawing.Size(130, 57);
            this.Btn_Verificar.TabIndex = 1;
            this.Btn_Verificar.Text = "Verificar";
            this.Btn_Verificar.UseVisualStyleBackColor = true;
            this.Btn_Verificar.Click += new System.EventHandler(this.Btn_Verificar_Click);
            // 
            // Label_Tiene
            // 
            this.Label_Tiene.AutoSize = true;
            this.Label_Tiene.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Tiene.Location = new System.Drawing.Point(33, 171);
            this.Label_Tiene.Name = "Label_Tiene";
            this.Label_Tiene.Size = new System.Drawing.Size(64, 24);
            this.Label_Tiene.TabIndex = 2;
            this.Label_Tiene.Text = "Tiene:";
            // 
            // Label_Resultado
            // 
            this.Label_Resultado.AutoSize = true;
            this.Label_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Resultado.Location = new System.Drawing.Point(103, 163);
            this.Label_Resultado.Name = "Label_Resultado";
            this.Label_Resultado.Size = new System.Drawing.Size(42, 33);
            this.Label_Resultado.TabIndex = 3;
            this.Label_Resultado.Text = "...";
            // 
            // Label_Titulo
            // 
            this.Label_Titulo.AutoSize = true;
            this.Label_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Titulo.Location = new System.Drawing.Point(33, 30);
            this.Label_Titulo.Name = "Label_Titulo";
            this.Label_Titulo.Size = new System.Drawing.Size(236, 24);
            this.Label_Titulo.TabIndex = 4;
            this.Label_Titulo.Text = "Ingrese la oración a valorar";
            // 
            // Label_RptOra
            // 
            this.Label_RptOra.AutoSize = true;
            this.Label_RptOra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_RptOra.Location = new System.Drawing.Point(31, 125);
            this.Label_RptOra.Name = "Label_RptOra";
            this.Label_RptOra.Size = new System.Drawing.Size(19, 25);
            this.Label_RptOra.TabIndex = 5;
            this.Label_RptOra.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 215);
            this.Controls.Add(this.Label_RptOra);
            this.Controls.Add(this.Label_Titulo);
            this.Controls.Add(this.Label_Resultado);
            this.Controls.Add(this.Label_Tiene);
            this.Controls.Add(this.Btn_Verificar);
            this.Controls.Add(this.TxtBox_Entrada);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBox_Entrada;
        private System.Windows.Forms.Button Btn_Verificar;
        private System.Windows.Forms.Label Label_Tiene;
        private System.Windows.Forms.Label Label_Resultado;
        private System.Windows.Forms.Label Label_Titulo;
        private System.Windows.Forms.Label Label_RptOra;
    }
}

