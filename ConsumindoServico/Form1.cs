using ConsumindoServico.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumindoServico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cpf = txtCpf.Text;

            try
            {
                ClienteServiceClient service = new ClienteServiceClient();
                Cliente cliente = new Cliente();
                cliente.Nome = nome;
                cliente.Cpf = cpf;
                service.Add(cliente);

                MessageBox.Show("Cliente Cadastrado Com Sucesso");
            }
            catch (Exception)
            {

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            try
            {
                ClienteServiceClient servico = new ClienteServiceClient();
                var cliente = servico.Buscar(nome);
                txtCpf.Text = cliente.Cpf;
            }
            catch (Exception)
            {

            }
        }
    }
}
