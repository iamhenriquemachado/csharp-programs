﻿using System;
using System.Globalization;
using CursoProgramacao;

namespace Course {
    class Program {
        static void Main(string[] args) {

            Produto p = new Produto();
            
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: ", p); 

            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(quantidade);

            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
            int quantidadeRemover = int.Parse(Console.ReadLine());
            p.RemoverProdutos(quantidadeRemover); 
        }
    }
}