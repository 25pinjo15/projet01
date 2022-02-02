// Swap 2 variable and display them

int x = 5;
int y = 8;
int tmp_x;


Console.WriteLine("Avant permutation x = " + x + " et y = " + y);
tmp_x = x;
x = y;
y = tmp_x;
Console.WriteLine("Apres permutation x = " + x + " et y = " + y);