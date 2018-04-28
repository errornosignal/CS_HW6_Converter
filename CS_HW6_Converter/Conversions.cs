using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_HW6_Converter
{
    internal class Conversions : Conversion
    {
        public static List<Conversion> ConvList = new List<Conversion>();

        public List<Conversion> GetConversions()
        {
            return ConvList;
        }

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
                    else
                    {
                        /*doNothing*/
                    }
                }

                if (MatchFound == false)
                {
                    var conversion = new Conversion(FromUnit, ToUnit, ConversionRatio);
                    ConvList.Add(conversion);
                    MessageBox.Show(conversion + " was added.");
                }
                else
                {
                    /*doNothing*/
                }
            }
            else
            {
                MessageBox.Show("Conversion Rario cannot be 0.");
            }
        }

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

        public List<Conversion> RefreshConversions()
        {
            var ConversionsList = GetConversions();
            ConvList = ConversionsList.OrderBy(o => o.FromUnit).ThenBy((n => n.ToUnit)).ToList();
            return ConvList;
        }
    }
 }