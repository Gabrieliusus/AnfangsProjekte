using System;
namespace vierbitaddierer
{
    public class Volladdierer_
    {
        public static (int Sum, int Carry) Volladdierer(int A, int B, int CarryIn)
        {
            int Sum = A ^ B ^ CarryIn;
            int Carry = (A & B) | (B & CarryIn) | (A & CarryIn);

            return (Sum, Carry);
        }

        public static (string Sum, int CarryOut) AddBinaryStrings(string binA, string binB, int carryIn)
        {
            int maxLength = Math.Max(binA.Length, binB.Length);
            binA = binA.PadLeft(maxLength, '0');
            binB = binB.PadLeft(maxLength, '0');

            string result = "";
            int carry = carryIn;

            for (int i = maxLength - 1; i >= 0; i--)
            {
                int bitA = binA[i] - '0';
                int bitB = binB[i] - '0';

                var (sum, newCarry) = Volladdierer(bitA, bitB, carry);
                result = sum + result;
                carry = newCarry;
            }

            if (carry > 0)
            {
                result = carry + result;
            }

            return (result, carry);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Volladdierer für mehrstellige binäre Zahlen\n");

            Console.Write("Geben Sie die erste Binärzahl ein: ");
            string binA = Console.ReadLine();

            Console.Write("Geben Sie die zweite Binärzahl ein: ");
            string binB = Console.ReadLine();

            Console.Write("Geben Sie Carry-In (0 oder 1) ein: ");
            int carryIn = int.Parse(Console.ReadLine());

            var (binarySum, carryOut) = AddBinaryStrings(binA, binB, carryIn);

            int decimalSum = Convert.ToInt32(binarySum, 2);

            Console.WriteLine($"\nErgebnis:\nSumme (binär): {binarySum}\nSumme (dezimal): {decimalSum}\nÜbertrag: {carryOut}");
        }
    }
}