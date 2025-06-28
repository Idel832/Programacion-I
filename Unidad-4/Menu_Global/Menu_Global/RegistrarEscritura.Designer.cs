namespace keylogger
{
    partial class RegistrarEscritura
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
            this.TxtBox_Input = new System.Windows.Forms.TextBox();
            this.ListBox_Keylogger = new System.Windows.Forms.ListBox();
            this.Titulo_Principal = new System.Windows.Forms.Label();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtBox_Input
            // 
            this.TxtBox_Input.Location = new System.Drawing.Point(21, 97);
            this.TxtBox_Input.Name = "TxtBox_Input";
            this.TxtBox_Input.Size = new System.Drawing.Size(546, 20);
            this.TxtBox_Input.TabIndex = 0;
            this.TxtBox_Input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.TxtBox_Input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBox_Input_KeyPress);
            // 
            // ListBox_Keylogger
            // 
            this.ListBox_Keylogger.FormattingEnabled = true;
            this.ListBox_Keylogger.Location = new System.Drawing.Point(21, 146);
            this.ListBox_Keylogger.Name = "ListBox_Keylogger";
            this.ListBox_Keylogger.Size = new System.Drawing.Size(546, 251);
            this.ListBox_Keylogger.TabIndex = 1;
            this.ListBox_Keylogger.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ListBox_Keylogger_KeyPress);
            // 
            // Titulo_Principal
            // 
            this.Titulo_Principal.AutoSize = true;
            this.Titulo_Principal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_Principal.Location = new System.Drawing.Point(16, 58);
            this.Titulo_Principal.Name = "Titulo_Principal";
            this.Titulo_Principal.Size = new System.Drawing.Size(242, 25);
            this.Titulo_Principal.TabIndex = 2;
            this.Titulo_Principal.Text = "Escriba a continuación: ";
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Location = new System.Drawing.Point(648, 400);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(131, 38);
            this.Btn_Clear.TabIndex = 3;
            this.Btn_Clear.Text = "Limpiar historial";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Principal_Intf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.Titulo_Principal);
            this.Controls.Add(this.ListBox_Keylogger);
            this.Controls.Add(this.TxtBox_Input);
            this.Name = "Principal_Intf";
            this.Text = "Un formulario nada sospechoso";
            this.Load += new System.EventHandler(this.Keylogger_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBox_Input;
        private System.Windows.Forms.ListBox ListBox_Keylogger;
        private System.Windows.Forms.Label Titulo_Principal;
        private System.Windows.Forms.Button Btn_Clear;
    }
}

