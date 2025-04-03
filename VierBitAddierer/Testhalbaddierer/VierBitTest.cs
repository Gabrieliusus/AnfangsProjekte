using System;
using System.Diagnostics;

namespace vierbitaddierer
{
    [TestFixture]
    class VolladdiererTests
    {
        [Test]
        public static void VierBitaddierer_different_input_returns()
        {
            Console.WriteLine("\nStarte Unittests...");

            Debug.Assert(Volladdierer_.AddBinaryStrings("1110", "1001", 0).Sum == "10111", "Test 1 fehlgeschlagen: 1110 + 1001");
            Debug.Assert(Volladdierer_.AddBinaryStrings("1110", "1001", 0).CarryOut == 1, "Test 2 fehlgeschlagen: CarryOut sollte 0 sein");

            Debug.Assert(Volladdierer_.AddBinaryStrings("1010", "0101", 0).Sum == "1111", "Test 3 fehlgeschlagen: 1010 + 0101");
            Debug.Assert(Volladdierer_.AddBinaryStrings("1010", "0101", 1).Sum == "10000", "Test 4 fehlgeschlagen: 1010 + 0101 + CarryIn");

            Debug.Assert(Volladdierer_.AddBinaryStrings("0", "0", 0).Sum == "0", "Test 5 fehlgeschlagen: 0 + 0");
            Debug.Assert(Volladdierer_.AddBinaryStrings("1", "1", 0).Sum == "10", "Test 6 fehlgeschlagen: 1 + 1");

            Debug.Assert(Volladdierer_.AddBinaryStrings("1111", "1111", 0).Sum == "11110", "Test 7 fehlgeschlagen: 1111 + 1111");
            Debug.Assert(Volladdierer_.AddBinaryStrings("1111", "1111", 1).Sum == "11111", "Test 8 fehlgeschlagen: 1111 + 1111 + CarryIn");

            Console.WriteLine("Alle Unittests erfolgreich bestanden!");
        }
        [Test]
        public static void Volladdierer_differentinput_correctoutputs()
        {
            var firsttest = Volladdierer_.Volladdierer(0, 0, 0);
            Assert.That(firsttest.Sum == 0);
        }
    }
}