// See https://aka.ms/new-console-template for more information




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
                              "|1. exercise 6.1                         |\n" +
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

            Console.Write("Valeur #1 : ");
            input_1 = int.Parse(Console.ReadLine());
            Console.Write("Valeur #2 : ");
            input_2 = int.Parse(Console.ReadLine());
            Console.Write("Valeur #3 : ");
            input_3 = int.Parse(Console.ReadLine());
            Console.Write("Valeur #4 : ");
            input_4 = int.Parse(Console.ReadLine());
            Console.Write("Valeur #5 : ");
            input_5 = int.Parse(Console.ReadLine());
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
            
            for (int i = 0; i < tableau1.Length; i++)       // Let the user input variable for each space in tableau1
            {
                Console.Write($"Entre le nombre #{i+1} : ");
                tableau1[i] = Decimal.Parse(Console.ReadLine());
            }

            sum = Sum(tableau1);
            Console.Write($"La somme de ces {tableau1.Length} est de {sum}");
            
            EndOfFunction();
        }


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
            Console.Write("Entrer x1 : ");
            x1 = int.Parse(Console.ReadLine());
            Console.Write("Entrer y1 : ");
            y1 = int.Parse(Console.ReadLine());
            Console.Write("Entrer x2 : ");
            x2 = int.Parse(Console.ReadLine());
            Console.Write("Entrer y2 : ");
            y2 = int.Parse(Console.ReadLine());
            distance = Distance(x1, x2, y1, y2);
            Console.Write($"La distance entre les points est de {distance}");

            EndOfFunction();
        }


        public static void Num6dot4()
        {
            // === Variable declaration
            int column;
            int range ;
            // === main
            Console.Clear();
            Console.Write("Comment de nombre voulez vous?: ");
            column = int.Parse(Console.ReadLine());
            Console.Write("voulez vous entrer le range des nombre alleatoire ? (y/n)");
            switch (Console.ReadLine())
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
                    break;
            }

           

                EndOfFunction();
        }


        private static void Num6dot5()
        {
            // === Variable declaration

            // === Main

            EndOfFunction();
        }


        private static void Num6dot6()
        {
            // === Variable declaration

            // === Main

            EndOfFunction();
        }


        private static void Num6dot7()
        {
            // === Variable declaration

            // === Main
            EndOfFunction();
        }


        private static void Num6dot8()
        {
            // === Variable declaration

            // === Main

            EndOfFunction();
        }


        private static void Num6dot9()
        {
            // === Variable declaration


            // === Main

            EndOfFunction();
        }


        private static void Num6dot10()
        {
            // === Variable declaration ===

            // === Main ===

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

        private static int Accumulator(int input_1, int input_2, int input_3, int input_4, int input_5)
        {
            return input_1 + input_2 + input_3 + input_4 + input_5;
        }

        // ============
        
        
        private static decimal Sum(decimal[] tableau1)
        {
            decimal sum1 = 0m;
            foreach (var VARIABLE in tableau1)
            {
                sum1 = sum1 + VARIABLE;
            }

            return sum1;
        }
        
        private static double Distance(double x1, double x2, double y1, double y2)
        {
            // === Variable declaration
            
            
            double distance = 0;

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
    }
}