using System.Linq;
using System.Windows.Forms;

namespace ProyectoFinal_GestionAlmacen
{
    partial class Form_AgregarProductos
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
        /// 

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AgregarProductos));
            this.LabelBox_ID = new System.Windows.Forms.Label();
            this.LabelBox_Nombre = new System.Windows.Forms.Label();
            this.LabelBox_Necesidad = new System.Windows.Forms.Label();
            this.LabelBox_Categoria = new System.Windows.Forms.Label();
            this.LabelBox_Cantidad = new System.Windows.Forms.Label();
            this.LabelBox_Precio = new System.Windows.Forms.Label();
            this.LabelBox_CantMin = new System.Windows.Forms.Label();
            this.TextBox_Nombre = new System.Windows.Forms.TextBox();
            this.ComboTextBox_Necesidad = new System.Windows.Forms.ComboBox();
            this.ComboTextBox_Categoria = new System.Windows.Forms.ComboBox();
            this.MaskTextBox_Cantidad = new System.Windows.Forms.MaskedTextBox();
            this.MaskTextBox_Precio = new System.Windows.Forms.MaskedTextBox();
            this.MaskTextBox_CantidadMinima = new System.Windows.Forms.MaskedTextBox();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.MaskTextBox_ID = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // LabelBox_ID
            // 
            this.LabelBox_ID.AutoSize = true;
            this.LabelBox_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBox_ID.Location = new System.Drawing.Point(33, 46);
            this.LabelBox_ID.Name = "LabelBox_ID";
            this.LabelBox_ID.Size = new System.Drawing.Size(28, 20);
            this.LabelBox_ID.TabIndex = 1;
            this.LabelBox_ID.Text = "ID";
            // 
            // LabelBox_Nombre
            // 
            this.LabelBox_Nombre.AutoSize = true;
            this.LabelBox_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBox_Nombre.Location = new System.Drawing.Point(33, 126);
            this.LabelBox_Nombre.Name = "LabelBox_Nombre";
            this.LabelBox_Nombre.Size = new System.Drawing.Size(71, 20);
            this.LabelBox_Nombre.TabIndex = 2;
            this.LabelBox_Nombre.Text = "Nombre";
            // 
            // LabelBox_Necesidad
            // 
            this.LabelBox_Necesidad.AutoSize = true;
            this.LabelBox_Necesidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBox_Necesidad.Location = new System.Drawing.Point(320, 46);
            this.LabelBox_Necesidad.Name = "LabelBox_Necesidad";
            this.LabelBox_Necesidad.Size = new System.Drawing.Size(93, 20);
            this.LabelBox_Necesidad.TabIndex = 3;
            this.LabelBox_Necesidad.Text = "Necesidad";
            // 
            // LabelBox_Categoria
            // 
            this.LabelBox_Categoria.AutoSize = true;
            this.LabelBox_Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBox_Categoria.Location = new System.Drawing.Point(320, 207);
            this.LabelBox_Categoria.Name = "LabelBox_Categoria";
            this.LabelBox_Categoria.Size = new System.Drawing.Size(87, 20);
            this.LabelBox_Categoria.TabIndex = 4;
            this.LabelBox_Categoria.Text = "Categoria";
            // 
            // LabelBox_Cantidad
            // 
            this.LabelBox_Cantidad.AutoSize = true;
            this.LabelBox_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBox_Cantidad.Location = new System.Drawing.Point(33, 209);
            this.LabelBox_Cantidad.Name = "LabelBox_Cantidad";
            this.LabelBox_Cantidad.Size = new System.Drawing.Size(81, 20);
            this.LabelBox_Cantidad.TabIndex = 5;
            this.LabelBox_Cantidad.Text = "Cantidad";
            // 
            // LabelBox_Precio
            // 
            this.LabelBox_Precio.AutoSize = true;
            this.LabelBox_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBox_Precio.Location = new System.Drawing.Point(33, 294);
            this.LabelBox_Precio.Name = "LabelBox_Precio";
            this.LabelBox_Precio.Size = new System.Drawing.Size(130, 20);
            this.LabelBox_Precio.TabIndex = 6;
            this.LabelBox_Precio.Text = "Precio (unidad)";
            // 
            // LabelBox_CantMin
            // 
            this.LabelBox_CantMin.AutoSize = true;
            this.LabelBox_CantMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBox_CantMin.Location = new System.Drawing.Point(33, 371);
            this.LabelBox_CantMin.Name = "LabelBox_CantMin";
            this.LabelBox_CantMin.Size = new System.Drawing.Size(252, 20);
            this.LabelBox_CantMin.TabIndex = 7;
            this.LabelBox_CantMin.Text = "Cantidad Min (Alerta de stock)";
            // 
            // TextBox_Nombre
            // 
            this.TextBox_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Nombre.Location = new System.Drawing.Point(37, 149);
            this.TextBox_Nombre.Name = "TextBox_Nombre";
            this.TextBox_Nombre.Size = new System.Drawing.Size(216, 24);
            this.TextBox_Nombre.TabIndex = 8;
            // 
            // ComboTextBox_Necesidad
            // 
            this.ComboTextBox_Necesidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTextBox_Necesidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboTextBox_Necesidad.FormattingEnabled = true;
            this.ComboTextBox_Necesidad.Items.AddRange(new object[] {
            "Primera",
            "Segunda",
            "Tercera"});
            this.ComboTextBox_Necesidad.Location = new System.Drawing.Point(324, 69);
            this.ComboTextBox_Necesidad.Name = "ComboTextBox_Necesidad";
            this.ComboTextBox_Necesidad.Size = new System.Drawing.Size(222, 26);
            this.ComboTextBox_Necesidad.TabIndex = 9;
            // 
            // ComboTextBox_Categoria
            // 
            this.ComboTextBox_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTextBox_Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboTextBox_Categoria.FormattingEnabled = true;
            this.ComboTextBox_Categoria.Items.AddRange(new object[] {
            "Comestibles",
            "Electronicos",
            "Electrodomesticos",
            "Ferreteria",
            "Maquinaría",
            "Vehiculos",
            "Limpieza"});
            this.ComboTextBox_Categoria.Location = new System.Drawing.Point(324, 230);
            this.ComboTextBox_Categoria.Name = "ComboTextBox_Categoria";
            this.ComboTextBox_Categoria.Size = new System.Drawing.Size(222, 26);
            this.ComboTextBox_Categoria.TabIndex = 10;
            // 
            // MaskTextBox_Cantidad
            // 
            this.MaskTextBox_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskTextBox_Cantidad.Location = new System.Drawing.Point(37, 232);
            this.MaskTextBox_Cantidad.Name = "MaskTextBox_Cantidad";
            this.MaskTextBox_Cantidad.Size = new System.Drawing.Size(216, 24);
            this.MaskTextBox_Cantidad.TabIndex = 12;
            // 
            // MaskTextBox_Precio
            // 
            this.MaskTextBox_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskTextBox_Precio.Location = new System.Drawing.Point(37, 317);
            this.MaskTextBox_Precio.Name = "MaskTextBox_Precio";
            this.MaskTextBox_Precio.Size = new System.Drawing.Size(216, 24);
            this.MaskTextBox_Precio.TabIndex = 13;
            // 
            // MaskTextBox_CantidadMinima
            // 
            this.MaskTextBox_CantidadMinima.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskTextBox_CantidadMinima.Location = new System.Drawing.Point(37, 394);
            this.MaskTextBox_CantidadMinima.Name = "MaskTextBox_CantidadMinima";
            this.MaskTextBox_CantidadMinima.Size = new System.Drawing.Size(216, 24);
            this.MaskTextBox_CantidadMinima.TabIndex = 14;
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Agregar.Location = new System.Drawing.Point(450, 386);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(96, 32);
            this.Btn_Agregar.TabIndex = 15;
            this.Btn_Agregar.Text = "Agregar";
            this.Btn_Agregar.UseVisualStyleBackColor = true;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancelar.Location = new System.Drawing.Point(324, 386);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(96, 32);
            this.Btn_Cancelar.TabIndex = 16;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // MaskTextBox_ID
            // 
            this.MaskTextBox_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskTextBox_ID.Location = new System.Drawing.Point(37, 69);
            this.MaskTextBox_ID.Name = "MaskTextBox_ID";
            this.MaskTextBox_ID.Size = new System.Drawing.Size(216, 24);
            this.MaskTextBox_ID.TabIndex = 17;
            // 
            // Form_AgregarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 450);
            this.Controls.Add(this.MaskTextBox_ID);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Agregar);
            this.Controls.Add(this.MaskTextBox_CantidadMinima);
            this.Controls.Add(this.MaskTextBox_Precio);
            this.Controls.Add(this.MaskTextBox_Cantidad);
            this.Controls.Add(this.ComboTextBox_Categoria);
            this.Controls.Add(this.ComboTextBox_Necesidad);
            this.Controls.Add(this.TextBox_Nombre);
            this.Controls.Add(this.LabelBox_CantMin);
            this.Controls.Add(this.LabelBox_Precio);
            this.Controls.Add(this.LabelBox_Cantidad);
            this.Controls.Add(this.LabelBox_Categoria);
            this.Controls.Add(this.LabelBox_Necesidad);
            this.Controls.Add(this.LabelBox_Nombre);
            this.Controls.Add(this.LabelBox_ID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_AgregarProductos";
            this.Text = "Agregar productos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelBox_ID;
        private System.Windows.Forms.Label LabelBox_Nombre;
        private System.Windows.Forms.Label LabelBox_Necesidad;
        private System.Windows.Forms.Label LabelBox_Categoria;
        private System.Windows.Forms.Label LabelBox_Cantidad;
        private System.Windows.Forms.Label LabelBox_Precio;
        private System.Windows.Forms.Label LabelBox_CantMin;
        private System.Windows.Forms.TextBox TextBox_Nombre;
        private System.Windows.Forms.ComboBox ComboTextBox_Necesidad;
        private System.Windows.Forms.ComboBox ComboTextBox_Categoria;
        private System.Windows.Forms.MaskedTextBox MaskTextBox_Cantidad;
        private System.Windows.Forms.MaskedTextBox MaskTextBox_Precio;
        private System.Windows.Forms.MaskedTextBox MaskTextBox_CantidadMinima;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.MaskedTextBox MaskTextBox_ID;
    }
}