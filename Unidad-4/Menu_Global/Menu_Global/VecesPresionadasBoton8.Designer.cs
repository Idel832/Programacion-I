namespace _8_VecesPresionadasBoton
{
    partial class VecesPresionadasBoton8
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
            this.Btn_Press = new System.Windows.Forms.Button();
            this.Label_Title = new System.Windows.Forms.Label();
            this.Label_Count = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Press
            // 
            this.Btn_Press.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Press.Location = new System.Drawing.Point(250, 61);
            this.Btn_Press.Name = "Btn_Press";
            this.Btn_Press.Size = new System.Drawing.Size(118, 70);
            this.Btn_Press.TabIndex = 0;
            this.Btn_Press.Text = "Presioname";
            this.Btn_Press.UseVisualStyleBackColor = true;
            this.Btn_Press.Click += new System.EventHandler(this.Btn_Press_Click);
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Title.Location = new System.Drawing.Point(27, 61);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(137, 20);
            this.Label_Title.TabIndex = 1;
            this.Label_Title.Text = "Veces presionada";
            // 
            // Label_Count
            // 
            this.Label_Count.AutoSize = true;
            this.Label_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Count.Location = new System.Drawing.Point(76, 106);
            this.Label_Count.Name = "Label_Count";
            this.Label_Count.Size = new System.Drawing.Size(30, 25);
            this.Label_Count.TabIndex = 2;
            this.Label_Count.Text = "...";
            this.Label_Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 277);
            this.Controls.Add(this.Label_Count);
            this.Controls.Add(this.Label_Title);
            this.Controls.Add(this.Btn_Press);
            this.Name = "Form_Main";
            this.Text = "Conteo de veces presionada de un boton";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Press;
        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.Label Label_Count;
    }
}

