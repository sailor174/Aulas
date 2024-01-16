using System;
using System.Collections;
using System.Data.Common;

namespace Csharp
{

    // int string bool char double 
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            // id, valor, quantidade
            double[] Óleo = {2, 5, 3};
            double[] Farinha = {1, 10, 3};
            double[] DuziaDeOvos = {3, 20, 3};
            double[] Carne = {0, 15, 3};

            while (true)
            {
                Console.WriteLine("Oque deseja fazer? \n\n[1] adicionar \n[2] atender \n[3] estoque");
                string tarefa = Console.ReadLine();
                Console.Clear();

                if (tarefa == "adicionar" || tarefa == "1")
                {
                    Console.WriteLine("Qual produto deseja adicionar? \n\n[1] Óleo \n[2] Farinha \n[3] Duzia de ovos \n[4] Carne\n\n");
                    string adicionar = Console.ReadLine();


                    if (adicionar == "Óleo" || adicionar == "1" || adicionar == "oleo")
                    {
                        Console.Write("Quantidade: ");
                        Óleo[2] += AlterarQntdProdutos(1, int.Parse(Console.ReadLine()));
                        Console.WriteLine("estoque: " + Óleo[2]);
                    }

                    else if (adicionar == "Farinha" || adicionar == "2")
                    {
                        Console.Write("Quantidade: ");
                        Farinha[2] += AlterarQntdProdutos(1, int.Parse(Console.ReadLine()));
                    }

                    else if (adicionar == "Duzia de ovos" || adicionar == "3" || adicionar == "Ovos")
                    {
                        Console.Write("Quantidade: ");
                        DuziaDeOvos[2] += AlterarQntdProdutos(1, int.Parse(Console.ReadLine()));
                    }

                    else if (adicionar == "Carne" || adicionar == "4")
                    {
                        Console.Write("Quantidade: ");
                        Carne[2] += AlterarQntdProdutos(1, int.Parse(Console.ReadLine()));
                    }
                }
                if (tarefa == "atender" || tarefa == "2")
                {
                    Console.Write("Qual receita deseja fazer? \n[1] Lasanha \n[2] Pastél assado \n[3] Bife acebolado \n[4] Escondidinho de carne\n\n");
                    string atender = Console.ReadLine();
                    Console.Write("\n");

                    if (atender == "1" || atender == "lasanha")
                    {
                        if (Óleo[2] >= 1 && Farinha[2] >= 1 && DuziaDeOvos[2] >= 1 && Carne[2] >= 1)
                        {
                            Console.WriteLine("O garfield iria amar\n");
                            Óleo[2] -= 1;
                            Farinha[2] -= 1;
                            DuziaDeOvos[2] -= 1;
                            Carne[2] -= 1;
                        }
                        else
                        {
                            Console.WriteLine("Garfield ficou sem lasanha\n");
                        }
                    }

                    if (atender == "2" || atender == "Pastél" || atender == "Pastél assado")
                    {
                        if (Farinha[2] >= 1 && DuziaDeOvos[2] >= 0.5 && Carne[2] >= 1)
                        {
                            Console.WriteLine("Pastél feito\n");
                            Farinha[2] -= 1;
                            DuziaDeOvos[2] -= 0.5;
                            Carne[2] -= 1;
                        }
                        else
                        {
                            Console.WriteLine("Sem pastel\n");
                        }
                    }

                    if (atender == "3" || atender == "Bife acebolado")
                    {
                        if (Óleo[2] >= 1 && Carne[2] >= 1)
                        {
                            Console.WriteLine("Fazendo o bife\n");
                            Óleo[2] -= 1;
                            Carne[2] -= 1;
                        }
                        else
                        {
                            Console.WriteLine("Sem bife, uma pena\n");
                        }
                    }

                    if (atender == "4" || atender == "Escondidinho de carne")
                    {
                        if (Farinha[2] >= 1 && Carne[2] >= 1)
                        {
                            Console.WriteLine("fazendo escondidinho\n");
                            Farinha[2] -= 1;
                            Carne[2] -= 1;
                        }
                        else
                        {
                            Console.WriteLine("Os ingredientes se esconderam\n");
                        }
                    }

                }
                
                    if (tarefa == "estoque" || tarefa == "3")
                    {
                        Console.WriteLine("Carne \nQuantidade: " + Carne[2]);
                        Console.WriteLine("Valor: " + Carne[1]);
                        Console.WriteLine("id: " + Carne[0]);
                        
                        Console.WriteLine("\nFarinha \nQuantidade: " + Farinha[2]);
                        Console.WriteLine("Valor: " + Farinha[1]);
                        Console.WriteLine("id: " + Farinha[0]);
                        
                        Console.WriteLine("\nÓleo \nQuantidade: " + Óleo[2]);
                        Console.WriteLine("Valor: " + Óleo[1]);
                        Console.WriteLine("id: " + Óleo[0]);
                        
                        Console.WriteLine("\nDuzia(s) de ovos \nQuantidade: " + DuziaDeOvos[2]);
                        Console.WriteLine("Valor: " + DuziaDeOvos[1]);
                        Console.WriteLine("id: " + DuziaDeOvos[0]);
                        Console.WriteLine("\n");

                    }
            }
            //função pra alterar a quantidade de produtos (se o nome não for indicativo o bastante)
            static int AlterarQntdProdutos(int ação, int QntdAlterar)
            {
                return ação * QntdAlterar;
            }
        }
    }
}