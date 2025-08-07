using System.Linq;
using System.Windows.Forms;

namespace ProyectoFinal_GestionAlmacen
{
    partial class Form_EditarProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_EditarProductos));
            this.MaskTextBox_Buscar_ID = new System.Windows.Forms.MaskedTextBox();
            this.Btn_TrearContenido = new System.Windows.Forms.Button();
            this.Label_BusquedaID = new System.Windows.Forms.Label();
            this.Label_Nombre = new System.Windows.Forms.Label();
            this.TextBox_Editar_Nombre = new System.Windows.Forms.TextBox();
            this.Label_Cantidad = new System.Windows.Forms.Label();
            this.MaskTextBox_Editar_Cantidad = new System.Windows.Forms.MaskedTextBox();
            this.MaskTextBox_Editar_Precio = new System.Windows.Forms.MaskedTextBox();
            this.Label_Precio = new System.Windows.Forms.Label();
            this.MaskTextBox_Editar_CantMin = new System.Windows.Forms.MaskedTextBox();
            this.Label_CantMin = new System.Windows.Forms.Label();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.ComboTextBox_Editar_Categoria = new System.Windows.Forms.ComboBox();
            this.ComboTextBox_Editar_Necesidad = new System.Windows.Forms.ComboBox();
            this.Label_Categoria = new System.Windows.Forms.Label();
            this.Label_Necesidad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_Estado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MaskTextBox_Buscar_ID
            // 
            this.MaskTextBox_Buscar_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskTextBox_Buscar_ID.Location = new System.Drawing.Point(12, 51);
            this.MaskTextBox_Buscar_ID.Name = "MaskTextBox_Buscar_ID";
            this.MaskTextBox_Buscar_ID.Size = new System.Drawing.Size(189, 26);
            this.MaskTextBox_Buscar_ID.TabIndex = 0;
            // 
            // Btn_TrearContenido
            // 
            this.Btn_TrearContenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_TrearContenido.Location = new System.Drawing.Point(207, 48);
            this.Btn_TrearContenido.Name = "Btn_TrearContenido";
            this.Btn_TrearContenido.Size = new System.Drawing.Size(127, 34);
            this.Btn_TrearContenido.TabIndex = 1;
            this.Btn_TrearContenido.Text = "Traer cotenido";
            this.Btn_TrearContenido.UseVisualStyleBackColor = true;
            this.Btn_TrearContenido.Click += new System.EventHandler(this.Btn_TrearContenido_Click);
            // 
            // Label_BusquedaID
            // 
            this.Label_BusquedaID.AutoSize = true;
            this.Label_BusquedaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_BusquedaID.Location = new System.Drawing.Point(12, 9);
            this.Label_BusquedaID.Name = "Label_BusquedaID";
            this.Label_BusquedaID.Size = new System.Drawing.Size(322, 24);
            this.Label_BusquedaID.TabIndex = 2;
            this.Label_BusquedaID.Text = "Indique el ID del producto a modificar";
            // 
            // Label_Nombre
            // 
            this.Label_Nombre.AutoSize = true;
            this.Label_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Nombre.Location = new System.Drawing.Point(12, 138);
            this.Label_Nombre.Name = "Label_Nombre";
            this.Label_Nombre.Size = new System.Drawing.Size(71, 20);
            this.Label_Nombre.TabIndex = 3;
            this.Label_Nombre.Text = "Nombre";
            // 
            // TextBox_Editar_Nombre
            // 
            this.TextBox_Editar_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Editar_Nombre.Location = new System.Drawing.Point(16, 161);
            this.TextBox_Editar_Nombre.Name = "TextBox_Editar_Nombre";
            this.TextBox_Editar_Nombre.Size = new System.Drawing.Size(243, 26);
            this.TextBox_Editar_Nombre.TabIndex = 4;
            // 
            // Label_Cantidad
            // 
            this.Label_Cantidad.AutoSize = true;
            this.Label_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Cantidad.Location = new System.Drawing.Point(12, 207);
            this.Label_Cantidad.Name = "Label_Cantidad";
            this.Label_Cantidad.Size = new System.Drawing.Size(81, 20);
            this.Label_Cantidad.TabIndex = 5;
            this.Label_Cantidad.Text = "Cantidad";
            // 
            // MaskTextBox_Editar_Cantidad
            // 
            this.MaskTextBox_Editar_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskTextBox_Editar_Cantidad.Location = new System.Drawing.Point(16, 230);
            this.MaskTextBox_Editar_Cantidad.Name = "MaskTextBox_Editar_Cantidad";
            this.MaskTextBox_Editar_Cantidad.Size = new System.Drawing.Size(243, 26);
            this.MaskTextBox_Editar_Cantidad.TabIndex = 6;
            this.MaskTextBox_Editar_Cantidad.ValidatingType = typeof(int);
            // 
            // MaskTextBox_Editar_Precio
            // 
            this.MaskTextBox_Editar_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskTextBox_Editar_Precio.Location = new System.Drawing.Point(16, 306);
            this.MaskTextBox_Editar_Precio.Name = "MaskTextBox_Editar_Precio";
            this.MaskTextBox_Editar_Precio.Size = new System.Drawing.Size(243, 26);
            this.MaskTextBox_Editar_Precio.TabIndex = 8;
            this.MaskTextBox_Editar_Precio.ValidatingType = typeof(int);
            // 
            // Label_Precio
            // 
            this.Label_Precio.AutoSize = true;
            this.Label_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Precio.Location = new System.Drawing.Point(12, 283);
            this.Label_Precio.Name = "Label_Precio";
            this.Label_Precio.Size = new System.Drawing.Size(130, 20);
            this.Label_Precio.TabIndex = 7;
            this.Label_Precio.Text = "Precio (unidad)";
            // 
            // MaskTextBox_Editar_CantMin
            // 
            this.MaskTextBox_Editar_CantMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskTextBox_Editar_CantMin.Location = new System.Drawing.Point(16, 385);
            this.MaskTextBox_Editar_CantMin.Name = "MaskTextBox_Editar_CantMin";
            this.MaskTextBox_Editar_CantMin.Size = new System.Drawing.Size(243, 26);
            this.MaskTextBox_Editar_CantMin.TabIndex = 10;
            this.MaskTextBox_Editar_CantMin.ValidatingType = typeof(int);
            // 
            // Label_CantMin
            // 
            this.Label_CantMin.AutoSize = true;
            this.Label_CantMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CantMin.Location = new System.Drawing.Point(12, 362);
            this.Label_CantMin.Name = "Label_CantMin";
            this.Label_CantMin.Size = new System.Drawing.Size(252, 20);
            this.Label_CantMin.TabIndex = 9;
            this.Label_CantMin.Text = "Cantidad Min (Alerta de stock)";
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancelar.Location = new System.Drawing.Point(324, 382);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(96, 32);
            this.Btn_Cancelar.TabIndex = 22;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Editar.Location = new System.Drawing.Point(450, 382);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(96, 32);
            this.Btn_Editar.TabIndex = 21;
            this.Btn_Editar.Text = "Editar";
            this.Btn_Editar.UseVisualStyleBackColor = true;
            this.Btn_Editar.Click += new System.EventHandler(this.Btn_Editar_Click);
            // 
            // ComboTextBox_Editar_Categoria
            // 
            this.ComboTextBox_Editar_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTextBox_Editar_Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboTextBox_Editar_Categoria.FormattingEnabled = true;
            this.ComboTextBox_Editar_Categoria.Items.AddRange(new object[] {
            "Comestibles",
            "Electronicos",
            "Electrodomesticos",
            "Ferreteria",
            "Maquinaría",
            "Vehiculos",
            "Limpieza"});
            this.ComboTextBox_Editar_Categoria.Location = new System.Drawing.Point(324, 306);
            this.ComboTextBox_Editar_Categoria.Name = "ComboTextBox_Editar_Categoria";
            this.ComboTextBox_Editar_Categoria.Size = new System.Drawing.Size(222, 26);
            this.ComboTextBox_Editar_Categoria.TabIndex = 20;
            // 
            // ComboTextBox_Editar_Necesidad
            // 
            this.ComboTextBox_Editar_Necesidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTextBox_Editar_Necesidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboTextBox_Editar_Necesidad.FormattingEnabled = true;
            this.ComboTextBox_Editar_Necesidad.Items.AddRange(new object[] {
            "Primera",
            "Segunda",
            "Tercera"});
            this.ComboTextBox_Editar_Necesidad.Location = new System.Drawing.Point(324, 161);
            this.ComboTextBox_Editar_Necesidad.Name = "ComboTextBox_Editar_Necesidad";
            this.ComboTextBox_Editar_Necesidad.Size = new System.Drawing.Size(222, 26);
            this.ComboTextBox_Editar_Necesidad.TabIndex = 19;
            // 
            // Label_Categoria
            // 
            this.Label_Categoria.AutoSize = true;
            this.Label_Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Categoria.Location = new System.Drawing.Point(320, 283);
            this.Label_Categoria.Name = "Label_Categoria";
            this.Label_Categoria.Size = new System.Drawing.Size(87, 20);
            this.Label_Categoria.TabIndex = 18;
            this.Label_Categoria.Text = "Categoria";
            // 
            // Label_Necesidad
            // 
            this.Label_Necesidad.AutoSize = true;
            this.Label_Necesidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Necesidad.Location = new System.Drawing.Point(320, 138);
            this.Label_Necesidad.Name = "Label_Necesidad";
            this.Label_Necesidad.Size = new System.Drawing.Size(93, 20);
            this.Label_Necesidad.TabIndex = 17;
            this.Label_Necesidad.Text = "Necesidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Estado:";
            // 
            // Label_Estado
            // 
            this.Label_Estado.AutoSize = true;
            this.Label_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Estado.Location = new System.Drawing.Point(89, 430);
            this.Label_Estado.Name = "Label_Estado";
            this.Label_Estado.Size = new System.Drawing.Size(21, 20);
            this.Label_Estado.TabIndex = 24;
            this.Label_Estado.Text = "...";
            // 
            // Form_EditarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 468);
            this.Controls.Add(this.Label_Estado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Editar);
            this.Controls.Add(this.ComboTextBox_Editar_Categoria);
            this.Controls.Add(this.ComboTextBox_Editar_Necesidad);
            this.Controls.Add(this.Label_Categoria);
            this.Controls.Add(this.Label_Necesidad);
            this.Controls.Add(this.MaskTextBox_Editar_CantMin);
            this.Controls.Add(this.Label_CantMin);
            this.Controls.Add(this.MaskTextBox_Editar_Precio);
            this.Controls.Add(this.Label_Precio);
            this.Controls.Add(this.MaskTextBox_Editar_Cantidad);
            this.Controls.Add(this.Label_Cantidad);
            this.Controls.Add(this.TextBox_Editar_Nombre);
            this.Controls.Add(this.Label_Nombre);
            this.Controls.Add(this.Label_BusquedaID);
            this.Controls.Add(this.Btn_TrearContenido);
            this.Controls.Add(this.MaskTextBox_Buscar_ID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_EditarProductos";
            this.Text = "Editar productos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox MaskTextBox_Buscar_ID;
        private System.Windows.Forms.Button Btn_TrearContenido;
        private System.Windows.Forms.Label Label_BusquedaID;
        private System.Windows.Forms.Label Label_Nombre;
        private System.Windows.Forms.TextBox TextBox_Editar_Nombre;
        private System.Windows.Forms.Label Label_Cantidad;
        private System.Windows.Forms.MaskedTextBox MaskTextBox_Editar_Cantidad;
        private System.Windows.Forms.MaskedTextBox MaskTextBox_Editar_Precio;
        private System.Windows.Forms.Label Label_Precio;
        private System.Windows.Forms.MaskedTextBox MaskTextBox_Editar_CantMin;
        private System.Windows.Forms.Label Label_CantMin;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.ComboBox ComboTextBox_Editar_Categoria;
        private System.Windows.Forms.ComboBox ComboTextBox_Editar_Necesidad;
        private System.Windows.Forms.Label Label_Categoria;
        private System.Windows.Forms.Label Label_Necesidad;
        private Label label1;
        private Label Label_Estado;
    }
}