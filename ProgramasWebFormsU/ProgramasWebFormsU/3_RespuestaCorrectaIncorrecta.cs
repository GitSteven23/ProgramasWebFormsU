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
    public partial class _3_RespuestaCorrectaIncorrecta : Form
    {
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void _3_RespuestaCorrectaIncorrecta_Load(object sender, EventArgs e)
        {

        }

        public _3_RespuestaCorrectaIncorrecta()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int correctas, incorrectas, blanco, postulantes,
                puntajec, puntajei, puntajeb;

            postulantes = int.Parse(textBox1.Text);
            correctas = int.Parse(textBox2.Text);
            incorrectas = int.Parse(textBox3.Text);
            blanco = int.Parse(textBox4.Text);

            puntajec = correctas * 4;
            puntajei = incorrectas * -1;
            puntajeb = blanco * 0;

            textBox5.Text = correctas.ToString();
            textBox6.Text = incorrectas.ToString();
            textBox7.Text = blanco.ToString();
            textBox8.Text = puntajec.ToString();
            textBox9.Text = puntajei.ToString();
            textBox10.Text = puntajeb.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
