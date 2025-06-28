namespace Mostrar_TablaMultiplicar
{
    partial class MostrarTablaMultiplicar1
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
            this.ListBox_Tabla = new System.Windows.Forms.ListBox();
            this.Btn_Mostrar = new System.Windows.Forms.Button();
            this.Label_Title = new System.Windows.Forms.Label();
            this.TxtBox_IngresarNumero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ListBox_Tabla
            // 
            this.ListBox_Tabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBox_Tabla.FormattingEnabled = true;
            this.ListBox_Tabla.ItemHeight = 20;
            this.ListBox_Tabla.Location = new System.Drawing.Point(32, 99);
            this.ListBox_Tabla.Name = "ListBox_Tabla";
            this.ListBox_Tabla.Size = new System.Drawing.Size(516, 284);
            this.ListBox_Tabla.TabIndex = 0;
            // 
            // Btn_Mostrar
            // 
            this.Btn_Mostrar.Location = new System.Drawing.Point(139, 52);
            this.Btn_Mostrar.Name = "Btn_Mostrar";
            this.Btn_Mostrar.Size = new System.Drawing.Size(95, 41);
            this.Btn_Mostrar.TabIndex = 2;
            this.Btn_Mostrar.Text = "Mostrar";
            this.Btn_Mostrar.UseVisualStyleBackColor = true;
            this.Btn_Mostrar.Click += new System.EventHandler(this.Btn_Mostrar_Click);
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Title.Location = new System.Drawing.Point(29, 27);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(519, 20);
            this.Label_Title.TabIndex = 3;
            this.Label_Title.Text = "Indique el numero del cual desea saber la tabla de multiplicar hasta el 10";
            // 
            // TxtBox_IngresarNumero
            // 
            this.TxtBox_IngresarNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_IngresarNumero.Location = new System.Drawing.Point(33, 56);
            this.TxtBox_IngresarNumero.Name = "TxtBox_IngresarNumero";
            this.TxtBox_IngresarNumero.Size = new System.Drawing.Size(100, 29);
            this.TxtBox_IngresarNumero.TabIndex = 4;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 450);
            this.Controls.Add(this.TxtBox_IngresarNumero);
            this.Controls.Add(this.Label_Title);
            this.Controls.Add(this.Btn_Mostrar);
            this.Controls.Add(this.ListBox_Tabla);
            this.Name = "Form_Main";
            this.Text = "Mostrar la tabla de multiplicar en una lista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox_Tabla;
        private System.Windows.Forms.Button Btn_Mostrar;
        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.TextBox TxtBox_IngresarNumero;
    }
}

