using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW6_Converter
{
    /// <summary>
    /// 
    /// </summary>
    internal interface IConvertible<T>
    {
        string ConvertFrom();
        string ConvertTo();
    }
}
