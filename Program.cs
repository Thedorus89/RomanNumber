using System.Text;

internal class Program
{
    public class NumberToRomanConverter
    {
        private static readonly (int Value, string Symbol)[] RomanNumerals = new[]
        {
        (1000, "M"),
        (900, "CM"),
        (500, "D"),
        (400, "CD"),
        (100, "C"),
        (90, "XC"),
        (50, "L"),
        (40, "XL"),
        (10, "X"),
        (9, "IX"),
        (5, "V"),
        (4, "IV"),
        (1, "I")
    };

        public static string ConvertToRoman(int number)
        {
            if (number < 1 || number > 3999)
            {
                throw new ArgumentOutOfRangeException("number", "Input must be between 1 and 3999.");
            }

            StringBuilder result = new StringBuilder();

            foreach (var (value, symbol) in RomanNumerals)
            {
                while (number >= value)
                {
                    result.Append(symbol);
                    number -= value;
                }
            }

            return result.ToString();
        }
    }


    private static void Main(string[] args)
    {
        int[] testNumbers = { 1, 4, 9, 40, 90, 400, 900, 3999 };

        foreach (var number in testNumbers)
        {
            Console.WriteLine($"{number} -> {NumberToRomanConverter.ConvertToRoman(number)}");
        }
    }
}