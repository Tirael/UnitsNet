using System;

namespace UnitsNet.Geometry
{
    public struct Rectangle
    {
        public readonly Length2d PointA;
        public readonly Length2d PointB;

        public Rectangle(Length2d pointA, Length2d pointB)
        {
            PointA = pointA;
            PointB = pointB;
        }

        public Area Area
        {
            get
            {
                double dxMeters = Math.Abs(PointB.Meters.X - PointA.Meters.X);
                double dyMeters = Math.Abs(PointB.Meters.Y - PointA.Meters.Y);
                return new Area(dxMeters * dyMeters);
            }
        }

        public Length Width
        {
            get
            {
                double dxMeters = Math.Abs(PointB.Meters.X - PointA.Meters.X);
                return Length.FromMeters(dxMeters);
            }
        }

        public Length Height
        {
            get
            {
                double dyMeters = Math.Abs(PointB.Meters.Y - PointA.Meters.Y);
                return Length.FromMeters(dyMeters);
            }
        }
    }
}
