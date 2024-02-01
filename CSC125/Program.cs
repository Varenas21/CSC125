// See https://aka.ms/new-console-template for more information
using System.Numerics;
using TestFunctions;
Tests tests = new Tests();

Console.WriteLine();
Console.WriteLine(tests.F2(false,false,true));

namespace TestFunctions
{
    public class Tests()
    {
        public void Main(string[] args)
        {

        }
        public bool F1(bool bValA, bool bValB, bool bValC)
        {
            // (( A && B ) || ( B || C )) 
            // ^ == One is false the whole thing is false but if both are the same it is that 
            // || == If one is true they are both true but if both are the same it is that

            bool leftValue = true;
            bool rightValue = true;

            //if ((bValA && bValB) || (bValB || bValC)) // ((T && F) || (F || F)) => ( (T) || (F) ) => T
            //{
            // --- LEFT VALUES ---
            if (bValA == bValB) leftValue = bValA;
            else if ((bValA != bValB)) leftValue = !bValB;
            else if ((bValB != bValA)) leftValue = !bValA;

            // --- RIGHT VALUES ---
            if ((bValB == bValC)) rightValue = bValB;
            else if (bValB != true) rightValue = bValC;
            else if (bValC != true) rightValue = bValB;

            // --- BOTH VALUES ---
            if ((leftValue == rightValue) ) return leftValue;
            else if ((rightValue != leftValue)) return rightValue;

            if ((rightValue == leftValue)) return rightValue;
            else if ((leftValue != rightValue)) return leftValue;
            //}
            return false;

        }

        public bool F2(bool bValA, bool bValB, bool bValC)
        {
            // (( A && !C) || !(B && C)) => ((T && !F) || !(T && F) => ((T && T) || (F && T)) => ((T) || (F)) => T
           

            // --- LEFT VALUES ---
            bool leftValue = true;
            bool rightValue = true;
            if (bValA == bValC) leftValue = !bValC;
            else if (bValA != bValC) leftValue = !bValC;
            else if (bValC != bValA) leftValue = !bValA;

            // --- RIGHT VALUES ---

            if (bValB == bValC) rightValue = !bValB;
            else if ((bValB != true)) rightValue = bValC;
            else if ((bValC != true)) rightValue = bValB;

            // -- BOTH VALUES ---
            if ((leftValue == rightValue)) return leftValue;
            else if ((leftValue != rightValue)) return rightValue;
            if (rightValue != leftValue) return rightValue;


            return true;
        }
    }
}

