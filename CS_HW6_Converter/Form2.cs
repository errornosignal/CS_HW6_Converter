using System;
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

        /// <summary>
        /// Event handler for ClearButton_Click.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.ConvertFromUnitTextBox.Clear();
            this.ConvertToUnitTextBox.Clear();
            this.ConversionRatioTextBox.Clear();
            this.ConvertFromUnitTextBox.Focus();
        }

        /// <summary>
        /// Event handler for AddButton_Click.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
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
                    conversions.ReSortConversions();
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

        /// <summary>
        /// Event handler for RemoveButton_Click.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            var ConvertFromUnit = ConvertFromUnitTextBox.Text;
            var ConvertToUnit = ConvertToUnitTextBox.Text;

            conversions.RemoveConversion(ConvertFromUnit, ConvertToUnit);
            conversions.ReSortConversions();
            this.Close();
        }
    }
}
