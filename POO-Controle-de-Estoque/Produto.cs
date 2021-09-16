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
        //Instanciação das váriaveis utilizadas no construtor.
        public string Nome;
        public double Preco;
        public int Quant;

        //Instanciação do construtor Produto, que converterá os dados inseridos pelo usuário e guardará numa variável.
        public Produto(string nome, double preco, int quant)
        {
            Nome = nome;
            Preco = preco;
            Quant = quant;
        }

        //Instanciação do construtor vazio Produto.
        public Produto()
        { }

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
