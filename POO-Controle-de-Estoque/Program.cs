//Frederico Guilherme Camilli Proença RA:200925

using System;
using System.Globalization;

namespace POO_Controle_de_Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciação das variáveis nome, preço, quantidade e quantp, que será o estoque mudado pelo usuário.
            string nome;
            double preco;
            int quant, quantp;

            //Inserção dos dados do produto a ser controlado em estoque pelo usuário.
            Console.WriteLine("Insira os dados do produto;");
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Preço: ");
            preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            quant = int.Parse(Console.ReadLine());

            //Instanciação do objeto produto "p".
            Produto p = new(nome, preco, quant);

            //Apresentação dos dados do produto inseridos pelo usuário ao mesmo, e o pedido de valor de produtos a serem adicionados ao estoque.
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine("Insira o número de produtos a serem adicionados ao estoque: ");

            //Inserção do usuário da quantidade de produtos a serem adicionados.
            quantp = int.Parse(Console.ReadLine());
            p.AddProduto(quantp);

            //Apresentação dos dados do produto atualizados, e pedido de valor de produtos a serem removidos do estoque.
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine("Insira o número de produtos a serem removidos do estoque: ");

            //Inserção do usuário da quantidade de produtos a serem removidos.
            quantp = int.Parse(Console.ReadLine());
            p.RmvProduto(quantp);

            //Apresentação dos dados do produto atualizados finais.
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}

//Professor, eu não entendi e, por mais que pesquisei, não achei maneira de utilizar a sobrecarga. Em diante segue o código original, com o erro que me impediu progresso. Note a linha 76, na qual acontece o erro. Aqui está meu e-mail, por conveniência: fredericoguilhermecp@gmail.com
//using System;
//using System.Globalization;

//namespace POO_Controle_de_Estoque
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //Instanciação das variáveis nome, preço, quantidade e quantp, que será o estoque mudado pelo usuário.
//            string nome;
//            double preco;
//            int quant, quantp;

//            //Inserção dos dados do produto a ser controlado em estoque pelo usuário.
//            Console.WriteLine("Insira os dados do produto;");
//            Console.Write("Nome: ");
//            nome = Console.ReadLine();
//            Console.Write("Preço: ");
//            preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            Console.Write("Quantidade no estoque: ");
//            quant = int.Parse(Console.ReadLine());

//            Produto p = new(nome, preco, quant);
//            Produto p = new("PS4, 2000, 10");

//            //Apresentação dos dados do produto inseridos pelo usuário ao mesmo, e o pedido de valor de produtos a serem adicionados ao estoque.
//            Console.WriteLine("Dados do produto: " + p);
//            Console.WriteLine("Insira o número de produtos a serem adicionados ao estoque: ");

//            //Inserção do usuário da quantidade de produtos a serem adicionados.
//            quantp = int.Parse(Console.ReadLine());
//            p.AddProduto(quantp);

//            //Apresentação dos dados do produto atualizados, e pedido de valor de produtos a serem removidos do estoque.
//            Console.WriteLine("Dados atualizados: " + p);
//            Console.WriteLine("Insira o número de produtos a serem removidos do estoque: ");

//            //Inserção do usuário da quantidade de produtos a serem removidos.
//            quantp = int.Parse(Console.ReadLine());
//            p.RmvProduto(quantp);

//            //Apresentação dos dados do produto atualizados finais.
//            Console.WriteLine("Dados atualizados: " + p);
//        }
//    }
//}
