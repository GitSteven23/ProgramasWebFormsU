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
    public partial class _6_NumeroCD : Form
    {
        int capDisco;
        decimal numCD;
        decimal convertir;
        int capCD = 700;
        public _6_NumeroCD()
        {
            InitializeComponent();
            
        }

        private void CapaDisco_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Resultado_Click(object sender, EventArgs e)
        {
            capDisco = Convert.ToInt32(CapaDisco.Text);

            convertir = capDisco * 1024;

            numCD = Math.Round(convertir / capCD,2);

            ResultadoNumCD.Text = numCD.ToString();
        }
    }
}
