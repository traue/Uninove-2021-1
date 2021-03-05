using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primeira_Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btSomar_Click(object sender, EventArgs e)
        {
            float soma;
            float vA = Convert.ToSingle(txtValorA.Text);
            float vB = Convert.ToSingle(txtValorB.Text);
            soma = vA + vB;
            lbResultado.Text = soma.ToString();
        }
    }
}
