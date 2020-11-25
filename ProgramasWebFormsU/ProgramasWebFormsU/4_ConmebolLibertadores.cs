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
    public partial class _4_ConmebolLibertadores : Form
    {
        public _4_ConmebolLibertadores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int win, lose, draw, total, suma,
                pointsw, pointsl, pointsd;

            string mensaje = "La suma debe ser exactamente de 38";
            
            string Equipo = textBox1.Text;
            win = int.Parse(textBox2.Text);
            lose = int.Parse(textBox3.Text);
            draw = int.Parse(textBox4.Text);

            pointsw = win * 3;
            pointsl = lose * 0;
            pointsd = draw * 1;
            suma = win + lose + draw;
            total = pointsw + pointsl + pointsd;

            if (suma == 38)
            {
                textBox5.Text = pointsw.ToString();
                textBox6.Text = pointsl.ToString();
                textBox7.Text = pointsd.ToString();
                textBox8.Text = total.ToString();
                mensaje = "El puntaje total de " + Equipo + " es " + total;
                textBox9.Text = mensaje.ToString();
            }
            else
            {
                textBox5.Text = " ";
                textBox6.Text = " ";
                textBox7.Text = " ";
                textBox8.Text = " ";
                textBox9.Text = mensaje.ToString();
            }
        }
        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
