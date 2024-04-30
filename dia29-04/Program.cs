// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

bool b4 = 4 != 5;

bool b5 = 4 > 3 && 5 < 4; // && || == !=
Console.WriteLine(b4);
Console.WriteLine(b5);

Console.WriteLine("Digita um número");

int x = int.Parse(Console.ReadLine());

if (x % 2 == 0)
{
    Console.WriteLine("par!");

}
else
{
    Console.WriteLine("impar!"); // validando numeros impares
}



Console.WriteLine("digite as horas");
double Horas = double.Parse(Console.ReadLine());
if (Horas >= 12)
{
    Console.WriteLine("Bom dia");
} else if  (Horas <= 12)
    {
    Console.WriteLine("Boa tarde");
} else if (Horas >= 6)
    {
    Console.WriteLine("Boa Noite");
}


