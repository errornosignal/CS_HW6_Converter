using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW6_Converter
{
    internal class Conversion : IConvertible<Conversion>
    {
        string FromUnit = String.Empty;
        string ToUnit = String.Empty;
        double ConversionRatio = 0.0;

        public double FromValue
        {
            get => this.FromValue;
            set => this.FromValue = value > 0 ? value : 1;
        }

        public double ToValue
        {
            get => this.ToValue;
            set => this.ToValue = value > 0 ? value : 1;
        }

        //Creates varibales to store conversion data

        public Conversion(string FromUnit, string ToUnit, double ConversionRatio)
        {
            this.FromUnit = FromUnit;
            this.ToUnit = ToUnit;
            this.ConversionRatio = ConversionRatio;
        }

        public Conversion()
        {
        }

        //Displays type of conversion made

        public new string GetType()
        {
            return FromUnit + " To " + ToUnit + ":" + ConversionRatio;
        }

        //Calculates conversion and stores as

        public string ConversionCalc(double fromValue)
        {

            var ToValue = fromValue * ConversionRatio;

            //DecimalFormat decFormat = new DecimalFormat("#.##");

            //ToValue = Double.valueOf(decFormat.format(toValue));

            return ToValue.ToString();
        }

        public string ConvertTo()
        {
            //throw new NotImplementedException();
            return FromUnit;
        }

        public string ConvertFrom()
        {
            //throw new NotImplementedException();
            return ToUnit;
        }

        public int CompareTo(Conversion other)
        {
            throw new NotImplementedException();
        }

        public TypeCode GetTypeCode()
        {
            throw new NotImplementedException();
        }

        public bool ToBoolean(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public char ToChar(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public sbyte ToSByte(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public byte ToByte(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public short ToInt16(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public ushort ToUInt16(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public int ToInt32(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public uint ToUInt32(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public long ToInt64(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public ulong ToUInt64(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public float ToSingle(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public double ToDouble(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public decimal ToDecimal(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public DateTime ToDateTime(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public string ToString(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public object ToType(Type conversionType, IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
