namespace _13_ProgressBar
{
    partial class ProgressBar13
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
            this.components = new System.ComponentModel.Container();
            this.PgrssBar_1 = new System.Windows.Forms.ProgressBar();
            this.Btn_Stop = new System.Windows.Forms.Button();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.PgressBar_Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // PgrssBar_1
            // 
            this.PgrssBar_1.Location = new System.Drawing.Point(120, 60);
            this.PgrssBar_1.Name = "PgrssBar_1";
            this.PgrssBar_1.Size = new System.Drawing.Size(360, 61);
            this.PgrssBar_1.TabIndex = 0;
            // 
            // Btn_Stop
            // 
            this.Btn_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Stop.Location = new System.Drawing.Point(361, 179);
            this.Btn_Stop.Name = "Btn_Stop";
            this.Btn_Stop.Size = new System.Drawing.Size(119, 57);
            this.Btn_Stop.TabIndex = 1;
            this.Btn_Stop.Text = "Detener";
            this.Btn_Stop.UseVisualStyleBackColor = true;
            this.Btn_Stop.Click += new System.EventHandler(this.Btn_Stop_Click);
            // 
            // Btn_Start
            // 
            this.Btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Start.Location = new System.Drawing.Point(120, 179);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(119, 57);
            this.Btn_Start.TabIndex = 2;
            this.Btn_Start.Text = "Iniciar";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // PgressBar_Timer
            // 
            this.PgressBar_Timer.Tick += new System.EventHandler(this.PgressBar_Timer_Tick);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 340);
            this.Controls.Add(this.Btn_Start);
            this.Controls.Add(this.Btn_Stop);
            this.Controls.Add(this.PgrssBar_1);
            this.Name = "Form_Main";
            this.Text = "Barra de progreso";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar PgrssBar_1;
        private System.Windows.Forms.Button Btn_Stop;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.Timer PgressBar_Timer;
    }
}

