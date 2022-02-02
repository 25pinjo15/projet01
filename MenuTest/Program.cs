/* Menu test place
 * Im tryin to learn to make some elaborate console menu and
 * at the same time learning class,function and ect
 *  -> = - > : => = = > 
 */

namespace MenuTest
{
    class Program
    {
        static void Main()
        {
            bool showMain = true;       // Set showmain to true so the loop can run
            
            while (showMain)            // = while true since showMain is bool
            {
                showMain = MainMenu();  // Call function MainMenu


            }
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Hello press 1 for test or type quit to exit");
            switch (Console.ReadLine())     // Read input and case it or reject it
            {
                case "1":
                    CaptureDisplay();
                    return true;
            
                case "quit":        // Will return false to Main so it stop the prog
                    Console.Clear();    // Display an exit message
                    Console.WriteLine("thank you, exited without error");
                    return false;
               
                default:            // In case something bad happen aka wrong input
                    return true;
            }
        }
        
        private static string InputCapture() // this will return inputed value
        {
            Console.Clear();
            Console.Write("enter something to show on screen\n");
            return Console.ReadLine();
        }



        private static void Display(string message)
        {
            Console.Clear();
            Console.WriteLine($"hey your message is here {message}");
            Console.ReadLine();
        }

        private static void CaptureDisplay()
        {
            Console.Clear();
            Display(InputCapture()); // Call display to show inputcapute call
        }

    }
}