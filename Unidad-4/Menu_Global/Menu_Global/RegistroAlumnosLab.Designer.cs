namespace _1_Ejercicio_Lab04
{
    partial class RegistroAlumnosLab
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
            this.Label_Codigo = new System.Windows.Forms.Label();
            this.Label_Nombre = new System.Windows.Forms.Label();
            this.Label_Promedio = new System.Windows.Forms.Label();
            this.Label_BuscarCod = new System.Windows.Forms.Label();
            this.TxtBox_Codigo = new System.Windows.Forms.TextBox();
            this.TxtBox_Nombre = new System.Windows.Forms.TextBox();
            this.TxtBox_Promedio = new System.Windows.Forms.TextBox();
            this.TxtBox_Buqueda = new System.Windows.Forms.TextBox();
            this.Btn_Registrar = new System.Windows.Forms.Button();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Ordenar = new System.Windows.Forms.Button();
            this.DG_Alumnos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Alumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Codigo
            // 
            this.Label_Codigo.AutoSize = true;
            this.Label_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Codigo.Location = new System.Drawing.Point(37, 26);
            this.Label_Codigo.Name = "Label_Codigo";
            this.Label_Codigo.Size = new System.Drawing.Size(93, 24);
            this.Label_Codigo.TabIndex = 0;
            this.Label_Codigo.Text = "Código:  *";
            // 
            // Label_Nombre
            // 
            this.Label_Nombre.AutoSize = true;
            this.Label_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Nombre.Location = new System.Drawing.Point(37, 101);
            this.Label_Nombre.Name = "Label_Nombre";
            this.Label_Nombre.Size = new System.Drawing.Size(101, 24);
            this.Label_Nombre.TabIndex = 1;
            this.Label_Nombre.Text = "Nombre:  *";
            // 
            // Label_Promedio
            // 
            this.Label_Promedio.AutoSize = true;
            this.Label_Promedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Promedio.Location = new System.Drawing.Point(256, 26);
            this.Label_Promedio.Name = "Label_Promedio";
            this.Label_Promedio.Size = new System.Drawing.Size(114, 24);
            this.Label_Promedio.TabIndex = 2;
            this.Label_Promedio.Text = "Promedio:  *";
            // 
            // Label_BuscarCod
            // 
            this.Label_BuscarCod.AutoSize = true;
            this.Label_BuscarCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_BuscarCod.Location = new System.Drawing.Point(37, 221);
            this.Label_BuscarCod.Name = "Label_BuscarCod";
            this.Label_BuscarCod.Size = new System.Drawing.Size(174, 24);
            this.Label_BuscarCod.TabIndex = 3;
            this.Label_BuscarCod.Text = "Buscar por código: ";
            this.Label_BuscarCod.Click += new System.EventHandler(this.label4_Click);
            // 
            // TxtBox_Codigo
            // 
            this.TxtBox_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Codigo.Location = new System.Drawing.Point(41, 53);
            this.TxtBox_Codigo.Name = "TxtBox_Codigo";
            this.TxtBox_Codigo.Size = new System.Drawing.Size(213, 26);
            this.TxtBox_Codigo.TabIndex = 4;
            // 
            // TxtBox_Nombre
            // 
            this.TxtBox_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Nombre.Location = new System.Drawing.Point(136, 101);
            this.TxtBox_Nombre.Name = "TxtBox_Nombre";
            this.TxtBox_Nombre.Size = new System.Drawing.Size(339, 26);
            this.TxtBox_Nombre.TabIndex = 5;
            // 
            // TxtBox_Promedio
            // 
            this.TxtBox_Promedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Promedio.Location = new System.Drawing.Point(260, 53);
            this.TxtBox_Promedio.Name = "TxtBox_Promedio";
            this.TxtBox_Promedio.Size = new System.Drawing.Size(213, 26);
            this.TxtBox_Promedio.TabIndex = 6;
            // 
            // TxtBox_Buqueda
            // 
            this.TxtBox_Buqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Buqueda.Location = new System.Drawing.Point(41, 257);
            this.TxtBox_Buqueda.Name = "TxtBox_Buqueda";
            this.TxtBox_Buqueda.Size = new System.Drawing.Size(161, 26);
            this.TxtBox_Buqueda.TabIndex = 7;
            // 
            // Btn_Registrar
            // 
            this.Btn_Registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Registrar.Location = new System.Drawing.Point(41, 144);
            this.Btn_Registrar.Name = "Btn_Registrar";
            this.Btn_Registrar.Size = new System.Drawing.Size(158, 43);
            this.Btn_Registrar.TabIndex = 8;
            this.Btn_Registrar.Text = "Registrar";
            this.Btn_Registrar.UseVisualStyleBackColor = true;
            this.Btn_Registrar.Click += new System.EventHandler(this.Btn_Registrar_Click);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buscar.Location = new System.Drawing.Point(217, 230);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(128, 53);
            this.Btn_Buscar.TabIndex = 9;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.Location = new System.Drawing.Point(347, 230);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(128, 53);
            this.Btn_Eliminar.TabIndex = 10;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Ordenar
            // 
            this.Btn_Ordenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ordenar.Location = new System.Drawing.Point(41, 298);
            this.Btn_Ordenar.Name = "Btn_Ordenar";
            this.Btn_Ordenar.Size = new System.Drawing.Size(161, 28);
            this.Btn_Ordenar.TabIndex = 11;
            this.Btn_Ordenar.Text = "Ordenar estudiantes";
            this.Btn_Ordenar.UseVisualStyleBackColor = true;
            this.Btn_Ordenar.Click += new System.EventHandler(this.Btn_Ordenar_Click);
            // 
            // DG_Alumnos
            // 
            this.DG_Alumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Alumnos.Location = new System.Drawing.Point(41, 332);
            this.DG_Alumnos.Name = "DG_Alumnos";
            this.DG_Alumnos.Size = new System.Drawing.Size(432, 244);
            this.DG_Alumnos.TabIndex = 12;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(509, 600);
            this.Controls.Add(this.DG_Alumnos);
            this.Controls.Add(this.Btn_Ordenar);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Btn_Registrar);
            this.Controls.Add(this.TxtBox_Buqueda);
            this.Controls.Add(this.TxtBox_Promedio);
            this.Controls.Add(this.TxtBox_Nombre);
            this.Controls.Add(this.TxtBox_Codigo);
            this.Controls.Add(this.Label_BuscarCod);
            this.Controls.Add(this.Label_Promedio);
            this.Controls.Add(this.Label_Nombre);
            this.Controls.Add(this.Label_Codigo);
            this.Name = "Form_Main";
            this.Text = "Registro de estudiantes";
            ((System.ComponentModel.ISupportInitialize)(this.DG_Alumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Codigo;
        private System.Windows.Forms.Label Label_Nombre;
        private System.Windows.Forms.Label Label_Promedio;
        private System.Windows.Forms.Label Label_BuscarCod;
        private System.Windows.Forms.TextBox TxtBox_Codigo;
        private System.Windows.Forms.TextBox TxtBox_Nombre;
        private System.Windows.Forms.TextBox TxtBox_Promedio;
        private System.Windows.Forms.TextBox TxtBox_Buqueda;
        private System.Windows.Forms.Button Btn_Registrar;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Ordenar;
        private System.Windows.Forms.DataGridView DG_Alumnos;
    }
}

