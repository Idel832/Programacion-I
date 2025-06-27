namespace prueba_visual
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Btn_Confirmar = new Button();
            Txt_Nombre = new TextBox();
            Titulo_Nombre = new Label();
            Titulo_Principal = new Label();
            Titulo_Apellido = new Label();
            Txt_Apellido = new TextBox();
            Titulo_Direccion_Vivienda = new Label();
            Txt_DirVivienda = new TextBox();
            Titulo_Correo = new Label();
            Txt_Correo_User = new TextBox();
            Titulo_Extension = new Label();
            DatePicker_Nacimiento = new DateTimePicker();
            Titulo_Nacimiento = new Label();
            Titulo_Num_Telf = new Label();
            Txt_Numero_Telf = new TextBox();
            Titulo_Correo_Recup = new Label();
            Txt_Correo_Recuperacion = new TextBox();
            Btn_Restablecer = new Button();
            Titulo_User_pswd = new Label();
            Txt_User_Pswd = new TextBox();
            Txt_Extn = new ComboBox();
            SuspendLayout();
            // 
            // Btn_Confirmar
            // 
            Btn_Confirmar.Location = new Point(412, 525);
            Btn_Confirmar.Name = "Btn_Confirmar";
            Btn_Confirmar.Size = new Size(75, 23);
            Btn_Confirmar.TabIndex = 0;
            Btn_Confirmar.Text = "Confirmar";
            Btn_Confirmar.UseVisualStyleBackColor = true;
            // 
            // Txt_Nombre
            // 
            Txt_Nombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txt_Nombre.Location = new Point(29, 132);
            Txt_Nombre.Name = "Txt_Nombre";
            Txt_Nombre.Size = new Size(315, 27);
            Txt_Nombre.TabIndex = 1;
            // 
            // Titulo_Nombre
            // 
            Titulo_Nombre.AutoSize = true;
            Titulo_Nombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Titulo_Nombre.Location = new Point(29, 108);
            Titulo_Nombre.Name = "Titulo_Nombre";
            Titulo_Nombre.Size = new Size(68, 21);
            Titulo_Nombre.TabIndex = 2;
            Titulo_Nombre.Text = "Nombre";
            Titulo_Nombre.Click += label1_Click;
            // 
            // Titulo_Principal
            // 
            Titulo_Principal.AutoSize = true;
            Titulo_Principal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Titulo_Principal.Location = new Point(29, 18);
            Titulo_Principal.Name = "Titulo_Principal";
            Titulo_Principal.Size = new Size(653, 32);
            Titulo_Principal.TabIndex = 3;
            Titulo_Principal.Text = "Ingrese a continuacion los datos solicitados para su registro.";
            // 
            // Titulo_Apellido
            // 
            Titulo_Apellido.AutoSize = true;
            Titulo_Apellido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Titulo_Apellido.Location = new Point(412, 108);
            Titulo_Apellido.Name = "Titulo_Apellido";
            Titulo_Apellido.Size = new Size(74, 21);
            Titulo_Apellido.TabIndex = 5;
            Titulo_Apellido.Text = "Apellidos";
            // 
            // Txt_Apellido
            // 
            Txt_Apellido.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txt_Apellido.Location = new Point(412, 132);
            Txt_Apellido.Name = "Txt_Apellido";
            Txt_Apellido.Size = new Size(315, 27);
            Txt_Apellido.TabIndex = 4;
            // 
            // Titulo_Direccion_Vivienda
            // 
            Titulo_Direccion_Vivienda.AutoSize = true;
            Titulo_Direccion_Vivienda.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Titulo_Direccion_Vivienda.Location = new Point(29, 253);
            Titulo_Direccion_Vivienda.Name = "Titulo_Direccion_Vivienda";
            Titulo_Direccion_Vivienda.Size = new Size(75, 21);
            Titulo_Direccion_Vivienda.TabIndex = 7;
            Titulo_Direccion_Vivienda.Text = "Dirección";
            // 
            // Txt_DirVivienda
            // 
            Txt_DirVivienda.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txt_DirVivienda.Location = new Point(29, 277);
            Txt_DirVivienda.Name = "Txt_DirVivienda";
            Txt_DirVivienda.Size = new Size(698, 27);
            Txt_DirVivienda.TabIndex = 6;
            // 
            // Titulo_Correo
            // 
            Titulo_Correo.AutoSize = true;
            Titulo_Correo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Titulo_Correo.Location = new Point(29, 188);
            Titulo_Correo.Name = "Titulo_Correo";
            Titulo_Correo.Size = new Size(58, 21);
            Titulo_Correo.TabIndex = 9;
            Titulo_Correo.Text = "Correo";
            // 
            // Txt_Correo_User
            // 
            Txt_Correo_User.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txt_Correo_User.Location = new Point(29, 212);
            Txt_Correo_User.Name = "Txt_Correo_User";
            Txt_Correo_User.Size = new Size(315, 27);
            Txt_Correo_User.TabIndex = 8;
            // 
            // Titulo_Extension
            // 
            Titulo_Extension.AutoSize = true;
            Titulo_Extension.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Titulo_Extension.Location = new Point(412, 188);
            Titulo_Extension.Name = "Titulo_Extension";
            Titulo_Extension.Size = new Size(76, 21);
            Titulo_Extension.TabIndex = 11;
            Titulo_Extension.Text = "Extension";
            Titulo_Extension.Click += label6_Click;
            // 
            // DatePicker_Nacimiento
            // 
            DatePicker_Nacimiento.CalendarFont = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DatePicker_Nacimiento.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DatePicker_Nacimiento.Location = new Point(29, 347);
            DatePicker_Nacimiento.MinDate = new DateTime(1920, 1, 1, 0, 0, 0, 0);
            DatePicker_Nacimiento.Name = "DatePicker_Nacimiento";
            DatePicker_Nacimiento.Size = new Size(259, 25);
            DatePicker_Nacimiento.TabIndex = 12;
            // 
            // Titulo_Nacimiento
            // 
            Titulo_Nacimiento.AutoSize = true;
            Titulo_Nacimiento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Titulo_Nacimiento.Location = new Point(29, 323);
            Titulo_Nacimiento.Name = "Titulo_Nacimiento";
            Titulo_Nacimiento.Size = new Size(152, 21);
            Titulo_Nacimiento.TabIndex = 13;
            Titulo_Nacimiento.Text = "Fecha de nacimiento";
            // 
            // Titulo_Num_Telf
            // 
            Titulo_Num_Telf.AutoSize = true;
            Titulo_Num_Telf.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Titulo_Num_Telf.Location = new Point(412, 321);
            Titulo_Num_Telf.Name = "Titulo_Num_Telf";
            Titulo_Num_Telf.Size = new Size(151, 21);
            Titulo_Num_Telf.TabIndex = 15;
            Titulo_Num_Telf.Text = "Numero de Telefono";
            // 
            // Txt_Numero_Telf
            // 
            Txt_Numero_Telf.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txt_Numero_Telf.Location = new Point(412, 345);
            Txt_Numero_Telf.Name = "Txt_Numero_Telf";
            Txt_Numero_Telf.Size = new Size(315, 27);
            Txt_Numero_Telf.TabIndex = 14;
            // 
            // Titulo_Correo_Recup
            // 
            Titulo_Correo_Recup.AutoSize = true;
            Titulo_Correo_Recup.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Titulo_Correo_Recup.Location = new Point(29, 396);
            Titulo_Correo_Recup.Name = "Titulo_Correo_Recup";
            Titulo_Correo_Recup.Size = new Size(173, 21);
            Titulo_Correo_Recup.TabIndex = 17;
            Titulo_Correo_Recup.Text = "Correo de recuperación";
            // 
            // Txt_Correo_Recuperacion
            // 
            Txt_Correo_Recuperacion.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txt_Correo_Recuperacion.Location = new Point(29, 420);
            Txt_Correo_Recuperacion.Name = "Txt_Correo_Recuperacion";
            Txt_Correo_Recuperacion.Size = new Size(315, 27);
            Txt_Correo_Recuperacion.TabIndex = 16;
            // 
            // Btn_Restablecer
            // 
            Btn_Restablecer.Location = new Point(269, 525);
            Btn_Restablecer.Name = "Btn_Restablecer";
            Btn_Restablecer.Size = new Size(75, 23);
            Btn_Restablecer.TabIndex = 18;
            Btn_Restablecer.Text = "Restablecer";
            Btn_Restablecer.UseVisualStyleBackColor = true;
            // 
            // Titulo_User_pswd
            // 
            Titulo_User_pswd.AutoSize = true;
            Titulo_User_pswd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Titulo_User_pswd.Location = new Point(412, 396);
            Titulo_User_pswd.Name = "Titulo_User_pswd";
            Titulo_User_pswd.Size = new Size(89, 21);
            Titulo_User_pswd.TabIndex = 20;
            Titulo_User_pswd.Text = "Contraseña";
            // 
            // Txt_User_Pswd
            // 
            Txt_User_Pswd.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txt_User_Pswd.Location = new Point(412, 420);
            Txt_User_Pswd.Name = "Txt_User_Pswd";
            Txt_User_Pswd.Size = new Size(315, 27);
            Txt_User_Pswd.TabIndex = 19;
            Txt_User_Pswd.UseSystemPasswordChar = true;
            // 
            // Txt_Extn
            // 
            Txt_Extn.AccessibleDescription = "";
            Txt_Extn.AccessibleName = "";
            Txt_Extn.BackColor = Color.LavenderBlush;
            Txt_Extn.DropDownStyle = ComboBoxStyle.DropDownList;
            Txt_Extn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Txt_Extn.ForeColor = SystemColors.WindowFrame;
            Txt_Extn.FormattingEnabled = true;
            Txt_Extn.Items.AddRange(new object[] { "@prueba.net", "@hotmail.com", "@ufhec.edu.do", "@extension.com.do" });
            Txt_Extn.Location = new Point(412, 216);
            Txt_Extn.Name = "Txt_Extn";
            Txt_Extn.RightToLeft = RightToLeft.Yes;
            Txt_Extn.Size = new Size(315, 23);
            Txt_Extn.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 569);
            Controls.Add(Txt_Extn);
            Controls.Add(Titulo_User_pswd);
            Controls.Add(Txt_User_Pswd);
            Controls.Add(Btn_Restablecer);
            Controls.Add(Titulo_Correo_Recup);
            Controls.Add(Txt_Correo_Recuperacion);
            Controls.Add(Titulo_Num_Telf);
            Controls.Add(Txt_Numero_Telf);
            Controls.Add(Titulo_Nacimiento);
            Controls.Add(DatePicker_Nacimiento);
            Controls.Add(Titulo_Extension);
            Controls.Add(Titulo_Correo);
            Controls.Add(Txt_Correo_User);
            Controls.Add(Titulo_Direccion_Vivienda);
            Controls.Add(Txt_DirVivienda);
            Controls.Add(Titulo_Apellido);
            Controls.Add(Txt_Apellido);
            Controls.Add(Titulo_Principal);
            Controls.Add(Titulo_Nombre);
            Controls.Add(Txt_Nombre);
            Controls.Add(Btn_Confirmar);
            Name = "Form1";
            Text = "Registro de usuario";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Confirmar;
        private TextBox Txt_Nombre;
        private Label Titulo_Nombre;
        private Label Titulo_Principal;
        private Label Titulo_Apellido;
        private TextBox Txt_Apellido;
        private Label Titulo_Direccion_Vivienda;
        private TextBox Txt_DirVivienda;
        private Label Titulo_Correo;
        private TextBox Txt_Correo_User;
        private Label Titulo_Extension;
        private DateTimePicker DatePicker_Nacimiento;
        private Label Titulo_Nacimiento;
        private Label Titulo_Num_Telf;
        private TextBox Txt_Numero_Telf;
        private Label Titulo_Correo_Recup;
        private TextBox Txt_Correo_Recuperacion;
        private Button Btn_Restablecer;
        private Label Titulo_User_pswd;
        private TextBox Txt_User_Pswd;
        private ComboBox Txt_Extn;
    }
}
