// Swap 2 variable and display them for: Exercice_01_-les_variables-_a_completer
// Problem 1.6 and 1.7

namespace VariableSwap
{
    class Program
    {
        static void Main()
        {
            // Variable declaration
            // For problem 1.6
            byte x = 5;
            byte y = 8;
            byte tmp_x;
            // For problem 1.7
            byte a = 5;
            byte b = 10;
            byte c = 2;
            byte tmp_c;
            
            // Main program
            Console.WriteLine("There is the problem #1.6 ");
            Console.WriteLine($"Avant permutation x = {x} et y = {y}");
            
            tmp_x = x;
            x = y;
            y = tmp_x;
            
            Console.WriteLine($"Apres permutation x = {x} et y = {y}");
            Console.WriteLine("Press enter to continue to 1.7");
            Console.ReadLine();

           
            
            Console.Clear();
            Console.WriteLine("There is the problem #1.7");
            Console.WriteLine($"Avant permutation a = {a} b = {b} c = {c} ");

            tmp_c = c;
            c = b;
            b = a;
            a = tmp_c;
            
            Console.WriteLine($"Apres permutation a = {a} b = {b} c = {c} ");
        }

    }

}
