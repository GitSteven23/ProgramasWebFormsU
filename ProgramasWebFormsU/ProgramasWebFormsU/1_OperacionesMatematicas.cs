using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramasWebFormsU
{
    public partial class _1_OperacionesMatematicas : Form
    {
        public _1_OperacionesMatematicas()
        {
            InitializeComponent();
        }
        decimal num1, num2;

        private void button1_Click(object sender, EventArgs e)
        {
            decimal suma;

            num1 = Convert.ToDecimal(textBox1.Text);
            num2 = Convert.ToDecimal(textBox2.Text);

            suma = num1 + num2;

            textBoxResultado.Text = suma.ToString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            decimal resta;

            num1 = Convert.ToDecimal(textBox1.Text);
            num2 = Convert.ToDecimal(textBox2.Text);

            resta = num1 - num2;

            textBoxResultado.Text = resta.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Multiplicacion_Click(object sender, EventArgs e)
        {
            decimal multiplicacion;

            num1 = Convert.ToDecimal(textBox1.Text);
            num2 = Convert.ToDecimal(textBox2.Text);

            multiplicacion = num1 * num2;

            textBoxResultado.Text = multiplicacion.ToString();
        }

        private void Division_Click(object sender, EventArgs e)
        {
            decimal division;

            num1 = Convert.ToDecimal(textBox1.Text);
            num2 = Convert.ToDecimal(textBox2.Text);

            division = num1 / num2;

            textBoxResultado.Text = division.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
