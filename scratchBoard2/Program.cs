// See https://aka.ms/new-console-template for more information

// exercise 3.0

int x1, x2, result;
Console.WriteLine("entrez deux entier :");
x1 = int.Parse(Console.ReadLine());
x2 = int.Parse(Console.ReadLine());

do
{
    result = x1 % x2;
    x1 = x2;
    x2 = result;
} while( result != 0);

Console.WriteLine($"Le resultat est {x1}");