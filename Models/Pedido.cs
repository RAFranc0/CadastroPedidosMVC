using System;
using System.Collections.Generic;

namespace CadastroDePedidosMVC.Models
{
    public class Pedido
    {
        private static List<ItemPedido> pedidos;

        static Pedido()
        {
            pedidos = new List<ItemPedido>();
        }

        public void Inserir(ItemPedido pedido)
        {
            pedidos.Add(pedido);
        }

        public List<ItemPedido> Listar()
        {
            return pedidos;
        }

        public double Totalizar()
        {
            double total = 0;
            foreach (ItemPedido p in pedidos)
            {
                total += (p.valor_unitario * p.quantidade);
            }

            return total;
        }
    }
}