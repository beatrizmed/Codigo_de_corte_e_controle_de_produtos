namespace Teste
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[,] dadosProdutos = new string[,] {
														  {"1", "martelos", "01/2019", "10"},
														  {"1", "martelos", "01/2019", "14"},
														  {"1", "martelos", "02/2019", "5"},
														  {"1", "martelos", "03/2019", "12"},
														  {"2", "chaves fenda", "02/2019", "2"},
														  {"2", "chaves fenda", "03/2019", "1"},
														  {"3", "chaves philips", "01/2019", "20"},
														  {"3", "chaves philips", "01/2019", "30"},
														  {"3", "chaves philips", "01/2019", "50"},
														  {"4", "baldes", "03/2019", "100"},
														  {"5", "pas", "02/2019", "50"},
														  {"5", "pas", "03/2019", "150"},
													};

			int totalProduto = 0;
			int totalGeral = 0;
			string idProdutoAtual = "";
			string idProdutoAnterior = "";
			int linha = 0;

			Console.WriteLine("Id - Produto - Data - Qtd");
			while (linha < 12)
			{
				idProdutoAtual = idProdutoAnterior = dadosProdutos[linha, 0];
				while (linha < 12 && idProdutoAnterior == idProdutoAtual)
				{
					Console.WriteLine($"{dadosProdutos[linha, 0]} - {dadosProdutos[linha, 1]} - {dadosProdutos[linha, 2]} - {dadosProdutos[linha, 3]}");
					totalProduto += Convert.ToInt16(dadosProdutos[linha, 3]);
					linha++;
					if (linha < 12)
						idProdutoAtual = dadosProdutos[linha, 0];
				}
				Console.WriteLine($"Total do Produto: {totalProduto}");
				Console.WriteLine();
				totalGeral += totalProduto;
				totalProduto = 0;
			}
			Console.WriteLine($"Total Geral: {totalGeral}");
			Console.ReadKey();
		}
	}
}