using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_final_InoDa
{
    public partial class FormClientes : Form
    {
        FormInicial formInicial;
        public FormClientes(FormInicial formInicial)
        {
            InitializeComponent();
            this.formInicial = formInicial;
            this.cbPesquisaClientes.SelectedIndex = 0;
        }

        private void btGerirClientes_Click(object sender, EventArgs e)
        {
            this.formInicial.Show();
            this.Close();
        }

        private void FormClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.formInicial.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormClientes_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
