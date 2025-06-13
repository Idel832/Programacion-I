namespace _4_SumarUsandoTxtBox
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
            this.Btn_Sumar = new System.Windows.Forms.Button();
            this.TxtBox_FirstN = new System.Windows.Forms.TextBox();
            this.Txt_SecondN = new System.Windows.Forms.TextBox();
            this.Label_Title = new System.Windows.Forms.Label();
            this.Label_PlusSymbol = new System.Windows.Forms.Label();
            this.Label_ResultSymbol = new System.Windows.Forms.Label();
            this.Label_OperationResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Sumar
            // 
            this.Btn_Sumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Sumar.Location = new System.Drawing.Point(129, 124);
            this.Btn_Sumar.Name = "Btn_Sumar";
            this.Btn_Sumar.Size = new System.Drawing.Size(102, 34);
            this.Btn_Sumar.TabIndex = 0;
            this.Btn_Sumar.Text = "Sumar";
            this.Btn_Sumar.UseVisualStyleBackColor = true;
            this.Btn_Sumar.Click += new System.EventHandler(this.Btn_Sumar_Click);
            // 
            // TxtBox_FirstN
            // 
            this.TxtBox_FirstN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_FirstN.Location = new System.Drawing.Point(63, 70);
            this.TxtBox_FirstN.Name = "TxtBox_FirstN";
            this.TxtBox_FirstN.Size = new System.Drawing.Size(100, 26);
            this.TxtBox_FirstN.TabIndex = 1;
            // 
            // Txt_SecondN
            // 
            this.Txt_SecondN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_SecondN.Location = new System.Drawing.Point(199, 70);
            this.Txt_SecondN.Name = "Txt_SecondN";
            this.Txt_SecondN.Size = new System.Drawing.Size(100, 26);
            this.Txt_SecondN.TabIndex = 2;
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Title.Location = new System.Drawing.Point(59, 30);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(240, 24);
            this.Label_Title.TabIndex = 3;
            this.Label_Title.Text = "Ingrese 2 numeros a sumar";
            // 
            // Label_PlusSymbol
            // 
            this.Label_PlusSymbol.AutoSize = true;
            this.Label_PlusSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_PlusSymbol.Location = new System.Drawing.Point(169, 73);
            this.Label_PlusSymbol.Name = "Label_PlusSymbol";
            this.Label_PlusSymbol.Size = new System.Drawing.Size(21, 24);
            this.Label_PlusSymbol.TabIndex = 4;
            this.Label_PlusSymbol.Text = "+";
            // 
            // Label_ResultSymbol
            // 
            this.Label_ResultSymbol.AutoSize = true;
            this.Label_ResultSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ResultSymbol.Location = new System.Drawing.Point(305, 73);
            this.Label_ResultSymbol.Name = "Label_ResultSymbol";
            this.Label_ResultSymbol.Size = new System.Drawing.Size(21, 24);
            this.Label_ResultSymbol.TabIndex = 5;
            this.Label_ResultSymbol.Text = "=";
            // 
            // Label_OperationResult
            // 
            this.Label_OperationResult.AutoSize = true;
            this.Label_OperationResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_OperationResult.Location = new System.Drawing.Point(332, 71);
            this.Label_OperationResult.Name = "Label_OperationResult";
            this.Label_OperationResult.Size = new System.Drawing.Size(24, 25);
            this.Label_OperationResult.TabIndex = 6;
            this.Label_OperationResult.Text = "0";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Label_OperationResult);
            this.Controls.Add(this.Label_ResultSymbol);
            this.Controls.Add(this.Label_PlusSymbol);
            this.Controls.Add(this.Label_Title);
            this.Controls.Add(this.Txt_SecondN);
            this.Controls.Add(this.TxtBox_FirstN);
            this.Controls.Add(this.Btn_Sumar);
            this.Name = "Form_Main";
            this.Text = "Suma utilizando TexBoxes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Sumar;
        private System.Windows.Forms.TextBox TxtBox_FirstN;
        private System.Windows.Forms.TextBox Txt_SecondN;
        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.Label Label_PlusSymbol;
        private System.Windows.Forms.Label Label_ResultSymbol;
        private System.Windows.Forms.Label Label_OperationResult;
    }
}

