namespace _5_Verificación_Primo
{
    partial class VerificacionPrimo5
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
            this.MTextBox_Entrada = new System.Windows.Forms.MaskedTextBox();
            this.Btn_Verificar = new System.Windows.Forms.Button();
            this.Label_Titulo = new System.Windows.Forms.Label();
            this.Label_Prg = new System.Windows.Forms.Label();
            this.Label_Respuesta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MTextBox_Entrada
            // 
            this.MTextBox_Entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTextBox_Entrada.Location = new System.Drawing.Point(22, 74);
            this.MTextBox_Entrada.Mask = "00000";
            this.MTextBox_Entrada.Name = "MTextBox_Entrada";
            this.MTextBox_Entrada.Size = new System.Drawing.Size(165, 31);
            this.MTextBox_Entrada.TabIndex = 0;
            this.MTextBox_Entrada.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // Btn_Verificar
            // 
            this.Btn_Verificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Verificar.Location = new System.Drawing.Point(193, 70);
            this.Btn_Verificar.Name = "Btn_Verificar";
            this.Btn_Verificar.Size = new System.Drawing.Size(93, 35);
            this.Btn_Verificar.TabIndex = 1;
            this.Btn_Verificar.Text = "Verificar";
            this.Btn_Verificar.UseVisualStyleBackColor = true;
            this.Btn_Verificar.Click += new System.EventHandler(this.Btn_Verificar_Click);
            // 
            // Label_Titulo
            // 
            this.Label_Titulo.AutoSize = true;
            this.Label_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Titulo.Location = new System.Drawing.Point(19, 39);
            this.Label_Titulo.Name = "Label_Titulo";
            this.Label_Titulo.Size = new System.Drawing.Size(230, 20);
            this.Label_Titulo.TabIndex = 2;
            this.Label_Titulo.Text = "Introduzca el número a verificar";
            // 
            // Label_Prg
            // 
            this.Label_Prg.AutoSize = true;
            this.Label_Prg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Prg.Location = new System.Drawing.Point(39, 128);
            this.Label_Prg.Name = "Label_Prg";
            this.Label_Prg.Size = new System.Drawing.Size(169, 20);
            this.Label_Prg.TabIndex = 3;
            this.Label_Prg.Text = "¿Es un número primo?";
            // 
            // Label_Respuesta
            // 
            this.Label_Respuesta.AutoSize = true;
            this.Label_Respuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Respuesta.Location = new System.Drawing.Point(214, 117);
            this.Label_Respuesta.Name = "Label_Respuesta";
            this.Label_Respuesta.Size = new System.Drawing.Size(42, 33);
            this.Label_Respuesta.TabIndex = 4;
            this.Label_Respuesta.Text = "...";
            this.Label_Respuesta.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 183);
            this.Controls.Add(this.Label_Respuesta);
            this.Controls.Add(this.Label_Prg);
            this.Controls.Add(this.Label_Titulo);
            this.Controls.Add(this.Btn_Verificar);
            this.Controls.Add(this.MTextBox_Entrada);
            this.Name = "Form1";
            this.Text = "Verificar si un númro es primo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox MTextBox_Entrada;
        private System.Windows.Forms.Button Btn_Verificar;
        private System.Windows.Forms.Label Label_Titulo;
        private System.Windows.Forms.Label Label_Prg;
        private System.Windows.Forms.Label Label_Respuesta;
    }
}

