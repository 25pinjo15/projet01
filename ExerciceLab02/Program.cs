using System.Diagnostics;

int input = 0;
int result = 0;


Console.WriteLine("#***********************************#\n" +
                  "Welcome to this not useful program.\n" +
                  "This is some exercise we had\n" +
                  "Please press to continue\n" +
                  "#***********************************#");

//*******************2.1****************
Console.ReadLine();
Console.Clear();
Console.Write("Entrez un nombre :");
input = Convert.ToInt32(Console.ReadLine());
result = input * input;
Console.WriteLine($"Le carre de {input} est {result}");
Console.WriteLine("pour le 2.2 press enter");
Console.ReadLine();
Console.Clear();

// ***********2.2************* 
// Variable declaration
decimal prixVente = 0;
decimal TPS = 0.05m;
decimal TPS_Res = 0m;
decimal TVQ = 0.09975m;
decimal TVQ_Res = 0m;
decimal total = 0m;

// Main
Console.Write("quel est le prix de vente  :");
prixVente = Convert.ToDecimal(Console.ReadLine());
TPS_Res = prixVente * TPS;
TVQ_Res = prixVente * TVQ;
total = Math.Round(prixVente + TPS_Res + TVQ_Res, 2);

// To use if you want to display 2 number for tax
TPS_Res = Math.Round(TPS_Res, 2);
TVQ_Res = Math.Round(TVQ_Res, 2);

Console.WriteLine($"Montant  : {prixVente} $\n" +
                  $"TPS      : {TPS_Res} $ \n" +
                  $"TVQ      : {TVQ_Res} $\n" +
                  $"Total    : {total} $\n\n");

Console.WriteLine("press enter to continue to 2.3");
Console.ReadLine();
Console.Clear();


// *************2.3************
// Variable declaration
decimal waterTemp;
string state = "";
// main
Console.WriteLine("Exercise 2.3");
Console.Write($"Entrez est la temperature de l'eau en celcieus : ");
waterTemp = Convert.ToDecimal(Console.ReadLine());
switch (waterTemp)
{
    case >= 100:
        state = "vapeur";
        break;
    case <= 0:
        state = "glace";
        break;
    default:
        state = "liquide";
        break;
}

Console.WriteLine($"L'etat de l'eau est : {state}");
Console.WriteLine("pour passer a 2.4 press enter");
Console.ReadLine();
Console.Clear();

//************************2.4*******************

double sphere = 0;
double sphereVolume = 0;

Console.WriteLine("Exercise 2.4");
Console.Write("Entre le diameter de la sphere :");
sphere = Convert.ToDouble(Console.ReadLine());
sphereVolume = Math.PI * Math.Pow(sphere, 3) / 3 / 2;
sphereVolume = Math.Round(sphereVolume, 1);
Console.WriteLine($"le volume d'une sphere de diamete {sphere} est de {sphereVolume} cm3");
Console.WriteLine("press enter to continue to 2.5");
Console.ReadLine();
Console.Clear();
