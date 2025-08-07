using System.Windows.Forms;

namespace ProyectoFinal_GestionAlmacen
{
    partial class Form_EliminarProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_EliminarProductos));
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Borrar = new System.Windows.Forms.Button();
            this.ComboTextBox_Borrar_Categoria = new System.Windows.Forms.ComboBox();
            this.ComboTextBox_Borrar_Necesidad = new System.Windows.Forms.ComboBox();
            this.Label_Categoria = new System.Windows.Forms.Label();
            this.Label_Necesidad = new System.Windows.Forms.Label();
            this.MaskTextBox_Borrar_CantMin = new System.Windows.Forms.MaskedTextBox();
            this.Label_CantMin = new System.Windows.Forms.Label();
            this.MaskTextBox_Borrar_Precio = new System.Windows.Forms.MaskedTextBox();
            this.Label_Precio = new System.Windows.Forms.Label();
            this.MaskTextBox_Borrar_Cantidad = new System.Windows.Forms.MaskedTextBox();
            this.Label_Cantidad = new System.Windows.Forms.Label();
            this.TextBox_Borrar_Nombre = new System.Windows.Forms.TextBox();
            this.Label_Nombre = new System.Windows.Forms.Label();
            this.Label_BusquedaID = new System.Windows.Forms.Label();
            this.Btn_TrearContenido = new System.Windows.Forms.Button();
            this.MaskTextBox_Buscar_ID = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancelar.Location = new System.Drawing.Point(335, 399);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(96, 32);
            this.Btn_Cancelar.TabIndex = 39;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Borrar
            // 
            this.Btn_Borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Borrar.Location = new System.Drawing.Point(461, 399);
            this.Btn_Borrar.Name = "Btn_Borrar";
            this.Btn_Borrar.Size = new System.Drawing.Size(96, 32);
            this.Btn_Borrar.TabIndex = 38;
            this.Btn_Borrar.Text = "Borrar";
            this.Btn_Borrar.UseVisualStyleBackColor = true;
            this.Btn_Borrar.Click += new System.EventHandler(this.Btn_Borrar_Click);
            // 
            // ComboTextBox_Borrar_Categoria
            // 
            this.ComboTextBox_Borrar_Categoria.Enabled = false;
            this.ComboTextBox_Borrar_Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboTextBox_Borrar_Categoria.FormattingEnabled = true;
            this.ComboTextBox_Borrar_Categoria.Items.AddRange(new object[] {
            "Comestibles",
            "Electronicos",
            "Electrodomesticos",
            "Ferreteria",
            "Maquinaría",
            "Vehiculos",
            "Limpieza"});
            this.ComboTextBox_Borrar_Categoria.Location = new System.Drawing.Point(335, 323);
            this.ComboTextBox_Borrar_Categoria.Name = "ComboTextBox_Borrar_Categoria";
            this.ComboTextBox_Borrar_Categoria.Size = new System.Drawing.Size(222, 26);
            this.ComboTextBox_Borrar_Categoria.TabIndex = 37;
            // 
            // ComboTextBox_Borrar_Necesidad
            // 
            this.ComboTextBox_Borrar_Necesidad.Enabled = false;
            this.ComboTextBox_Borrar_Necesidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboTextBox_Borrar_Necesidad.FormattingEnabled = true;
            this.ComboTextBox_Borrar_Necesidad.Items.AddRange(new object[] {
            "Primera",
            "Segunda",
            "Tercera"});
            this.ComboTextBox_Borrar_Necesidad.Location = new System.Drawing.Point(335, 178);
            this.ComboTextBox_Borrar_Necesidad.Name = "ComboTextBox_Borrar_Necesidad";
            this.ComboTextBox_Borrar_Necesidad.Size = new System.Drawing.Size(222, 26);
            this.ComboTextBox_Borrar_Necesidad.TabIndex = 36;
            // 
            // Label_Categoria
            // 
            this.Label_Categoria.AutoSize = true;
            this.Label_Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Categoria.Location = new System.Drawing.Point(331, 300);
            this.Label_Categoria.Name = "Label_Categoria";
            this.Label_Categoria.Size = new System.Drawing.Size(87, 20);
            this.Label_Categoria.TabIndex = 35;
            this.Label_Categoria.Text = "Categoria";
            // 
            // Label_Necesidad
            // 
            this.Label_Necesidad.AutoSize = true;
            this.Label_Necesidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Necesidad.Location = new System.Drawing.Point(331, 155);
            this.Label_Necesidad.Name = "Label_Necesidad";
            this.Label_Necesidad.Size = new System.Drawing.Size(93, 20);
            this.Label_Necesidad.TabIndex = 34;
            this.Label_Necesidad.Text = "Necesidad";
            // 
            // MaskTextBox_Borrar_CantMin
            // 
            this.MaskTextBox_Borrar_CantMin.Enabled = false;
            this.MaskTextBox_Borrar_CantMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskTextBox_Borrar_CantMin.Location = new System.Drawing.Point(27, 402);
            this.MaskTextBox_Borrar_CantMin.Name = "MaskTextBox_Borrar_CantMin";
            this.MaskTextBox_Borrar_CantMin.Size = new System.Drawing.Size(243, 26);
            this.MaskTextBox_Borrar_CantMin.TabIndex = 33;
            this.MaskTextBox_Borrar_CantMin.ValidatingType = typeof(int);
            // 
            // Label_CantMin
            // 
            this.Label_CantMin.AutoSize = true;
            this.Label_CantMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CantMin.Location = new System.Drawing.Point(23, 379);
            this.Label_CantMin.Name = "Label_CantMin";
            this.Label_CantMin.Size = new System.Drawing.Size(252, 20);
            this.Label_CantMin.TabIndex = 32;
            this.Label_CantMin.Text = "Cantidad Min (Alerta de stock)";
            // 
            // MaskTextBox_Borrar_Precio
            // 
            this.MaskTextBox_Borrar_Precio.Enabled = false;
            this.MaskTextBox_Borrar_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskTextBox_Borrar_Precio.Location = new System.Drawing.Point(27, 323);
            this.MaskTextBox_Borrar_Precio.Name = "MaskTextBox_Borrar_Precio";
            this.MaskTextBox_Borrar_Precio.Size = new System.Drawing.Size(243, 26);
            this.MaskTextBox_Borrar_Precio.TabIndex = 31;
            this.MaskTextBox_Borrar_Precio.ValidatingType = typeof(int);
            // 
            // Label_Precio
            // 
            this.Label_Precio.AutoSize = true;
            this.Label_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Precio.Location = new System.Drawing.Point(23, 300);
            this.Label_Precio.Name = "Label_Precio";
            this.Label_Precio.Size = new System.Drawing.Size(130, 20);
            this.Label_Precio.TabIndex = 30;
            this.Label_Precio.Text = "Precio (unidad)";
            // 
            // MaskTextBox_Borrar_Cantidad
            // 
            this.MaskTextBox_Borrar_Cantidad.Enabled = false;
            this.MaskTextBox_Borrar_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskTextBox_Borrar_Cantidad.Location = new System.Drawing.Point(27, 247);
            this.MaskTextBox_Borrar_Cantidad.Name = "MaskTextBox_Borrar_Cantidad";
            this.MaskTextBox_Borrar_Cantidad.Size = new System.Drawing.Size(243, 26);
            this.MaskTextBox_Borrar_Cantidad.TabIndex = 29;
            // 
            // Label_Cantidad
            // 
            this.Label_Cantidad.AutoSize = true;
            this.Label_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Cantidad.Location = new System.Drawing.Point(23, 224);
            this.Label_Cantidad.Name = "Label_Cantidad";
            this.Label_Cantidad.Size = new System.Drawing.Size(81, 20);
            this.Label_Cantidad.TabIndex = 28;
            this.Label_Cantidad.Text = "Cantidad";
            // 
            // TextBox_Borrar_Nombre
            // 
            this.TextBox_Borrar_Nombre.Enabled = false;
            this.TextBox_Borrar_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Borrar_Nombre.Location = new System.Drawing.Point(27, 178);
            this.TextBox_Borrar_Nombre.Name = "TextBox_Borrar_Nombre";
            this.TextBox_Borrar_Nombre.Size = new System.Drawing.Size(243, 26);
            this.TextBox_Borrar_Nombre.TabIndex = 27;
            // 
            // Label_Nombre
            // 
            this.Label_Nombre.AutoSize = true;
            this.Label_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Nombre.Location = new System.Drawing.Point(23, 155);
            this.Label_Nombre.Name = "Label_Nombre";
            this.Label_Nombre.Size = new System.Drawing.Size(71, 20);
            this.Label_Nombre.TabIndex = 26;
            this.Label_Nombre.Text = "Nombre";
            // 
            // Label_BusquedaID
            // 
            this.Label_BusquedaID.AutoSize = true;
            this.Label_BusquedaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_BusquedaID.Location = new System.Drawing.Point(23, 26);
            this.Label_BusquedaID.Name = "Label_BusquedaID";
            this.Label_BusquedaID.Size = new System.Drawing.Size(296, 24);
            this.Label_BusquedaID.TabIndex = 25;
            this.Label_BusquedaID.Text = "Indique el ID del producto a borrar";
            // 
            // Btn_TrearContenido
            // 
            this.Btn_TrearContenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_TrearContenido.Location = new System.Drawing.Point(218, 65);
            this.Btn_TrearContenido.Name = "Btn_TrearContenido";
            this.Btn_TrearContenido.Size = new System.Drawing.Size(127, 34);
            this.Btn_TrearContenido.TabIndex = 24;
            this.Btn_TrearContenido.Text = "Traer cotenido";
            this.Btn_TrearContenido.UseVisualStyleBackColor = true;
            this.Btn_TrearContenido.Click += new System.EventHandler(this.Btn_TrearContenido_Click);
            // 
            // MaskTextBox_Buscar_ID
            // 
            this.MaskTextBox_Buscar_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskTextBox_Buscar_ID.Location = new System.Drawing.Point(23, 68);
            this.MaskTextBox_Buscar_ID.Name = "MaskTextBox_Buscar_ID";
            this.MaskTextBox_Buscar_ID.Size = new System.Drawing.Size(189, 26);
            this.MaskTextBox_Buscar_ID.TabIndex = 23;
            // 
            // Form_EliminarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 478);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Borrar);
            this.Controls.Add(this.ComboTextBox_Borrar_Categoria);
            this.Controls.Add(this.ComboTextBox_Borrar_Necesidad);
            this.Controls.Add(this.Label_Categoria);
            this.Controls.Add(this.Label_Necesidad);
            this.Controls.Add(this.MaskTextBox_Borrar_CantMin);
            this.Controls.Add(this.Label_CantMin);
            this.Controls.Add(this.MaskTextBox_Borrar_Precio);
            this.Controls.Add(this.Label_Precio);
            this.Controls.Add(this.MaskTextBox_Borrar_Cantidad);
            this.Controls.Add(this.Label_Cantidad);
            this.Controls.Add(this.TextBox_Borrar_Nombre);
            this.Controls.Add(this.Label_Nombre);
            this.Controls.Add(this.Label_BusquedaID);
            this.Controls.Add(this.Btn_TrearContenido);
            this.Controls.Add(this.MaskTextBox_Buscar_ID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_EliminarProductos";
            this.Text = "Eliminar productos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Borrar;
        private System.Windows.Forms.ComboBox ComboTextBox_Borrar_Categoria;
        private System.Windows.Forms.ComboBox ComboTextBox_Borrar_Necesidad;
        private System.Windows.Forms.Label Label_Categoria;
        private System.Windows.Forms.Label Label_Necesidad;
        private System.Windows.Forms.MaskedTextBox MaskTextBox_Borrar_CantMin;
        private System.Windows.Forms.Label Label_CantMin;
        private System.Windows.Forms.MaskedTextBox MaskTextBox_Borrar_Precio;
        private System.Windows.Forms.Label Label_Precio;
        private System.Windows.Forms.MaskedTextBox MaskTextBox_Borrar_Cantidad;
        private System.Windows.Forms.Label Label_Cantidad;
        private System.Windows.Forms.TextBox TextBox_Borrar_Nombre;
        private System.Windows.Forms.Label Label_Nombre;
        private System.Windows.Forms.Label Label_BusquedaID;
        private System.Windows.Forms.Button Btn_TrearContenido;
        private System.Windows.Forms.MaskedTextBox MaskTextBox_Buscar_ID;
    }
}