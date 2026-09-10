using System;
using System.Collections.Generic;
using System.Linq;

namespace CarrinhoCompras
{
    public class Carrinho
    {
        private List<Produto> produtos = new List<Produto>();

        public void AdicionarProduto(Produto produto)
        {
            if (produto == null)
            {
                throw new ArgumentNullException(nameof(produto));
            }

            produtos.Add(produto);
        }

        public void RemoverProduto(string nome)
        {
            var produto = produtos.FirstOrDefault(p => p.Nome == nome);

            if (produto != null)
            {
                produtos.Remove(produto);
            }
        }

        public decimal CalcularTotal()
        {
            decimal total = 0;

            foreach (var produto in produtos)
            {
                total += produto.Preco * produto.Quantidade;
            }

            return total;
        }
    }
}