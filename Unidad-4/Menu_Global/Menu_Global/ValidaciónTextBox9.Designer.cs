namespace _9_ValidaciónTextBox
{
    partial class ValidaciónTextBox9
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
            this.TxtBox_Validate = new System.Windows.Forms.TextBox();
            this.Btn_Validate = new System.Windows.Forms.Button();
            this.Label_Title = new System.Windows.Forms.Label();
            this.Label_Test = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtBox_Validate
            // 
            this.TxtBox_Validate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Validate.Location = new System.Drawing.Point(26, 92);
            this.TxtBox_Validate.Name = "TxtBox_Validate";
            this.TxtBox_Validate.Size = new System.Drawing.Size(324, 26);
            this.TxtBox_Validate.TabIndex = 0;
            // 
            // Btn_Validate
            // 
            this.Btn_Validate.Location = new System.Drawing.Point(386, 85);
            this.Btn_Validate.Name = "Btn_Validate";
            this.Btn_Validate.Size = new System.Drawing.Size(125, 43);
            this.Btn_Validate.TabIndex = 1;
            this.Btn_Validate.Text = "Validar";
            this.Btn_Validate.UseVisualStyleBackColor = true;
            this.Btn_Validate.Click += new System.EventHandler(this.Btn_Validate_Click);
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Title.Location = new System.Drawing.Point(22, 58);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(207, 20);
            this.Label_Title.TabIndex = 2;
            this.Label_Title.Text = "Ingrese lo que desea validar";
            // 
            // Label_Test
            // 
            this.Label_Test.AutoSize = true;
            this.Label_Test.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Test.Location = new System.Drawing.Point(22, 162);
            this.Label_Test.Name = "Label_Test";
            this.Label_Test.Size = new System.Drawing.Size(21, 20);
            this.Label_Test.TabIndex = 3;
            this.Label_Test.Text = "...";
            this.Label_Test.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 281);
            this.Controls.Add(this.Label_Test);
            this.Controls.Add(this.Label_Title);
            this.Controls.Add(this.Btn_Validate);
            this.Controls.Add(this.TxtBox_Validate);
            this.Name = "Form_Main";
            this.Text = "Validar si la entrada es un numero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBox_Validate;
        private System.Windows.Forms.Button Btn_Validate;
        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.Label Label_Test;
    }
}

