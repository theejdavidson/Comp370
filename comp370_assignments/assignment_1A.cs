//  Integer functions of two integer parameters
//  -------------------------------------------
//  (for COMP 370)
/*
using System;
using System.IO;

public class intfuncA
{

    public static
    long gcd(long m, long n)   //  Greatest common divisor
    { return (m % n) == 0 ? n : gcd(n, m % n); }

    public static
    long lcm(long m, long n)   //  Least common multiple      
    { return m * n / gcd(m, n); }

    // ----------------------------

    //  Test driver for gcd and lcm

    public static
    void Main(string[] args)
    {
        // Create a string with a line of text.
        string text = "Test Results:" + Environment.NewLine;

        // Set a variable to the Documents path.
        string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        // Write the text to a new file named "testResults.txt".
        File.WriteAllText(Path.Combine(docPath, "testResults.txt"), text);

        Console.WriteLine("Welcome to the GCD & LCM function testing session!");

        bool testing = true;

        while (testing == true)
        {
            try
            {
                Console.WriteLine("Please enter the first integer, or 'q' to quit the testing session: ");
                string aString = Console.ReadLine();
                if (aString == "q")
                {
                    testing = false;
                }
                long a = long.Parse(aString);
                Console.WriteLine("Please enter the second integer: ");
                string bString = Console.ReadLine();
                long b = long.Parse(bString);

                //performs gcd and lcm operations only once for both console and text file string
                string greatestCommonDivisor = gcd(a, b).ToString();
                string leastCommonMultiple = lcm(a, b).ToString();

                Console.WriteLine("The greatest common divisor of "
                   + a + " and " + b + " is " + greatestCommonDivisor);
                Console.WriteLine("Their least common multiple is " + leastCommonMultiple);

                string[] result = { "first int: " + aString + " || second int: " + bString + " || GCD: " + greatestCommonDivisor + " || LCM: " + leastCommonMultiple };
                // Append new lines of text to the file
                File.AppendAllLines(Path.Combine(docPath, "testResults.txt"), result);
            }
            catch (Exception e)
            {
                if(testing != false)
                Console.WriteLine("Unrecognized input, please enter an integer. ");

            }
        }
        //after testing loop ends, close out text writer
        Console.WriteLine("You can review our documented session in 'testResults.txt. Happy Testing!");
      

    }
}
*/