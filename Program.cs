using System;
using System.Collections.Generic;

namespace ExercicioPratico
{
    class Program
    {
        static List<string> nomes = new List<string>();

        static void Main(string[] args)
        {
            int op = 0;
            string nome = null;

            do
            {
                Console.WriteLine("-MENU-");
                Console.WriteLine("1 - Incluir nome");
                Console.WriteLine("2 - Ler os nomes incluidos");
                Console.WriteLine("3 - Alterar");
                Console.WriteLine("4 - Excluir");
                Console.WriteLine("5 - Sair\n");

                Console.WriteLine("Informe a opção desejada:");
                op = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (op)
                {
                    case 1: //Incluir nome

                        Console.WriteLine("Digite o nome:\n");
                        nome = Console.ReadLine();

                        Adicionar(nome);
                        break;

                    case 2: //Ler os nomes incluidos
                        Ler();
                        break;

                    case 3: //Alterar
                        Console.WriteLine("Digite o nome que será alterado:");
                        nome = Console.ReadLine();

                        Alterar(nome);
                        break;

                    case 4: //Excluir
                        Console.WriteLine("Digite o nome que será excluido:");
                        nome = Console.ReadLine();

                        Excluir(nome);
                        break;

                    case 5:
                        break;

                    default:
                        Console.WriteLine("Opção Inválida!\n");
                        break;
                }
            } while (op != 5);

            Console.WriteLine("Pressione qualquer tecla para fechar o programa...");
            Console.ReadKey();

        }

        public static void Adicionar(string nome)
        {
            if (nomes.Count == 0)
            {
                if (!nome.Contains(" ") && nome != null && nome.Length > 0)
                {
                    nomes.Add(nome);
                    Console.WriteLine("Incluido com sucesso!\n");
                }
                else
                {
                    Console.WriteLine("Não foi possivel incluir na lista!\n");
                }
            }
            else
            {
                for (int i = 0; i < nomes.Count; i++)
                {
                    if (nome == nomes[i])
                    {
                        Console.WriteLine("Este nome já existe!\n");
                        break;
                    }

                    else if (i == nomes.Count - 1)
                    {
                        if (!nome.Contains(" ") && nome != null && nome.Length > 0)
                        {
                            nomes.Add(nome);
                            Console.WriteLine("Incluido com sucesso!\n");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Não foi possivel incluir na lista!\n");
                        }
                    }
                }
            }
        }

        public static void Ler()
        {
            for (int i = 0; i < nomes.Count; i++)
            {
                Console.WriteLine(nomes[i]);
            }
            Console.WriteLine("");
        }

        public static void Alterar(string nome)
        {
            int x = new int();

            for (int i = 0; i < nomes.Count; i++)
            {
                if (nome == nomes[i])
                {
                    x = i;
                    Console.WriteLine("Nome encontrado!\n");

                }
            }
            Console.WriteLine("Digite o novo nome:");
            string n = Console.ReadLine();

            for (int i = 0; i < nomes.Count; i++)
            {
                if (n == nomes[i])
                {
                    Console.WriteLine("Este nome já existe!\n");
                    break;
                }

                else if (i == nomes.Count - 1)
                {
                    if (!n.Contains(" ") && n != null && n.Length > 0)
                    {
                        nomes[x] = n;
                        Console.WriteLine("Nome alterado com sucesso!\n");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Não foi possivel alterar!\n");
                    }
                }
            }
        }

        public static void Excluir(string nome)
        {
            for (int i = 0; i < nomes.Count; i++)
            {
                if (nome == nomes[i])
                {
                    nomes.Remove(nomes[i]);
                    Console.WriteLine("Excluido com sucesso!\n");
                    break;
                }

                else if (i == nomes.Count - 1)
                {
                    Console.WriteLine("Nome não encontrado!\n");
                }
            }
        }
    }
}

