using static System.Console;
using System.Collections.Generic;
using System.Linq;
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

                        // Pessoa.lista.ForEach(i => WriteLine("{0}\t", i.ToString()));
                        break;
                    case "2":
                        Pessoa joao = new("João", 15);
                        Pessoa.lista.Add(joao);

                        Pessoa leandro = new("Leandro", 21);
                        Pessoa.lista.Add(leandro);

                        Pessoa paulo = new("Paulo", 17);
                        Pessoa.lista.Add(paulo);

                        Pessoa jessica = new("Jéssica", 18);
                        Pessoa.lista.Add(jessica);

                        int maiorIdade = Pessoa.lista.Max(Pessoa => Pessoa.Idade);
                        WriteLine($"Maior idade : {maiorIdade}");

                        Pessoa.lista.ForEach(i => WriteLine("{0}\t", i.ToString()));

                        // foreach (Pessoa pessoa in Pessoa.lista)
                        // {
                        //     if (pessoa.Idade < 18)
                        //     {
                        //         Pessoa.lista.Remove(pessoa);
                        //     }
                        // }
                        bool tem = Pessoa.lista.Any(i => i.Nome == "Jéssica");
                        if (tem)
                        {
                            WriteLine("Jéssica está na lista");
                        }

                        break;
                    case "3":

                        string[] numeros = ReadLine().Split(" ");

                        int maior = int.Parse(numeros[0]);

                        for (int i = 1; i < numeros.Length; ++i)
                        {
                            if (int.Parse(numeros[i]) > maior)
                            {
                                maior = int.Parse(numeros[i]);
                            }
                        }
                        WriteLine("Maior = " + maior);

                        int menor = int.Parse(numeros[0]);

                        for (int i = 1; i < numeros.Length; ++i)
                        {
                            if (int.Parse(numeros[i]) < menor)
                            {
                                menor = int.Parse(numeros[i]);
                            }
                        }
                        WriteLine("Menor = " + menor);

                        int soma = int.Parse(numeros[0]);
                        for (int i = 1; i < numeros.Length; ++i)
                        {
                            soma += int.Parse(numeros[i]);
                        }
                        double media = soma / numeros.Length;
                        WriteLine("Média = " + media);

                        string primeiroItem = numeros[0];
                        bool iguais = numeros.Skip(1)
                          .All(s => string.Equals(primeiroItem, s, StringComparison.InvariantCultureIgnoreCase));

                        if (iguais) WriteLine("Os números são iguais");

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

