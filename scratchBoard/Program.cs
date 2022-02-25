int[] chiffre = new int[20];
int[] chiffretotal = new int[20];


for (int i = 0; i < 20; i++)

{
    do
    {
        Console.Write($"entrez le chiffre # {i + 1} : ");
        chiffre[i] = int.Parse(Console.ReadLine());
        if (chiffre[i] > 9)
        {
            Console.WriteLine("le chiffre est trop grand !");
        }
        else if (chiffre[i] < 0)
        {
            Console.WriteLine("le chiffre est trop petit !");
        }
    } while (chiffre[i] > 9 || chiffre[i] < 0);


}

for (int i = 0; i < 20; i++)
{
    switch (chiffre[i])
    {
        case 0: 
            chiffretotal[0]++;
            break;
        case 1: chiffretotal[1]++;
            break;
        case 2: chiffretotal[2]++;
            break;
        case 3: chiffretotal[3]++;
            break;
        case 4: chiffretotal[4]++;
            break;
        case 5: chiffretotal[5]++;
            break;
        case 6: chiffretotal[6]++;
            break;
        case 7: chiffretotal[7]++;
            break;
        case 8: chiffretotal[8]++;
            break;
        case 9: chiffretotal[9]++;
            break;

    }

    for (int j = 0; j < chiffretotal.Length; j++)
    {
        Console.WriteLine($"le chiffre # {i} ----> {chiffretotal[i]} : "); 
    }
}