// swap to variable 
int a = 5;
int b = 8;
int c = 2;
int tmp_a;
int tmp_b;
int tmp_c;

Console.WriteLine("Avant permutation a = " + a + " et b = " + b);
tmp_a = a;
tmp_b = b;
a = tmp_b;
b = tmp_a;
Console.WriteLine("Apres permutation a = " + a + " et b = " + b);