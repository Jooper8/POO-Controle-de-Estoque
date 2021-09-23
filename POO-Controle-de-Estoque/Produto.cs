//Frederico Guilherme Camilli Proença RA:200925

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Controle_de_Estoque
{
    class Produto
    {
        //Instanciação das váriaveis utilizadas no construtor, sendo que Preco e Quant utilizam Auto Properties.
        private string Nome;
        private double Preco { get; set; }
        private int Quant{ get; set;}

        //Instanciação do construtor vazio Produto.
        public Produto()
        { }

        //Instanciação do construtor Produto, que converterá os dados inseridos pelo usuário e guardará numa variável.
        public Produto(string nome, double preco, int quant)
        {
            Nome = nome;
            Preco = preco;
            Quant = quant;
        }

        //Instanciação das propriedades do Nome, checando se o valor não é nulo.
        public string GetSetNome
        {
            get
            {
                return Nome;
            }
            set
            {
                if (value != null && value.Length > 1)
                {
                    Nome = value;
                }
            }
        }

        //Função para determinar o valor guardado em estoque.
        public double ValorEstoque()
        {
            return Preco * Quant;
        }

        //Função para adicionar a quantia desejada ao estoque já calculado.
        public void AddProduto(int quant)
        {
            Quant += quant;
        }

        //Função para remover a quantia desejada ao estoque já calculado.
        public void RmvProduto(int quant)
        {
            Quant -= quant;
        }

        //Local no qual o programa se referirá para mostrar seus dados guardados.
        public override string ToString()
        {
            return Nome
            + ", R$"
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quant
            + " unidades, Total: R$"
            + ValorEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
