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
         * Écrire un programme C# qui demande un nombre compris entre 10 et 20, jusqu’à ce que la
            réponse convienne. En cas de réponse supérieure à 20, on fera apparaître un message : « Plus
            petit ! », et inversement, « Plus grand ! » si le nombre est inférieur à 10.
         */

        private static void Num4dot2()
        {
            EndOfFunction();
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
        private static void Num4dot3()
        {
            // === Variable declaration

            // === Main
            EndOfFunction();
        }


        /*
         * Écrire un programme C# qui demande un nombre à l'utilisateur et calcule sa factorielle.
         */
        private static void Num4dot4()
        {
            // === Variable declaration

            // === Main
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
        private static void Num4dot5()
        {
            // === Variable declaration

            // === Main
            EndOfFunction();
        }


        /*
         *  Reprenez le programme précédent (3.5) mais :
                1. En faisant tirer au hasard un nombre entre 0 et 50
                2. Afficher « trop bas/haut » si la valeur devinée est trop petite/grande
         */
        private static void Num4dot6()
        {
            // === Variable declaration

            // === Main
            EndOfFunction();
        }


        /* 3.7
         * Écrire un programme C# qui demande un nombre de départ qui doit obligatoirement être pair
        (boucle « do… while ») sinon on redemande un nombre, et qui ensuite affiche les dix nombres
        suivants par saut de 2 (boucle « for »). Par exemple, si l'utilisateur entre le nombre 18, le
        programme affichera de 18 à 38.
         */
        private static void Num4dot7()
        {
            // === Variable declaration

            // === Main
            EndOfFunction();
        }


        /*  3.8) Écrire un programme C# qui demande successivement 5 nombres enter positif à l’utilisateur,
             et qui lui dit ensuite quel était le plus grand parmi ces 5 nombres.
        */
        private static void Num4dot8()
        {
            // === Variable declaration

            // === Main
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