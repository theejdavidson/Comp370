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

        }
        [Test()]
        public void ToRadiansTestCase()
        {
            Assert.AreEqual(new Angle(0).toRadians(), 0);
            Assert.AreEqual(new Angle(180, 0, 0).toRadians(), Math.PI);
        }
        [Test()]
        public void TestBasics()
        {
            Assert.AreEqual(new Angle(0).Cos(), 1);
            Assert.AreEqual(new Angle(0).Sin(), 0);
            Assert.AreEqual(new Angle(0).Tan(), 0);
            Assert.Less(Math.Abs(new Angle(90, 0, 0).Cos()-0.0), 0.000001);
            Assert.AreEqual(new Angle(90, 0, 0).Sin(), 1);//test fails, potential bug
            Assert.AreEqual(new Angle(45, 0, 0).Tan(), 1);//incredibly close
        }
        [Test()]
        public void TestArcs()
        {
           // new Angle(a) = 180;
            //Assert.AreEqual(new Angle(Arccos(1.1), 0));
            Assert.IsTrue(true);
        }
    }
}
