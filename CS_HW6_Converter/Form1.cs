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
            var conversion = new Conversion();
            var conversions = new Conversions();

            var arr = conversions.getConversions().ToArray();


            foreach (var elem in arr)
            {
                var a = elem.ConvertTo() + " /" + elem.ConvertFrom();
                ConvertToComboBox.Items.Add(a);
            }





        }
    }
}

