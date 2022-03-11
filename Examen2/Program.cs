// Examen #2, 10 mars 2022. Johny Pineault

using System;
namespace Examen2
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

            Console.WriteLine("*******************************************\n" + // Nice menu
                              "|Examen 2 du 10 mars 2022                 |\n" + // So Much wow
                              "|Hello enter a choice or type quit to exit|\n" +
                              "|1. exercise   1                          |\n" +
                              "|2. exercise   2                          |\n" +
                              "*******************************************");
            switch (Console.ReadLine()) // Read input and case it or reject it
            {
                case "1": // If 1 is entered, will point to the number 1 program
                    Num1();
                    return true;
                case "2": // If 2 is entered, will point to the number 2 program
                    Num2();
                    return true;

                case "quit": // Will return false to Main so it stop the prog
                    Console.Clear(); // Display an exit message
                    Console.WriteLine("thank you, exited without error");
                    return false;

                default: // In case something bad happen aka wrong input
                    return true;
            }
        }


        // Function for the number one problem
        // Should consider each input check if its good. take in mind the number of student over the average and ect ... 
        private static void Num1()
        {
            Console.Clear(); // Always start nice and clean !!

            // === Variable declaration
            string customRange = null; // used for choice verification
            double moyenne = 0; // Var for the average
            int arraySize = 0; // Var for the array size
            List<int> auDessusMoyene = new List<int>(); // List of the name position wich are over the average

            // === Main

            arraySize = UserNumberInput("Combien d'etudiant avez-vous dans votre classe ? : "); //Ask for array size
            string[] nameArray = new string[arraySize]; // Array for name, created after the array size been asked
            double[] noteArray = new double[arraySize]; // Array for note,created after the array size been asked

            Console.WriteLine("    --->>>>> Saisie des noms <<<<<<---");
            for (int i = 0; i < nameArray.Length; i++)
            {
                nameArray[i] = UserStringInput($"Entrer le nom de votre etudiant.e #{i + 1} : "); // Ask for name in
            }

            Console.WriteLine("    --->>>>> Saisie des notes <<<<<<---");
            for (int i = 0; i < noteArray.Length; i++)
            {
                do
                {
                    // Input note in each array . reepeat if the number is out of range or if its not a number 
                    noteArray[i] = UserNumberInput($"Entrer la note/100 de {nameArray[i]} : ");
                } while ((noteArray[i] < 0) || (noteArray[i] > 100)); // Make sure the note is equal or in betwen
                // 0 - 100
            }

            foreach (var VARIABLE in noteArray)
            {
                moyenne = moyenne + VARIABLE; // Add each note in moyenne to divide it later by the array size
            }

            moyenne = moyenne / arraySize; // Calculate the class average . 
            Math.Round(moyenne, 2); // Round the avergage

            for (int i = 0; i < noteArray.Length; i++)
            {
                if (noteArray[i] > moyenne)
                {
                    auDessusMoyene.Add(i); // If the note is higher than the average , we will add its position in 
                    // is array to a list so we can gatter it later . 
                }
            }

            Console.WriteLine($"La moyene de la classe est : {moyenne}");
            Console.WriteLine($"Les etudiants qui on plus que {moyenne} sont :");

            if (auDessusMoyene.Count > 1) // If there is more than one student over the average display this
            {
                for (int i = 0; i < auDessusMoyene.Count - 1; i++)
                {
                    Console.Write($"{nameArray[auDessusMoyene[i]]}, "); // display the fist(s) name before the last one
                }

                Console.Write($"et {nameArray[auDessusMoyene[auDessusMoyene.Count - 1]]}"); // Write the last name
            }
            else
            {
                Console.Write($"{nameArray[auDessusMoyene[auDessusMoyene.Count - 1]]}"); // Write only 1 name witout "et" 
            }
            
            
            Console.WriteLine();// Just making a new line :)
            
            do
            {
                
                Console.Write("Voulez-vous faire un nouvel calcul de moyenne ? [Tapez O pour oui et N pour non]");
                customRange = Console.ReadLine(); // read with a range to check if everything is good or not

                switch (customRange)
                {
                    case "O":   // If yess we repeat the number 1 
                        Num1();
                        break;
                    case "N":   // If no we exit to main menu
                        Console.WriteLine("Bye ! ");
                       
                        break;
                    default:
                        Console.WriteLine("Input invalide  doit etre majuscule !"); // Easter egg !! 
                        break;
                }
            } while ((customRange != "O") && (customRange != "N")); // Reapeat until we got a right input

            EndOfFunction();
        }


        // Function for the number two problem
       
        public static class GlobalData // Public array to access anywhere 
        {
            public static string[] Question = new string[]
            {
                "Question # 1 : Quelle est la plus grande ville de Cuba ?",
                "Question # 2 : Quelle est la plus grande ville du Canada ?",
                "Question # 3 : Quelle est la capitale du Maroc ?",
                "Question # 4 : Quel est le pays d'hexagone ?",
                "Question # 5 : Quel est le plus grand continent du monde ?",
                "Question # 6 : Quelle est la langue officielle du Brésil ?",
                "Question # 7 : Quelle est la monnaie de l'Argentine ?",
                "Question # 8 : Quelles sont les trois villes les plus propres au monde ?",
                "Question # 9 : Quelle est la ville appelée 'ville ocre' ? ",
                "Question # 10 : Quelle est la capitale de Seychelles ?"
            };
            public static string[] Answer = new string[]
            {
                "La Havane",
                "Toronto",
                "Rabat",
                "France",
                "Asie",
                "Portugais",
                "Peso argentin",
                "Calgary, Wellington et Ifrane",
                "Marrakech",
                "Victoria"
            };
        };
        
        private static void Num2()
        {
            // === Variable declaration ===
            int selection; // Variable for selection and display things 
            
            // === Main ===
            Console.Clear(); // Start clean !!
            
            Console.Write("Bienvenue a question reponse, dites Bonjour :) :");
            Console.ReadLine();
            
            
            for (int i = 0; i < 5; i++) // Repeat 5 time the question/ answer thing 
            {
                Console.WriteLine();
                Console.Write("Question # ");
                selection = GetChoice();
                GetQuestion(selection);
                Console.Write("Votre reponse : ");
                Console.ReadLine();
                GetResponse(selection);

            }
            EndOfFunction();
        }


        // === when called , pause and ask to press enter to return to main menu
        private static void EndOfFunction()
        {
            Console.WriteLine("\nPress enter to return to main menu"); // 
            Console.ReadLine(); // Pause and wait for an input
            Console.Clear();
        }


        
        
        // Function used to enter number input while displaying a phrase and make sure that the input is really a number
        // But can be used to enter number while displaying nothing

        public static int GetChoice()
        {
            // === Variable declaration
            int output = 0; // Used for input output purpose
            bool tryParse = false; // Used for the loop to make sure its a number 
            // === Function main

            do
            {
                tryParse = int.TryParse(Console.ReadLine(), out output); // Try to parse the input 
            } while (tryParse != true); // If try parse success ... continue

            return (output);
        }

        
        
        public static void GetQuestion(int selection)
        {
            Console.SetCursorPosition(0, Console.CursorTop -1); // Go back to rewrite the line
            Console.WriteLine($"{GlobalData.Question[selection-1]}"); // Rewrite the line with the question
        }
        
        
        
        public static void GetResponse(int selection)
        {
            // Show the correct answer with the selection
            Console.WriteLine($"La bonne reponse est : {GlobalData.Answer[selection - 1]}");
        }
        
        
        
        
        
        public static int UserNumberInput(string texte = "")
        {
            // === Variable declaration
            int output = 0; // Used for input output purpose
            bool tryParse = false; // Used for the loop to make sure its a number 
            // === Function main

            do
            {
                Console.Write(texte); // Write asked text
                tryParse = int.TryParse(Console.ReadLine(), out output); // Try to parse the input 
            } while (tryParse != true); // If try parse success ... continue

            return (output);
        }

        
        
        
        
        // Used to read input text . nothing much here . 
        // Will display the parameter if used 
        public static string UserStringInput(string texte = "")
        {
            // === Variable declaration
            string output = null; // Used for I/O purpose
            // === Function main


            Console.Write(texte);
            output = Console.ReadLine();

            return output;
        }
    }
}

/*
        ▄              ▄    
        ▌▒█           ▄▀▒▌   
        ▌▒▒█        ▄▀▒▒▒▐   
       ▐▄█▒▒▀▀▀▀▄▄▄▀▒▒▒▒▒▐   
     ▄▄▀▒▒▒▒▒▒▒▒▒▒▒█▒▒▄█▒▐   
   ▄▀▒▒▒░░░▒▒▒░░░▒▒▒▀██▀▒▌   
  ▐▒▒▒▄▄▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▀▄▒▌  
  ▌░░▌█▀▒▒▒▒▒▄▀█▄▒▒▒▒▒▒▒█▒▐  
 ▐░░░▒▒▒▒▒▒▒▒▌██▀▒▒░░░▒▒▒▀▄▌ 
 ▌░▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒▒▒▒▌ 
▌▒▒▒▄██▄▒▒▒▒▒▒▒▒░░░░░░░░▒▒▒▐ 
▐▒▒▐▄█▄█▌▒▒▒▒▒▒▒▒▒▒░▒░▒░▒▒▒▒▌
▐▒▒▐▀▐▀▒▒▒▒▒▒▒▒▒▒▒▒▒░▒░▒░▒▒▐ 
 ▌▒▒▀▄▄▄▄▄▄▒▒▒▒▒▒▒▒░▒░▒░▒▒▒▌ 
 ▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒░▒▒▄▒▒▐  
  ▀▄▒▒▒▒▒▒▒▒▒▒▒▒▒░▒░▒▄▒▒▒▒▌  
    ▀▄▒▒▒▒▒▒▒▒▒▒▄▄▄▀▒▒▒▒▄▀   
      ▀▄▄▄▄▄▄▀▀▀▒▒▒▒▒▄▄▀     
         ▀▀▀▀▀▀▀▀▀▀▀▀        
*/