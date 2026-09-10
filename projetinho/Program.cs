using System;
using CarrinhoCompras;

namespace CarrinhoCompras
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho carrinho = new Carrinho();

            Produto mouse = new Produto("Mouse", 50.00m, 2);
            Produto teclado = new Produto("Teclado", 100.00m, 1);

            carrinho.AdicionarProduto(mouse);
            carrinho.AdicionarProduto(teclado);

            Console.WriteLine(
                $"Total do carrinho: R$ {carrinho.CalcularTotal():F2}"
            );
        }
    }
}