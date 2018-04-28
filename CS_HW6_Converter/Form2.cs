using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_HW6_Converter
{
    public partial class Form2 : Form
    {
        private readonly Conversions conversions = new Conversions();

        public Form2()
        {
            InitializeComponent();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.ConvertFromUnitTextBox.Clear();
            this.ConvertToUnitTextBox.Clear();
            this.ConversionRatioTextBox.Clear();
            this.ConvertFromUnitTextBox.Focus();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var ConvertFromUnit = ConvertFromUnitTextBox.Text;
            var ConvertToUnit = ConvertToUnitTextBox.Text;
            var ConversionRatio = ConversionRatioTextBox.Text;

            if (ConvertFromUnit != string.Empty && ConvertToUnit != string.Empty && ConversionRatio != string.Empty)
            {

                var IsValid = double.TryParse(ConversionRatio, out var TryParseResult);
                if (IsValid)
                {
                    var NewConversionRatio = TryParseResult;

                    conversions.AddConversion(ConvertFromUnit, ConvertToUnit, NewConversionRatio);
                    conversions.RefreshConversions();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Entry! Only double values permitted.");
                    ConversionRatioTextBox.Clear();
                    ConversionRatioTextBox.Focus();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Entry! You left something blank.");
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            var ConvertFromUnit = ConvertFromUnitTextBox.Text;
            var ConvertToUnit = ConvertToUnitTextBox.Text;

            conversions.RemoveConversion(ConvertFromUnit, ConvertToUnit);
            conversions.RefreshConversions();
            this.Close();
        }
    }
}
