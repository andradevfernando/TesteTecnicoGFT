using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
namespace TesteGFT;
using Teste1;
using Teste2;
using Teste3;
using TesteGFT.Teste4;
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

                        string[] data1 = "Helena 28 03 1989".Split(" ");
                        string[] data2 = "Romeu 21 04 1950".Split(" ");
                        string[] data3 = "Raquel 14 01 2000".Split(" ");
                        string[] data4 = "Enzo 25 12 2021".Split(" ");

                        var cultureInfo = new CultureInfo("pt-BR");

                        string iString = data1[1] + "-" + data1[2] + "-" + data1[3];
                        DateTime Data1 = DateTime.Parse(iString, cultureInfo);

                        string iString1 = data2[1] + "-" + data2[2] + "-" + data2[3];
                        DateTime Data2 = DateTime.Parse(iString1, cultureInfo);

                        string iString2 = data3[1] + "-" + data3[2] + "-" + data3[3];
                        DateTime Data3 = DateTime.Parse(iString2, cultureInfo);

                        string iString3 = data4[1] + "-" + data4[2] + "-" + data4[3];
                        DateTime Data4 = DateTime.Parse(iString3, cultureInfo);

                        CalcularIdade(data1, Data1);
                        CalcularIdade(data2, Data2);
                        CalcularIdade(data3, Data3);
                        CalcularIdade(data4, Data4);


                        break;
                    default:
                        throw new ArgumentOutOfRangeException("Entrada inválida");
                }
                Menu();
                choose = ReadLine().ToUpper();
            }

        }
    }
    public static void CalcularIdade(string[] pessoa, DateTime data)
    {
        // int idade = 0;
        // if (pessoa[1] == "01" || pessoa[1] == "03" || pessoa[1] == "05" || pessoa[1] == "10" || pessoa[1] == "12")
        // {
        //     idade += 31 - int.Parse(pessoa[0]);
        // }
        DateTime hoje = DateTime.Now;
        int anos = new DateTime(DateTime.Now.Subtract(data).Ticks).Year - 1;
        DateTime anoPassado = data.AddYears(anos);
        int meses = 0;
        for (int i = 1; i <= 12; i++)
        {
            if (anoPassado.AddMonths(i) == hoje)
            {
                meses = i;
                break;
            }
            else if (anoPassado.AddMonths(i) >= hoje)
            {
                meses = i - 1;
                break;
            }
        }
        int diasMeses = hoje.Subtract(anoPassado.AddMonths(meses)).Days;
        int diasAnos = hoje.Subtract(anoPassado.AddYears(anos)).Days;
        int dias = diasMeses + diasAnos;
        Console.WriteLine($"A pessoa {pessoa[0]} viveu por {dias} dias");
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

