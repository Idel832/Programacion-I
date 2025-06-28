namespace _2_BotonCambiaTexto
{
    partial class BotonCambiaTexto2
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
            this.Btn_CambiarTxt = new System.Windows.Forms.Button();
            this.Label_Cambiar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_CambiarTxt
            // 
            this.Btn_CambiarTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CambiarTxt.Location = new System.Drawing.Point(321, 93);
            this.Btn_CambiarTxt.Name = "Btn_CambiarTxt";
            this.Btn_CambiarTxt.Size = new System.Drawing.Size(112, 49);
            this.Btn_CambiarTxt.TabIndex = 0;
            this.Btn_CambiarTxt.Text = "Presioname";
            this.Btn_CambiarTxt.UseVisualStyleBackColor = true;
            this.Btn_CambiarTxt.Click += new System.EventHandler(this.Btn_CambiarTxt_Click);
            // 
            // Label_Cambiar
            // 
            this.Label_Cambiar.AutoSize = true;
            this.Label_Cambiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Cambiar.Location = new System.Drawing.Point(74, 106);
            this.Label_Cambiar.Name = "Label_Cambiar";
            this.Label_Cambiar.Size = new System.Drawing.Size(177, 20);
            this.Label_Cambiar.TabIndex = 1;
            this.Label_Cambiar.Text = "¡Hola! Presiona le botón";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Label_Cambiar);
            this.Controls.Add(this.Btn_CambiarTxt);
            this.Name = "Form_Main";
            this.Text = "Botón que cambie etiqueta a \"Texto cambiado\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_CambiarTxt;
        private System.Windows.Forms.Label Label_Cambiar;
    }
}

