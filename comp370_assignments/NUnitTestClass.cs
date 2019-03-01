//@author Ethan Davidson
//NUnit test class to test angle methods provided in Angle.cs class
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace comp370_assignments
{
    [TestFixture()]
    public class NUnitTestClass
    {
        readonly List<int> testCases = new List<int>(){
        -15, 0, 15,
         30, 45, 60, 75, 90, 105, 120, 135, 150, 165, 180, 195, 210, 225,
             240, 255, 270, 285, 300, 315, 330, 345, 360, 375
             };

        static Boolean CloseEnough(double a, double b)
        {
            return Math.Abs(a - b) < 0.000001;
        }


        [Test()]
        public void ToDegreesTestCase()
        {
            Assert.AreEqual(new Angle(0).toDegrees(), 0);
            Assert.AreEqual(new Angle(Math.PI).toDegrees(), 180);
            Assert.AreEqual(new Angle(Math.PI / 2).toDegrees(), 90);

        }
        [Test()]
        public void ToRadiansTestCase()
        {
            Assert.AreEqual(new Angle(0).toRadians(), 0);
            Assert.AreEqual(new Angle(180).toRadians(), Math.PI);
            Assert.AreEqual(new Angle(90).toRadians(), Math.PI / 2);
        }
        [Test()]
        public void TestBasics()
        {
            Assert.AreEqual(new Angle(0).Cos(), 1.0);
            Assert.AreEqual(new Angle(0).Sin(), 0.0);
            Assert.AreEqual(new Angle(0).Tan(), 0.0);
            Assert.IsTrue(CloseEnough(new Angle(90).Cos(), 0.0));
            Assert.AreEqual(new Angle(90).Sin(), 1);
            Assert.IsTrue(CloseEnough(new Angle(45).Tan(), 1.0));


            //Testing important trig identities, tan(theta)=sin(theta)/cos(theta)
            //cos^2(theta)+sin^2(theta)= 1
            for (int i = 0; i < testCases.Count; i++)
            {
                Angle a = new Angle(i);
                Assert.IsTrue(CloseEnough(a.Tan(), a.Sin() / a.Cos()));
                Assert.IsTrue(CloseEnough(Math.Pow(a.Cos(), 2) + Math.Pow(a.Sin(), 2), 1));
            }
        }
        [Test()]
        public void TestArcs()
        {
            Assert.AreEqual(Angle.Arccos(.5), new Angle(60));
            Assert.AreEqual(Angle.Arcsin(.5), new Angle(30));
            Assert.AreEqual(Angle.Arctan(1.0), new Angle(45));
        }
        [Test()]
        public void TestOperands()
        {
            for (int i = 0; i <testCases.Count; i++)
            {
                Assert.IsTrue(new Angle(i) == new Angle(i));
                Assert.IsFalse(new Angle(i) < new Angle(i));
                Assert.IsTrue(new Angle(i) <= new Angle(i));
                Assert.IsFalse(new Angle(i) != new Angle(i));
                Assert.IsFalse(new Angle(i) > new Angle(i));
                Assert.IsTrue(new Angle(i) >= new Angle(i));

                Assert.IsTrue((new Angle(i) + new Angle(i)) == (2 * new Angle(i)));
                Assert.IsTrue((new Angle(i) - new Angle(i)) == new Angle(0));

                if (i != 0)
                {
                    double foo = new Angle(i) / new Angle(i);
                    Assert.AreEqual(foo, 1.0);
                }
            }
        }
        [Test()]
        public void TestNormalize()
        {
            Assert.AreEqual(new Angle(4 * Math.PI), new Angle(0));
            Assert.AreEqual(new Angle(5 * Math.PI), new Angle(Math.PI));
            Assert.AreEqual(new Angle(-4 * Math.PI), new Angle(0));
            Assert.IsTrue(CloseEnough(new Angle(5000 * Math.PI).toRadians(), new Angle(0).toRadians()));
        }
    }
}
