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
                            Console.WriteLine("Bravo!");
                            EndOfFunction();
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
                              "\n x2 par le resultat jusqua ce que resulat = 0 ");
            EndOfFunction();
            
        }

        private static void Num3dot4()
        {
            Console.Clear(); // Stating blank !
            // ===Variable
            int  i = 1;
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
            Console.WriteLine($"Bravo vous avez reussi apres {nbTry} essai(s)");
            EndOfFunction();


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
            Console.WriteLine($"Bravo vous avez reussi apres {nbTry} essai(s)");
            EndOfFunction();
            
        }

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
            EndOfFunction();
        }



        private static void Num3dot8()
        {
            // === Variable declaration
            var input1 = 0;
            var input2 = 0;
            var input3 = 0;
            var input4 = 0;
            var input5 = 0;
            int biggest = 0; // variable used in loop , get the biggest of each one
            int b = 0;//set a variable for the array because array start at 0
            
            // === main
            Console.Clear();
            Console.WriteLine("Entrez 5 nombre entier :");
            input1 = int.Parse(Console.ReadLine());
            input2 = int.Parse(Console.ReadLine());
            input3 = int.Parse(Console.ReadLine());
            input4 = int.Parse(Console.ReadLine());
            input5 = int.Parse(Console.ReadLine());
            
            // Will set the value in an array to test it in a for loop
            var test = new int[] {input1, input2, input3, input4, input5};
            
            
                for (int i = 0; i < 5; i++) // Loop to test each variable vs input5
                {
                    
                     
                    int tmp = test[b]; // set a temp value for accessing array
                
                if (tmp > biggest)
                {
                    biggest = tmp;
                }
                

                b++; // Increment b for array acces
                }

                Console.WriteLine($"Le plus grand nombre est {biggest}");
                            
            EndOfFunction();

        }
        
        private static void Num3dot9()
        {
            // === Variable declaration
            int input;
            EndOfFunction();
        }
        
        private static void Num3dot10()
        {
            // === Variable declaration
            int input;
            EndOfFunction();
        }
        
        private static void Num3dot11()
        {
            // === Variable declaration
            int input;
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