using Comex.Modelos;
using Comex.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Menus
{
    public class MenuListarPedidos
    {
        public void ListarPedidos(List<Pedido> listaDePedidos)
        {
            Console.Clear();
            Console.WriteLine("Exibindo todos os produtos registradoss na nossa aplicação");

            var pedidosOrdenados = listaDePedidos.OrderBy(p => p.Cliente.Nome).ToList();

            foreach (var Pedido in pedidosOrdenados)
            {
                Console.WriteLine($"Cliente: {Pedido.Cliente.Nome}, Total: {Pedido.Total:F2}");
            }

            ConsoleUtils.PararELimparAplicação();
        }
    }
}
