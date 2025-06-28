namespace ContandoLetrasOracion
{
    partial class ContandoLetras
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
            this.TxtBox_Escribe = new System.Windows.Forms.TextBox();
            this.ListBox_Analizar = new System.Windows.Forms.ListBox();
            this.Btn_Analizar = new System.Windows.Forms.Button();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.Label_Titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtBox_Escribe
            // 
            this.TxtBox_Escribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Escribe.Location = new System.Drawing.Point(51, 80);
            this.TxtBox_Escribe.Name = "TxtBox_Escribe";
            this.TxtBox_Escribe.Size = new System.Drawing.Size(410, 26);
            this.TxtBox_Escribe.TabIndex = 0;
            // 
            // ListBox_Analizar
            // 
            this.ListBox_Analizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBox_Analizar.FormattingEnabled = true;
            this.ListBox_Analizar.ItemHeight = 16;
            this.ListBox_Analizar.Location = new System.Drawing.Point(51, 122);
            this.ListBox_Analizar.Name = "ListBox_Analizar";
            this.ListBox_Analizar.Size = new System.Drawing.Size(410, 228);
            this.ListBox_Analizar.TabIndex = 1;
            // 
            // Btn_Analizar
            // 
            this.Btn_Analizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Analizar.Location = new System.Drawing.Point(371, 39);
            this.Btn_Analizar.Name = "Btn_Analizar";
            this.Btn_Analizar.Size = new System.Drawing.Size(90, 35);
            this.Btn_Analizar.TabIndex = 2;
            this.Btn_Analizar.Text = "Analizar";
            this.Btn_Analizar.UseVisualStyleBackColor = true;
            this.Btn_Analizar.Click += new System.EventHandler(this.Btn_Analizar_Click);
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Limpiar.Location = new System.Drawing.Point(371, 366);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(90, 35);
            this.Btn_Limpiar.TabIndex = 3;
            this.Btn_Limpiar.Text = "Limpiar";
            this.Btn_Limpiar.UseVisualStyleBackColor = true;
            this.Btn_Limpiar.Click += new System.EventHandler(this.Btn_Limpiar_Click);
            // 
            // Label_Titulo
            // 
            this.Label_Titulo.AutoSize = true;
            this.Label_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Titulo.Location = new System.Drawing.Point(48, 46);
            this.Label_Titulo.Name = "Label_Titulo";
            this.Label_Titulo.Size = new System.Drawing.Size(58, 18);
            this.Label_Titulo.TabIndex = 4;
            this.Label_Titulo.Text = "Escribe";
            // 
            // ContandoLetras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 444);
            this.Controls.Add(this.Label_Titulo);
            this.Controls.Add(this.Btn_Limpiar);
            this.Controls.Add(this.Btn_Analizar);
            this.Controls.Add(this.ListBox_Analizar);
            this.Controls.Add(this.TxtBox_Escribe);
            this.Name = "ContandoLetras";
            this.Text = "Contando letras en una oración";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBox_Escribe;
        private System.Windows.Forms.ListBox ListBox_Analizar;
        private System.Windows.Forms.Button Btn_Analizar;
        private System.Windows.Forms.Button Btn_Limpiar;
        private System.Windows.Forms.Label Label_Titulo;
    }
}

