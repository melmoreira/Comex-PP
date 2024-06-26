using Comex.Modelos;
using Comex.Utils;

namespace Comex.Menus
{
    public class MenuOrdenarProdutos
    {
        public void OrdenarProdutosPeloTitulo(List<Produto> listaDeProdutos)
        {
            var produtosOrdenados = listaDeProdutos.OrderBy(p => p.Nome).ToList();
            Console.Clear();
            Console.WriteLine("Produtos ordenados pelo título:");
            for (int i = 0; i < produtosOrdenados.Count; i++)
            {
                Console.WriteLine($"Produto: {produtosOrdenados[i].Nome}, Preço: {produtosOrdenados[i].PrecoUnitario:F2}");
            }
            ConsoleUtils.PararELimparAplicação();
        }

        public void OrdenarProdutosPeloPreço(List<Produto> listaDeProdutos)
        {
            var produtosOrdenadosPorPreco = listaDeProdutos.OrderBy(p => p.PrecoUnitario).ToList();
            Console.Clear();
            Console.WriteLine("Produtos ordenados pelo preço:");
            for (int i = 0; i < produtosOrdenadosPorPreco.Count; i++)
            {
                Console.WriteLine($"Produto: {produtosOrdenadosPorPreco[i].Nome}, Preço: {produtosOrdenadosPorPreco[i].PrecoUnitario:F2}");
            }
            ConsoleUtils.PararELimparAplicação();
        }
    }
}
