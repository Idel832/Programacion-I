namespace Menu_Global
{
    partial class Form_Login
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
            this.TxtBox_Login_Nombre = new System.Windows.Forms.TextBox();
            this.TxtBox_Login_Contr = new System.Windows.Forms.TextBox();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Label_Login_Nombre = new System.Windows.Forms.Label();
            this.Label_Login_Contr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtBox_Login_Nombre
            // 
            this.TxtBox_Login_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Login_Nombre.Location = new System.Drawing.Point(77, 55);
            this.TxtBox_Login_Nombre.Name = "TxtBox_Login_Nombre";
            this.TxtBox_Login_Nombre.Size = new System.Drawing.Size(180, 26);
            this.TxtBox_Login_Nombre.TabIndex = 0;
            // 
            // TxtBox_Login_Contr
            // 
            this.TxtBox_Login_Contr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Login_Contr.Location = new System.Drawing.Point(77, 123);
            this.TxtBox_Login_Contr.Name = "TxtBox_Login_Contr";
            this.TxtBox_Login_Contr.Size = new System.Drawing.Size(180, 26);
            this.TxtBox_Login_Contr.TabIndex = 1;
            this.TxtBox_Login_Contr.UseSystemPasswordChar = true;
            // 
            // Btn_Login
            // 
            this.Btn_Login.Location = new System.Drawing.Point(89, 172);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(148, 51);
            this.Btn_Login.TabIndex = 2;
            this.Btn_Login.Text = "Acceder";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Label_Login_Nombre
            // 
            this.Label_Login_Nombre.AutoSize = true;
            this.Label_Login_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Login_Nombre.Location = new System.Drawing.Point(73, 32);
            this.Label_Login_Nombre.Name = "Label_Login_Nombre";
            this.Label_Login_Nombre.Size = new System.Drawing.Size(68, 20);
            this.Label_Login_Nombre.TabIndex = 3;
            this.Label_Login_Nombre.Text = "Usuario:";
            // 
            // Label_Login_Contr
            // 
            this.Label_Login_Contr.AutoSize = true;
            this.Label_Login_Contr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Login_Contr.Location = new System.Drawing.Point(73, 100);
            this.Label_Login_Contr.Name = "Label_Login_Contr";
            this.Label_Login_Contr.Size = new System.Drawing.Size(96, 20);
            this.Label_Login_Contr.TabIndex = 4;
            this.Label_Login_Contr.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuario: Idelfonso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contraseña: MT-2024-00222";
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(344, 302);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label_Login_Contr);
            this.Controls.Add(this.Label_Login_Nombre);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.TxtBox_Login_Contr);
            this.Controls.Add(this.TxtBox_Login_Nombre);
            this.Name = "Form_Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBox_Login_Nombre;
        private System.Windows.Forms.TextBox TxtBox_Login_Contr;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.Label Label_Login_Nombre;
        private System.Windows.Forms.Label Label_Login_Contr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

