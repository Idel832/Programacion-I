namespace _4_Palabra_Palindroma
{
    partial class VerificarPalindroma4
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
            this.Btn_Verf = new System.Windows.Forms.Button();
            this.Label_Preg = new System.Windows.Forms.Label();
            this.Label_Titulo = new System.Windows.Forms.Label();
            this.Label_Respuesta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtBox_Entrada
            // 
            this.TxtBox_Entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Entrada.Location = new System.Drawing.Point(17, 64);
            this.TxtBox_Entrada.Name = "TxtBox_Entrada";
            this.TxtBox_Entrada.Size = new System.Drawing.Size(306, 31);
            this.TxtBox_Entrada.TabIndex = 0;
            // 
            // Btn_Verf
            // 
            this.Btn_Verf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Verf.Location = new System.Drawing.Point(329, 64);
            this.Btn_Verf.Name = "Btn_Verf";
            this.Btn_Verf.Size = new System.Drawing.Size(97, 31);
            this.Btn_Verf.TabIndex = 1;
            this.Btn_Verf.Text = "Verificar";
            this.Btn_Verf.UseVisualStyleBackColor = true;
            this.Btn_Verf.Click += new System.EventHandler(this.Btn_Verf_Click);
            // 
            // Label_Preg
            // 
            this.Label_Preg.AutoSize = true;
            this.Label_Preg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Preg.Location = new System.Drawing.Point(13, 120);
            this.Label_Preg.Name = "Label_Preg";
            this.Label_Preg.Size = new System.Drawing.Size(151, 24);
            this.Label_Preg.TabIndex = 2;
            this.Label_Preg.Text = "¿Es palindroma?";
            // 
            // Label_Titulo
            // 
            this.Label_Titulo.AutoSize = true;
            this.Label_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Titulo.Location = new System.Drawing.Point(12, 24);
            this.Label_Titulo.Name = "Label_Titulo";
            this.Label_Titulo.Size = new System.Drawing.Size(414, 25);
            this.Label_Titulo.TabIndex = 3;
            this.Label_Titulo.Text = "Digite a continuación la palabra a verificar";
            // 
            // Label_Respuesta
            // 
            this.Label_Respuesta.AutoSize = true;
            this.Label_Respuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Respuesta.Location = new System.Drawing.Point(170, 107);
            this.Label_Respuesta.Name = "Label_Respuesta";
            this.Label_Respuesta.Size = new System.Drawing.Size(50, 39);
            this.Label_Respuesta.TabIndex = 4;
            this.Label_Respuesta.Text = "...";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 196);
            this.Controls.Add(this.Label_Respuesta);
            this.Controls.Add(this.Label_Titulo);
            this.Controls.Add(this.Label_Preg);
            this.Controls.Add(this.Btn_Verf);
            this.Controls.Add(this.TxtBox_Entrada);
            this.Name = "Form_Main";
            this.Text = "Indicar si la palabra digitada es Palindroma o no";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBox_Entrada;
        private System.Windows.Forms.Button Btn_Verf;
        private System.Windows.Forms.Label Label_Preg;
        private System.Windows.Forms.Label Label_Titulo;
        private System.Windows.Forms.Label Label_Respuesta;
    }
}

