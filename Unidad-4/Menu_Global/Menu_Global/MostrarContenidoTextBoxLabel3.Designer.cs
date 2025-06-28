namespace _3_MostrarContenidoTxtBox_Label
{
    partial class MostrarContenidoTextBoxLabel3
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
            this.Label_Cambiar = new System.Windows.Forms.Label();
            this.TxtBox_Cambiar = new System.Windows.Forms.TextBox();
            this.Btn_Cambiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_Cambiar
            // 
            this.Label_Cambiar.AutoSize = true;
            this.Label_Cambiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Cambiar.Location = new System.Drawing.Point(34, 157);
            this.Label_Cambiar.Name = "Label_Cambiar";
            this.Label_Cambiar.Size = new System.Drawing.Size(199, 20);
            this.Label_Cambiar.TabIndex = 0;
            this.Label_Cambiar.Text = "Escribe y presiona el botón";
            this.Label_Cambiar.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtBox_Cambiar
            // 
            this.TxtBox_Cambiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Cambiar.Location = new System.Drawing.Point(38, 74);
            this.TxtBox_Cambiar.Name = "TxtBox_Cambiar";
            this.TxtBox_Cambiar.Size = new System.Drawing.Size(292, 29);
            this.TxtBox_Cambiar.TabIndex = 1;
            // 
            // Btn_Cambiar
            // 
            this.Btn_Cambiar.Location = new System.Drawing.Point(396, 67);
            this.Btn_Cambiar.Name = "Btn_Cambiar";
            this.Btn_Cambiar.Size = new System.Drawing.Size(135, 48);
            this.Btn_Cambiar.TabIndex = 2;
            this.Btn_Cambiar.Text = "Presioname";
            this.Btn_Cambiar.UseVisualStyleBackColor = true;
            this.Btn_Cambiar.Click += new System.EventHandler(this.Btn_Cambiar_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Cambiar);
            this.Controls.Add(this.TxtBox_Cambiar);
            this.Controls.Add(this.Label_Cambiar);
            this.Name = "Form_Main";
            this.Text = "Mostrar contenido de TextBox en una etiqueta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Cambiar;
        private System.Windows.Forms.TextBox TxtBox_Cambiar;
        private System.Windows.Forms.Button Btn_Cambiar;
    }
}

