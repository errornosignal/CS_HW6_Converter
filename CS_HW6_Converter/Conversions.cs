using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CS_HW6_Converter
{
    /// <inheritdoc />
    /// <summary>
    /// Conversions class.
    /// </summary>
    internal class Conversions : Conversion
    {
        public static List<Conversion> ConvList = new List<Conversion>();

        /// <summary>
        /// Returns list of Conversion objects.
        /// </summary>
        /// <returns>Returns ConvList.</returns>
        private static IEnumerable<Conversion> GetConversions()
        {
            return ConvList;
        }

        /// <summary>
        /// Adds a conversion, created by the user, to the list of Conversion objects.
        /// </summary>
        /// <param name="FromUnit">string</param>
        /// <param name="ToUnit">string</param>
        /// <param name="ConversionRatio">double</param>
        public void AddConversion(string FromUnit, string ToUnit, double ConversionRatio)
        {
            if (ConversionRatio != 0)
            {
                var MatchFound = false;
                var TestString = FromUnit + " " + ToUnit;
                foreach (var ConversionObject in ConvList)
                {
                    if (string.Equals(ConversionObject.ToShortString(), TestString,
                        StringComparison.CurrentCultureIgnoreCase))
                    {
                        MatchFound = true;
                        MessageBox.Show("Entry already in list. Nothing added.");
                        break;
                    }
                    else { /*doNothing*/ }
                }

                if (MatchFound == false)
                {
                    var conversion = new Conversion(FromUnit, ToUnit, ConversionRatio);
                    ConvList.Add(conversion);
                    MessageBox.Show(conversion + " was added.");
                }
                else { /*doNothing*/ }
            }
            else
            {
                MessageBox.Show("Conversion Rario cannot be 0.");
            }
        }

        /// <summary>
        /// Adds a conversion, specified by the user, from the list of Conversion objects.
        /// </summary>
        /// <param name="FromUnit">string</param>
        /// <param name="ToUnit">string</param>
        public void RemoveConversion(string FromUnit, string ToUnit)
        {
            var MatchFound = false;
            var TestString = FromUnit + " " + ToUnit;
            foreach (var ConversionObject in ConvList)
            {
                if (string.Equals(ConversionObject.ToShortString(), TestString, StringComparison.CurrentCultureIgnoreCase))
                {
                    MatchFound = true;
                    var IndexToRemove = ConvList.IndexOf(ConversionObject);
                    ConvList.RemoveAt(IndexToRemove);
                    MessageBox.Show(ConversionObject + " was removed.");
                    break;
                }
                else { /*doNothing*/ }
            }

            if (MatchFound == false)
            {
                MessageBox.Show("No match found.");
            }
            else { /*doNothing*/ }

        }

        /// <summary>
        /// Sorts the Conversion object list collection.
        /// </summary>
        /// <returns></returns>
        public List<Conversion> ReSortConversions()
        {
            var ConversionsList = GetConversions();
            ConvList = ConversionsList.OrderBy(o => o.FromUnit).ThenBy((n => n.ToUnit)).ToList();
            return ConvList;
        }
    }
 }