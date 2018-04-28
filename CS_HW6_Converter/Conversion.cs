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

        public int Compare(Conversion ConvObj1, Conversion ConvObj2)
        {
            var str1 = ConvObj1.ToShortString();
            var str2 = ConvObj2.ToShortString();
            return str1.CompareTo(str2);
        }

        public int CompareTo(Conversion other)
        {
            return ToString().CompareTo(other.ToString());
        }

        public override string ToString()
        {
            return FromUnit + " " + ToUnit + " " + ConversionRatio;
        }

        public string ToShortString()
        {
            return FromUnit + " " + ToUnit;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Conversion);
        }

        public bool Equals(Conversion conversion)
        {
            if (conversion is null)
            {
                return false;
            }
            else { /*doNothing*/ }

            if (ReferenceEquals(this, conversion))
            {
                return true;
            }
            else { /*doNothing*/ }

            return string.Equals(FromUnit, conversion.FromUnit)
                   && string.Equals(ToUnit, conversion.ToUnit)
                   && string.Equals(ConversionRatio, conversion.ConversionRatio);
        }
        
        public override int GetHashCode()
        {
            //acknowledge overflow will occur 
            unchecked
            {
                // Choose large primes to avoid hashing collisions
                const int HashBase = (int)2166136261;
                const int HashMultiplier = 16777619;

                var hash = HashBase;
                hash = (hash * HashMultiplier) + (FromUnit?.GetHashCode() ?? 0);
                hash = (hash * HashMultiplier) + (ToUnit?.GetHashCode() ?? 0);
                hash = (hash * HashMultiplier) + 0;
                return hash;
            }
        }

        public static bool operator == (Conversion conversion1, Conversion conversion2)
        {
            if (ReferenceEquals(conversion1, conversion2))
            {
                return true;
            }
            else { /*doNothing*/ }

            return conversion1?.Equals(conversion2) == true;
        }

        public static bool operator != (Conversion conversion1, Conversion conversion2)
        {
            return !(conversion1 == conversion2);
        }

        string IConvertible<Conversion>.ConvertFrom()
        {
            return ConvertFrom();
        }

        string IConvertible<Conversion>.ConvertTo()
        {
            return ConvertTo();
        }

        int IComparable<Conversion>.CompareTo(Conversion other)
        {
            return CompareTo(other);
        }
    }
}
