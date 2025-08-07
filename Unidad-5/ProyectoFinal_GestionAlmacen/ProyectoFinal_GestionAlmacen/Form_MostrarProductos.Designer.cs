namespace ProyectoFinal_GestionAlmacen
{
    partial class Form_MostrarProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MostrarProductos));
            this.DataGrid_Productos = new System.Windows.Forms.DataGridView();
            this.Product_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Need = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_ITBIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_PTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_MinStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Productos)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid_Productos
            // 
            this.DataGrid_Productos.AllowUserToAddRows = false;
            this.DataGrid_Productos.AllowUserToDeleteRows = false;
            this.DataGrid_Productos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid_Productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid_Productos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGrid_Productos.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_Productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_ID,
            this.Product_Name,
            this.Product_Category,
            this.Product_Need,
            this.Product_Stock,
            this.Product_Price,
            this.Product_ITBIS,
            this.Product_PTotal,
            this.Product_MinStock,
            this.Product_Status});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid_Productos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid_Productos.Location = new System.Drawing.Point(27, 117);
            this.DataGrid_Productos.Name = "DataGrid_Productos";
            this.DataGrid_Productos.Size = new System.Drawing.Size(1179, 311);
            this.DataGrid_Productos.TabIndex = 0;
            // 
            // Product_ID
            // 
            this.Product_ID.HeaderText = "ID";
            this.Product_ID.MinimumWidth = 100;
            this.Product_ID.Name = "Product_ID";
            // 
            // Product_Name
            // 
            this.Product_Name.HeaderText = "Nombre";
            this.Product_Name.MinimumWidth = 100;
            this.Product_Name.Name = "Product_Name";
            // 
            // Product_Category
            // 
            this.Product_Category.HeaderText = "Categoría";
            this.Product_Category.MinimumWidth = 100;
            this.Product_Category.Name = "Product_Category";
            // 
            // Product_Need
            // 
            this.Product_Need.HeaderText = "Necesidad";
            this.Product_Need.MinimumWidth = 100;
            this.Product_Need.Name = "Product_Need";
            // 
            // Product_Stock
            // 
            this.Product_Stock.HeaderText = "Cantidad";
            this.Product_Stock.MinimumWidth = 100;
            this.Product_Stock.Name = "Product_Stock";
            // 
            // Product_Price
            // 
            this.Product_Price.HeaderText = "Precio (unidad)";
            this.Product_Price.MinimumWidth = 100;
            this.Product_Price.Name = "Product_Price";
            // 
            // Product_ITBIS
            // 
            this.Product_ITBIS.HeaderText = "+ ITBIS (18%)";
            this.Product_ITBIS.MinimumWidth = 100;
            this.Product_ITBIS.Name = "Product_ITBIS";
            // 
            // Product_PTotal
            // 
            this.Product_PTotal.HeaderText = "Precio + ITBIS";
            this.Product_PTotal.MinimumWidth = 100;
            this.Product_PTotal.Name = "Product_PTotal";
            // 
            // Product_MinStock
            // 
            this.Product_MinStock.HeaderText = "Cantidad mínima";
            this.Product_MinStock.MinimumWidth = 100;
            this.Product_MinStock.Name = "Product_MinStock";
            // 
            // Product_Status
            // 
            this.Product_Status.HeaderText = "Estado";
            this.Product_Status.MinimumWidth = 100;
            this.Product_Status.Name = "Product_Status";
            // 
            // Form_MostrarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(1233, 520);
            this.Controls.Add(this.DataGrid_Productos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_MostrarProductos";
            this.Text = "Tabla de productos";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Productos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView DataGrid_Productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Need;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_ITBIS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_PTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_MinStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Status;
    }
}