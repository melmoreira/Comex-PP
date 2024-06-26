using System.Text.Json;
using Comex.Modelos;
using Comex.Utils;

namespace Comex.Menus
{
    public class MenuConsultaApiExterna
    {
        private HttpClient client;
        public MenuConsultaApiExterna(HttpClient client)
        {
            this.client = client;
        }

        public async Task ConsultarApiExterna(List<Produto> listaDeProdutos)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("\nExibindo Produtos\n");
                string resposta = await client.GetStringAsync("http://fakestoreapi.com/products");
                var produtos = JsonSerializer.Deserialize<List<Produto>>(resposta)!;
                for (int i = 0; i < produtos.Count; i++)
                {
                    Console.WriteLine($"Nome: {produtos[i].Nome}, " +
                        $"Descrição: {produtos[i].Descricao}, " +
                        $"Preço {produtos[i].PrecoUnitario} \n");
                }
                ConsoleUtils.PararELimparAplicação();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Temos um problema: {ex.Message}");
            }
        }
    }
}
