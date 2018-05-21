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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.tbNome.Enabled = true;
            this.tbNIF.Enabled = true;
            this.tbMorada.Enabled = true;
            this.tbContacto.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {   
            //Guardar novo cliente
            if (this.btnGuardar.Text.Equals("Guardar"))
            {
                if (this.tbNome.Text.Length >= 3)
                {
                    if (this.tbNIF.Text.Length != 9)
                    {
                        try
                        {
                            long nif = Convert.ToInt64(this.tbNIF.Text);
                            if (this.tbMorada.Text.Length >= 10)
                            {
                                if(this.tbContacto.Text.Length != 9)
                                {
                                    try
                                    {
                                        long contacto = Convert.ToInt64(this.tbContacto.Text);

                                        Cliente cliente = new Cliente(this.tbNome.Text,this.tbNIF.Text,this.tbMorada.Text,this.tbContacto.Text);
                                    }
                                    catch (FormatException)
                                    {
                                        //contacto tem letras
                                    }
                                    catch (ArgumentNullException)
                                    {
                                        //Algum campo esta a null | impossivel de acontecer
                                    }
                                }
                                else
                                {
                                    //contacto com mais ou menos de 9 digitos
                                }
                            }
                            else
                            {
                                //Morada n tem tamanho suficiente
                            }
                        }
                        catch (FormatException)
                        {
                            //NIF tem letras
                        }
                    }
                    else
                    {
                        //NIF pequeno
                    }
                }
                else
                {
                    //nome pequeno
                }
            }
            //Editar cliente selecionado
            else
            {


                this.btnGuardar.Text = "Guardar";
            }
        }
    }
}
