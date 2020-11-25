using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramasWebFormsU
{
    public partial class _5_ProduccionEmpleado : Form
    {
        public _5_ProduccionEmpleado()
        {
            InitializeComponent();
                
        
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
              
        private void button1_Click(object sender, EventArgs e)
        {
            int[] dias = new int[7];
            int total;               
               
            dias[0] = int.Parse(textBox1.Text);
            dias[1] = int.Parse(textBox2.Text);
            dias[2] = int.Parse(textBox3.Text);
            dias[3] = int.Parse(textBox4.Text);
            dias[4] = int.Parse(textBox5.Text);
            dias[5] = int.Parse(textBox6.Text);

            total = (dias.Sum() / 6);

            if (total < 100)
            {
                textBox9.Text = "La productividad del trabajador es de : " + total;
                textBox7.Text = "El trabajador no merece una bonificacion";

            }
            else
            {
                textBox9.Text = "La productividad del trabajador no es de : " + total;
                textBox7.Text = "El trabajador merece una bonificacion";
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
