using NUnit.Framework;
using System;
namespace comp370_assignments
{
    [TestFixture()]
    public class NUnitTestClass
    {
        [Test()]
        public void ToDegreesTestCase(Angle a, Double b)
        {
            double aInDegrees = a.toDegrees();
            Assert.IsTrue(aInDegrees == b);
        }
        [Test()]
        public void ToRadiansTestCase(Angle a, Double b)
        {

        }
    }
}
