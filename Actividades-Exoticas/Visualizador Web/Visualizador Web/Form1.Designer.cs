namespace Visualizador_Web
{
    partial class Intf_Principal
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
            this.Titulo_Principal = new System.Windows.Forms.Label();
            this.TxtBox_URL = new System.Windows.Forms.TextBox();
            this.Web_Browser = new System.Windows.Forms.WebBrowser();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Titulo_Principal
            // 
            this.Titulo_Principal.AutoSize = true;
            this.Titulo_Principal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_Principal.Location = new System.Drawing.Point(12, 9);
            this.Titulo_Principal.Name = "Titulo_Principal";
            this.Titulo_Principal.Size = new System.Drawing.Size(116, 20);
            this.Titulo_Principal.TabIndex = 0;
            this.Titulo_Principal.Text = "Ingrese la URL";
            this.Titulo_Principal.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtBox_URL
            // 
            this.TxtBox_URL.Location = new System.Drawing.Point(12, 32);
            this.TxtBox_URL.Name = "TxtBox_URL";
            this.TxtBox_URL.Size = new System.Drawing.Size(670, 20);
            this.TxtBox_URL.TabIndex = 1;
            this.TxtBox_URL.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Web_Browser
            // 
            this.Web_Browser.Location = new System.Drawing.Point(12, 74);
            this.Web_Browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.Web_Browser.Name = "Web_Browser";
            this.Web_Browser.Size = new System.Drawing.Size(776, 346);
            this.Web_Browser.TabIndex = 2;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(700, 32);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Buscar.TabIndex = 3;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Intf_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Web_Browser);
            this.Controls.Add(this.TxtBox_URL);
            this.Controls.Add(this.Titulo_Principal);
            this.Name = "Intf_Principal";
            this.Text = "Visualizador Web";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo_Principal;
        private System.Windows.Forms.TextBox TxtBox_URL;
        private System.Windows.Forms.WebBrowser Web_Browser;
        private System.Windows.Forms.Button Btn_Buscar;
    }
}

