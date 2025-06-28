namespace _11_MostrarFecha
{
    partial class MostrarFecha11
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
            this.DTP_Transfer = new System.Windows.Forms.DateTimePicker();
            this.Btn_Transfer = new System.Windows.Forms.Button();
            this.Label_Transfer = new System.Windows.Forms.Label();
            this.Label_Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DTP_Transfer
            // 
            this.DTP_Transfer.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_Transfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_Transfer.Location = new System.Drawing.Point(47, 92);
            this.DTP_Transfer.Name = "DTP_Transfer";
            this.DTP_Transfer.Size = new System.Drawing.Size(262, 22);
            this.DTP_Transfer.TabIndex = 0;
            // 
            // Btn_Transfer
            // 
            this.Btn_Transfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Transfer.Location = new System.Drawing.Point(47, 137);
            this.Btn_Transfer.Name = "Btn_Transfer";
            this.Btn_Transfer.Size = new System.Drawing.Size(124, 49);
            this.Btn_Transfer.TabIndex = 1;
            this.Btn_Transfer.Text = "Transferir";
            this.Btn_Transfer.UseVisualStyleBackColor = true;
            this.Btn_Transfer.Click += new System.EventHandler(this.button1_Click);
            // 
            // Label_Transfer
            // 
            this.Label_Transfer.AutoSize = true;
            this.Label_Transfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Transfer.Location = new System.Drawing.Point(43, 217);
            this.Label_Transfer.Name = "Label_Transfer";
            this.Label_Transfer.Size = new System.Drawing.Size(24, 20);
            this.Label_Transfer.TabIndex = 2;
            this.Label_Transfer.Text = "...";
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Title.Location = new System.Drawing.Point(43, 49);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(162, 20);
            this.Label_Title.TabIndex = 3;
            this.Label_Title.Text = "Seleccione una fecha";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Label_Title);
            this.Controls.Add(this.Label_Transfer);
            this.Controls.Add(this.Btn_Transfer);
            this.Controls.Add(this.DTP_Transfer);
            this.Name = "Form_Main";
            this.Text = "Mostrar en etiqueta fecha seleccionada en el DateTimePicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTP_Transfer;
        private System.Windows.Forms.Button Btn_Transfer;
        private System.Windows.Forms.Label Label_Transfer;
        private System.Windows.Forms.Label Label_Title;
    }
}

