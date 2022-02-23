namespace Laboratoire06;

public class E01
{
    public static decimal Sum(decimal[] tableau1)
    {
        decimal sum1 = 0m;
        foreach (var VARIABLE in tableau1)
        {
            sum1 = sum1 + VARIABLE;
        }

        return sum1;
    }
}