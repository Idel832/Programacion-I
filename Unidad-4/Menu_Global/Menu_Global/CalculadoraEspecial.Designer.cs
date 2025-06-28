namespace CalculadoraAritmetica
{
    partial class CalculadoraEspecial
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
            this.TxtBox_Resultado = new System.Windows.Forms.TextBox();
            this.Label_Resultado = new System.Windows.Forms.Label();
            this.Btn_Operar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtBox_Resultado
            // 
            this.TxtBox_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Resultado.Location = new System.Drawing.Point(39, 42);
            this.TxtBox_Resultado.Name = "TxtBox_Resultado";
            this.TxtBox_Resultado.Size = new System.Drawing.Size(540, 29);
            this.TxtBox_Resultado.TabIndex = 0;
            // 
            // Label_Resultado
            // 
            this.Label_Resultado.AutoSize = true;
            this.Label_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Resultado.Location = new System.Drawing.Point(194, 102);
            this.Label_Resultado.Name = "Label_Resultado";
            this.Label_Resultado.Size = new System.Drawing.Size(28, 24);
            this.Label_Resultado.TabIndex = 1;
            this.Label_Resultado.Text = "...";
            // 
            // Btn_Operar
            // 
            this.Btn_Operar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Operar.Location = new System.Drawing.Point(39, 82);
            this.Btn_Operar.Name = "Btn_Operar";
            this.Btn_Operar.Size = new System.Drawing.Size(123, 53);
            this.Btn_Operar.TabIndex = 2;
            this.Btn_Operar.Text = "Operar";
            this.Btn_Operar.UseVisualStyleBackColor = true;
            this.Btn_Operar.Click += new System.EventHandler(this.Btn_Operar_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 214);
            this.Controls.Add(this.Btn_Operar);
            this.Controls.Add(this.Label_Resultado);
            this.Controls.Add(this.TxtBox_Resultado);
            this.Name = "Form_Main";
            this.Text = "Calculadora Aritmetica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBox_Resultado;
        private System.Windows.Forms.Label Label_Resultado;
        private System.Windows.Forms.Button Btn_Operar;
    }
}

