namespace _12_TransformarTemperaturas
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
            this.TxtBox_Celsius = new System.Windows.Forms.TextBox();
            this.Btn_Trans = new System.Windows.Forms.Button();
            this.Label_Result = new System.Windows.Forms.Label();
            this.Label_TitleCel = new System.Windows.Forms.Label();
            this.Label_Deco1 = new System.Windows.Forms.Label();
            this.Label_TitleFahr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtBox_Celsius
            // 
            this.TxtBox_Celsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Celsius.Location = new System.Drawing.Point(41, 81);
            this.TxtBox_Celsius.Name = "TxtBox_Celsius";
            this.TxtBox_Celsius.Size = new System.Drawing.Size(100, 26);
            this.TxtBox_Celsius.TabIndex = 0;
            // 
            // Btn_Trans
            // 
            this.Btn_Trans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Trans.Location = new System.Drawing.Point(127, 135);
            this.Btn_Trans.Name = "Btn_Trans";
            this.Btn_Trans.Size = new System.Drawing.Size(114, 35);
            this.Btn_Trans.TabIndex = 1;
            this.Btn_Trans.Text = "Transformar";
            this.Btn_Trans.UseVisualStyleBackColor = true;
            this.Btn_Trans.Click += new System.EventHandler(this.Btn_Trans_Click);
            // 
            // Label_Result
            // 
            this.Label_Result.AutoSize = true;
            this.Label_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Result.Location = new System.Drawing.Point(232, 81);
            this.Label_Result.Name = "Label_Result";
            this.Label_Result.Size = new System.Drawing.Size(25, 24);
            this.Label_Result.TabIndex = 2;
            this.Label_Result.Text = "...";
            // 
            // Label_TitleCel
            // 
            this.Label_TitleCel.AutoSize = true;
            this.Label_TitleCel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TitleCel.Location = new System.Drawing.Point(37, 40);
            this.Label_TitleCel.Name = "Label_TitleCel";
            this.Label_TitleCel.Size = new System.Drawing.Size(71, 24);
            this.Label_TitleCel.TabIndex = 3;
            this.Label_TitleCel.Text = "Celsius";
            // 
            // Label_Deco1
            // 
            this.Label_Deco1.AutoSize = true;
            this.Label_Deco1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Deco1.Location = new System.Drawing.Point(166, 83);
            this.Label_Deco1.Name = "Label_Deco1";
            this.Label_Deco1.Size = new System.Drawing.Size(45, 24);
            this.Label_Deco1.TabIndex = 4;
            this.Label_Deco1.Text = "---->";
            // 
            // Label_TitleFahr
            // 
            this.Label_TitleFahr.AutoSize = true;
            this.Label_TitleFahr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TitleFahr.Location = new System.Drawing.Point(223, 40);
            this.Label_TitleFahr.Name = "Label_TitleFahr";
            this.Label_TitleFahr.Size = new System.Drawing.Size(101, 24);
            this.Label_TitleFahr.TabIndex = 5;
            this.Label_TitleFahr.Text = "Fahrenheit";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 200);
            this.Controls.Add(this.Label_TitleFahr);
            this.Controls.Add(this.Label_Deco1);
            this.Controls.Add(this.Label_TitleCel);
            this.Controls.Add(this.Label_Result);
            this.Controls.Add(this.Btn_Trans);
            this.Controls.Add(this.TxtBox_Celsius);
            this.Name = "Form_Main";
            this.Text = "Convertir temperaturas de Celsius a Fahrenheit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBox_Celsius;
        private System.Windows.Forms.Button Btn_Trans;
        private System.Windows.Forms.Label Label_Result;
        private System.Windows.Forms.Label Label_TitleCel;
        private System.Windows.Forms.Label Label_Deco1;
        private System.Windows.Forms.Label Label_TitleFahr;
    }
}

