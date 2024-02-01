using TestFunctions;
using static System.Net.Mime.MediaTypeNames;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        // --- F1 TESTS ---
        [TestMethod]
        public void TTT()
        {
            Tests functions = new Tests();
            bool expected = true;
            bool actual = functions.F1(true, true, true);
            Assert.AreEqual(expected, actual);
            Console.WriteLine("Expected: " + expected);
            Console.WriteLine("Actual: " + actual);
        }

        [TestMethod]
        public void TFT()
        {
            Tests functions = new Tests();
            bool expected = true;
            bool actual = functions.F1(true, false, true);
            Assert.AreEqual(expected, actual);
            Console.WriteLine("Expected: " + expected);
            Console.WriteLine("Actual: " + actual);
        }

        [TestMethod]
        public void FTF()
        {
            Tests functions = new Tests();
            bool expected = true;
            bool actual = functions.F1(false, true, false);
            Assert.AreEqual(expected, actual);
            Console.WriteLine("Expected: " + expected);
            Console.WriteLine("Actual: " + actual);
        }

        [TestMethod]
        public void TTF()
        {
            Tests functions = new Tests();
            bool expected = true;
            bool actual = functions.F1(true, true, false);
            Assert.AreEqual(expected, actual);
            Console.WriteLine("Expected: " + expected);
            Console.WriteLine("Actual: " + actual);

        }

        [TestMethod]
        public void FTT()
        {
            Tests functions = new Tests();
            bool expected = true;
            bool actual = functions.F1(false,true,true);
            Assert.AreEqual(expected, actual);
            Console.WriteLine("Expected: " + expected);
            Console.WriteLine("Actual: " + actual);

        }
        [TestMethod]
        public void FFT()
        {
            Tests functions = new Tests();
            bool expected = true;
            bool actual = functions.F1(false,false, true);
            Assert.AreEqual(expected, actual);
            Console.WriteLine("Expected: " + expected);
            Console.WriteLine("Actual: " + actual);

        }

        [TestMethod]
        public void TFF()
        {
            Tests functions = new Tests();
            bool expected = false;
            bool actual = functions.F1(true, false, false);
            Assert.AreEqual(expected, actual);
            Console.WriteLine("Expected: " + expected);
            Console.WriteLine("Actual: " + actual);

        }

        [TestMethod]
        public void FFF()
        {
            Tests functions = new Tests();
            bool expected = false;
            bool actual = functions.F1(false, false, false);
            Assert.AreEqual(expected, actual);
            Console.WriteLine("Expected: " + expected);
            Console.WriteLine("Actual: " + actual);

        }

        // --- F2 TESTS ---
        [TestMethod]
        public void TTT2()
        {
            Tests functions = new Tests();
            bool expected = false;
            bool actual = functions.F2(true, true, true);
            Assert.AreEqual(expected, actual);
            Console.WriteLine("Expected: " + expected);
            Console.WriteLine("Actual: " + actual);
        }

        [TestMethod]
        public void TTF2()
        {
            Tests functions = new Tests();
            bool expected = true;
            bool actual = functions.F2(true, true, false);
            Assert.AreEqual(expected, actual);
            Console.WriteLine("Expected: " + expected);
            Console.WriteLine("Actual: " + actual);

        }

        [TestMethod]
        public void FTT2()
        {
            Tests functions = new Tests();
            bool expected = false;
            bool actual = functions.F2(false,true,true);
            Assert.AreEqual(expected, actual);
            Console.WriteLine("Expected: " + expected);
            Console.WriteLine("Actual: " + actual);

        }
        [TestMethod]
        public void FFT2()
        {
            Tests functions = new Tests();
            bool expected = true;
            bool actual = functions.F2(false, false, true);
            Assert.AreEqual(expected, actual);
            Console.WriteLine("Expected: " + expected);
            Console.WriteLine("Actual: " + actual);

        }

        [TestMethod]
        public void TFF2()
        {
            Tests functions = new Tests();
            bool expected = true;
            bool actual = functions.F2(true, false, false);
            Assert.AreEqual(expected, actual);
            Console.WriteLine("Expected: " + expected);
            Console.WriteLine("Actual: " + actual);

        }

        [TestMethod]
        public void FFF2()
        {
            Tests functions = new Tests();
            bool expected = true;
            bool actual = functions.F2(false, false, false);
            Assert.AreEqual(expected, actual);
            Console.WriteLine("Expected: " + expected);
            Console.WriteLine("Actual: " + actual);

        }

        [TestMethod]
        public void TFT2()
        {
            Tests functions = new Tests();
            bool expected = true;
            bool actual = functions.F1(true, false, true);
            Assert.AreEqual(expected, actual);
            Console.WriteLine("Expected: " + expected);
            Console.WriteLine("Actual: " + actual);
        }

        [TestMethod]
        public void FTF2()
        {
            Tests functions = new Tests();
            bool expected = true;
            bool actual = functions.F1(false, true, false);
            Assert.AreEqual(expected, actual);
            Console.WriteLine("Expected: " + expected);
            Console.WriteLine("Actual: " + actual);
        }
    }
}