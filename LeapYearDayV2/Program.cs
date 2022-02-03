/* Program to show day number in any given month 
 *
 * === TODO ===
 * - Put thing to detect string as input because it crash :)
 * 
 */

/* Changelog:
 *
 * jan 30 , finalised the program and cleaned the code
 * 
*/


// -Variable decalaration

string monthInput;
byte monthNumber = 0;
int year = 0;
bool leapYear = false;
string leapName = "allo";
byte dayNumber = 0;

// - Array declaration
string[] monthName = {"January", "February", "March", "April", "May", "June", 
            "July", "August", "September", "October", "November", "December"};



// -Main program
Console.WriteLine("#***********************************#\n" + 
                  "Welcome to this not useful program.\n" + 
                  "It show the number of day in any\n" +
                  "given month.\n" +
                  "Please press enter to continue\n" +
                  "#***********************************#");

Console.ReadLine();


// Month Will check if the value is valid otherwise will loop
// and display a message if the value is invalid
while(true) 
{ 
    Console.Clear();
    Console.WriteLine("#***********************************#\n" + 
                      "Enter a month number from 0 to 12 :\n" +
                      "#***********************************#");
    
    //monthNumber = Convert.ToByte(Console.ReadLine());

// *******************************************************************************************************
// Im trying to ignore invalid input like letters since it crash the prog
    
    string tmp;
    tmp = Console.ReadLine();
    //Check for month number and if the value is valid
    // And will display a message if the value is invalid
    switch (Console.ReadLine())
    {
        
        
        case byte n when (n > 0 && n < 13):
          //  Console.WriteLine("it worked"); //debug line
          
            break;

      
        default:
            Console.Clear();
            Console.WriteLine("#***********************************#\n" + 
                              "             Invalid\n" +
                              "Enter a month number from 0 to 12 :\n" +
                              "Press enter to continue :\n" +
                              "#***********************************#");
            Console.ReadLine();
            continue; //restart the loop
    }
    break; //break out of the loop
    
} // End of while


// Year Will check if the value is valid otherwise will loop
// and display a message if the value is invalid
while(true) 
{ 
    Console.Clear();
    Console.WriteLine("#***********************************#\n" + 
                      "Enter a year between 0 and 10 000 :\n" +
                      "#***********************************#");
    
    year = Convert.ToInt32(Console.ReadLine());

    // - Year entry and check if the value is valid 
    switch (year)
    {
        
        
        case int n when (n > 0 && n < 10001):
            Console.WriteLine("year check worked");
            break;

      
        default:
            Console.Clear();
            Console.WriteLine("#***********************************#\n" + 
                              "             Invalid\n" +
                              "Enter a year number from 0 to 10 000 :\n" +
                              "Press enter to continue :\n" +
                              "#***********************************#");
            Console.ReadLine();
            continue; //restart the loop
    }
    break; //break out of the loop
    
} //-End of while


//-Will check if the year is a leap year
// Will modulo the year value to check if the year enter one of this category
if ((year % 400) == 0)
    {
       // Console.WriteLine(" is a leap year.\n", year);
        leapYear = true;
    }

    else if ((year % 100) == 0)
    {
       // Console.WriteLine(" is not a leap year.\n", year);
        leapYear = false;
    }

    else if ((year % 4) == 0)
    {
      //  Console.WriteLine(" is a leap year.\n", year);
        leapYear = true;
    }

    else
    {
       // Console.WriteLine("is not a leap year.\n", year);
        leapYear = false;
    }
//-End of leap check


//- Give the dayNumber and check if its february and leap year

if (monthNumber < 8)
{
    if(monthNumber%2 == 0){
        if (monthNumber == 2)           // check if its february
        {
            if (leapYear == true)
            {
                dayNumber = 29;         // is a leap year so 29
            }
            else
            {
                dayNumber = 28;         // normal year so 28
            }
        }
        
        else
        {
            dayNumber = 30;             // even month so 30 day
        }
        
    }
    
        else
    {
        dayNumber = 31;                 // odd month so 31
    }
}
else
{
    if (monthNumber%2 == 0)
    {
        dayNumber = 31;
    }
    else
    {
        dayNumber = 30;
    }
}





// End of dayNumber write

if (leapYear == true)
{
    leapName = "leap";
}
else
{
    leapName = "normal";
}
//-Write final answer

Console.Clear();
Console.WriteLine("#***********************************#\n" + 
                  "The month: " + monthName[monthNumber - 1] + "\n"+ // substract 1 to fit the array since 0-11 not 1-12
                  "contain: " + dayNumber + " days\n" + 
                  "and the year "+ year + " is a " + leapName + " year\n" +
                  "#***********************************#");

//- End final answer