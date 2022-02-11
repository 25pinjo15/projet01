// There is the exercise for the lab03 

namespace ExerciceLab02
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
                            Console.WriteLine("Bravo!\nPress enter to continue");
                            Console.ReadLine();
                        }
                        
            } while (input >= 21 || input <= 9);
        }

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
                              "\n x2 par le resultat jusqua ce que resulat = 0 " +
                              "\nEnter pour continuer");
            Console.ReadLine();
            
        }

        private static void Num3dot4()
        {
            Console.Clear(); // Stating blank !
            // ===Variable
            int  i = 1;
            int factoriel = 1;
            int input;
            
            // ===Main
            Console.Write("Entrez un nombre entier: ");
            input = int.Parse(Console.ReadLine());
            do
            {
                factoriel *= i;
                i++;
            } while (i <= input);

            Console.Write($"Factorial of {input} est: {factoriel}\nPress enter to continue");
            Console.ReadLine();



        }

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
                else    //Then say to retry with the number of guess and increment the try number
                {
                    Console.WriteLine($"Mauvaise reponse essayer de nouveau\n" +
                                      $"Entrez un nombre, vous ete au {nbTry} essai(s)");
                    input = int.Parse(Console.ReadLine());
                    nbTry++;
                }
            } while (input != rdm);
            Console.Clear();
            Console.WriteLine($"Bravo vous avez reussi apres {nbTry} essai(s)\n" +
                              $"Press enter to return to menu");
            Console.ReadLine();


        }

        private static void Num3dot6()
        {
            Console.Clear(); // Stating blank !

            
            // === Varible
            
            int input; // Must not be 0 because the random number could be 0
            int nbTry = 1;
            Random rnd = new Random();  // Create the random 
            int rdm = rnd.Next(0, 51);  // Set a radom to the rdm 
            
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
                else    //Then say to retry with the number of guess and increment the try number
                {
                    Console.WriteLine($"Mauvaise reponse essayer de nouveau\n" +
                                      $"Entrez un nombre, vous ete au {nbTry} essai(s)");
                    input = int.Parse(Console.ReadLine());
                    nbTry++;
                }

                if (input > rdm ) // Message for to big value
                {
                    Console.WriteLine("La valeur est trop grande!\n" +
                                      "Appuyer sur enter pour essayer encore");
                    Console.ReadLine();
                }
                else if (input < rdm)   // Message for to small value
                {
                    Console.WriteLine("La valeur est trop petite!\n" +
                                      "Appuyer sur enter pour essayer encore");
                    Console.ReadLine();
                }
            } while (input != rdm);
            Console.Clear();
            Console.WriteLine($"Bravo vous avez reussi apres {nbTry} essai(s)\n" +
                              $"Press enter to return to menu");
            Console.ReadLine();
            
        }

        private static void Num3dot7()
        {
            
        }
    }
}
