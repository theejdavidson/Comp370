using NUnit.Framework;
using System;
namespace comp370_assignments
{
    [TestFixture()]
    public class NUnitTestClass
    {
        [Test()]
        public void ToDegreesTestCase()
        {
            Assert.AreEqual(new Angle(0).toDegrees(), 0);
            Assert.AreEqual(new Angle(Math.PI).toDegrees(), 180);
            Assert.AreEqual(new Angle(Math.PI/2).toDegrees(), 90);

        }
        [Test()]
        public void ToRadiansTestCase()
        {
            Assert.AreEqual(new Angle(0).toRadians(), 0);
            Assert.AreEqual(new Angle(180, 0, 0).toRadians(), Math.PI);
            Assert.AreEqual(new Angle(90, 0, 0).toRadians(), Math.PI / 2);
        }
        [Test()]
        public void TestBasics()
        {
            Angle a = new Angle(90);

            Assert.AreEqual(new Angle(0).Cos(), 1);
            Assert.AreEqual(new Angle(0).Sin(), 0);
            Assert.AreEqual(new Angle(0).Tan(), 0);
            Assert.Less(Math.Abs(new Angle(90, 0, 0).Cos()-0.0), 0.000001);
            Assert.AreEqual(new Angle(90, 0, 0).Sin(), 1);
            Assert.Less(Math.Abs(new Angle(45, 0, 0).Tan()-1.0), 0.000001);

            //Make sure trig identities are covered, tan(theta)=sin(theta)/cos(theta)
            //cos^2(theta)+sin^2(theta)= 1
            Assert.AreEqual(a.Tan(), a.Sin()/a.Cos());
            Assert.AreEqual(Math.Pow(a.Cos(), 2)+Math.Pow(a.Sin(), 2), 1);


        }
        [Test()]
        public void TestArcs()
        {
           Assert.AreEqual(Angle.Arccos(.5), new Angle(60, 0, 0));
           Assert.AreEqual(Angle.Arcsin(.5), new Angle(30, 0, 0));
        }
    }
}
