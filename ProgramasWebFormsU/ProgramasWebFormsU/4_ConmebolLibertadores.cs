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

            string Equipo = textBox3.Text;
            win = int.Parse(textBox3.Text);
            lose = int.Parse(textBox4.Text);
            draw = int.Parse(textBox2.Text);

            pointsw = win * 3;
            pointsl = lose * 0;
            pointsd = draw * 1;
            suma = win + lose + draw;
            total = pointsw + pointsl + pointsd;

            
            if (suma != 38)
            {
                
                
            }
        }
    }
}
