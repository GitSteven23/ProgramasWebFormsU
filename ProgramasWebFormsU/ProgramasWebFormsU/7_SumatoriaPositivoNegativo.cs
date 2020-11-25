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
    public partial class _7_SumatoriaPositivoNegativo : Form
    {



        int opcion;
        string continuar;
        int num1, num2;


        public _7_SumatoriaPositivoNegativo()
        {
            InitializeComponent();

       }


        private void button1_Click(object sender, EventArgs e)
        {

            int[] numeros = new int[8];
            
            string vnumero = "";
            int vlong = 0;
            int i = 0;
            int vsumap = 0;
            int vsuman = 0;

          
            vnumero = textBox1.Text;
            vlong = vnumero.Length;


            string CNumeros = textBox1.Text;
            string[] cadenaNum = CNumeros.Split(',');

            foreach (var vnum in cadenaNum)
            {
                numeros[i] = int.Parse(vnum);
                i++;
            }


            for (int y = 0; y < numeros.Length; y++)
            {

                if (numeros[y] > 0)
                {
                    vsumap = vsumap + numeros[y];
                }

               else
                {
                    vsuman= vsuman + numeros[y];
                }

            }

            textBox2.Text = vsumap.ToString();
            textBox3.Text = vsuman.ToString();

        }
    }
}
