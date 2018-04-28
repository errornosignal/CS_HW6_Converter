using System;
using System.Windows.Forms;

namespace CS_HW6_Converter
{
    public partial class Form1 : Form
    {
        private readonly Conversions conversions = new Conversions();

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets initial form state.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        public void Form1_Load_1(object sender, EventArgs e)
        {
            //add default conversions
            conversions.AddConversion("Miles", "Kilometers", 1.6093);
            conversions.AddConversion("Kilometers", "Miles", 0.6214);
            conversions.AddConversion("Inches", "Centimeters", 2.54);
            conversions.AddConversion("Centimeters", "Inches", 0.3937);

            this.ConvertToComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ConvertToComboBox.DataSource = Conversions.ConvList;
        }

        /// <summary>
        /// Event handler for ConvertButton_Click.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void ConvertButton_Click(object sender, EventArgs e)
        {
            if (ConvertToComboBox.Text != string.Empty)
            {
                var ConversionText = ConvertToComboBox.SelectedItem.ToString();
                var IsValid = double.TryParse(ConvertFromTextBox.Text, out var TryParseResult);
                if (IsValid)
                {
                    var LocalConversionRatio = 0.0;
                    var newtext = ConversionText.Split(' ');
                    //Console.WriteLine(newtext[0] + " " + newtext[1]);

                    if (ConversionText != string.Empty)
                    {
                        foreach (var ConversionObject in Conversions.ConvList)
                        {
                            if (newtext[0] == ConversionObject.FromUnit && newtext[1] == ConversionObject.ToUnit)
                            {
                                LocalConversionRatio = ConversionObject.GetType();
                            }
                        }

                        if (LocalConversionRatio == 0.0)
                        {
                            MessageBox.Show("Oops! Looks like the selected conversion may have been removed.");
                        }
                        else
                        {
                            this.ConvertToTextBox.Text = conversions.PerformConversion(TryParseResult, LocalConversionRatio);
                        }
                    }
                    else { /*doNothing*/ }
                }
                else
                {
                    MessageBox.Show("Invalid Entry! Only double values permitted.");
                    this.ConvertFromTextBox.Clear();
                    this.ConvertFromTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("No conversion type selected.");
            }
        }

        /// <summary>
        /// Event handler for EditConversionsButton_Click.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void EditConversionsButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            var Form2 = new Form2();
            Form2.FormClosing += this.Form2_FormClosing;
            Form2.Show();
        }

        /// <summary>
        /// Event handler for Form2_FormClosing.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">FormClosingEventArgs</param>
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Enabled = true;
            this.ConvertToComboBox.DataSource = null;
            this.ConvertToComboBox.DataSource = Conversions.ConvList;
        }
    }
}
