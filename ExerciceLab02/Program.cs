// There is the exercise for the lab02 

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
            Console.Clear();        // Stating blank !
            
            Console.WriteLine("*******************************************\n" + 
                              "|Hello enter a choice or type quit to exit|\n" + 
                              "|1. exercise 2.1                          |\n" +
                              "|2. exercise 2.2                          |\n" +
                              "|3. exercise 2.3                          |\n" +
                              "|4. exercise 2.4                          |\n" +
                              "|5. exercise 2.5                          |\n" +
                              "|6. exercise 2.6                          |\n" +
                              "|7. exercise 2.7                          |\n" + 
                              "*******************************************");
            switch (Console.ReadLine()) // Read input and case it or reject it
            {
                case "1":
                    Num2dot1();
                    return true;
                
                case "2":
                    Num2dot2();
                    return true;
                
                case "3":
                    Num2dot3();
                    return true;
                case "4":
                    Num2dot4();
                    return true;
                case "5":
                    Num2dot5();
                    return true;
                case "6":
                    Num2dot6();
                    return true;
                case "7":
                    Num2dot7();
                    return true;
                case "quit": // Will return false to Main so it stop the prog
                    Console.Clear(); // Display an exit message
                    Console.WriteLine("thank you, exited without error");
                    return false;

                default: // In case something bad happen aka wrong input
                    return true;
            }
        }

        
        
        
        private static void Num2dot1()
        {
            Console.Clear();        // Stating blank !
            
            // Variable declaration
            int input = 0;
            int result = 0;

            // Main
            Console.ReadLine();
            Console.Clear();
            Console.Write("Entrez un nombre :");
            input = Convert.ToInt32(Console.ReadLine());
            result = input * input;
            Console.WriteLine($"Le carre de {input} est {result}");
            Console.WriteLine("press enter to return to main menu");
            Console.ReadLine();
            Console.Clear();
        }

        private static void Num2dot2()
        {
            Console.Clear();        // Stating blank !
            
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

            Console.WriteLine("press enter to return to main menu");
            Console.ReadLine();
            Console.Clear();
        }

        private static void Num2dot3()
        {
            Console.Clear();        // Stating blank !
            
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
            Console.WriteLine("press enter to return to main menu");
            Console.ReadLine();
            Console.Clear();

        }

        private static void Num2dot4()
        {
            Console.Clear();        // Stating blank !
            // Variable
            double sphere = 0;
            double sphereVolume = 0;
            
            // Main
            Console.WriteLine("Exercise 2.4");
            Console.Write("Entre le diameter de la sphere :");
            sphere = Convert.ToDouble(Console.ReadLine());
            sphereVolume = Math.PI * Math.Pow(sphere, 3) / 3 / 2;
            sphereVolume = Math.Round(sphereVolume, 1);
            Console.WriteLine($"le volume d'une sphere de diamete {sphere} est de {sphereVolume} cm3");
            Console.WriteLine("press enter to return to main menu");
            Console.ReadLine();
            Console.Clear(); 
        }

        private static void Num2dot5()
        {
            Console.Clear();        // Stating blank !
            
            // Varible
            int nombre = 0;
            string validation = "";
            
            // Main
            Console.WriteLine("Divise par 5 mais pas 7");
            Console.Write("Entre un nombre :");
            
            nombre = Convert.ToInt32(Console.ReadLine());
            if ((nombre % 5 ) == 0 && (nombre % 7) != 0)
            {
                Console.WriteLine($"Le nombre {nombre} est valide");
            }
            else
            {
                Console.WriteLine($"Le nombre {nombre} est invalide");
            } 
            
            
            
            Console.WriteLine("press enter to return to main menu");
            Console.ReadLine();
            Console.Clear();
        }

        private static void Num2dot6()
        {
            Console.Clear();        // Stating blank !
            
            // Variable declaration
            bool leapYear = false;
            int year = 0;
            string indicateur= "reguliere";
            
            // Main
            Console.Write("Entrez une annee : ");
            year = Convert.ToInt32(Console.ReadLine());
            
            //Leap year detector !
            if ((year % 400) == 0)
            {
                leapYear = true;
            }
            else if ((year % 100) == 0)
            {
                leapYear = false;
            }
            else if ((year % 4) == 0)
            {
                leapYear = true;
            }
            else
            {
                leapYear = false;
            }
            //-End of leap check
            if (leapYear == true)
            {
                indicateur = "bissextile";
            }
            else
            {
                
            }
            Console.Clear();
            Console.WriteLine($"{year} est une annee {indicateur}");
            Console.WriteLine("press enter to return to main menu");
            Console.ReadLine();
            Console.Clear();
        }

        private static void Num2dot7()
        {
            
            Console.Write("Quel numero de jour de la semaine sommes-nous ? : ");
            switch (Console.ReadLine()) // Read input and case it or reject it
            {
                case "1":
                    Console.WriteLine("Bon dimanche a toi!");
                    break;
                case "2":
                    Console.WriteLine("Bon lundi a toi!");
                    break;
                case "3":
                    Console.WriteLine("Bon mardi a toi!");
                    break;
                case "4":
                    Console.WriteLine("Bon mercredi a toi!");
                    break;
                case "5":
                    Console.WriteLine("Bon jeudi a toi!");
                    break;
                case "6":
                    Console.WriteLine("Bon vendredi a toi!");
                    break;
                case "7" :
                    Console.WriteLine("Bon Samedi a toi!");
                    break;
                default: // In case something bad happen aka wrong input
                    Console.WriteLine("Tu est perdu dans l'espcace toi!");
                    break;
            }
            Console.WriteLine("press enter to return to main menu");
            Console.ReadLine();
            Console.Clear();
        }
    }
}

