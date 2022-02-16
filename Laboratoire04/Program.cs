// There is the exercise for the lab04 

namespace Laboratoire04
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
                              "|1. exercise 4.1                          |\n" +
                              "|2. exercise 4.2                          |\n" +
                              "|3. exercise 4.3                          |\n" +
                              "|4. exercise 4.4                          |\n" +
                              "|5. exercise 4.5                          |\n" +
                              "|6. exercise 4.6                          |\n" +
                              "|7. exercise 4.7                          |\n" +
                              "|8. exercise 4.8                          |\n" +
                              "*******************************************");
            switch (Console.ReadLine()) // Read input and case it or reject it
            {
                case "1":
                    Num4dot1();
                    return true;
                case "2":
                    Num4dot2();
                    return true;
                case "3":
                    Num4dot3();
                    return true;
                case "4":
                    Num4dot4();
                    return true;
                case "5":
                    Num4dot5();
                    return true;
                case "6":
                    Num4dot6();
                    return true;
                case "7":
                    Num4dot7();
                    return true;
                case "8":
                    Num4dot8();
                    return true;
               
                case "quit": // Will return false to Main so it stop the prog
                    Console.Clear(); // Display an exit message
                    Console.WriteLine("thank you, exited without error");
                    return false;

                default: // In case something bad happen aka wrong input
                    return true;
            }
        }


        /*
         Écrire un programme en C# qui initialise un tableau de 10 variables de type byte avec les
        chiffres de 0 à 9 (0, 1, 2, 3, 4, 5, 6, 7, 8 et 9).
         */
        private static void Num4dot1()
        {
            // === Variable declaration
            var tableau = new byte[10] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            // === Main
            EndOfFunction();
        }


        /*
         * Écrire un programme en C# qui demande à l’utilisateur 5 nombres. Il affiche finalement les
nom     bres entrés. L’utilisation d’un tableau est obligatoire.
         */

        private static void Num4dot2()
        {
            // === Variable declaration ===
            int[] input = new int[]{0, 0, 0, 0, 0};
            
            // === Main ===
            Console.Clear();
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Entrez nombre {i+1} : ");
                input[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Les nombre sont :");
            foreach (var VARIABLE in input)
            {
                Console.Write(" "+VARIABLE.ToString());
            }
            
            EndOfFunction();
        }


        /*
         * 4.3) Reprendre l’algorithme précédent et affichez plutôt la moyenne des nombres entrés.
         */
        private static void Num4dot3()
        {
            // === Variable declaration ===
            int[] input = new int[]{0, 0, 0, 0, 0};
            int moy = 0;
            // === Main ===
            Console.Clear();
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Entrez nombre {i+1} : ");
                input[i] = int.Parse(Console.ReadLine());
            }
            
            foreach (var VARIABLE in input)
            {
                moy = moy + VARIABLE;
                
            }
            
            moy = moy / (input.Length);
            Console.WriteLine($"La moyenne des nombre est de : {moy}");
            EndOfFunction();
        }

        


        /*
         * 4.4) Écrire un programme C# qui demande à l’utilisateur 5 nombres. Il affiche ensuite la plus
         *  grande valeur entrée en précisant quelle position réelle (humaine) elle occupe dans le tableau.
         */
        private static void Num4dot4()
        {
            // === Variable declaration

            int biggest = 0;                // variable used in loop , get the biggest of each one
            var test = new int[5];          // array for test number
            int index;                      // Place where the biggest is
            
            // === main

            // Will set the value in an array to test it in a for loop after
            for (int i = 0; i <= 4; i++)
            {
                Console.Clear();
                Console.WriteLine($"entrer le nombre entier # {i + 1}");
                test[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++) // Loop to test each variable vs input5 and write the biggest
            {
                if (test[i] > biggest)
                {
                    biggest = test[i];
                }
            }

            index = Array.IndexOf(test, biggest);

            Console.WriteLine($"Le plus grand nombre est {biggest} et ocupe la place {index+1} dans le tableau");

            EndOfFunction();
        }


        /*
        4.5) Écrire un programme C# qui remplis aléatoirement de chiffres (compris entre 0 et 9) deux
        tableaux de départ de 8 éléments. Il crée ensuite un troisième tableau composé de la
        multiplication des éléments des deux tableaux de même indice et affiche les résultats à l’écran
        comme suit :
         */
        private static void Num4dot5()
        {
            // === Variable declaration
            int[] array1 = new int[8];
            int[] array2 = new int[8];
            int[] result = new int[8];
            Random rnd = new Random();
            // === Main
            for (int i = 0; i < array1.Length; i++)     //Input all value in first array
            {
                array1[i] = rnd.Next(0, 9);
            }
            
            for (int i = 0; i < array2.Length; i++)     // Input all the value in the second array
            {
                array2[i] = rnd.Next(0, 9);
            }
            
            for (int i = 0; i < array1.Length; i++)     //Multiply array1 by array2 and store in result
            {
                result[i] = array1[i] * array2[i];
            }
            Console.Clear();
            Console.WriteLine("Tableau 1 = " + "[{0}]", string.Join(", ", array1));
            Console.WriteLine("Tableau 2 = " + "[{0}]", string.Join(", ", array2));
            Console.WriteLine("Resultats = " + "[{0}]", string.Join(", ", result));
            EndOfFunction();
        }


        /*
        *  4.6) Écrire un programme C# qui demande à l’utilisateur 9 notes à l’utilisateur (sur 100, non
        *nécessaire de valider). Il retourne ensuite le nombre de notes supérieures à la moyenne de la
        *classe. L’affichage doit être identique à celui-ci.
        */
        private static void Num4dot6()
        {
            // === Variable declaration
            int[] note = new int[9];
            int median = 0;
            int nbNoteOver = 0;

            // === Main
            Console.Clear();
            
            for (int i = 0; i < note.Length; i++)    // Enter all the note in the array
            {
                Console.Write($"Entrer note # {i+1} : ");
                note[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < note.Length; i++)   // Add all the array value to the median before calculation
            {
                median = median + note[i];
            }

            median = median / (note.Length);        // Calculate the median by the number of space in the array
            
            for (int i = 0; i < note.Length; i++)   // Compare each value in the array to the median
            {
                if (note[i] > median)
                {
                    nbNoteOver++;                   // Add 1 to nb of note over the median if true
                }
                
            }
            Console.WriteLine($"Nombre de notes > moyenne = {nbNoteOver}");
            EndOfFunction();
        }


        /* 4.7) Écrire un programme en C# qui demande à l’utilisateur à l’utilisateur 20 chiffres (0 à 9 validés
        par le système c’est à dire que si on entre 10, il faut demander à nouveau) et qui construit
        ensuite un tableau contenant le nombre d’occurrence pour chaque chiffre de 0 à 9 et l’affiche
        à l’écran.
         */
        private static void Num4dot7()
        {
            // === Variable declaration
            int[] theArray = new int[20];           // Array for user input
            int[] resultArray = new int [10];       // Array for each time a number is entered
            int input;

            // === Main
            
            for (int i = 0; i < theArray.Length; i++)
            {
                do
                {
                        Console.Clear();
                        Console.Write($"Entrez le chiffre # {i+1} / 20 : ");
                        input = int.Parse(Console.ReadLine());
                        
                    if (input > 9) // Message for to big value
                    {
                        Console.WriteLine("La valeur est trop grande! Entre 0-9 inclus\n" +
                                          "Appuyer sur enter pour essayer encore");
                        Console.ReadLine();
                    }
                    else if (input < 0) // Message for to small value
                    {
                        Console.WriteLine("La valeur est trop petite! Entre 0-9 inclus\n" +
                                          "Appuyer sur enter pour essayer encore");
                        Console.ReadLine();
                    }
                } while (input is > 9 or < 0);

                theArray[i] = input; // When the condition are right the input is set in the correct array
            }

            for (int i = 0; i < theArray.Length; i++) // There is better way to do that but to follow the class 
            {                                         // this will add each time a number is used in another array
                switch (theArray[i])
                {
                    case 0:
                        resultArray[0]++;
                        break;
                    case 1:
                        resultArray[1]++;
                        break;
                    case 2:
                        resultArray[2]++;
                        break;
                    case 3:
                        resultArray[3]++;
                        break;
                    case 4:
                        resultArray[4]++;
                        break;
                    case 5:
                        resultArray[5]++;
                        break;
                    case 6:
                        resultArray[6]++;
                        break;
                    case 7:
                        resultArray[7]++;
                        break;
                    case 8:
                        resultArray[8]++;
                        break;
                    case 9:
                        resultArray[9]++;
                        break;
                    default:
                        Console.WriteLine("You should not see this hehe");
                        break;
                }
            }

            for (int i = 0; i < resultArray.Length; i++)
            {
                Console.WriteLine($"{i} --> {resultArray[i]}"); // Write the result
            }

            
            EndOfFunction();
        }


        /*
         * 4.8) Écrire un programme en C# qui demande à l’utilisateur une quantité déterminée par vous de
         *nombres à entrer et qui affiche ensuite ces nombres triés de façon décroissante.
        */
        private static void Num4dot8()
        {
            
            // === Variable declaration
            int[] theArray = new int[15];           // Array for user input, its scalable by only modifying the array nb
            int input;

            // === Main
            
            for (int i = 0; i < theArray.Length; i++)
            {
               
                    Console.Clear();
                    Console.Write($"Entrez le chiffre # {i+1} / 15 : ");
                    theArray[i] = int.Parse(Console.ReadLine());
            }
            
            Array.Sort(theArray);           // Sort the array in ascending order
            Array.Reverse(theArray);        // Reverse the ascending order to descending
            Console.Write("Voici votre lise en ordre decroissant : ");
            foreach (var value in theArray)     // Print out the result for each value in the array
            {
                Console.Write($" {value},");
            }
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
}

/* Filler nothing to see here
 *
 *
 *
 *
 *
 *
 *
 *
 *
 *
 *
 *
 *
 *
 *
 *
 *
 *
 *
 *
 *
 *
 *
 *
 *
 *
 *
 *
 *
 *
 * 
 */