using System;

namespace CS_HW6_Converter
{
    /// <summary>
    /// Conversion Class.
    /// </summary>
    internal class Conversion : IConvertible<Conversion>, IComparable<Conversion>
    {
        public string FromUnit = string.Empty;
        public string ToUnit = string.Empty;
        public double ConversionRatio = 0.0;

        /// <summary>
        /// Conversion class constructor.
        /// </summary>
        public Conversion()
        {
        }

        /// <summary>
        /// Conversion class constructor.
        /// </summary>
        /// <param name="FromUnit">string</param>
        /// <param name="ToUnit">string</param>
        /// <param name="ConversionRatio">double</param>
        public Conversion(string FromUnit, string ToUnit, double ConversionRatio)
        {
            this.FromUnit = FromUnit;
            this.ToUnit = ToUnit;
            this.ConversionRatio = ConversionRatio;
        }

        /// <summary>
        /// Returns object property.
        /// </summary>
        /// <returns>Returns FromUnit.</returns>
        public string ConvertFrom()
        {
            return FromUnit;
        }

        /// <summary>
        /// Returns object property.
        /// </summary>
        /// <returns>Returns ToUnit.</returns>
        public string ConvertTo()
        {
            return ToUnit;
        }

        /// <summary>
        /// Returns object property.
        /// </summary>
        /// <returns>Returns ConversionRatio.</returns>
        public new double GetType()
        {
            return ConversionRatio;
        }

        /// <summary>
        /// Performs conversion.
        /// </summary>
        /// <param name="fromValue">double</param>
        /// <param name="conversionRatio">double</param>
        /// <returns>Returns value formatted as string.</returns>
        public string PerformConversion(double fromValue, double conversionRatio)
        {
            var toValue = fromValue * conversionRatio;
            return toValue.ToString("#.####");
        }

        /// <summary>
        /// Comparator for Conversion ojects.
        /// </summary>
        /// <param name="other">Conversion</param>
        /// <returns>Returns integer value indication of object comparison relationship.</returns>
        public int CompareTo(Conversion other)
        {
            return ToString().CompareTo(other.ToString());
        }

        /// <summary>
        /// Overrides ToString() method.
        /// </summary>
        /// <returns>Returns Conversion object properties.</returns>
        public override string ToString()
        {
            return FromUnit + " " + ToUnit + " " + ConversionRatio;
        }

        /// <summary>
        /// Returns partial Conversion object properties.
        /// </summary>
        /// <returns>Returns Conversion object properties.</returns>
        public string ToShortString()
        {
            return FromUnit + " " + ToUnit;
        }

        /// <summary>
        /// Overrides Equals() method.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Returns boolean value indication of object comparison relationship. </returns>
        public override bool Equals(object obj)
        {
            return Equals(obj as Conversion);
        }

        /// <summary>
        /// Tests if one object is equal to another object.
        /// </summary>
        /// <param name="conversion"></param>
        /// <returns>Returns boolean value indication of object comparison relationship.</returns>
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
        
        /// <summary>
        /// Gets Hashcode.
        /// </summary>
        /// <returns>Returns Hash.</returns>
        public override int GetHashCode()
        {
            //acknowledge overflow will occur 
            unchecked
            {
                // Choose large primes to avoid hashing collisions
                const int HashBase = (int)2166136261;
                const int HashMultiplier = 16777619;

                var Hash = HashBase;
                Hash = (Hash * HashMultiplier) + (FromUnit?.GetHashCode() ?? 0);
                Hash = (Hash * HashMultiplier) + (ToUnit?.GetHashCode() ?? 0);
                Hash = (Hash * HashMultiplier) + 0;
                return Hash;
            }
        }

        /// <summary>
        /// Overrides == relational operator.
        /// </summary>
        /// <param name="conversion1"></param>
        /// <param name="conversion2"></param>
        /// <returns>Returns boolean value for object relation.</returns>
        public static bool operator == (Conversion conversion1, Conversion conversion2)
        {
            if (ReferenceEquals(conversion1, conversion2))
            {
                return true;
            }
            else { /*doNothing*/ }

            return conversion1?.Equals(conversion2) == true;
        }

        /// <summary>
        /// Overrides != relational operator.
        /// </summary>
        /// <param name="conversion1"></param>
        /// <param name="conversion2"></param>
        /// <returns>Returns boolean value for object relation.</returns>
        public static bool operator != (Conversion conversion1, Conversion conversion2)
        {
            return !(conversion1 == conversion2);
        }

        /// <summary>
        /// Returns object property.
        /// </summary>
        /// <returns>Returns ConvertFrom() method</returns>
        string IConvertible<Conversion>.ConvertFrom()
        {
            return ConvertFrom();
        }

        /// <summary>
        /// Returns object property.
        /// </summary>
        /// <returns>Returns ConvertTo() method</returns>
        string IConvertible<Conversion>.ConvertTo()
        {
            return ConvertTo();
        }

        /// <inheritdoc />
        /// <summary>
        /// Returns object property.
        /// </summary>
        /// <param name="other"></param>
        /// <returns>Returns CompareTo(other) method</returns>
        int IComparable<Conversion>.CompareTo(Conversion other)
        {
            return CompareTo(other);
        }
    }
}
