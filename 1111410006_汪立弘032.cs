using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Roman numeral: " + IntToRoman(number));
    }

    static string IntToRoman(int number)
    {
        if (number < 1 || number > 3999)
            throw new ArgumentOutOfRangeException(nameof(number), "Input must be between 1 and 3999");

        string[] romanNumerals = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        int[] numbers = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

        StringBuilder roman = new StringBuilder();

        for (int i = 0; i < numbers.Length; i++)
        {
            while (number >= numbers[i])
            {
                number -= numbers[i];
                roman.Append(romanNumerals[i]);
            }
        }

        return roman.ToString();
    }
}