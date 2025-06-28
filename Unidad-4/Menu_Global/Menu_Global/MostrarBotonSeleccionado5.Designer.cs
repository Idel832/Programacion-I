namespace _5_MostrarBotonSeleccionado
{
    partial class MostrarBotonSeleccionado5
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
            this.Btn_ShowSelec = new System.Windows.Forms.Button();
            this.RadBtn_A = new System.Windows.Forms.RadioButton();
            this.Label_Title = new System.Windows.Forms.Label();
            this.Label_Pre = new System.Windows.Forms.Label();
            this.RadBtn_B = new System.Windows.Forms.RadioButton();
            this.RadBtn_C = new System.Windows.Forms.RadioButton();
            this.Label_Showletter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_ShowSelec
            // 
            this.Btn_ShowSelec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ShowSelec.Location = new System.Drawing.Point(209, 113);
            this.Btn_ShowSelec.Name = "Btn_ShowSelec";
            this.Btn_ShowSelec.Size = new System.Drawing.Size(115, 53);
            this.Btn_ShowSelec.TabIndex = 0;
            this.Btn_ShowSelec.Text = "Presioname";
            this.Btn_ShowSelec.UseVisualStyleBackColor = true;
            this.Btn_ShowSelec.Click += new System.EventHandler(this.Btn_ShowSelec_Click);
            // 
            // RadBtn_A
            // 
            this.RadBtn_A.AutoSize = true;
            this.RadBtn_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadBtn_A.Location = new System.Drawing.Point(68, 89);
            this.RadBtn_A.Name = "RadBtn_A";
            this.RadBtn_A.Size = new System.Drawing.Size(108, 28);
            this.RadBtn_A.TabIndex = 1;
            this.RadBtn_A.TabStop = true;
            this.RadBtn_A.Text = "Opción A";
            this.RadBtn_A.UseVisualStyleBackColor = true;
            this.RadBtn_A.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Title.Location = new System.Drawing.Point(65, 55);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(522, 24);
            this.Label_Title.TabIndex = 4;
            this.Label_Title.Text = "Selecciona alguna de las opciones y luego presiona el botón";
            // 
            // Label_Pre
            // 
            this.Label_Pre.AutoSize = true;
            this.Label_Pre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Pre.Location = new System.Drawing.Point(356, 130);
            this.Label_Pre.Name = "Label_Pre";
            this.Label_Pre.Size = new System.Drawing.Size(127, 18);
            this.Label_Pre.TabIndex = 5;
            this.Label_Pre.Text = "Ha seleccionado: ";
            // 
            // RadBtn_B
            // 
            this.RadBtn_B.AutoSize = true;
            this.RadBtn_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadBtn_B.Location = new System.Drawing.Point(68, 123);
            this.RadBtn_B.Name = "RadBtn_B";
            this.RadBtn_B.Size = new System.Drawing.Size(107, 28);
            this.RadBtn_B.TabIndex = 6;
            this.RadBtn_B.TabStop = true;
            this.RadBtn_B.Text = "Opción B";
            this.RadBtn_B.UseVisualStyleBackColor = true;
            // 
            // RadBtn_C
            // 
            this.RadBtn_C.AutoSize = true;
            this.RadBtn_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadBtn_C.Location = new System.Drawing.Point(68, 157);
            this.RadBtn_C.Name = "RadBtn_C";
            this.RadBtn_C.Size = new System.Drawing.Size(108, 28);
            this.RadBtn_C.TabIndex = 7;
            this.RadBtn_C.TabStop = true;
            this.RadBtn_C.Text = "Opción C";
            this.RadBtn_C.UseVisualStyleBackColor = true;
            // 
            // Label_Showletter
            // 
            this.Label_Showletter.AutoSize = true;
            this.Label_Showletter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Showletter.Location = new System.Drawing.Point(489, 127);
            this.Label_Showletter.Name = "Label_Showletter";
            this.Label_Showletter.Size = new System.Drawing.Size(25, 24);
            this.Label_Showletter.TabIndex = 8;
            this.Label_Showletter.Text = "...";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Label_Showletter);
            this.Controls.Add(this.RadBtn_C);
            this.Controls.Add(this.RadBtn_B);
            this.Controls.Add(this.Label_Pre);
            this.Controls.Add(this.Label_Title);
            this.Controls.Add(this.RadBtn_A);
            this.Controls.Add(this.Btn_ShowSelec);
            this.Name = "Form_Main";
            this.Text = "Formulario que muestre la opción seleccionada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_ShowSelec;
        private System.Windows.Forms.RadioButton RadBtn_A;
        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.Label Label_Pre;
        private System.Windows.Forms.RadioButton RadBtn_B;
        private System.Windows.Forms.RadioButton RadBtn_C;
        private System.Windows.Forms.Label Label_Showletter;
    }
}

