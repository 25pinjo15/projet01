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

        
        
        // ###########################################################################################################
        
        
        
        // === when called , pause and ask to press enter to return to main menu
        private static void EndOfFunction()
        {
            Console.WriteLine("\nPress enter to return to main menu");
            Console.ReadLine();
            Console.Clear();
        }
        
        
        
        
        // ############################################################################################################

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
    
    
    //#################################################################################################################
    
    
    public static int NewUserNumberInput(int lenght = 1, string texte = "", bool sound = false,
        bool errorHandle = true)
    {
        ConsoleKeyInfo userInput;
        char? userInputString = null;
        string? output = null;
        int finalOutput;
        bool tryParse = false; // Used for try parse if we dont enter number 


        do
        {
            Console.SetCursorPosition(0, Console.CursorTop); // Replace the cursor at the start of the line

            Console.Write(texte); //Write text if there is any

            finalOutput = 0; // Lets reset the value , used with while try parse
            output = null; // Lets reset the value , used with while try parse

            // For the leng of number total we will run it . ex : 05 or 14 is lenght 2 
            for (int i = 0; i < lenght; i++)
            {
                userInput = Console.ReadKey(); // Read the key to special magic char
                userInputString = userInput.KeyChar; // Convert the magic char to only single char
                output = output +
                         userInputString; // Add the char to a string if the number is more than 1 digit

                // If sound is true will beep each time a key is pressed
                if (sound == true)
                {
                    SoundLibrary("beep");
                }
            }

            tryParse = int.TryParse(output, out finalOutput); // Parse the number
                    
            if (errorHandle == false)
            {
                tryParse = true; // Skip the error handling and ship the value as is 
            }
                    
        } while (tryParse != true);
           

        return finalOutput;
    }

    
    
    //##############################################################################################################
    
    public static string UserCharInput(int lenght = 1, string texte = "", bool sound = false)
    {
        ConsoleKeyInfo userInput;
        char? userInputString = null;
        string output = null;

        /*Will return a string of a said lenght with . can show a string of text with console.write
         * will output a beep if sound is true 
         */

        Console.Write(texte); //Write text if there is any


        // For the leng of number total we will run it . ex : 05 or 14 is lenght 2 
        for (int i = 0; i < lenght; i++)
        {
            userInput = Console.ReadKey(); // Read the key to special magic char
            userInputString = userInput.KeyChar; // Convert the magic char to only single char
            output = output +
                     userInputString; // Add the char to a string if the number is more than 1 digit

            // If sound is true will beep each time a key is pressed
            if (sound == true)
            {
                Console.Beep(1500, 100);
            }
        }


        return output;
    }
    
    
    
    // ################################################################################################################
    
    public static void SoundLibrary(string sound = "beep")
    {
        switch (sound)
        {
            case "beep":
                Console.Beep(1500, 100); //Pad press sound
                break;
            case "coin":
                Console.Beep(1300, 100); // Coin sound
                Console.Beep(2500, 100);
                break;
            case "cancel":
                Console.Beep(2600, 100); // Cancel Sound
                Console.Beep(1600, 100);
                Console.Beep(800, 100);
                break;
            case "success":
                Console.Beep(1000, 100); // Success sound
                Console.Beep(2000, 100);
                Console.Beep(3000, 100);
                break;
            case "error":
                Console.Beep(2600, 100); // error Sound
                Console.Beep(800, 100);
                break;
            default:
                Console.Beep(500, 100); // Default sound
                break;
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