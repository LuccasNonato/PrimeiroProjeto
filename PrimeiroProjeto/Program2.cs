using System.Globalization;
using System.Net.Security;
using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {
        int anos = 0;
        string nome;
        Double valor;
        string[] vet = Console.ReadLine().Split(' ');
        string NomeVet = vet[0];

        bool Verdadeiro = true;

        if (Verdadeiro == true)
        {
            nome = "Luccas";
            valor = 10.2354;
            anos = 27;

            Console.WriteLine(nome + " tem " + anos + " anos e apenas " + valor.ToString("F2",CultureInfo.InvariantCulture) + " reais");
        }
        else
        {
            Console.WriteLine("False");
        }


        Console.WriteLine("Hello, World!");


        string Nome2;
        int Quartos;
        double PrecoProduto;

    }
}