using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Length len = new Length();
        Time time = new Time();
        Weight wei = new Weight();
        Temperature temp = new Temperature();

        private void button1_Click(object sender, EventArgs e)
        {
            // testing the converter classes
            double converted = Math.Round(time.MinToHour(Double.Parse(textBox1.Text)), 2);
            textBox2.Text = converted.ToString();
        }
    }
}
