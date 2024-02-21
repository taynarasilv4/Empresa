using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_Empresa
{
    public partial class CadastroEmpresa : Form
    {
        List<Empresa> empresas = new List<Empresa>();
        public CadastroEmpresa()
        {
            InitializeComponent();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Empresa empresa = new Empresa();

                empresa.Cnpj = tx_cnpj.Text;
                empresa.Razao_Social = tx_razaoSocial.Text;
                empresa.Nome_Fantasia = tx_nomeFantasia.Text;
                empresa.Situacao_Cadastral = cb_situacaoCadastral.Text;
                empresa.Data_Inicio_Atividade = dp_dataInicioAtividade.Value;
                empresa.Telefone = mb_telefone.Text;
                empresa.Capital_Social = Convert.ToDouble(tx_capitalSocial.Text);
                empresa.Endereco_Completo = $"{tx_rua.Text}, {tx_bairro.Text}, {tx_cidade.Text}, {cb_estado.SelectedItem}";


                // Regime tributario
                if (rb_simplesNacional.Checked)
                {
                    empresa.Regime_Tributario = "Simples Nacional";
                }
                else if (rb_lucroPresumido.Checked)
                {
                    empresa.Regime_Tributario = "Lucro Presumido";
                }
                else if (rb_real.Checked)
                {
                    empresa.Regime_Tributario = "Real";
                }


                // Tipo
                if (rb_matriz.Checked)
                {
                    empresa.Tipo = "Matriz";

                }
                else if (rb_filial.Checked)
                {
                    empresa.Tipo = "Filial";
                }


                //  Porte da Empresa
                if (rb_pequeno.Checked)
                {
                    empresa.Porte_Empresa = "Pequeno";
                }
                else if (rb_medio.Checked)
                {
                    empresa.Porte_Empresa = "Médio";
                }
                else if (rb_grande.Checked)
                {
                    empresa.Porte_Empresa = "Grande";
                }


                empresa.Natureza_Juridica = cb_naturezaJuridica.Text;
                empresa.Nome_Proprietario = tx_nomeProprietario.Text;
                empresa.Cpf = mb_cpfProprietario.Text;

                empresas.Add(empresa);

                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                dataGridView1.DataSource = empresas;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um Erro!  {ex.Message}");
            }

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void CadastroEmpresa_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tx_cnpj.Clear();
            tx_razaoSocial.Clear();
            tx_nomeFantasia.Clear();
            cb_situacaoCadastral.SelectedItem = null;
            rb_simplesNacional.Checked = false;
            rb_lucroPresumido.Checked = false;
            rb_real.Checked = false;
            dp_dataInicioAtividade.Value = DateTime.Now;
            mb_telefone.Clear();
            tx_capitalSocial.Clear();
            cb_estado.SelectedItem = null;
            tx_cidade.Clear();
            tx_rua.Clear();
            tx_bairro.Clear();
            cb_naturezaJuridica.SelectedItem = null;
            tx_nomeProprietario.Clear();
            mb_cpfProprietario.Clear();
            rb_matriz.Checked = false;
            rb_filial.Checked = false;
            rb_pequeno.Checked = false;
            rb_medio.Checked = false;
            rb_grande.Checked = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            empresas.RemoveAt(index);

            dataGridView1.DataSource = null;//zerar ou seja deixar sem nenhum elemento
            dataGridView1.Refresh();//atualizar toda tabela
            dataGridView1.DataSource = empresas;
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cb_estado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
