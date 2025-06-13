namespace _7_AgregarElementosListBox
{
    partial class Form_Main
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
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Label_Title = new System.Windows.Forms.Label();
            this.ListBox_Recibir = new System.Windows.Forms.ListBox();
            this.TxtBox_Send = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(530, 54);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(97, 35);
            this.Btn_Add.TabIndex = 0;
            this.Btn_Add.Text = "Agregar";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Title.Location = new System.Drawing.Point(26, 58);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(348, 24);
            this.Label_Title.TabIndex = 1;
            this.Label_Title.Text = "Escriba y registre el contenido en la caja";
            // 
            // ListBox_Recibir
            // 
            this.ListBox_Recibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBox_Recibir.FormattingEnabled = true;
            this.ListBox_Recibir.ItemHeight = 18;
            this.ListBox_Recibir.Location = new System.Drawing.Point(30, 148);
            this.ListBox_Recibir.Name = "ListBox_Recibir";
            this.ListBox_Recibir.Size = new System.Drawing.Size(597, 202);
            this.ListBox_Recibir.TabIndex = 2;
            // 
            // TxtBox_Send
            // 
            this.TxtBox_Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Send.Location = new System.Drawing.Point(30, 95);
            this.TxtBox_Send.Name = "TxtBox_Send";
            this.TxtBox_Send.Size = new System.Drawing.Size(597, 26);
            this.TxtBox_Send.TabIndex = 3;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 418);
            this.Controls.Add(this.TxtBox_Send);
            this.Controls.Add(this.ListBox_Recibir);
            this.Controls.Add(this.Label_Title);
            this.Controls.Add(this.Btn_Add);
            this.Name = "Form_Main";
            this.Text = "Agregar elementos ingresados en la TxtBox a la ListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.ListBox ListBox_Recibir;
        private System.Windows.Forms.TextBox TxtBox_Send;
    }
}

