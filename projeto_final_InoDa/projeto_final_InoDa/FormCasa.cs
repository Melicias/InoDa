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
    public partial class FormCasa : Form
    {
        private FormInicial formInicial;
        private Model1Container mc;

        public FormCasa(FormInicial formInicial)
        {
            InitializeComponent();
            this.cbPesquisaCasas.SelectedIndex = 0;
            this.formInicial = formInicial;
            mc = new Model1Container();
        }

        private void btFiltrar_Click(object sender, EventArgs e)
        {

        }

        private void btNova_Click(object sender, EventArgs e)
        {

        }

        private void rbArrendavel_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbArrendavel.Checked)
            {
                this.gbArrendamento.Enabled = true;
            }
            else
            {
                this.gbArrendamento.Enabled = false;
            }
        }

        private void rbVendavel_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbVendavel.Checked)
            {
                this.gbVendavel.Enabled = true;
            }
            else
            {
                this.gbVendavel.Enabled = false;
            }
        }

        private void FormCasa_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.formInicial.Show();
        }
    }
}
