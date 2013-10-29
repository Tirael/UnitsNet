using System;
using NUnit.Framework;

namespace UnitsNet.Tests.net35
{
    [TestFixture]
    public class AngleTests
    {
        private const double Delta = 1E-5;
        private readonly Angle _degree = Angle.FromDegrees(90);

        [Test]
        public void DegreesToAngleUnits()
        {
            Assert.AreEqual(Math.PI / 2, _degree.Radians, Delta);
            Assert.AreEqual(100, _degree.Gradians, Delta);
        }

        [Test]
        public void AngleUnitsRoundTrip()
        {
            Assert.AreEqual(90, Angle.FromRadians(_degree.Radians).Degrees, Delta);
            Assert.AreEqual(90, Angle.FromGradians(_degree.Gradians).Degrees, Delta);
        }

        [Test]
        public void ArithmeticOperatorsRoundtrip()
        {
            Angle a = Angle.FromDegrees(90);
            Assert.AreEqual(-90, -a.Degrees, Delta);
            Assert.AreEqual(180, (Angle.FromDegrees(270)-a).Degrees, Delta);
            Assert.AreEqual(180, (a + a).Degrees, Delta);
            Assert.AreEqual(900, (a * 10).Degrees, Delta);
            Assert.AreEqual(900, (10 * a).Degrees, Delta);
            Assert.AreEqual(18.0, (Angle.FromDegrees(90) / 5).Degrees, Delta);
            Assert.AreEqual(18.0, Angle.FromDegrees(90) / Angle.FromDegrees(5), Delta);
        }

        [Test]
        public void ComparisonOperators()
        {
            Angle degrees90 = Angle.FromDegrees(90);
            Angle degrees180 = Angle.FromDegrees(180);

            Assert.True(degrees90 < degrees180);
            Assert.True(degrees90 <= degrees180);
            Assert.True(degrees180 > degrees90);
            Assert.True(degrees180 >= degrees90);

            Assert.False(degrees90 > degrees180);
            Assert.False(degrees90 >= degrees180);
            Assert.False(degrees180 < degrees90);
            Assert.False(degrees180 <= degrees90);
        }

        [Test]
        public void CompareToIsImplemented()
        {
            Angle degree = Angle.FromDegrees(1);
            Assert.AreEqual(0, degree.CompareTo(degree));
            Assert.Greater(degree.CompareTo(Angle.Zero), 0);
            Assert.Less(Angle.Zero.CompareTo(degree), 0);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void CompareToThrowsOnTypeMismatch()
        {
            Angle angle = Angle.FromDegrees(90);
            angle.CompareTo(new object());
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CompareToThrowsOnNull()
        {
            Angle angle = Angle.FromDegrees(90);
            angle.CompareTo(null);
        }


        [Test]
        public void EqualityOperators()
        {
            Angle a = Angle.FromDegrees(90);
            Angle b = Angle.FromDegrees(180);

            Assert.True(a == a); 
            Assert.True(a != b);

            Assert.False(a == b);
            Assert.False(a != a);
        }

        [Test]
        public void EqualsIsImplemented()
        {
            Area v = Area.FromSquareMeters(1);
            Assert.IsTrue(v.Equals(Area.FromSquareMeters(1)));
            Assert.IsFalse(v.Equals(Area.Zero));
        }

        [Test]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Angle angle = Angle.FromDegrees(0);
            Assert.IsFalse(angle.Equals(new object()));
        }

        [Test]
        public void EqualsReturnsFalseOnNull()
        {
            Angle angle = Angle.FromDegrees(0);
            Assert.IsFalse(angle.Equals(null));
        }
    }
}