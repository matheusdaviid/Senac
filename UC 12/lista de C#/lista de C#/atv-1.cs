using System;
using System.Linq;
using System.Threading;

namespace Sistema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuInicial();
        }

        static void MenuInicial()
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
███████╗██╗░░██╗███████╗██████╗░░█████╗░██╗████████╗░█████╗░███╗░░██╗██████╗░░█████╗░
██╔════╝╚██╗██╔╝██╔════╝██╔══██╗██╔══██╗██║╚══██╔══╝██╔══██╗████╗░██║██╔══██╗██╔══██╗
█████╗░░░╚███╔╝░█████╗░░██████╔╝██║░░╚═╝██║░░░██║░░░███████║██╔██╗██║██║░░██║██║░░██║
██╔══╝░░░██╔██╗░██╔══╝░░██╔══██╗██║░░██╗██║░░░██║░░░██╔══██║██║╚████║██║░░██║██║░░██║
███████╗██╔╝╚██╗███████╗██║░░██║╚█████╔╝██║░░░██║░░░██║░░██║██║░╚███║██████╔╝╚█████╔╝
╚══════╝╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝░╚════╝░╚═╝░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░░╚════╝░");
            Console.WriteLine("EXERCITANDO - Sistema de Atividades");
            Console.ResetColor();

            Console.WriteLine("\nAutor: Seu Nome");
            Console.WriteLine("\nMenu de Opções:");
            Console.WriteLine("00 - Sair");
            Console.WriteLine("01 - Exercício 1: Verificar Positivo, Negativo ou Zero");
            Console.WriteLine("02 - Exercício 2: Maioridade");
            Console.WriteLine("03 - Exercício 3: Par ou Ímpar");
            Console.WriteLine("04 - Exercício 4: Maior de Três Números");
            Console.WriteLine("05 - Exercício 5: Vogal ou Consoante");
            Console.WriteLine("06 - Exercício 6: Situação do Aluno");
            Console.Write("\nEscolha uma opção: ");

            int opcao = int.Parse(Console.ReadLine());
            
            switch (opcao)
            {
                case 00:
                    Console.WriteLine("Saindo...");
                    return;
                case 01:
                    Exercicio1();
                    break;
                case 02:
                    Exercicio2();
                    break;
                case 03:
                    Exercicio3();
                    break;
                case 04:
                    Exercicio4();
                    break;
                case 05:
                    Exercicio5();
                    break;
                case 06:
                    Exercicio6();
                    break;
                default:
                    Console.WriteLine("Opção inválida! Pressione Enter para tentar novamente.");
                    Console.ReadLine();
                    break;
            }
        }

        static void Exercicio1()
        {
            Console.Clear();
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0)
                Console.WriteLine("O número é positivo.");
            else if (numero < 0)
                Console.WriteLine("O número é negativo.");
            else
                Console.WriteLine("O número é zero.");
            Console.ReadLine();
            Thread.Sleep(3000);
            MenuInicial();
        }

        static void Exercicio2()
        {
            Console.Clear();
            Console.Write("Digite a idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
                Console.WriteLine("Maior de idade.");
            else
                Console.WriteLine("Menor de idade.");
            Console.ReadLine();
            Thread.Sleep(3000);
            Console.Clear();
            MenuInicial();
        }

        static void Exercicio3()
        {
            Console.Clear();
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
                Console.WriteLine("O número é par.");
            else
                Console.WriteLine("O número é ímpar.");
            Console.ReadLine();
            Thread.Sleep(3000);
            Console.Clear();
            MenuInicial();
        }

        static void Exercicio4()
        {
            Console.Clear();
            Console.Write("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro número: ");
            int num3 = int.Parse(Console.ReadLine());

            int maior = num1;

            if (num2 > maior)
                maior = num2;
            if (num3 > maior)
                maior = num3;

            Console.WriteLine("O maior número é: " + maior);
            Console.ReadLine();
            Thread.Sleep(3000);
            Console.Clear();
            MenuInicial();
        }

        static void Exercicio5()
        {
            Console.Clear();
            Console.Write("Digite uma letra: ");
            char letra = char.Parse(Console.ReadLine().ToLower());

            if ("aeiou".Contains(letra))
                Console.WriteLine("A letra é uma vogal.");
            else
                Console.WriteLine("A letra é uma consoante.");
            Console.ReadLine();
            Thread.Sleep(3000);
            Console.Clear();
            MenuInicial();
        }

        static void Exercicio6()
        {
            Console.Clear();
            Console.Write("Digite a nota do aluno: ");
            double nota = double.Parse(Console.ReadLine());

            if (nota >= 7)
            { 
                Console.WriteLine("Aprovado.");
            
            Thread.Sleep(3000);
                Console.Clear();
                MenuInicial();
            }
            else if (nota >= 5)
            { 
                Console.WriteLine("Em recuperação.");
            
            Thread.Sleep(3000);
                Console.Clear();
                MenuInicial();
              }
            else
            { 
             Console.WriteLine("Reprovado.");
            
            Thread.Sleep(3000);
                Console.Clear();
                MenuInicial();
            }
        }

    }
}

