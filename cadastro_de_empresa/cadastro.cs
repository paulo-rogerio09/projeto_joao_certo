using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastro_de_empresa
{
    public partial class cadastro : Form
    {
        public cadastro()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Cnpj = cnpj.Text;
            string Razao = razao.Text;
            string Nome_fantasia = nome_fantasia.Text;
            string Situacao = situacao_cadastral.Text;
            string Regime = "";
            if(simples.Checked)
            {
                Regime = "simples";
            }
            else if (lucro.Checked)
            {
                Regime = "lucro";
            }
            else if (real.Checked)
            {
                Regime = "real";
            }
            string Data = data.Text;
            string Telefone = maskedTextBox1.Text;
            string Capital = capital.Text;
            string Endereco = enderecos.Text;
            string Tipo = "";
            if (matriz.Checked)
            {
                Tipo = "matriz";
            }
            else if (lucro.Checked)
            {
                Tipo = "lucro";
            }
            string Porte = "";
            if (pequeno.Checked)
            {
                Porte = "pequeno";
            }
            else if (medio.Checked)
            {
                Porte = "medio";
            }
            else if (grande.Checked)
            {
                Porte = "Grande";
            }
            string Natureza = natureza.Text;
            string Nome_propi = nome_proprietario.Text;
            string Cpf = cpf_proprietario.Text;

            MessageBox.Show($"{Cnpj}\n {Razao}\n{Nome_fantasia}\n{Situacao}\n{Regime}\n{Data}\n{Telefone}\n{Capital}\n{Endereco}\n{Tipo}\n{Porte}\n{Natureza}\n{Nome_propi}\n{Cpf}");


        }

        private void razao_tx_Click(object sender, EventArgs e)
        {

        }

        private void nome_fantasia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
