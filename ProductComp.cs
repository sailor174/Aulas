using System;
using System.Security.Cryptography.X509Certificates;
using VScode;

namespace ProductComp

{
    public class Products
    {
        public String Nome;
        public int Quantidade;
        public int Id;
        public double Valor;
        Products Farinha = new Products("Farinha", 15, 1, 7);
        public Products(string nome, int quantidade, int id, double valor)
        {
            Nome = nome;
            Quantidade = quantidade;
            Id = id;
            Valor = valor;
        }
        public void PrintStock()
        {
            Console.WriteLine("Nome: " + Farinha.Nome, "\nQuantidade: " + Farinha.Quantidade, "\nId: " + Farinha.Id, "\nValor: " + Farinha.Valor);
        }

        public void RemoveStock(string nome, int quantidade)
        {
            switch (nome)
            {
                case "farinha":
                    Console.Write("você aumentou a " + Farinha.Nome, " em " + quantidade, " (" + Farinha.Quantidade);
                    Farinha.Quantidade -= quantidade;
                    Console.Write(" -> " + Farinha.Quantidade, ")");
                    break;
            }
        }
        public void AddStock(Products produto, int quantidade)
        {
            Console.Write("você aumentou a " + produto.Nome, " em " + quantidade, " (" + produto.Quantidade);
            produto.Quantidade += quantidade;
            Console.Write(" -> " + produto.Quantidade, ")");
        }
    }
}