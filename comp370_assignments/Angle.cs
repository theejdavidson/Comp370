//<pre>
//Angle class   --   copyright 2001, 2014 Information Disciplines, Inc.

//  This value class supports operations on plane angles.

using System;
public struct Angle
{
    double value;                 //  normalized radians


    //  For compatibility with the math libraries and other software
    //  range is (-pi,pi] not [0,2pi), enforced by the following function:  

    void Normalize()
    {
        double twoPi = Math.PI + Math.PI;
        while (value <= -Math.PI) value += twoPi;
        while (value > Math.PI) value -= twoPi;
    }


    //  Constructors
    //  ------------

    public Angle(double rad) { value = rad; Normalize(); }
    public Angle(Angle theta) { value = theta.value; }

    public Angle(int deg, //  Degrees, minutes, seconds
                      int min, //    (Signs should agree
                      int sec) //       for conventional notation.)
    {
        double seconds = sec + 60 * (min + 60 * deg);//Delivers unexpected result
        value = seconds * Math.PI / 648000.0;//TODO: figure out what would correct
        Normalize();
    }
    public Angle(int deg, int min) { this = new Angle(deg, min, 0); }


    //  Accessors
    //  ---------

    public double toDegrees() { return 180.0 * (value / Math.PI); }
    public double toRadians() { return value; }

    //  If the following functions are used often, performance can be improved
    //  by caching the results -- See IDI Date class for example.

    public short Degrees() { return (short)toDegrees(); }
    public short Minutes()
    {
        long result = ((long)(Math.Abs(toDegrees()) * 60.0) % 60);
        return (short)(value >= 0 ? result : -result);
    }
    public short Seconds()
    {
        long result = ((long)(Math.Round(Math.Abs(toDegrees()) * 3600.0)) % 60);
        return (short)(value >= 0 ? result : -result);
    }


    //  Trigonometric functions (for notational consistency and to hide internal 
    //  -----------------------  representation.  User can use other old functions
    //                           by extracting value with  toRadians() accessor)

    public double Cos() { return Math.Cos(value); }
    public double Sin() { return Math.Sin(value); }
    public double Tan() { return Math.Tan(value); }

    public static Angle Arccos(double x) { return new Angle(Math.Acos(x)); }
    public static Angle Arcsin(double x) { return new Angle(Math.Asin(x)); }
    public static Angle Arctan(double y, double x)
    { return new Angle(Math.Atan2(y, x)); }
    public static Angle Arctan(double y) { return new Angle(Arctan(y, 1.0)); }




    //  Conversion functions
    //  --------------------
    public override string ToString()
    {
        char degreeSymbol = (char)176;
        return (value < 0 ? "-" : "")
             + Math.Abs(Degrees()) + degreeSymbol
             + Math.Abs(Minutes()) + '\''
             + Math.Abs(Seconds()) + '\"';
    }


    //  Relational operators
    //  --------------------
    //  WARNING:  Floating point equality test is undependable
    //            Ordering is ambiguous and not transitive, due to normalization.

    public static bool operator ==(Angle ls, Angle rs)
    { return ls.value == rs.value; }
    public static bool operator <(Angle ls, Angle rs)
    { return ls.value < rs.value; }

    public static bool operator <=(Angle ls, Angle rs)
    { return !(ls > rs); }
    public static bool operator !=(Angle ls, Angle rs)
    { return !(ls == rs); }
    public static bool operator >(Angle ls, Angle rs)
    { return rs < ls; }
    public static bool operator >=(Angle ls, Angle rs)
    { return !(ls < rs); }



    //  Operators follow the standard additive pattern
    //  ---------

    public static Angle operator +(Angle ls, Angle rs)
    { return new Angle(ls.value + rs.value); }
    public static Angle operator -(Angle ls, Angle rs)
    { return new Angle(ls.value - rs.value); }
    public static Angle operator -(Angle p)
    { return new Angle(-p.value); }
    public static Angle operator *(Angle ls, double rs)
    { return new Angle(ls.value * rs); }
    public static Angle operator *(double ls, Angle rs)
    { return rs * ls; }
    public static Angle operator /(Angle ls, double rs)
    { return new Angle(ls.value / rs); }
    public static double operator /(Angle ls, Angle rs)
    { return ls.value / rs.value; }

    //  ---------------------------------------

    //  Test Angle (Interim placeholder version)

    public static void Main()
    {
        Console.WriteLine("Testing Angle class");
        Angle p = new Angle(Math.PI / 4);
        Angle q = 4 * p;
        Console.WriteLine("p = " + p);
        Console.WriteLine("q = " + q);
        Console.WriteLine(p * 3);
        Console.WriteLine(p.Sin());
        Console.WriteLine(q / p);

    }

    //public Boolean ToDegreesTest(Angle inputInRadians, Angle outputInRadians)
    //{
    //    return true;
    //}

    //Methods to test: toDegrees, toRadians, 
    //ToDo: find way to cache Degrees, Minutes, Seconds
    //Test all operators
}
