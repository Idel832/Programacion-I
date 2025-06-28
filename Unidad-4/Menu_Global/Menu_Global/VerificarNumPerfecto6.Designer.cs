namespace _6_NúmeroPerfecto
{
    partial class VerificarNumPerfecto6
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
            this.Label_Titulo = new System.Windows.Forms.Label();
            this.MTxtBox_Entrada = new System.Windows.Forms.MaskedTextBox();
            this.label_Preg = new System.Windows.Forms.Label();
            this.Label_Respuesta = new System.Windows.Forms.Label();
            this.Btn_Validar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_Titulo
            // 
            this.Label_Titulo.AutoSize = true;
            this.Label_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Titulo.Location = new System.Drawing.Point(54, 26);
            this.Label_Titulo.Name = "Label_Titulo";
            this.Label_Titulo.Size = new System.Drawing.Size(262, 24);
            this.Label_Titulo.TabIndex = 0;
            this.Label_Titulo.Text = "Introduzca el número a validar";
            // 
            // MTxtBox_Entrada
            // 
            this.MTxtBox_Entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTxtBox_Entrada.Location = new System.Drawing.Point(57, 60);
            this.MTxtBox_Entrada.Mask = "0000000000000";
            this.MTxtBox_Entrada.Name = "MTxtBox_Entrada";
            this.MTxtBox_Entrada.Size = new System.Drawing.Size(149, 29);
            this.MTxtBox_Entrada.TabIndex = 1;
            // 
            // label_Preg
            // 
            this.label_Preg.AutoSize = true;
            this.label_Preg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Preg.Location = new System.Drawing.Point(34, 104);
            this.label_Preg.Name = "label_Preg";
            this.label_Preg.Size = new System.Drawing.Size(223, 24);
            this.label_Preg.TabIndex = 2;
            this.label_Preg.Text = "¿Es un número perfecto?";
            // 
            // Label_Respuesta
            // 
            this.Label_Respuesta.AutoSize = true;
            this.Label_Respuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Respuesta.Location = new System.Drawing.Point(263, 94);
            this.Label_Respuesta.Name = "Label_Respuesta";
            this.Label_Respuesta.Size = new System.Drawing.Size(44, 37);
            this.Label_Respuesta.TabIndex = 3;
            this.Label_Respuesta.Text = "...";
            // 
            // Btn_Validar
            // 
            this.Btn_Validar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Validar.Location = new System.Drawing.Point(212, 60);
            this.Btn_Validar.Name = "Btn_Validar";
            this.Btn_Validar.Size = new System.Drawing.Size(104, 31);
            this.Btn_Validar.TabIndex = 4;
            this.Btn_Validar.Text = "Validar";
            this.Btn_Validar.UseVisualStyleBackColor = true;
            this.Btn_Validar.Click += new System.EventHandler(this.Btn_Validar_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 177);
            this.Controls.Add(this.Btn_Validar);
            this.Controls.Add(this.Label_Respuesta);
            this.Controls.Add(this.label_Preg);
            this.Controls.Add(this.MTxtBox_Entrada);
            this.Controls.Add(this.Label_Titulo);
            this.Name = "Form_Main";
            this.Text = "Verificar si el número indicado es perfecto o no";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Titulo;
        private System.Windows.Forms.MaskedTextBox MTxtBox_Entrada;
        private System.Windows.Forms.Label label_Preg;
        private System.Windows.Forms.Label Label_Respuesta;
        private System.Windows.Forms.Button Btn_Validar;
    }
}

