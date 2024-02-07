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
        public Products(string nome, int quantidade, int id, double valor)
        {
            Nome = nome;
            Quantidade = quantidade;
            Id = id;
            Valor = valor;
        }
        public void PrintStock()
        {
            Console.WriteLine("Nome: " + this.Nome + "\nQuantidade: " + this.Quantidade + "\nId: " + this.Id + "\nValor: " + this.Valor + "\n");
        }
        public void RemoveStock(int quantidade)
        {
            // 3 farinha, foi removido 2: "você diminuiu a farinha em 2 (3 -> 1)"

            Console.Write("você diminuiu a " + this.Nome + " em " + quantidade + " (" + this.Quantidade);
            this.Quantidade -= quantidade;
            Console.Write(" -> " + this.Quantidade + ")");
        }
        public void AddStock(int quantidade)
        {
            // 3 farinha, foi adicionado 2: "você aumentou a farinha em 2 (3 -> 5)"

            Console.Write("você aumentou a " + this.Nome + " em " + quantidade + " (" + this.Quantidade);
            this.Quantidade += quantidade;
            Console.Write(" -> " + this.Quantidade + ")");
        }
    }
}