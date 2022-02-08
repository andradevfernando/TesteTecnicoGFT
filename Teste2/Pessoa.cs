namespace TesteGFT.Teste2;
using System.Collections.Generic;
public class Pessoa
{
    public string Nome;
    public int Idade;
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
    public static List<Pessoa> lista = new();
    public override string ToString()
    {
        return (Nome + " " + Idade);
    }
}
