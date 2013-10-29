using System;

namespace UnitsNet
{
    public enum AngleUnits
    { 
        Degrees,
        Radians,
        Gradians
    }

    public struct Angle : IComparable, IComparable<Angle>
    {
        private const double RadiansToDegreesRatio = 180.0 / Math.PI;
        private const double GradiansToDegreesRatio = 0.9;
        
        public readonly double Degrees;

        public Angle(double degrees)
        {
            Degrees = degrees;
        }

        #region Unit Properties

        public double Radians
        {
            get { return Degrees / RadiansToDegreesRatio; }
        }

        public double Gradians
        {
            get { return Degrees / GradiansToDegreesRatio; }
        }
        
        #endregion

        #region Static
        
        public static Angle Zero
        {
            get { return new Angle(0); }
        }

        public static Angle FromDegrees(double degrees)
        {
            return new Angle(degrees);
        }

        public static Angle FromRadians(double radians)
        {
            return new Angle(radians * RadiansToDegreesRatio);
        }

        public static Angle FromGradians(double gradians)
        {
            return new Angle(gradians * GradiansToDegreesRatio);
        }
        
        #endregion

        #region Arithmetic operators

        public static Angle operator -(Angle right)
        {
            return FromDegrees(-right.Degrees);
        }

        public static Angle operator +(Angle left, Angle right)
        {
            return FromDegrees(left.Degrees + right.Degrees);
        }

        public static Angle operator -(Angle left, Angle right)
        {
            return FromDegrees(left.Degrees - right.Degrees);
        }

        public static Angle operator *(double left, Angle right)
        {
            return FromDegrees(left * right.Degrees);
        }

        public static Angle operator *(Angle left, double right)
        {
            return FromDegrees(left.Degrees * right);
        }

        public static Angle operator /(Angle left, double right)
        {
            return FromDegrees(left.Degrees / right);
        }

        public static double operator /(Angle left, Angle right)
        {
            return left.Degrees / right.Degrees;
        }

        #endregion

        #region Comparable operators

        public static bool operator <=(Angle left, Angle right)
        {
            return left.Degrees <= right.Degrees;
        }

        public static bool operator >=(Angle left, Angle right)
        {
            return left.Degrees >= right.Degrees;
        }

        public static bool operator <(Angle left, Angle right)
        {
            return left.Degrees < right.Degrees;
        }

        public static bool operator >(Angle left, Angle right)
        {
            return left.Degrees > right.Degrees;
        }

        public static bool operator ==(Angle left, Angle right)
        {
            return left.Degrees == right.Degrees;
        }

        public static bool operator !=(Angle left, Angle right)
        {
            return !(left.Degrees == right.Degrees);
        }

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");
            if (!(obj is Area)) throw new ArgumentException("Expected type Angle.", "obj");
            return CompareTo((Area)obj);
        }

        public int CompareTo(Angle other)
        {
            return Degrees.CompareTo(other.Degrees);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Angle))
            {
                return false;
            }

            return Degrees.CompareTo(((Angle)obj).Degrees) == 0;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion

        public override string ToString()
        {
            return Degrees + " °";
        }
    }
}