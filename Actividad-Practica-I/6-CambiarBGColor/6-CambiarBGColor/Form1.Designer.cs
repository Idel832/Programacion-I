namespace _6_CambiarBGColor
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
            this.ComboBox_Colors = new System.Windows.Forms.ComboBox();
            this.Label_Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComboBox_Colors
            // 
            this.ComboBox_Colors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Colors.FormattingEnabled = true;
            this.ComboBox_Colors.Items.AddRange(new object[] {
            "Rojo",
            "Verde",
            "Azul"});
            this.ComboBox_Colors.Location = new System.Drawing.Point(59, 97);
            this.ComboBox_Colors.Name = "ComboBox_Colors";
            this.ComboBox_Colors.Size = new System.Drawing.Size(175, 32);
            this.ComboBox_Colors.TabIndex = 0;
            this.ComboBox_Colors.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Colors_SelectedIndexChanged);
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Title.Location = new System.Drawing.Point(55, 52);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(179, 24);
            this.Label_Title.TabIndex = 1;
            this.Label_Title.Text = "Seleccione un color";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Label_Title);
            this.Controls.Add(this.ComboBox_Colors);
            this.Name = "Form_Main";
            this.Text = "Cambiar fondo del formulario seleccionado colores en un ComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBox_Colors;
        private System.Windows.Forms.Label Label_Title;
    }
}

