using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Empresa
{
    internal class Empresa
    {
        public string Cnpj { get; set;}
        public string Razao_Social { get; set;}
        public string Nome_Fantasia { get; set;}
        public string Situacao_Cadastral { get; set;}
        public string Regime_Tributario { get; set;}
        public DateTime Data_Inicio_Atividade { get; set;}
        public string Telefone { get; set;}
        public double Capital_Social { get; set;}
        public string Endereco_Completo { get; set;}
        public string Tipo { get; set;}
        public string Porte_Empresa { get; set;}
        public string Natureza_Juridica { get; set;}
        public string Nome_Proprietario { get; set;}
        public string Cpf { get; set; }

        public Empresa()
        {

        }
        public Empresa(string cnpj, string razaoSocial, string nomeFantasia, string situacaoCadastral, string regimeTributario, DateTime dataInicioAtividade, string telefone, double capitalSocial, string enderecoCompleto, string tipo, string porteEmpresa, string naturezaJuridica, string nomeProprietario, string cpf)
        {
            Cnpj = cnpj;
            Razao_Social = razaoSocial;
            Nome_Fantasia = nomeFantasia;
            Situacao_Cadastral = situacaoCadastral;
            Regime_Tributario = regimeTributario;
            Data_Inicio_Atividade = dataInicioAtividade;
            Telefone = telefone;
            Capital_Social = capitalSocial;
            Endereco_Completo = enderecoCompleto;
            Tipo = tipo;
            Porte_Empresa = porteEmpresa;
            Natureza_Juridica = naturezaJuridica;
            Nome_Proprietario = nomeProprietario;
            Cpf = cpf;
        }
    }
}
