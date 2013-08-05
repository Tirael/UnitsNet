using NUnit.Framework;

namespace UnitsNet.Geometry.Tests.net35
{
    [TestFixture]
    public class RectangleTests
    {
        [Test]
        public void MeterToLengthUnits()
        { 
            var r = new Rectangle(Length2d.FromMeters(1, 2), Length2d.FromMeters(2, 4));
            Assert.AreEqual(1, r.PointA.Meters.X);
            Assert.AreEqual(2, r.PointA.Meters.Y);
            Assert.AreEqual(2, r.PointB.Meters.X);
            Assert.AreEqual(4, r.PointB.Meters.Y);
            Assert.AreEqual(1, r.Width.Meters);
            Assert.AreEqual(2, r.Height.Meters);
            Assert.AreEqual(2, r.Area.SquareMeters);
        }
    }
}
