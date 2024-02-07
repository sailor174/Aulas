using System;
using System.ComponentModel.Design;
using System.Reflection;
using ProductComp;

namespace VScode
{
    class Program
    {
        static void Main(string[] args)
        {
            //cria os produtos           nome, quantidade, id, valor
            Products Farinha = new Products("Farinha", 15, 1, 7);
            Products DuziaDeOvos = new Products("DuziaDeOvos", 15, 2, 7);
            Products Oleo = new Products("Oleo", 15, 3, 7);
            Products Carne = new Products("Carne", 15, 4, 7);

            //Variavel para saber o que o usuario deseja fazer
            string atividade = Console.ReadLine();
            atividade = atividade.ToLower();

            if (atividade == "adicionar")
            {
                string produto = Console.ReadLine();
                produto = produto.ToLower();

                if (produto == "farinha")
                {
                    Farinha.AddStock(int.Parse(Console.ReadLine()));
                }
                else if (produto == "duziadeovos" || produto == "ovos")
                {
                    DuziaDeOvos.AddStock(int.Parse(Console.ReadLine()));
                }
                else if (produto == "oleo" || produto == "óleo")
                {
                    Oleo.AddStock(int.Parse(Console.ReadLine()));
                }
                else if (produto ==  "carne")
                {
                    Carne.AddStock(int.Parse(Console.ReadLine()));
                }
            }   
            else if (atividade == "estoque")
            {
                Console.Clear();
                Farinha.PrintStock();
                DuziaDeOvos.PrintStock();
                Oleo.PrintStock();
                Carne.PrintStock();
            }
        }
    }
}