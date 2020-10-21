using System;
using System.Globalization;

namespace ExercícioConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: "); // entrada do nome
            string nome = Console.ReadLine();
            Console.Write("Preço: "); // entrada do preço
            double preço = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: "); // entrada da quantidade
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preço, quantidade); // instanciar o construtor

            Console.WriteLine("Dados do produto: " + p); // vai imprimir os dados

            Console.Write("Digite o número de produtos a serem adicionados no estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte); // vai adicionar os produtos da quantidade

            Console.WriteLine("Dados atualizados: " + p); // vai imprimir os dados atualizados

            Console.WriteLine("Digite o número de produtos a serem removidos no estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte); // vai remover os produtos da quantidade 

            Console.WriteLine("Dados atualizados: " + p); // vai imprimir os dados atualizados
            Console.ReadKey();
        }
    }
}
