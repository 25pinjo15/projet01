// =================================== This is a menu template ===========================================


namespace ScrapYard
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
                              "|9. exercise Bonus 7.1                    |\n" +
                              "|10. exercise Bonus 7.2                   |\n" +
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
                case "9":
                    Num7dot1();
                    return true;
                case  "10":
                    Num7dot2();
                    return true;
               
                case "quit": // Will return false to Main so it stop the prog
                    Console.Clear(); // Display an exit message
                    Console.WriteLine("thank you, exited without error");
                    return false;

                default: // In case something bad happen aka wrong input
                    return true;
            }
        }


        
    
        private static void Num4dot1()
        {
            // === Variable declaration
            
            // === Main
            
            EndOfFunction();
        }


        

        private static void Num4dot2()
        {
            // === Variable declaration ===

            // === Main ===
            
            EndOfFunction();
        }


        
        private static void Num4dot3()
        {
            // === Variable declaration ===
           
            // === Main ===
            
            EndOfFunction();
        }
        

        
        private static void Num4dot4()
        {
            // === Variable declaration

            // === main

            EndOfFunction();
        }


        
        private static void Num4dot5()
        {
            // === Variable declaration
         
            // === Main
          
            EndOfFunction();
        }


        
        private static void Num4dot6()
        {
            // === Variable declaration
       
            // === Main
          
            EndOfFunction();
        }


        
        private static void Num4dot7()
        {
            // === Variable declaration
           
            // === Main
            EndOfFunction();
        }


        
        private static void Num4dot8()
        {
            
            // === Variable declaration

            // === Main
            
            EndOfFunction();
        }
        
        
        
        private static void Num7dot1()
        {
            
            // === Variable declaration
            

            // === Main
            
            EndOfFunction();
        }

        
        
        private static void Num7dot2()
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


// =================================== This is something else ============================================

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