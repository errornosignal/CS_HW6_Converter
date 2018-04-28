using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_HW6_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.ConvertToComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            var list = new List<IConvertible>();
            
            var conversions = new Conversions();

            var ConversionArray = conversions.GetConversions().ToArray();
            
            Array.Sort(ConversionArray, conversions.Compare);

            foreach (var Element in ConversionArray)
            {
                var ToFromString = Element.ConvertTo() + " " + Element.ConvertFrom();
                this.ConvertToComboBox.Items.Add(ToFromString);
            }
        }

        private void EditConversionsButton_Click(object sender, EventArgs e)
        {

        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            if (ConvertToComboBox.Text != string.Empty)
            {
                var Conversion = new Conversion();
                var ConversionText = ConvertToComboBox.SelectedItem.ToString();
                var IsValid = double.TryParse(ConvertFromTextBox.Text, out var TryParseResult);
                if (IsValid)
                {
                    var LocalConversionRatio = 0.0;
                    //var text = ConvertToComboBox.SelectedItem.ToString();
                    var newtext = ConversionText.Split(' ');
                    Console.WriteLine(newtext[0] + " " + newtext[1]);

                    if (ConversionText != string.Empty)
                    {
                        foreach (var ConversionObject in Conversions.ConvList)
                        {
                            if (newtext[0] == ConversionObject.FromUnit && newtext[1] == ConversionObject.ToUnit)
                            {
                                LocalConversionRatio = ConversionObject.GetType();
                            }
                        }
                        ConvertToTextBox.Text = Conversion.PerformConversion(TryParseResult, LocalConversionRatio);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Entry! Only double values permitted.");
                    ConvertFromTextBox.Clear();
                }
            }
            else
            {
                MessageBox.Show("No conversion type selected.");
            }
        }
    }
}

