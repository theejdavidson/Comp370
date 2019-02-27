//  Integer functions of two integer parameters
//  -------------------------------------------
//  (for COMP 370)
/*

using System;

public class intfuncB
{

    public static
    long gcd(long m, long n)   //  Greatest common divisor
    { return (m % n) == 0 ? n : gcd(n, m % n); }

    public static
    long lcm(long m, long n)   //  Least common multiple      
    { return m * n / gcd(m, n); }

    // ----------------------------

    //  Test driver for gcd and lcm

    public static void Main(string[] args)
    {
        long[,] testCases = new long[6, 2] { { 1, 2 }, { -1, -5 }, { 0, 10}, { 5, 15 }, { 50, 30}, { 50000, 60000} };
        long[,] expectedResults = new long[6, 2] { { 1, 2 }, { -1, -5 }, { 10, 0 }, { 5, 15 }, { 10, 150}, { 10000, 300000} };
    ;xzlckgvjasd;lkfjsadl;kj
        for(int i = 0; i<testCases.GetLength(0); i++)
        {
            long j = testCases[i, 0];
            long k = testCases[i, 1];
            long greatestCommonDivisor = gcd(j, k);
            long leastCommonMultiple = lcm(j, k);
            long expectedGCD = expectedResults[i, 0];
            long expectedLCM = expectedResults[i, 1];
            if(greatestCommonDivisor == expectedGCD && leastCommonMultiple == expectedLCM)
            {
            Console.WriteLine("The greatest common divisor of "
               + j + " and " + k + " is " + greatestCommonDivisor);
            Console.WriteLine("Their least common multiple is " + leastCommonMultiple);
            }
                else
                {
                Console.WriteLine("The test cases " + j + " and " + k + " did not compile with the expected results.");
                }
        }
    }

}
*/