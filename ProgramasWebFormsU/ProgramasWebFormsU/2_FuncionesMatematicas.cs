using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramasWebFormsU
{
    public partial class _2_FuncionesMatematicas : Form
    {
        int opcion;
        string continuar;
        int num1, num2;
        double num3;

        public class select
        {
            public string Text { get; set; }
            public string Value { get; set; }
        }
        public _2_FuncionesMatematicas()
        {
            InitializeComponent();

            List<select> listado = new List<select>();
            listado.Add(new select() { Text = "Seleccione", Value = "0" });
            listado.Add(new select() { Text = "Maximo", Value = "1" });
            listado.Add(new select() { Text = "Minimo", Value = "2" });
            listado.Add(new select() { Text = "Redondeo", Value = "3" });
            listado.Add(new select() { Text = "Raiz", Value = "4" });
            listado.Add(new select() { Text = "Trucate", Value = "5" });
            listado.Add(new select() { Text = "Seno", Value = "6" });
            listado.Add(new select() { Text = "Coseno", Value = "7" });
            listado.Add(new select() { Text = "Potencia", Value = "8" });

            comboBox1.DataSource = listado;
            comboBox1.DisplayMember = "Text";
        }

 
             
        private void button1_Click(object sender, EventArgs e)
        {   
            switch (comboBox1.SelectedIndex)
            {
                case 1:
                    num1 = Convert.ToInt32(textBox1.Text);
                    num2 = Convert.ToInt32(textBox2.Text);

                    int maximo1 = Math.Max(num1, num2);
                    textBox3.Text = maximo1.ToString();


                    break;


                case 2:
                    num1 = Convert.ToInt32(textBox1.Text);
                    num2 = Convert.ToInt32(textBox2.Text);

                    int minimo2 = Math.Min(num1, num2);
                    textBox3.Text = minimo2.ToString();


                    break;

                case 3:
                    num3 = Convert.ToInt32(textBox1.Text);
                    num2 = Convert.ToInt32(textBox2.Text);

                    double redondedo = Math.Round(num3);
                    textBox3.Text = redondedo.ToString();


                    break;


                case 4:
                    num1 = Convert.ToInt32(textBox1.Text);
                    num2 = Convert.ToInt32(textBox2.Text);

                    double Raiz = Math.Sqrt(num1);
                    textBox3.Text = Raiz.ToString();


                    break;

                case 5:
                    num1 = Convert.ToInt32(textBox1.Text);
                    num2 = Convert.ToInt32(textBox2.Text);

                    int maximo5 = Math.Max(num1, num2);
                    textBox3.Text = maximo5.ToString();


                    break;

                case 6:
                    num1 = Convert.ToInt32(textBox1.Text);
                    num2 = Convert.ToInt32(textBox2.Text);

                    int maximo3 = Math.Max(num1, num2);
                    textBox3.Text = maximo3.ToString();


                    break;


                case 7:
                    num1 = Convert.ToInt32(textBox1.Text);
                    num2 = Convert.ToInt32(textBox2.Text);

                    int maximo4 = Math.Max(num1, num2);
                    textBox3.Text = maximo4.ToString();


                    break;

                case 8:
                    num1 = Convert.ToInt32(textBox1.Text);
                    num2 = Convert.ToInt32(textBox2.Text);

                    int maximo8 = Math.Max(num1, num2);
                    textBox3.Text = maximo8.ToString();


                    break;




                default:
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }
}
