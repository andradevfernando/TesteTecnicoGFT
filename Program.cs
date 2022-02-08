using static System.Console;
namespace TesteGFT;
using Teste1;
using Teste2;
using Teste3;
using Teste4;
class Program
{
    static void Main()
    {
        Choose();

        static void Choose()
        {
            Menu();

            string choose = ReadLine();

            while (choose != "X".ToUpper())
            {
                switch (choose)
                {
                    case "1":
                        WriteLine($"{Environment.NewLine}Choose your name:");
                        break;
                    case "2":
                        WriteLine($"{Environment.NewLine}Choose your weapon:");

                        break;
                    case "3":
                        WriteLine($"{Environment.NewLine}Choose monster:");

                        break;
                    case "4":

                        break;
                    default:
                        throw new ArgumentOutOfRangeException("Entrada inválida");
                }
                Menu();
                choose = ReadLine().ToUpper();
            }

        }
    }
    static void Menu()
    {
        WriteLine(@$"
Welcome, choose your option
1- Teste1
2- Teste2
3- Teste3
4- Teste4
X- Sair");
    }
}

