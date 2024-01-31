using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nImproper:\tMixed:\t\tDecimal:");
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString() + "\t\t" +
            f1.GetMixedFractionString() + "\t\t" +
            f1.GetDecimalValue()
        );

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString() + "\t\t" + 
            f2.GetMixedFractionString() + "\t\t" +
            f2.GetDecimalValue()
        );

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString() + "\t\t" + 
            f3.GetMixedFractionString() + "\t\t" +
            f3.GetDecimalValue()
        );

        Fraction f4 = new Fraction(9, 8);
        Console.WriteLine(f4.GetFractionString() + "\t\t" + 
            f4.GetMixedFractionString() + "\t\t" + 
            f4.GetDecimalValue()
        );

        Console.WriteLine();
    }
}