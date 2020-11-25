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
    public partial class _8_MuestreoPersonas : Form
    {
        public _8_MuestreoPersonas()
        {
            InitializeComponent();
        }

        #region VARIABLES

        int[] personas = new int[10];
        int[] edadesTotal = new int[10];
        int[] pesosTotal = new int[10];
        int peso, edad;

        double promedioNiños = 0;
        double promedioJovenes = 0;
        double promedioAdultos = 0;
        double promedioAncianos = 0;

        double calculoNiños = 0;
        double calculoJovenes = 0;
        double calculoAdultos = 0;
        double calculoAncianos = 0;

        double totalPromedioNiños = 0;
        double totalPromedioJovenes = 0;
        double totalPromedioAdultos = 0;
        double totalPromedioAncianos = 0;

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            
            for (int i = 1; i < personas.Length; i++)
            {

                /*edad = int.Parse(textBox1.Text);
                peso = int.Parse(textBox2.Text);*/

                label11.Text = i.ToString();
                label11.Update();                

                edadesTotal[i] = int.Parse(textBox1.Text);
                pesosTotal[i] = int.Parse(textBox2.Text);

                MessageBox.Show("Persona" + i + "agregada.");

                textBox1.Clear();
                textBox2.Clear();
            }            
        }

        public void calculoEdadesPeso(int[] edadesTotal, int[] pesosTotal)
        {
            //Niños
            if (edad >= 0 && edad <= 13)
            {
                promedioNiños = promedioNiños + peso;
                calculoNiños = calculoNiños + 1;
            }
            //Jovenes
            else if (edad >= 14 && edad <= 30)
            {
                promedioJovenes = promedioJovenes + peso;
                calculoJovenes = calculoJovenes + 1;
            }
            //Adultos
            else if (edad >= 31 && edad <= 60)
            {
                promedioAdultos = promedioAdultos + peso;
                calculoAdultos = calculoAdultos + 1;
            }
            //Ancianos
            else if (edad > 60)
            {
                promedioAncianos = promedioAncianos + peso;
                calculoAncianos = calculoAncianos + 1;
            }           


            //Calculo de promedios
            totalPromedioNiños = promedioNiños / calculoNiños;
            totalPromedioJovenes = promedioJovenes / calculoJovenes;
            totalPromedioAdultos = promedioAdultos / calculoAdultos;
            totalPromedioAncianos = promedioAncianos / calculoAncianos;

            textBox3.Text = Convert.ToDouble(Math.Round(totalPromedioNiños, 2)).ToString();
            textBox4.Text = Convert.ToDouble(Math.Round(totalPromedioJovenes, 2)).ToString();
            textBox5.Text = Convert.ToDouble(Math.Round(totalPromedioAdultos, 2)).ToString();
            textBox6.Text = Convert.ToDouble(Math.Round(totalPromedioAncianos, 2)).ToString();
        }

        private void _8_MuestreoPersonas_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
