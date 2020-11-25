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
    public partial class _10_NominaEmpleados : Form
    {
        public _10_NominaEmpleados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int auxilio_transporte = 0;
            int fondo_Solidaridad = 0;
            String cedula = textBox1.Text;
            String nombre = textBox2.Text;
            int salario = int.Parse(textBox3.Text);
            int dias = int.Parse(textBox4.Text);
            int nhed = int.Parse(textBox5.Text);
            int nhen = int.Parse(textBox6.Text);
            int nhef = int.Parse(textBox21.Text);
            int dias_recargo = int.Parse(textBox8.Text);
            int prestamo = int.Parse(textBox7.Text);
            //salario minimo= 980657, auxilio de transporte $102854 para el que gane 1961314, para el
            //que gane mas 0$
            int sueldo = salario / 30 * dias;
            textBox22.Text = sueldo.ToString();
            if (salario <= 1961314)
            {
                auxilio_transporte = 102854 / 30 * dias;
                auxilio_transporte = auxilio_transporte + 10000;
            }
            textBox9.Text = auxilio_transporte.ToString();
            //calculo de las horas extras

            int vhed = Convert.ToInt32(salario / 240 * nhed * 1.25);
            int vhen = Convert.ToInt32(salario / 240 * nhen * 1.75);
            int vhef = Convert.ToInt32(salario / 240 * nhef * 2);
            textBox10.Text = vhed.ToString();
            textBox11.Text = vhen.ToString();
            textBox13.Text = vhef.ToString();

            //empleados que trabajan por turnos y se les da 35% salario base
            int recargo_nocturno = Convert.ToInt32(salario / 30 * dias_recargo * 1.35);
            //salarios recibidos por el empleado
            textBox14.Text = recargo_nocturno.ToString();
            int total_devengado = sueldo + auxilio_transporte + vhed + vhen + vhef + recargo_nocturno;
            textBox15.Text = total_devengado.ToString();
            //deducciones
            int salud = Convert.ToInt32((total_devengado - auxilio_transporte) * 0.4);
            int pension = Convert.ToInt32((total_devengado - auxilio_transporte) * 0.4);
            textBox16.Text = salud.ToString();
            textBox17.Text = pension.ToString();
            // 1% para salario igual o superior a 3922628
            if (salario >= 39922628)
            {
                fondo_Solidaridad = Convert.ToInt32(salario * 0.1);
            }
            int total_deducido = salud + pension + prestamo + fondo_Solidaridad;
            textBox18.Text = fondo_Solidaridad.ToString();
            textBox19.Text = total_deducido.ToString();
            int neto_pagado = total_devengado - total_deducido;
            textBox20.Text = neto_pagado.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuProgramas menu = new MenuProgramas();
            menu.Show();
        }
    }
}
