namespace ProgramasWebFormsU
{
    partial class _6_NumeroCD
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
            this.CapDisco = new System.Windows.Forms.Label();
            this.CapaDisco = new System.Windows.Forms.TextBox();
            this.NumCD = new System.Windows.Forms.Label();
            this.ResultadoNumCD = new System.Windows.Forms.TextBox();
            this.Resultado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CapDisco
            // 
            this.CapDisco.AutoSize = true;
            this.CapDisco.Location = new System.Drawing.Point(138, 136);
            this.CapDisco.Name = "CapDisco";
            this.CapDisco.Size = new System.Drawing.Size(151, 13);
            this.CapDisco.TabIndex = 0;
            this.CapDisco.Text = "Ingrese la capacidad del disco";
            // 
            // CapaDisco
            // 
            this.CapaDisco.Location = new System.Drawing.Point(307, 133);
            this.CapaDisco.Name = "CapaDisco";
            this.CapaDisco.Size = new System.Drawing.Size(123, 20);
            this.CapaDisco.TabIndex = 1;
            this.CapaDisco.TextChanged += new System.EventHandler(this.CapaDisco_TextChanged);
            // 
            // NumCD
            // 
            this.NumCD.AutoSize = true;
            this.NumCD.Location = new System.Drawing.Point(138, 199);
            this.NumCD.Name = "NumCD";
            this.NumCD.Size = new System.Drawing.Size(182, 13);
            this.NumCD.TabIndex = 2;
            this.NumCD.Text = "El número de CD´s que necesita son:";
            // 
            // ResultadoNumCD
            // 
            this.ResultadoNumCD.Location = new System.Drawing.Point(326, 196);
            this.ResultadoNumCD.Name = "ResultadoNumCD";
            this.ResultadoNumCD.Size = new System.Drawing.Size(100, 20);
            this.ResultadoNumCD.TabIndex = 3;
            // 
            // Resultado
            // 
            this.Resultado.Location = new System.Drawing.Point(491, 174);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(75, 23);
            this.Resultado.TabIndex = 4;
            this.Resultado.Text = "Resultado";
            this.Resultado.UseVisualStyleBackColor = true;
            this.Resultado.Click += new System.EventHandler(this.Resultado_Click);
            // 
            // _6_NumeroCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.ResultadoNumCD);
            this.Controls.Add(this.NumCD);
            this.Controls.Add(this.CapaDisco);
            this.Controls.Add(this.CapDisco);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "_6_NumeroCD";
            this.Text = "Número CD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CapDisco;
        private System.Windows.Forms.TextBox CapaDisco;
        private System.Windows.Forms.Label NumCD;
        private System.Windows.Forms.TextBox ResultadoNumCD;
        private System.Windows.Forms.Button Resultado;
    }
}