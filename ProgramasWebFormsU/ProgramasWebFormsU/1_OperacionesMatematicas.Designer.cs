namespace ProgramasWebFormsU
{
    partial class _1_OperacionesMatematicas
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
            this.SumaBoton = new System.Windows.Forms.Button();
            this.Resta = new System.Windows.Forms.Button();
            this.Multiplicacion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Resultado = new System.Windows.Forms.Label();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.Division = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SumaBoton
            // 
            this.SumaBoton.Location = new System.Drawing.Point(473, 108);
            this.SumaBoton.Name = "SumaBoton";
            this.SumaBoton.Size = new System.Drawing.Size(95, 23);
            this.SumaBoton.TabIndex = 0;
            this.SumaBoton.Text = "Suma";
            this.SumaBoton.UseVisualStyleBackColor = true;
            this.SumaBoton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Resta
            // 
            this.Resta.Location = new System.Drawing.Point(473, 153);
            this.Resta.Name = "Resta";
            this.Resta.Size = new System.Drawing.Size(95, 23);
            this.Resta.TabIndex = 1;
            this.Resta.Text = "Resta";
            this.Resta.UseVisualStyleBackColor = true;
            this.Resta.Click += new System.EventHandler(this.button4_Click);
            // 
            // Multiplicacion
            // 
            this.Multiplicacion.Location = new System.Drawing.Point(473, 203);
            this.Multiplicacion.Name = "Multiplicacion";
            this.Multiplicacion.Size = new System.Drawing.Size(95, 23);
            this.Multiplicacion.TabIndex = 2;
            this.Multiplicacion.Text = "Multiplicación";
            this.Multiplicacion.UseVisualStyleBackColor = true;
            this.Multiplicacion.Click += new System.EventHandler(this.Multiplicacion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Primer Número ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Segundo Número";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 153);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(252, 153);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Location = new System.Drawing.Point(65, 244);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(55, 13);
            this.Resultado.TabIndex = 8;
            this.Resultado.Text = "Resultado";
            this.Resultado.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Location = new System.Drawing.Point(145, 241);
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.Size = new System.Drawing.Size(119, 20);
            this.textBoxResultado.TabIndex = 9;
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(473, 253);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(95, 23);
            this.Division.TabIndex = 10;
            this.Division.Text = "División";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.Division_Click);
            // 
            // _1_OperacionesMatematicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Multiplicacion);
            this.Controls.Add(this.Resta);
            this.Controls.Add(this.SumaBoton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "_1_OperacionesMatematicas";
            this.Text = "Operaciones Matemáticas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SumaBoton;
        private System.Windows.Forms.Button Resta;
        private System.Windows.Forms.Button Multiplicacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.Button Division;
    }
}