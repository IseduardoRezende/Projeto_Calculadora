using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Calculadora
{
    class Program
    {
        enum menu { Soma = 1, Subtração, Divisão, Multiplicação, Potência, Raíz, Sair }
        static void Main(string[] args)
        {
            bool escolheuSair = false; // Condição = Enquanto o usuário não(!) escolher sair, Exiba o menu.
            while (!escolheuSair)    // Quando se coloca sinal de "!" na frente de uma condição, você inverte esta.
            {
                Console.WriteLine("Bem vindo a Console CALC ! Selecione o que deseja:\n");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potência\n6-Raiz\n7-Sair");

                /*string opcaoTXT = Console.ReadLine();
                int opcaoINT = int.Parse(opcaoTXT);     ======= Mesma forma de fazer porém maior;
                menu opcao1 = (menu)opcaoINT;*/

                menu opcao = (menu)int.Parse(Console.ReadLine()); // Forma limpa;

                switch (opcao)
                {
                    case menu.Soma:
                        Soma();
                        break;
                    case menu.Subtração:
                        Subtração();
                        break;
                    case menu.Divisão:
                        Divisão();
                        break;
                    case menu.Multiplicação:
                        Multiplicação();
                        break;
                    case menu.Potência:
                        Potência();
                        break;
                    case menu.Raíz:
                        Raíz();
                        break; 
                    case menu.Sair:
                        escolheuSair = true;
                        break;
                }

                Console.Clear();
            }
        }
        static void Soma()
        {
            Console.WriteLine("Soma de dois números.\n");
            Console.WriteLine("Digite o primero número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int result = a + b;
            Console.WriteLine($"O resultado é: {result}\n");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }
        static void Subtração()
        {
            Console.WriteLine("Subtração entre dois números.\n");
            Console.WriteLine("Digite o primero número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int result = a - b;
            Console.WriteLine($"O resultado é: {result}\n");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }
        static void Divisão()
        {
            Console.WriteLine("Divisão entre dois números.\n");
            Console.WriteLine("Digite o primero número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            float result = (float)a /(float)b;  // Cast = mudando de um tipo para o outro;
            Console.WriteLine($"O resultado é: {result}\n");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }
        static void Multiplicação()
        {
            Console.WriteLine("Multiplicação entre dois números.\n");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int result = a * b;
            Console.WriteLine($"O resultado é: {result}\n");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }
        static void Potência()
        {
           // 2^4 = 2 * 2 * 2 * 2 = 16
            Console.WriteLine("Potência de um número.\n");
            Console.WriteLine("Digite a base: ");
            int basenum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente: ");
            int expo = int.Parse(Console.ReadLine());
            int result = (int)Math.Pow(basenum, expo);

            //            Ponto Flutuantes:
            // FLOAT = 4.000000000, 6 a 9 digitos de precisão;
            // DOUBLE = entre 15 a 17 digitos;
            // DECIMAL = entre 28 a 29 digitos;

            Console.WriteLine($"O resultado é: {result}\n");
            Console.WriteLine("Aperte ENTER parea voltar ao menu");
            Console.ReadLine();
        }
        
        static void Raíz()
        {
            Console.WriteLine("Raíz de um número \n");
            Console.WriteLine("Digite o número: ");
            int a = int.Parse(Console.ReadLine());
            double result = Math.Sqrt(a);
            Console.WriteLine($"O resultado é: {result}\n");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }
    }
}
