﻿// Copyright © 2007 by Initial Force AS.  All rights reserved.
// https://github.com/InitialForce/SIUnits
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;

namespace UnitsNet
{
    /// <summary>
    ///     A class for representing units of volume.
    /// </summary>
    public struct Volume : IComparable, IComparable<Volume>
    {
        private const double CubicKilometersToCubicMetersRatio = 1E9;
        private const double CubicDecimetersToCubicMetersRatio = 1E-3;
        private const double CubicCentimetersToCubicMetersRatio = 1E-6;
        private const double CubicMillimetersToCubicMetersRatio = 1E-9;
        private const double HectolitersToCubicMetersRatio = 1E-1;
        private const double LitersToCubicMetersRatio = 1E-3;
        private const double DecilitersToCubicMetersRatio = 1E-4;
        private const double CentilitersToCubicMetersRatio = 1E-5;
        private const double MillilitersToCubicMetersRatio = 1E-6;

        public readonly double CubicMeters;

        /// <summary>
        ///     Enforce static methods for creation.
        /// </summary>
        private Volume(double cubicMeters)
            : this()
        {
            CubicMeters = cubicMeters;
        }

        #region Unit Properties

        public double CubicKilometers
        {
            get { return CubicMeters/CubicKilometersToCubicMetersRatio; }
        }

        public double CubicDecimeters
        {
            get { return CubicMeters/CubicDecimetersToCubicMetersRatio; }
        }

        public double CubicCentimeters
        {
            get { return CubicMeters/CubicCentimetersToCubicMetersRatio; }
        }

        public double CubicMillimeters
        {
            get { return CubicMeters/CubicMillimetersToCubicMetersRatio; }
        }

        public double Hectoliters
        {
            get { return CubicMeters/HectolitersToCubicMetersRatio; }
        }

        public double Liters
        {
            get { return CubicMeters/LitersToCubicMetersRatio; }
        }

        public double Deciliters
        {
            get { return CubicMeters/DecilitersToCubicMetersRatio; }
        }

        public double Centiliters
        {
            get { return CubicMeters/CentilitersToCubicMetersRatio; }
        }

        public double Milliliters
        {
            get { return CubicMeters/MillilitersToCubicMetersRatio; }
        }

        #endregion

        #region Static

        /// <summary>
        ///     The maximum representable volume in cubic meters.
        /// </summary>
        public static Volume Max
        {
            get { return new Volume(double.MaxValue); }
        }

        /// <summary>
        ///     The smallest representable volume in cubic meters.
        /// </summary>
        public static Volume Min
        {
            get { return new Volume(double.MinValue); }
        }

        public static Volume Zero
        {
            get { return new Volume(); }
        }

        public static Volume FromCubicKilometers(double cubicKilometers)
        {
            return new Volume(cubicKilometers*CubicKilometersToCubicMetersRatio);
        }

        public static Volume FromCubicMeters(double cubicMeters)
        {
            return new Volume(cubicMeters);
        }

        public static Volume FromCubicDecimeters(double cubicDecimeters)
        {
            return new Volume(cubicDecimeters*CubicDecimetersToCubicMetersRatio);
        }

        public static Volume FromCubicCentimeters(double cubicCentimeters)
        {
            return new Volume(cubicCentimeters*CubicCentimetersToCubicMetersRatio);
        }

        public static Volume FromCubicMillimeters(double cubicMillimeters)
        {
            return new Volume(cubicMillimeters*CubicMillimetersToCubicMetersRatio);
        }

        public static Volume FromHectoliters(double hectoliters)
        {
            return new Volume(hectoliters*HectolitersToCubicMetersRatio);
        }

        public static Volume FromLiters(double liters)
        {
            return new Volume(liters*LitersToCubicMetersRatio);
        }

        public static Volume FromDeciliters(double deciliters)
        {
            return new Volume(deciliters*DecilitersToCubicMetersRatio);
        }

        public static Volume FromCentiliters(double centiliters)
        {
            return new Volume(centiliters*CentilitersToCubicMetersRatio);
        }

        public static Volume FromMilliliters(double milliliters)
        {
            return new Volume(milliliters*MillilitersToCubicMetersRatio);
        }

        #endregion

        #region Arithmetic operators

        public static Volume operator -(Volume right)
        {
            return FromCubicMeters(-right.CubicMeters);
        }

        public static Volume operator +(Volume left, Volume right)
        {
            return FromCubicMeters(left.CubicMeters + right.CubicMeters);
        }

        public static Volume operator -(Volume left, Volume right)
        {
            return FromCubicMeters(left.CubicMeters - right.CubicMeters);
        }

        public static Volume operator *(double left, Volume right)
        {
            return FromCubicMeters(left*right.CubicMeters);
        }

        public static Volume operator *(Volume left, double right)
        {
            return FromCubicMeters(left.CubicMeters*right);
        }

        public static Volume operator /(Volume left, double right)
        {
            return FromCubicMeters(left.CubicMeters/right);
        }

        public static double operator /(Volume left, Volume right)
        {
            return left.CubicMeters/right.CubicMeters;
        }

        #endregion

        #region Comparable operators

        public static bool operator <=(Volume left, Volume right)
        {
            return left.CubicMeters <= right.CubicMeters;
        }

        public static bool operator >=(Volume left, Volume right)
        {
            return left.CubicMeters >= right.CubicMeters;
        }

        public static bool operator <(Volume left, Volume right)
        {
            return left.CubicMeters < right.CubicMeters;
        }

        public static bool operator >(Volume left, Volume right)
        {
            return left.CubicMeters > right.CubicMeters;
        }

        public static bool operator ==(Volume left, Volume right)
        {
            return left.CubicMeters == right.CubicMeters;
        }

        public static bool operator !=(Volume left, Volume right)
        {
            return !(left.CubicMeters == right.CubicMeters);
        }

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");
            if (!(obj is Volume)) throw new ArgumentException("Expected type Volume.", "obj");
            return CompareTo((Volume) obj);
        }

        public int CompareTo(Volume other)
        {
            return CubicMeters.CompareTo(other.CubicMeters);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Volume))
            {
                return false;
            }

            return CubicMeters.CompareTo(((Volume) obj).CubicMeters) == 0;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion

        public override string ToString()
        {
            return CubicMeters + " m³";
        }
    }
}