namespace _10_MensajeEmergente
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
            this.Btn_Show = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Show
            // 
            this.Btn_Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Show.Location = new System.Drawing.Point(66, 41);
            this.Btn_Show.Name = "Btn_Show";
            this.Btn_Show.Size = new System.Drawing.Size(154, 57);
            this.Btn_Show.TabIndex = 0;
            this.Btn_Show.Text = "Presioname";
            this.Btn_Show.UseVisualStyleBackColor = true;
            this.Btn_Show.Click += new System.EventHandler(this.Btn_Show_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 150);
            this.Controls.Add(this.Btn_Show);
            this.Name = "Form_Main";
            this.Text = "Mostrar mensaje emergente con nombre y matricula";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Show;
    }
}

