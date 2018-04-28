
namespace CS_HW6_Converter
{
    /// <summary>
    /// IConvertible interface
    /// </summary>
    internal interface IConvertible<T>
    {
        string ConvertFrom();
        string ConvertTo();
    }
}
