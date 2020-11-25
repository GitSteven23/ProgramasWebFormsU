using System;
using System.Windows.Forms;

namespace ProgramasWebFormsU
{
    public partial class MenuProgramas : Form
    {
        public MenuProgramas()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboBox1.SelectedIndex;

            switch (indice)
            {
                case 0:
                    _1_OperacionesMatematicas menu1 = new _1_OperacionesMatematicas();
                    menu1.Show();
                    break;

                case 1:
                    _2_FuncionesMatematicas menu2 = new _2_FuncionesMatematicas();
                    menu2.Show();
                    break;

                case 2:
                    _3_RespuestaCorrectaIncorrecta menu3 = new _3_RespuestaCorrectaIncorrecta();
                    menu3.Show();
                    break;

                case 3:
                    _4_ConmebolLibertadores menu4 = new _4_ConmebolLibertadores();
                    menu4.Show();
                    break;

                case 4:
                    _5_ProduccionEmpleado menu5 = new _5_ProduccionEmpleado();
                    menu5.Show();
                    break;

                case 5:
                    _6_NumeroCD menu6 = new _6_NumeroCD();
                    menu6.Show();
                    break;

                case 6:
                    _7_SumatoriaPositivoNegativo menu7 = new _7_SumatoriaPositivoNegativo();
                    menu7.Show();
                    break;

                case 7:
                    _8_MuestreoPersonas menu8 = new _8_MuestreoPersonas();
                    menu8.Show();
                    break;

                case 8:
                    _9_MatrizCalificaciones menu9 = new _9_MatrizCalificaciones();
                    menu9.Show();
                    break;

                case 9:
                    _10_NominaEmpleados menu10 = new _10_NominaEmpleados();
                    menu10.Show();
                    break;

                default:
                    Close();
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
