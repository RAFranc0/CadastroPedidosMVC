using System;
using System.Collections.Generic;

namespace CadastroDePedidosMVC.Models {
    public static class Dados {
        public static Pedido PedidoAtual;

        static Dados() {
            PedidoAtual = new Pedido();
        }
    }
}