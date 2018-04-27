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
        public List<Conversion> getConversions()
        {
            var temp = new List<Conversion>();

            try
            {
                // Get the current directory.
                var path = Directory.GetCurrentDirectory();
                const string target = @"\conversions.txt";
                var fullPath = path + target;
                Console.WriteLine(fullPath);

                string[] lineOfContents = File.ReadAllLines(fullPath);

                foreach (var line in lineOfContents)
                {
                    var tokens = line.Split(',');
                    temp.Add(new Conversion(tokens[0], tokens[1], Convert.ToDouble(tokens[2])));
                }
            }
            catch
            {
                MessageBox.Show("Could not process data.");
            }

            return temp;
        }

    }
}

        //public static void saveConversions(List<Conversion> conversions)
        //{

        //    try
        //    {

        //        PrintWriter out = new PrintWriter("conversion_types.txt");

        //        for (Conversion item: conversions)
        //        {

        //            out.println(item.fromUnit + " " + item.toUnit + " " + item.conversionRatio);

        //        }

        //        out.close();

        //    }

        //    catch (FileNotFoundException e)
        //    {

        //        System.out.println("Unable to create file");

        //    }

        //}

//    }




//    public string FromUnit { get; set; }
//        public string ToUnit { get; set; }
//        public double ConversionRatio { get; set; }
//        public IEnumerable<Conversions> conversions = from line in File.ReadLines(@"conversions.csv")

//        let arr = line.Split(',')
//        select new Conversions
//        {
//            FromUnit = arr[0].Trim(),
//            ToUnit = arr[1].Trim(),
//            ConversionRatio = Convert.ToDouble(arr[2].Trim())
//        };


//    }
//}
