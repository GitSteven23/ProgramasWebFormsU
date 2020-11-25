using Microsoft.VisualBasic;
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
    public partial class _9_MatrizCalificaciones : Form
    {
        public _9_MatrizCalificaciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[,] notas;
            string[] materias;
            string[] estudiantes;
            double suma = 0, promedio;
            int filas, columnas, i, j;
            filas = int.Parse(textBox1.Text);
            columnas = int.Parse(textBox2.Text);
            notas = new double[filas, columnas];
            materias = new string[filas];
            estudiantes = new string[columnas];
            dataGridView1.ColumnCount = columnas + 1;
            dataGridView1.RowCount = filas + 1;
            //Carga las Nombres de las materias
            for (j = 0; j < filas; j++)
            {
                //Carga las materias en el vector
                materias[j] = Interaction.InputBox("Digite la Materia a Insertar");
                //Agregar Notas desde la matriz al Datagridview
                dataGridView1.Rows[j].HeaderCell.Value = materias[j];
            }
            dataGridView1.Rows[filas].HeaderCell.Value = "Promedio Estudiante";
            //Carga las Nombres de los estudiantes
            for (j = 0; j < filas; j++)
            {
                //Carga las materias en el vector
                estudiantes[j] = Interaction.InputBox("Digite El Estudinate Materia a Insertar");
                //Agregar Notas desde la matriz al Datagridview
                dataGridView1.Columns[j].HeaderCell.Value = estudiantes[j];
            }
            dataGridView1.Columns[columnas].HeaderCell.Value = "Promedio Materia";
            //Carga de Notas en la matriz
            for (i = 0; i < filas; i++)
            {
                for (j = 0; j < columnas; j++)
                {
                    //Carga de Notas en la matriz
                    notas[i, j] = double.Parse(Interaction.InputBox("Digite la Nota posicion(" + i + "," + j + "):"));
                    //Agregar Notas desde la matriz al Datagridview
                    dataGridView1.Rows[i].Cells[j].Value = notas[i, j];
                    suma = suma + notas[i, j];

                }
                promedio = suma / columnas;
                //Agregar el promedio en la ultima posicion del Datagridview
                dataGridView1.Rows[i].Cells[columnas].Value = promedio;
                suma = 0;
            }
            suma = 0;
            for (j = 0; j < columnas; j++)
            {
                for (i = 0; i < filas; i++)
                {
                    //Sumar Notas en el sentido de las columnas
                    suma = suma + notas[j, i];
                }
                promedio = suma / filas;
                //Agregar el promedio en la ultima posicion del Datagridview
                dataGridView1.Rows[columnas].Cells[j].Value = promedio;
                suma = 0;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuProgramas menu = new MenuProgramas();
            menu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
