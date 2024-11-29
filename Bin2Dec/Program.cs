namespace Bin2Dec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string binaryString = "101";
            decimal decimalValue = BinaryToDecimal(binaryString);
            Console.WriteLine($"The decimal value of binary {binaryString} is {decimalValue}");
        }

        static decimal BinaryToDecimal(string binary)
        {
            decimal decimalValue = 0;
            decimal baseValue = 1;

            for (int i = binary.Length - 1; i >= 0; i--)
            {
                if (binary[i] == '1')
                {
                    decimalValue += baseValue;
                }
                baseValue *= 2;
            }
            return decimalValue;
        }
    }
}
