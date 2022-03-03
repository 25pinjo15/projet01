// See https://aka.ms/new-console-template for more information


using System.Diagnostics.SymbolStore;
using System.Reflection.Emit;

namespace Laboratoire06
{
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
                              "|Welcome to exercise Labo04               |\n" +
                              "|Hello enter a choice or type quit to exit|\n" +
                              "|1. exercise 6.1                          |\n" +
                              "|2. exercise 6.2                          |\n" +
                              "|3. exercise 6.3                          |\n" +
                              "|4. exercise 6.4                          |\n" +
                              "|5. exercise 6.5                          |\n" +
                              "|6. exercise 6.6                          |\n" +
                              "|7. exercise 6.7                          |\n" +
                              "|8. exercise 6.8                          |\n" +
                              "|9. exercise 6.9                          |\n" +
                              "|10. exercise 6.10                        |\n" +
                              "*******************************************");
            switch (Console.ReadLine()) // Read input and case it or reject it
            {
                case "1":
                    Num6dot1();
                    return true;
                case "2":
                    Num6dot2();
                    return true;
                case "3":
                    Num6dot3();
                    return true;
                case "4":
                    Num6dot4();
                    return true;
                case "5":
                    Num6dot5();
                    return true;
                case "6":
                    Num6dot6();
                    return true;
                case "7":
                    Num6dot7();
                    return true;
                case "8":
                    Num6dot8();
                    return true;
                case "9":
                    Num6dot9();
                    return true;
                case "10":
                    Num6dot10();
                    return true;

                case "quit": // Will return false to Main so it stop the prog
                    Console.Clear(); // Display an exit message
                    Console.WriteLine("thank you, exited without error");
                    return false;

                default: // In case something bad happen aka wrong input
                    return true;
            }
        }

        /*6.1) Écrivez une fonction Accumulator() qui renvoie la somme de cinq nombres entrés par vous
        et passés en paramètres individuellement dans la fonction (ne PAS utiliser de tableaux pour ce
            numéro).
        N.B. Votre fonction accumulator() peut être appelée dans une fonction nommée E01()
        */
        private static void Num6dot1()
        {
            // === Variable declaration
            int input_1 = 0;
            int input_2 = 0;
            int input_3 = 0;
            int input_4 = 0;
            int input_5 = 0;
            int sum = 0;

            // === Main
            Console.Clear();
            Console.WriteLine("Entre 5 valeur pour en avoir la somme :");
            
            input_1 = UserNumberInput("Valeur #1 : ");
            
            input_2 = UserNumberInput("Valeur #2 : ");

            input_3 = UserNumberInput("Valeur #3 : ");

            input_4 = UserNumberInput("Valeur #4 : ");

            input_5 = UserNumberInput("Valeur #5 : ");

            sum = Accumulator(input_1, input_2, input_3, input_4, input_5);
            Console.WriteLine($"La some est de : {sum}");
            EndOfFunction();
        }


        /*6.2) Écrire une fonction Sum() ayant comme paramètres un tableau de nombre et qui retourne la
        somme de tous les éléments du tableau. Le tableau contiendra 5 nombres.
        N.B. Votre fonction peut être appelée dans une fonction nommée E02()
        */
        private static void Num6dot2()
        {
            // === Variable declaration ===
            var tableau1 = new decimal[5];
            decimal sum = 0;

            // === Main ===
            Console.Clear();
            Console.WriteLine("Entrer 5 valeur decimal pour avoir la somme (ex 3,54");

            for (int i = 0; i < tableau1.Length; i++) // Let the user input variable for each space in tableau1
            {
                Console.Write($"Entre le nombre #{i + 1} : ");
                tableau1[i] = Decimal.Parse(Console.ReadLine());
            }

            sum = Sum(tableau1);
            Console.Write($"La somme de ces {tableau1.Length} est de {sum}");

            EndOfFunction();
        }

        /*
         * 6.3) Écrire une fonction Distance() ayant comme paramètres 4 nombres x1, y1 et x2, y2 qui
        représentent les coordonnées de deux points 1 et 2 et qui renvoie la distance entre les points.
         */
        private static void Num6dot3()
        {
            // === Variable declaration ===
            double x1 = 0d;
            double x2 = 0d;
            double y1 = 0d;
            double y2 = 0d;
            double distance = 0d;

            // === Main ===

            Console.Clear();
            Console.WriteLine("Entrer les coordonner de 2 point et vous aurez la distance entre ces 2 :");
            x1 = UserNumberInput("Entrer x1 : ");

            y1 = UserNumberInput("Entrer y1 : ");

            x2 = UserNumberInput("Entrer x2 : ");

            y2 = UserNumberInput("Entrer y2 : ");

            distance = Distance(x1, x2, y1, y2);
            Console.Write($"La distance entre les points est de {distance}");

            EndOfFunction();
        }

        /*
         * 6.4) Écrire une fonction RandomNumbers() ayant en paramètre une quantité de nombre à entrer et
        qui retourne un tableau remplis de nombre aléatoires en 0 et 100 qui sera ensuite affichés à l’écran à
        partir de la fonction E04();. Il faut que l’algorithme ne génère l’objet Random() qu’une seule fois en
        mémoire 
         */
        public static void Num6dot4()
        {
            // === Variable declaration
            string customRange = null;
            int column;
            int range;
            // === main
            Console.Clear();
            Console.Write("Comment de nombre voulez vous?: ");
            column = int.Parse(Console.ReadLine());

            do

            {
                Console.Write("voulez vous entrer le range des nombre alleatoire ? (y/n)");
                customRange = Console.ReadLine();

                switch (customRange)
                {
                    case "y":
                        Console.Write("D'accord , de 0 a ? : ");
                        range = int.Parse(Console.ReadLine());
                        foreach (var VARIABLE in RandomData(column, range))
                        {
                            Console.Write($"{VARIABLE} ");
                        }

                        break;
                    case "n":
                        Console.WriteLine("Ok le range par default sera 0-100");
                        foreach (var VARIABLE in RandomData(column))
                        {
                            Console.Write($"{VARIABLE} ");
                        }

                        break;
                    default:
                        Console.WriteLine("Input invalide !");
                        break;
                }
            } while ((customRange != "y") && (customRange != "n"));

//**************************************************************************************
// TODO
// Im trying to put what is above under a try catch ... 

/*            
            switch (Console.ReadLine())
            {
                case "y":
                    Console.Write("D'accord, de 0 a combien ? : ");
                     int range = int.Parse(Console.ReadLine());
                    break;
                case "n":
                    Console.WriteLine("Le range par default seras de 0-100");
                    break;
            }

            try
            {
                RandomData(column, range);
            }
            catch (Exception)
            {
                RandomData(column);
                throw;
                
                
            }
  */
//************************************************************************************
            EndOfFunction();
        }

        /*
         * 6.5) Écrivez une fonction Power() permettant de calculer la puissance de n’importe quel nombre.
        Exemple 2 à la 4, 10 à la 5. Vous devez bien sur tout coder vous-même, pas le droit d’utiliser de
        fonctions C#. L’algorithme se termine quand l’utilisateur ne veut plus faire de calcul ( N ).
         */
        private static void Num6dot5()
        {
            // === Variable declaration
            int x1;
            int x2;
            string exect = null;
            int result = 0;
            // === Main
            do

            {
                Console.Write("Vouler vous calculer la un nombe x1 avec son exposant x2 ? (y/n)");
                exect = Console.ReadLine();

                switch (exect)
                {
                    case "y":
                        Console.Write("Entre x1 (nombre) : ");
                        x1 = int.Parse(Console.ReadLine());
                        Console.Write("entre x2 (puissance) : ");
                        x2 = int.Parse(Console.ReadLine());
                        result = Power(x1, x2);
                        Console.WriteLine($"Resultat : {result}");
                        break;
                    case "n":
                        Console.WriteLine("Ok ,Merci ! ");
                        break;
                    default:
                        Console.WriteLine("Input invalide !");
                        break;
                }
            } while ((exect != "n"));

            EndOfFunction();
        }

        /*
         * 6.6) Reprenez l’exercice précédent et, si ce n’est pas déjà le cas, transformer la demande de faire
        d’autres calculs en fonction AnotherPower() Qui retourne une valeur booléenne (0 ou 1).
         */
        private static void Num6dot6()
        {
            // === Variable declaration
            bool exectYesNo = false;
            int x1;
            int x2;
            int result = 0;
            // === Main
            Console.Clear();
            do
            {
                exectYesNo = AnotherPpwer();
                if (exectYesNo == true)
                {
                    x1 = UserNumberInput("Entrer x1 (Nombre) : ");

                    x2 = UserNumberInput("Entrer x2 (puissance) : ");

                    result = Power(x1, x2);
                    Console.WriteLine($"Resultat : {result}");
                }
            } while (exectYesNo == true);


            EndOfFunction();
        }
        /*
        * 6.7) Lisez sur les fonctions récursives et créer un programme en C# avec une fonction récursive
        permettant de calculer la factorielle d’un nombre demandé à l’utilisateur.
        */

        private static void Num6dot7()
        {
            // === Variable declaration
            int inputNumber;
            double factorial;
            
            // === Main ===
            Console.Clear();
            inputNumber = UserNumberInput("Entrer un nombre entier pour la factoriel : ");
            
            factorial = Factorial(inputNumber); // Call the function  
            
            Console.WriteLine($"factorial de {inputNumber} est : {factorial}"); // Print result
            
            EndOfFunction();
        }

        /*
        * 6.8) Écrire une fonction Prime() ayant en paramètre un nombre et qui renvoie une valeur booléenne
        si le nombre entré est un nombre premier. L’algorithme se termine lorsque l’utilisateur entre un zéro
        (0). Aucune des fonctions C# ne seront acceptées, vous devez bien sur coder l’algorithme du nombre
        premier.
        */
        private static void Num6dot8()
        {
            // === Variable declaration
            int input = 0;
            bool prime = false;
            // === Main
            Console.Clear();

            input = UserNumberInput("Entrer un nombnre : ");
            
            prime = Prime(input);

            if (prime == true)
            {
                Console.WriteLine($"{input} est un nombre premier.");
            }
            else
            {
                Console.WriteLine($"{input} est un nombre divisible.");
            }

            EndOfFunction();
        }

        /*
        * 6.9) Écrire un programme C# qui demande un nombre x et affiche les x premiers nombre de cette
        série [1, 1, 2, 3, 5, 8, 13, ...] (suite de Fibonacci) en mode récursif.
        Double-défi, écrire proprement la fonction récursive en 2 ligne de code !
         */
        private static void Num6dot9()
        {
            // === Variable declaration
            int position;
            double fibonacci;
            bool tryparse;
            

            // === Main
            Console.Clear();
            position = UserNumberInput("Entrez une position de la suite de fibonacci : ");
            
            fibonacci = Fibonacci(position);
            
            Console.WriteLine($"Le nombre {position} de la suite de Fibonacci est : {fibonacci}");
            EndOfFunction();
        }

        /*
         * 6.10) Inventer un algorithme qui nécessite l’utilisation d’une fonction qui fait appel à une autre
        fonction, toutes deux développées par vous (pas de fonctions C#)
         */
        private static void Num6dot10()
        {
            // === Variable declaration ===
            bool exit = false;
            bool wantSum = false;
            bool tryparse;
            int x1;
            int x2;
            decimal sum = 0;
            
            // === Main ===
            Console.Clear();
            Console.WriteLine("On va cree un array de votre choix");
            var theArray = CreateArray();
            Console.Write("Voulez vous le remplir de nomhre aleatoir ?");
            do
            {
                Console.Write("Voulez vous le remplir de nomhre aleatoir ? (y/n)");
                switch (Console.ReadLine())
                {
                    case "y":
                        Console.WriteLine("De combien a combien ?");
                        x1 = UserNumberInput("De :");
                        x2 = UserNumberInput("A : ");
                        theArray = RandomData2(theArray, x1, x2);
                        exit = true;
                        break;
                    case "n":
                        Console.WriteLine("Okay... un array vide alors.");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("L'entre est invalide");
                        Console.Clear();
                        break;
                }
            } while (exit != true);
            
            Console.WriteLine("Voici votre array :");
            
            foreach (var VARIABLE in theArray)
            {
                Console.Write($" {VARIABLE},");
            }
            Console.WriteLine(); // Line step

            exit = false;       // Reset the variable exit for the selection
            do
            {
                Console.Write("En voulez vous la somme ? (y/n)");
                switch (Console.ReadLine())
                {
                    case "y":
                        
                        //Array.ConvertAll(theArray, x => (decimal)x);
                        
                        sum = Sum2(theArray);
                        exit = true;
                        wantSum = true;
                        break;
                    case "n":
                        Console.WriteLine("Okay... A la prochaine !");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("L'entre est invalide");
                        Console.Clear();
                        break;
                }
            } while (exit != true);

            if (wantSum == true)
            {
                Console.WriteLine($"Voici votre somme : {sum}");
            }
            
            EndOfFunction();
        }


        //#################################################################################
        //================== MENU FONCTION ================================================
        //#################################################################################


        // === when called , pause and ask to press enter to return to main menu
        private static void EndOfFunction()
        {
            Console.WriteLine("\nPress enter to return to main menu");
            Console.ReadLine();
            Console.Clear();
        }

        //#################################################################################
        //================== EXERCISE FUNCTION ============================================
        //#################################################################################

        public static int Accumulator(int input_1, int input_2, int input_3, int input_4, int input_5)
        {
            return input_1 + input_2 + input_3 + input_4 + input_5;
        }

        // ============


        public static decimal Sum(decimal[] tableau1)
        {
            decimal sum1 = 0m;
            foreach (var VARIABLE in tableau1)
            {
                sum1 = sum1 + VARIABLE;
            }

            return sum1;
        }
        
        public static decimal Sum2(int[] tableau1)
        {
            int sum1 = 0;
            foreach (var VARIABLE in tableau1)
            {
                sum1 = sum1 + VARIABLE;
            }

            return sum1;
        }

        public static double Distance(double x1, double x2, double y1, double y2)
        {
            // === Variable declaration
            double distance = 0;
            // === Function main
            distance = Math.Round(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)), 2);
            return distance;
        }

        public static int[] RandomData(int column, int range = 100)
        {
            // === Variable
            var rndTableau = new int[column];
            Random rnd = new Random();

            // === Main of function
            for (int i = 0; i < column; i++)
            {
                rndTableau[i] = rnd.Next(0, range);
            }

            return (rndTableau);
        }

        public static int Power(int x1, int x2)
        {
            // === Variable declaration ===
            int result = x1;

            // === Function main

            for (int i = 1; i < x2; i++)
            {
                result = result * x1;
            }

            return result;
        }

        public static double Factorial(int number)
        {
            if (number == 0)
                return 1;
            return number * Factorial(number - 1); //Recursive call  
        }

        public static bool AnotherPpwer()
        {
            // === Variable declaration
            string exect = null;
            bool cont = false;
            // === Main


            do
            {
                Console.Write("Vouler vous calculer la un nombe x1 avec son exposant x2 ? (y/n)");
                exect = Console.ReadLine();
                switch (exect)
                {
                    case "y":
                        return true;
                    case "n":
                        return false;
                    default:
                        Console.WriteLine("Input invalide !");
                        break;
                }
            } while (exect is not ("y" or "n"));

            return cont; // If anything go bad here I come
        }


        public static bool Prime(int input)
        {
            if (input == 2 || input == 3)
                return true;

            if (input <= 1 || input % 2 == 0 || input % 3 == 0)
                return false;

            for (int i = 5; i * i <= input; i += 6)
            {
                if (input % i == 0 || input % (i + 2) == 0)
                    return false;
            }

            return true;
        }

        public static double Fibonacci(int input)
        {
            if (input <= 2)
            {
                return 1;
            }
            else
            {
                return Fibonacci(input - 1) + Fibonacci(input - 2);
            }
        }

        public static int[] CreateArray()
        {
            // === Variable declaration
            int arraySize;
            string style = null;
            // === Function main
            
            int[] outArray = new int[UserNumberInput("Grosseur de votre tableau ?")];
            return outArray;

        }

        public static int UserNumberInput(string texte = "")
        {
            // === Variable declaration
            int output = 0;
            bool tryParse = false;
            // === Function main

            do
            {
                Console.Write(texte);
                tryParse = int.TryParse(Console.ReadLine(), out output);
            } while (tryParse != true);
            
            return (output);

        }
        
        public static int[] RandomData2(int[] arrayIn, int x1, int x2)
        {
            // === Variable
            
            Random rnd = new Random();

            // === Main of function
            for (int i = 0; i < arrayIn.Length; i++)
            {
                arrayIn[i] = rnd.Next(x1, x2);
            }

            return (arrayIn);
        }
        
        public static string UserStringInput(string texte = "")
        {
            // === Variable declaration
            string output = null;
            // === Function main

            
                Console.WriteLine(texte);
                output = Console.ReadLine();

                return output;

        }
    }
    
}