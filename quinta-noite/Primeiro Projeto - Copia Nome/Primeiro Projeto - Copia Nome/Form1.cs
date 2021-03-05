using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primeiro_Projeto___Copia_Nome
{
    public partial class frmCopiaNome : Form
    {
        public frmCopiaNome()
        {
            InitializeComponent();
        }

        private void btCopia_Click(object sender, EventArgs e)
        {
            lbResultado.Visible = true;
            lbResultado.Text = txtNome.Text + " " + txtSobrenome.Text;
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            //Formas diferentes de fazer a mesma coisa
            txtNome.Text = "";
            txtSobrenome.Clear();
            lbResultado.Visible = false;

            //da no mesmo se você limpar o texto do label:
            lbResultado.Text = "";
        }
    }
}
