using System;
using System.Collections;
using System.Data.Common;
using Estoque;

namespace Csharp
{

    // int string bool char double 
    class Program
    {
        static void Main(string[] args)
        {                        // quantidade, id, valor
            Produto Farinha = new Produto(3, 1, 10);
            Produto Oleo = new Produto(3, 2, 5);
            Produto DuziaDeOvos = new Produto(3, 3, 20);
            Produto Carne = new Produto(3, 4, 15);

            while (true)
            {
                Console.WriteLine("Oque deseja fazer? \n\n[1] adicionar \n[2] atender \n[3] estoque\n");
                string? tarefa = Console.ReadLine();
                Console.Clear();

                if (tarefa == "adicionar" || tarefa == "1")
                {
                    Console.WriteLine("Qual produto deseja adicionar? \n\n[1] Óleo \n[2] Farinha \n[3] Duzia de ovos \n[4] Carne\n");
                    string? adicionar = Console.ReadLine();

                    if (adicionar == "Óleo" || adicionar == "1" || adicionar == "oleo")
                    {
                        Console.Write("Quantidade: ");
                        Oleo.Quantidade += AlterarQntdProdutos(1, Console.ReadLine());

                        // Console.WriteLine("estoque: " + Óleo[2]);
                    }

                    else if (adicionar == "Farinha" || adicionar == "2")
                    {
                        Console.Write("Quantidade: ");
                        Farinha.Quantidade += AlterarQntdProdutos(1, Console.ReadLine());
                        // Console.WriteLine("estoque: " + Farinha[2]);
                    }

                    else if (adicionar == "Duzia de ovos" || adicionar == "3" || adicionar == "Ovos")
                    {
                        Console.Write("Quantidade: ");
                        DuziaDeOvos.Quantidade += AlterarQntdProdutos(1, Console.ReadLine());
                        // Console.WriteLine("estoque: " + DuziaDeOvos[2]);
                    }

                    else if (adicionar == "Carne" || adicionar == "4")
                    {
                        Console.Write("Quantidade: ");
                        Carne.Quantidade += AlterarQntdProdutos(1, Console.ReadLine());
                        // Console.WriteLine("estoque: " + Carne[2]);
                    }
                }
                if (tarefa == "atender" || tarefa == "2")
                {
                    Console.Write("Qual receita deseja fazer? \n[1] Lasanha \n[2] Pastél assado \n[3] Bife acebolado \n[4] Escondidinho de carne\n\n");
                    string? atender = Console.ReadLine();
                    Console.Write("\n");

                    if (atender == "1" || atender == "lasanha")
                    {
                        if (Oleo.Quantidade >= 1 && Farinha.Quantidade >= 1 && DuziaDeOvos.Quantidade >= 1 && Carne.Quantidade >= 1)
                        {
                            Console.WriteLine("O garfield iria amar\n");
                            Oleo.Quantidade -= 1;
                            Farinha.Quantidade -= 1;
                            DuziaDeOvos.Quantidade -= 1;
                            Carne.Quantidade -= 1;
                        }
                        else
                        {
                            Console.WriteLine("Garfield ficou sem lasanha\n");
                        }
                    }

                    if (atender == "2" || atender == "Pastél" || atender == "Pastél assado")
                    {
                        if (Farinha.Quantidade >= 1 && DuziaDeOvos.Quantidade >= 0.5 && Carne.Quantidade >= 1)
                        {
                            Console.WriteLine("Pastél feito\n");
                            Farinha.Quantidade -= 1;
                            DuziaDeOvos.Quantidade -= 0.5;
                            Carne.Quantidade -= 1;
                        }
                        else
                        {
                            Console.WriteLine("Sem pastel\n");
                        }
                    }

                    if (atender == "3" || atender == "Bife acebolado")
                    {
                        if (Oleo.Quantidade >= 1 && Carne.Quantidade >= 1)
                        {
                            Console.WriteLine("Fazendo o bife\n");
                            Oleo.Quantidade -= 1;
                            Carne.Quantidade -= 1;
                        }
                        else
                        {
                            Console.WriteLine("Sem bife, uma pena\n");
                        }
                    }

                    if (atender == "4" || atender == "Escondidinho de carne")
                    {
                        if (Farinha.Quantidade >= 1 && Carne.Quantidade >= 1)
                        {
                            Console.WriteLine("fazendo escondidinho\n");
                            Farinha.Quantidade -= 1;
                            Carne.Quantidade -= 1;
                        }
                        else
                        {
                            Console.WriteLine("Os ingredientes se esconderam\n");
                        }
                    }

                }
                if (tarefa == "estoque" || tarefa == "3")
                {
                    Console.WriteLine("Carne \nQuantidade: " + Carne.Quantidade);
                    Console.WriteLine("Valor: " + Carne.Valor);
                    Console.WriteLine("id: " + Carne.Id);

                    Console.WriteLine("\nFarinha \nQuantidade: " + Farinha.Quantidade);
                    Console.WriteLine("Valor: " + Farinha.Valor);
                    Console.WriteLine("id: " + Farinha.Id);

                    Console.WriteLine("\nÓleo \nQuantidade: " + Oleo.Quantidade);
                    Console.WriteLine("Valor: " + Oleo.Valor);
                    Console.WriteLine("id: " + Oleo.Id);

                    Console.WriteLine("\nDuzia(s) de ovos \nQuantidade: " + DuziaDeOvos.Quantidade);
                    Console.WriteLine("Valor: " + DuziaDeOvos.Valor);
                    Console.WriteLine("id: " + DuziaDeOvos.Id);
                    Console.WriteLine("\n");

                }
            }
            //função pra alterar a quantidade de produtos (se o nome não for indicativo o bastante)
            static int AlterarQntdProdutos(int ação, string QntdAlterar)
            {
                if (QntdAlterar == "")
                {
                    return 0;
                }
                else
                {
                    return ação * int.Parse(QntdAlterar);
                }
            }
        }
    }
}