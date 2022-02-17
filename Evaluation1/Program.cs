// 1er evaluation of the class programation de base , by Johny Pineault

//Partie pratique
// Exercise 1 , Écrire un programme C# pour demander à l'utilisateur un nombre et ensuite afficher un rectangle de
// 3 colonnes de largeur et 5 lignes de hauteur en utilisant ce chiffre. Par exemple:

/*
byte input;

Console.Write("Entrez un chiffres: ");
input = Byte.Parse(Console.ReadLine());

Console.WriteLine($"{input}{input}{input}");

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"{input} {input}");
}

Console.WriteLine($"{input}{input}{input}");
*/






/* Exercice 2 - les instructions conditionnelles (10 points)
Écrire un programme C# qui demande un nombre à l’utilisateur, puis qui calcule et affiche :
- le carré de ce nombre (si le nombre est entre 0 et 20),
- la racine carrée de ce nombre (si le nombre est plus grand que 20 et plus petit ou égal 100) : vous utilisez la fonction Math.Sqrt(nombre) pour calculer la racine carrée du nombre.
on affiche le message "le nombre dépasse 100..." si le nombre est plus grand que 100.
*/

/*
 
int input;
int result;
Console.Write("Entrez un nombre: ");
input = int.Parse(Console.ReadLine());

if (input <= 20 && input > 0)
{
    result = input * input;
    Console.WriteLine($"Le carre de {input} est {result}");
}else if (input > 20 && input <= 100)
{
    result = (int) Math.Sqrt(input);
    Console.WriteLine($"La racine carree de {input} est {result}");
}
else if (input > 100)
{
    Console.WriteLine("Le nombre depasse 100...");
}
else
{
    Console.WriteLine("Ton entre ne dois pas etre bonne . ex : negatif");
}

*/




/*
Exercice 3 - les boucles ( 20 points)

Écrire un programme C# permettant de résoudre les problèmes suivants (avec un menu) :
1- Calcul de la somme de deux nombres entiers.
2- Calcul de la factorielle de N (N !).
3- Vérifier si un nombre entier A divise un nombre entier B.
4- Calcul du quotient et du reste de la division entière de deux nombres entiers A et B.
5- Vérifier si un caractère donné est une voyelle (voyelles : 'a', 'e', 'i', 'o', 'u', 'y').
6- Permet de permuter (d’échanger) le contenu de deux variables réelles.
7- Étant donné un entier A, calcule sa valeur absolue. vous utilisez la fonction Math.Abs(nombre) pour avoir la valeur absolue d'un nombre.
*/

class Program
{
    static void Main()
    {
        bool showMain = true; // Set showmain to true so the loop can run

        while (showMain) // = while true since showMain is bool
        {
            showMain = MainMenu(); // Call function MainMenu
        }
    }

    private static bool MainMenu()
    {
        Console.Clear(); // Stating blank !

        Console.WriteLine("*******************************************\n" +
                          "|Welcome to exercise Exam  #1             |\n" +
                          "|Hello enter a choice or type quit to exit|\n" +
                          "|1. exercise 3.1                          |\n" +
                          "|2. exercise 3.2                          |\n" +
                          "|3. exercise 3.3                          |\n" +
                          "|4. exercise 3.4                          |\n" +
                          "|5. exercise 3.5                          |\n" +
                          "|6. exercise 3.6                          |\n" +
                          "|7. exercise 3.7                          |\n" +
                          "*******************************************");
        switch (Console.ReadLine()) // Read input and case it or reject it
        {
            case "1":
                Num3dot1();
                return true;
            case "2":
                Num3dot2();
                return true;
            case "3":
                Num3dot3();
                return true;
            case "4":
                Num3dot4();
                return true;
            case "5":
                Num3dot5();
                return true;
            case "6":
                Num3dot6();
                return true;
            case "7":
                Num3dot7();
                return true;

            case "quit": // Will return false to Main so it stop the prog
                Console.Clear(); // Display an exit message
                Console.WriteLine("thank you, exited without error");
                return false;

            default: // In case something bad happen aka wrong input
                return true;
        }
    }



    // Calculate the addition of 2 user input
    private static void Num3dot1()
    {
        // === Variable declaration
        int userInput1 = 0;
        int userInput2 = 0;
        int result = 0;

        // === Main
        Console.Clear();
        Console.WriteLine("Entrez 2 entiers pour avoir leur somme ");
        Console.Write("Entier #1 : ");
        userInput1 = int.Parse(Console.ReadLine());
        Console.Write("Entier #2 : ");
        userInput2 = int.Parse((Console.ReadLine()));
        result = userInput1 + userInput2;
        Console.WriteLine($"La somme de {userInput1} et {userInput2} est de : {result}");

        EndOfFunction();
    }



    // Calcul the factorial of input 
    private static void Num3dot2()
    {
        // === Variable declaration ===
        long result = 1;
        int userInput = 0;
        int tmpCalculation = 0;
        
        // === Main ===
        
        Console.Clear();
        Console.Write("Entre un nombre pour avoir ca factoriel : ");
        userInput = int.Parse(Console.ReadLine());

        tmpCalculation = userInput;
        while (tmpCalculation != 1)
        {
            result = result * tmpCalculation;
            tmpCalculation--;
        }
        Console.WriteLine($"La factoriel de {userInput} est : {result}");
        EndOfFunction();
    }


    // check if a number is divisible by the other input
    private static void Num3dot3()
    {
        // === Variable declaration ===
        int inputA = 0;
        int inputB = 0;

        // === Main ===
        
        Console.Clear();
        Console.WriteLine("Entre 2 entier pour savoir si le B est divisible par le A (B/A)");
        
        Console.Write("Entier A : ");
        inputA = int.Parse(Console.ReadLine());
        Console.Write("Entier B : ");
        inputB = int.Parse(Console.ReadLine());

        if ((inputB % inputA) == 0)
        {
            Console.WriteLine($"Le nombre {inputB} est divisible par {inputA}");
        }
        else
        {
            Console.WriteLine($"Le nombre {inputB} n'est pas divisible par {inputA} !!!");
        }
        EndOfFunction();
    }


    // Calculate the division and the rest
    private static void Num3dot4()
    {
        // === Variable declaration ===
        int inputA = 0;
        int inputB = 0;
        int resultQuo = 0;
        int resultMod = 0;

        // === Main ===
        Console.Clear();
        Console.WriteLine("Entre 2 entier pour avoir le quotient de A/B et le reste");
        
        Console.Write("Entier A : ");
        inputA = int.Parse(Console.ReadLine());
        Console.Write("Entier B : ");
        inputB = int.Parse(Console.ReadLine());

        resultQuo = inputA / inputB;
        resultMod = inputA % inputB;
        
        Console.WriteLine($"Le quotient de {inputA} et {inputB} est de {resultQuo} et a un reste de {resultMod}");

        EndOfFunction();
    }


    // check if user input is a vowel 
    private static void Num3dot5()
    {
        // === Variable declaration
        
        string userInput;
        

        // === Main
        Console.Clear();
        Console.Write("Entre un caractere en minuscule et vous serez si c'est une voyelle ! :");
        userInput = Console.ReadLine();

        switch (userInput)
        {
            case "a":
                Console.WriteLine("C'est bien une voyelle !");
                break;
            case "e":
                Console.WriteLine("C'est bien une voyelle !");
                break;
            case "i":
                Console.WriteLine("C'est bien une voyelle !");
                break;
            case "o":
                Console.WriteLine("C'est bien une voyelle !");
                break;
            case "u":
                Console.WriteLine("C'est bien une voyelle !");
                break;
            case "y":
                Console.WriteLine("C'est bien une voyelle !");
                break;
            default:
                Console.WriteLine("Et bien non, ce n'est pas une voyelle");
                break;
        }
        EndOfFunction();
    }



    private static void Num3dot6()
    {
        // === Variable declaration
        int input_1 = 0;
        int input_2 = 0;
        int tmp = 0;

        // === Main
        Console.Clear();
        Console.WriteLine("Entre 2 entier pour les afficher et les permuter");
        
        Console.Write("Entier 1 : ");
        input_1 = int.Parse(Console.ReadLine());
        Console.Write("Entier 2 : ");
        input_2 = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"La variable 1 : {input_1} et variable 2 : {input_2} vont maintenant etre inverser");
        tmp = input_1;
        input_1 = input_2;
        input_2 = tmp;
        Console.WriteLine($"Maintenant la variable 1 : {input_1} et la variable 2 : {input_2}");
        EndOfFunction();
    }



    private static void Num3dot7()
    {
        int input_1 = 0;

        // === Main
        Console.Clear();
        Console.WriteLine("Entre 1 nombre pour avoir ca valeur absolue :");
        
        Console.Write("Nombre1 : ");
        input_1 = int.Parse(Console.ReadLine());
        Console.WriteLine($"L'abosolue de {input_1} est : {Math.Abs(input_1)}");
        
        EndOfFunction();
    }





    // === when called , pause and ask to press enter to return to main menu
    private static void EndOfFunction()
    {
        Console.WriteLine("\nPress enter to return to main menu");
        Console.ReadLine();
        Console.Clear();
    }
}