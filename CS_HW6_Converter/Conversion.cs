using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW6_Converter
{
    internal class Conversion : IConvertible<Conversion>, IComparable<Conversion>
    {
        public string FromUnit = string.Empty;
        public string ToUnit = string.Empty;
        public double ConversionRatio = 0.0;

        //Creates varibales to store conversion data
        public Conversion()
        {
        }

        public Conversion(string FromUnit, string ToUnit, double ConversionRatio)
        {
            this.FromUnit = FromUnit;
            this.ToUnit = ToUnit;
            this.ConversionRatio = ConversionRatio;
        }

        public string ConvertFrom()
        {
            return FromUnit;
        }

        public string ConvertTo()
        {
            return ToUnit;
        }

        //Displays type of conversion made
        public new double GetType()
        {
            return ConversionRatio;
        }

        //Calculates conversion and stores as
        public string PerformConversion(double fromValue, double conversionRatio)
        {
            var toValue = fromValue * conversionRatio;
            return toValue.ToString("#.####");
        }

        public int Compare(Conversion conv1, Conversion conv2)
        {
            string str1 = conv1.FromUnit + "," + conv1.ToUnit;
            string str2 = conv2.FromUnit + "," + conv2.ToUnit;
            return str1.CompareTo(str2);
        }

        public int CompareTo(Conversion other)
        {
            return ToString().CompareTo(other.ToString());
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        string IConvertible<Conversion>.ConvertTo()
        {
            return ConvertTo();
        }

        string IConvertible<Conversion>.ConvertFrom()
        {
            return ConvertFrom();
        }

        int IComparable<Conversion>.CompareTo(Conversion other)
        {
            return CompareTo(other);
        }
    }
}
