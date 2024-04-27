using System.Globalization;
using System.Net.Security;

internal class Program
{
    private static void Main(string[] args)
    {
        int anos = 0;
        string nome;
        Double valor;

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
    }
}