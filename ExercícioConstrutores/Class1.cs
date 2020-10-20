using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExercícioConstrutores
{
    public class Produto
    {
		// declarando as variáveis
		public string Nome;
		public double Preço;
		public int Quantidade;

		// uso dos construtor
		public Produto(string nome, double preço, int quantidade)
		{
			Nome = nome;
			Preço = preço;
			Quantidade = quantidade;
		}

		// declarar os métodos
		public double ValorTotalEmEstoque() // indicar o valor total no estoque
		{
			return Preço * Quantidade;
		}
		public void AdicionarProdutos(int quantidade) // irá adicionar produtos da variável quantidade
		{
			Quantidade += quantidade;
		}
		public void RemoverProdutos(int quantidade) // irá remover produtos da variável quantidade
		{
			Quantidade -= quantidade;
		}

		// declarar uma string para a saída dos produtos
		public override string ToString()
		{
			return Nome + ", R$ " + Preço.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, Total: R$ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
		}
	}
}
