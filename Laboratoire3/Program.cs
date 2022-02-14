// There is the exercise for the lab03 

namespace Laboratoire3
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
                              "|Welcome to exercise labo03               |\n" +
                              "|Hello enter a choice or type quit to exit|\n" +
                              "|1. exercise 3.1                          |\n" +
                              "|2. exercise 3.2                          |\n" +
                              "|3. exercise 3.3   et 3.3.1 ...           |\n" +
                              "|4. exercise 3.4                          |\n" +
                              "|5. exercise 3.5                          |\n" +
                              "|6. exercise 3.6                          |\n" +
                              "|7. exercise 3.7                          |\n" +
                              "|8. exercise 3.8                          |\n" +
                              "|9. exercise 3.9                          |\n" +
                              "|10. exercise 3.10                        |\n" +
                              "|11. exercise 3.11                        |\n" +
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
                case "8":
                    Num3dot8();
                    return true;
                case "9":
                    Num3dot9();
                    return true;
                case "10":
                    Num3dot10();
                    return true;
                case "11":
                    Num3dot11();
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
         * Écrire un programme C# avec une boucle « do… while » et un « switch » qui demande à
        l’utilisateur un nombre compris entre 1 et 3 jusqu’à ce que la réponse convienne. Il affiche
        "Ajouter une note" pour le choix 1, "Modifier une note" pour le choix 2 et "Supprimer une
        note" pour le choix 3.
         */
        private static void Num3dot1()
        {
            // === Variable declaration
            int input = 0;

            // === Main
            Console.Clear(); // Stating blank !
            do
            {
                Console.WriteLine("Faite votre choix de menu [1, 2 ou 3");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Ajouter une note\nEnter to continue");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Modifier une note\nEnter to continue");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Suprimer une note \nEnter to continue");
                        Console.ReadLine();
                        break;

                    default:
                        break;
                }
            } while (input >= 4 || input <= 0);
        }


        /*
         * Écrire un programme C# qui demande un nombre compris entre 10 et 20, jusqu’à ce que la
            réponse convienne. En cas de réponse supérieure à 20, on fera apparaître un message : « Plus
            petit ! », et inversement, « Plus grand ! » si le nombre est inférieur à 10.
         */

        private static void Num3dot2()
        {
            Console.Clear(); // Stating blank !
            // === Variable declaration
            int input = 0;

            // === Main
            do
            {
                Console.WriteLine("Entrez un nombre entre 10 et 20 inclusivement");
                input = int.Parse(Console.ReadLine());


                if (input > 20)
                {
                    Console.WriteLine("Plus petit!");
                }
                else if (input < 10)
                {
                    Console.WriteLine("Plus grand!");
                }
                else
                {
                    Console.WriteLine("Bravo!");
                    EndOfFunction();
                }
            } while (input >= 21 || input <= 9);
        }


        /*
         * Analysez le programme C# suivant et répondez aux questions suivantes :
            3.3.1 Quelle est l’instruction qui permet de modifier le résultat du test de sortie de boucle (dans le while ) ?
            3.3.2 Quel sera le résultat en supposant que l’utilisateur entre les valeurs 30 et 42.
            Exécutez le programme à la main (pour vous aider, construisez le tableau de trace des variables).
            3.3.3 Quel sera le résultat en supposant que l’utilisateur entre les valeurs 35 et 6.
            Exécutez le programme à la main (pour vous aider, construisez le tableau de trace des variables).
            3.3.4 Quel est le calcul réalisé par ce programme, a quoi sert ce programme ?
         */
        private static void Num3dot3()
        {
            Console.Clear(); // Stating blank !

            // Variable declaration


            // main

            Console.WriteLine("Reponse 3.3.1 : x1 = x2;");
            Console.WriteLine("Reponse 3.3.2: 6");
            Console.WriteLine("Reponse 3.3.3: 1");
            Console.WriteLine("Reponse 3.3.4: Il calcule le modulo de x1 et x2" +
                              "\net ensuite remplace le x2 par x1 et ensuite remplace" +
                              "\n x2 par le resultat jusqua ce que resulat = 0 ");
            EndOfFunction();
        }


        /*
         * Écrire un programme C# qui demande un nombre à l'utilisateur et calcule sa factorielle.
         */
        private static void Num3dot4()
        {
            Console.Clear(); // Stating blank !
            // ===Variable
            int i = 1;
            ulong factoriel = 1;
            int input;

            // ===Main
            Console.Write("Entrez un nombre entier: ");
            input = int.Parse(Console.ReadLine());
            do
            {
                factoriel *= (ulong) i;
                i++;
            } while (i <= input);

            Console.Write($"Factorial of {input} est: {factoriel}");
            EndOfFunction();
        }


        /*
         * Écrivez un programme de type devinette qui tire un chiffre au hasard entre 0 et 9 et demande
            à l’utilisateur de deviner ce nombre jusqu’à-ce qu’il le trouve. Suivez le étapes suivantes :
            1. Tirer le nombre au hasard
            2. Demander un nombre à l’utilisateur
            3. Tant que le nombre lu est différent du nombre tiré au hasard
                A) Demande un nombre à l’utilisateur
                B) Compter le nombre de boucles (essaie) effectuées
            4. Afficher un message de réussite ainsi que le nombre d’essaies nécessaires
            5. N.B. Pour tirer un nombre aléatoire : new Random().Next(0,9)

         */
        private static void Num3dot5()
        {
            Console.Clear(); // Stating blank !

            // === Varible

            int input; // Must not be 0 because the random number could be 0
            int nbTry = 1;
            Random rnd = new Random();
            int rdm = rnd.Next(0, 10);

            // === Main
            do
            {
                Console.Clear();
                if (nbTry == 1) // Show different message at first try and add 1 to guess number
                {
                    Console.Clear();
                    Console.WriteLine($"Un nombre au hazard entre 0 et 9 inclusivement a ete choisi\n" +
                                      $"Entrez un nombre, vous ete au {nbTry} essai(s)");
                    input = int.Parse(Console.ReadLine());
                    nbTry++;
                }
                else //Then say to retry with the number of guess and increment the try number
                {
                    Console.WriteLine($"Mauvaise reponse essayer de nouveau\n" +
                                      $"Entrez un nombre, vous ete au {nbTry} essai(s)");
                    input = int.Parse(Console.ReadLine());
                    nbTry++;
                }
            } while (input != rdm);

            Console.Clear();
            Console.WriteLine($"Bravo vous avez reussi apres {nbTry} essai(s)");
            EndOfFunction();
        }


        /*
         *  Reprenez le programme précédent (3.5) mais :
                1. En faisant tirer au hasard un nombre entre 0 et 50
                2. Afficher « trop bas/haut » si la valeur devinée est trop petite/grande
         */
        private static void Num3dot6()
        {
            Console.Clear(); // Stating blank !


            // === Varible

            int input; // Must not be 0 because the random number could be 0
            int nbTry = 1;
            Random rnd = new Random(); // Create the random 
            int rdm = rnd.Next(0, 51); // Set a radom to the rdm 

            // === Main
            do
            {
                Console.Clear();
                if (nbTry == 1) // Show different message at first try and add 1 to guess number
                {
                    Console.Clear();
                    Console.WriteLine($"Un nombre au hazard entre 0 et 50 inclusivement a ete choisi\n" +
                                      $"Entrez un nombre, vous ete au {nbTry} essai(s)");
                    input = int.Parse(Console.ReadLine());
                    nbTry++;
                }
                else //Then say to retry with the number of guess and increment the try number
                {
                    Console.WriteLine($"Mauvaise reponse essayer de nouveau\n" +
                                      $"Entrez un nombre, vous ete au {nbTry} essai(s)");
                    input = int.Parse(Console.ReadLine());
                    nbTry++;
                }

                if (input > rdm) // Message for to big value
                {
                    Console.WriteLine("La valeur est trop grande!\n" +
                                      "Appuyer sur enter pour essayer encore");
                    Console.ReadLine();
                }
                else if (input < rdm) // Message for to small value
                {
                    Console.WriteLine("La valeur est trop petite!\n" +
                                      "Appuyer sur enter pour essayer encore");
                    Console.ReadLine();
                }
            } while (input != rdm);

            Console.Clear();
            Console.WriteLine($"Bravo vous avez reussi apres {nbTry} essai(s)");
            EndOfFunction();
        }


        /* 3.7
         * Écrire un programme C# qui demande un nombre de départ qui doit obligatoirement être pair
        (boucle « do… while ») sinon on redemande un nombre, et qui ensuite affiche les dix nombres
        suivants par saut de 2 (boucle « for »). Par exemple, si l'utilisateur entre le nombre 18, le
        programme affichera de 18 à 38.
         */
        private static void Num3dot7()
        {
            // === Variable declaration
            int input = 1;
            int output = 0;

            // === Main
            do
            {
                Console.Clear();
                Console.WriteLine("Entrez un nombre pair :");
                input = int.Parse(Console.ReadLine());
            } while (input % 2 != 0);

            output = input;

            Console.Write("Resultat = [");
            for (int i = 0; i < 10; i++)
            {
                output = output + 2;
                Console.Write($" {output}");
            }
            Console.Write(" ]");
            EndOfFunction();
        }


        /*  3.8) Écrire un programme C# qui demande successivement 5 nombres enter positif à l’utilisateur,
             et qui lui dit ensuite quel était le plus grand parmi ces 5 nombres.
        */
        private static void Num3dot8()
        {
            // === Variable declaration

            int biggest = 0; // variable used in loop , get the biggest of each one
            var test = new int[5]; // array for test number

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

            Console.WriteLine($"Le plus grand nombre est {biggest}");

            EndOfFunction();
        }


        /*
         * 3.9) Écrire un programme C# qui demande un nombre x et affiche les x premiers nombre de cette
        série [1, 1, 2, 3, 5, 8, 13, ...] (suite de Fibonacci).
         */
        private static void Num3dot9()
        {
            // === Variable declaration

            int number1 = 0;
            int number2 = 1;
            int number3;
            int input;

            // === Main
            Console.Clear();
            Console.Write("Entre le nombre d'element de la suite: ");
            input = int.Parse(Console.ReadLine());
            Console.Write(number1 + " " + number2 + " "); // Print 0 and 1    
            for (int i = 2; i < input; ++i) // Loop starts at 2 because 0 and 1 are already printed    
            {
                number3 = number1 + number2;
                Console.Write($"{number3} ");
                number1 = number2; // Make the fibonnaci magic
                number2 = number3;
            }

            EndOfFunction();
        }


        /*
         * Écrire un programme C# qui demande un nombre à l'utilisateur (hauteur) et qui affiche un
            « carré (rectangle) » de cette hauteur avec des « X »
         */
        private static void Num3dot10()
        {
            // === Variable declaration ===
            int input;

            // === Main ===
            Console.Clear();
            Console.Write("Entre hauteur du carre : ");
            input = int.Parse(Console.ReadLine());
            for (int i = 0; i < input; i++)
            {
                Console.WriteLine("XXXXX");
            }

            EndOfFunction();
        }


        /*
         * Écrire un programme C# qui demande un nombre à l'utilisateur (hauteur) et qui affiche une
        pyramide de cette hauteur avec des « X »
         */
        private static void Num3dot11()
        {
            // === Variable declaration ===
            int input; // Used input 
            // === Main ===
            Console.Clear();
            Console.Write("Entre hauteur de la pyramide : ");
            input = int.Parse(Console.ReadLine());
            for (int i = 0; i <= input; i++)             // We roll the thing the number of time we input in it
            {
                // We take input - i (where we are in the loop) and make space on the left with that
                for (int j = 1; j <= input - i; j++)     // We make the space on the left
                {
                    Console.Write(" ");
                }
                
                // We take 2 * the i (where we are in the loop) -1 to get nice pyramid and repeat until the line is done
                for (int k = 1; k <= 2 * i - 1; k++)    // We make the actual pyramid (X)
                {
                    Console.Write("X");
                }

                Console.WriteLine();
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