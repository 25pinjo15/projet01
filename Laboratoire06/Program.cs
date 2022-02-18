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
                              "|10. exercise Bonus 7.2                   |\n" +
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
                case  "10":
                    Num8dot1();
                    return true;
               
                case "quit": // Will return false to Main so it stop the prog
                    Console.Clear(); // Display an exit message
                    Console.WriteLine("thank you, exited without error");
                    return false;

                default: // In case something bad happen aka wrong input
                    return true;
            }
        }


        
    
        private static void Num6dot1()
        {
            // === Variable declaration
            
            // === Main
            
            EndOfFunction();
        }

        private static int Accumulator(int input_1, int input_2, int input_3, int input_4, int input_5)
        {
            return input_1 + input_2 + input_3 + input_4 + input_5;
        }
        

        private static void Num6dot2()
        {
            // === Variable declaration ===

            // === Main ===
            
            EndOfFunction();
        }


        
        private static void Num6dot3()
        {
            // === Variable declaration ===
           
            // === Main ===
            
            EndOfFunction();
        }
        

        
        private static void Num6dot4()
        {
            // === Variable declaration

            // === main

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

        
        
        private static void Num8dot1()
        {
            // === Variable declaration ===
            
            // === Main ===
            
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