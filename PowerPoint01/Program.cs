
int a = 5, result1;
float x = 2.0f;
result1 = (int) (a / x); // will convert the answer to a int so will keep only the 2 of 2.5
Console.WriteLine(result1);


//##################################################################

/*

int a = 4;
int result_int;
float x = 2.0f;
float result_float;
result_float = a / x; // a : 4, x : 2.0f , reusult_float : 4/2.0 => 4.0f / 2.0f => 2.0f // inplicit converstion 
result_int = a / (int) x; //a: 4, x:2.0f => 2 , result_int : 4/2 =>2 // explicit convertion 
Console.WriteLine("float " + result_float + " int " + result_int);

*/

//##################################################################

/*
 
// converttion des valeur

int x = 5;
int y = 2;
double z;
z = x / (double) y;
Console.WriteLine(z);

*/

//##################################################################

/*
int premier = 5, second = 3, coefficient = 2;
double resultat;
double resultat_2;
resultat = (double) (coefficient * premier / second); // we lost the number after the period
resultat_2 = (double) (coefficient * premier /(double) second); //we keep the number after the period
Console.WriteLine("reusltat = " + resultat);
Console.WriteLine("resultat_2 = " + resultat_2);
*/

/*

double a;
double b;
decimal c;
float d;

a = (10 / 3f + 3) / 5d;
b = (10 / 3 + 3) / 5;
c = (10.99m + 11.11m);
d = 10.0f * 2;


Console.WriteLine(" a " + a + "\n b " + b + "\n c " + c + "\n d " + d);

*/

//##################################################################

/*
string a, b, c;
a = "123";
b = "456";
c = a + b;
Console.WriteLine(c);
*/