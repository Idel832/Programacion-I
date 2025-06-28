namespace _14_TabControl
{
    partial class TabContro14
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
            this.TabControl_Main = new System.Windows.Forms.TabControl();
            this.TabPage_Nom = new System.Windows.Forms.TabPage();
            this.TabPage_Apell = new System.Windows.Forms.TabPage();
            this.TabPage_Matr = new System.Windows.Forms.TabPage();
            this.Label_Nomb = new System.Windows.Forms.Label();
            this.Label_Apell = new System.Windows.Forms.Label();
            this.Label_Matr = new System.Windows.Forms.Label();
            this.TabControl_Main.SuspendLayout();
            this.TabPage_Nom.SuspendLayout();
            this.TabPage_Apell.SuspendLayout();
            this.TabPage_Matr.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl_Main
            // 
            this.TabControl_Main.Controls.Add(this.TabPage_Nom);
            this.TabControl_Main.Controls.Add(this.TabPage_Apell);
            this.TabControl_Main.Controls.Add(this.TabPage_Matr);
            this.TabControl_Main.Location = new System.Drawing.Point(12, 12);
            this.TabControl_Main.Name = "TabControl_Main";
            this.TabControl_Main.SelectedIndex = 0;
            this.TabControl_Main.Size = new System.Drawing.Size(776, 426);
            this.TabControl_Main.TabIndex = 0;
            // 
            // TabPage_Nom
            // 
            this.TabPage_Nom.Controls.Add(this.Label_Nomb);
            this.TabPage_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPage_Nom.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Nom.Name = "TabPage_Nom";
            this.TabPage_Nom.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Nom.Size = new System.Drawing.Size(768, 400);
            this.TabPage_Nom.TabIndex = 0;
            this.TabPage_Nom.Text = "Nombre";
            this.TabPage_Nom.UseVisualStyleBackColor = true;
            // 
            // TabPage_Apell
            // 
            this.TabPage_Apell.Controls.Add(this.Label_Apell);
            this.TabPage_Apell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPage_Apell.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Apell.Name = "TabPage_Apell";
            this.TabPage_Apell.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Apell.Size = new System.Drawing.Size(768, 400);
            this.TabPage_Apell.TabIndex = 1;
            this.TabPage_Apell.Text = "Apellidos";
            this.TabPage_Apell.UseVisualStyleBackColor = true;
            // 
            // TabPage_Matr
            // 
            this.TabPage_Matr.Controls.Add(this.Label_Matr);
            this.TabPage_Matr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPage_Matr.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Matr.Name = "TabPage_Matr";
            this.TabPage_Matr.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Matr.Size = new System.Drawing.Size(768, 400);
            this.TabPage_Matr.TabIndex = 2;
            this.TabPage_Matr.Text = "Matricula";
            this.TabPage_Matr.UseVisualStyleBackColor = true;
            // 
            // Label_Nomb
            // 
            this.Label_Nomb.AutoSize = true;
            this.Label_Nomb.Location = new System.Drawing.Point(34, 38);
            this.Label_Nomb.Name = "Label_Nomb";
            this.Label_Nomb.Size = new System.Drawing.Size(75, 20);
            this.Label_Nomb.TabIndex = 0;
            this.Label_Nomb.Text = "Idelfonso";
            // 
            // Label_Apell
            // 
            this.Label_Apell.AutoSize = true;
            this.Label_Apell.Location = new System.Drawing.Point(26, 32);
            this.Label_Apell.Name = "Label_Apell";
            this.Label_Apell.Size = new System.Drawing.Size(101, 20);
            this.Label_Apell.TabIndex = 0;
            this.Label_Apell.Text = "Peña Castillo";
            // 
            // Label_Matr
            // 
            this.Label_Matr.AutoSize = true;
            this.Label_Matr.Location = new System.Drawing.Point(25, 29);
            this.Label_Matr.Name = "Label_Matr";
            this.Label_Matr.Size = new System.Drawing.Size(122, 20);
            this.Label_Matr.TabIndex = 0;
            this.Label_Matr.Text = "MT-2024-00222";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControl_Main);
            this.Name = "Form_Main";
            this.Text = "Control de pestañas";
            this.TabControl_Main.ResumeLayout(false);
            this.TabPage_Nom.ResumeLayout(false);
            this.TabPage_Nom.PerformLayout();
            this.TabPage_Apell.ResumeLayout(false);
            this.TabPage_Apell.PerformLayout();
            this.TabPage_Matr.ResumeLayout(false);
            this.TabPage_Matr.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl_Main;
        private System.Windows.Forms.TabPage TabPage_Nom;
        private System.Windows.Forms.TabPage TabPage_Apell;
        private System.Windows.Forms.TabPage TabPage_Matr;
        private System.Windows.Forms.Label Label_Nomb;
        private System.Windows.Forms.Label Label_Apell;
        private System.Windows.Forms.Label Label_Matr;
    }
}

