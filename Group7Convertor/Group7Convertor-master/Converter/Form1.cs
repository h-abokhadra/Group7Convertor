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
        // Declare variables
        Length len = new Length();
        Time time = new Time();
        Weight wei = new Weight();
        Temperature temp = new Temperature();
        double converted = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // Radiobuttons of Length and Unit1 are selected after loading
        private void Form1_Load(object sender, EventArgs e)
        {
            Length.Checked = true;
            Unit1.Checked = true;
        }

        // Change the text of Unit1 and Unit2 radiobuttons
        private void ConvertionType_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

            if (sender == Length)
            {
                Unit1.Text = "Foot to Meter";
                Unit2.Text = "Meter to Foot";
            }
            else if (sender == Temperature)
            {
                Unit1.Text = "Celsius to Farenheit";
                Unit2.Text = "Farenheit to Celsius";
            }
            else if (sender == TimeRB)
            {
                Unit1.Text = "Minute to Hour";
                Unit2.Text = "Hour to Minute";
            }
            else if (sender == Weight)
            {
                Unit1.Text = "Pound to Kilogram";
                Unit2.Text = "Kilogram to Pound";
            }
        }

        // Change the label text of the textboxes
        private void ConversionUnit_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

            if (sender == Unit1)
            {
                if (Length.Checked)
                {
                    label1.Text = "Foot";
                    label2.Text = "Meter";
                }
                else if (Temperature.Checked)
                {
                    label1.Text = "Celsius";
                    label2.Text = "Farenheit";
                }
                else if (TimeRB.Checked)
                {
                    label1.Text = "Minute";
                    label2.Text = "Hour";
                }
                else if (Weight.Checked)
                {
                    label1.Text = "Pound";
                    label2.Text = "Kilogram";
                }
            }
            else if (sender == Unit2)
            {
                if (Length.Checked)
                {
                    label1.Text = "Meter";
                    label2.Text = "Foot";
                }
                else if (Temperature.Checked)
                {
                    label1.Text = "Farenheit";
                    label2.Text = "Celsius";
                }
                else if (TimeRB.Checked)
                {
                    label1.Text = "Hour";
                    label2.Text = "Minute";
                }
                else if (Weight.Checked)
                {
                    label1.Text = "Kilogram";
                    label2.Text = "Pound";
                }
            }
        }

        // Convert user input to chosen output
        private void Convert_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(textBox1.Text, out converted))
            {
                if (Length.Checked)
                {
                    if (Unit1.Checked)
                    {
                        converted = Math.Round(len.FootToMeter(converted), 2);
                    }
                    else
                    {
                        converted = Math.Round(len.MeterToFoot(converted), 2);
                    }
                    textBox2.Text = converted.ToString();
                }
                else if (Temperature.Checked)
                {
                    if (Unit1.Checked)
                    {
                        converted = Math.Round(temp.CelsiusToFarenheit(converted), 2);
                    }
                    else
                    {
                        converted = Math.Round(temp.FarenheitToCelsius(converted), 2);
                    }
                    textBox2.Text = converted.ToString();
                }
                else if (TimeRB.Checked)
                {
                    if (Unit1.Checked)
                    {
                        converted = Math.Round(time.MinToHour(converted), 2);
                    }
                    else
                    {
                        converted = Math.Round(time.HourToMin(converted), 2);
                    }
                    textBox2.Text = converted.ToString();
                }
                else if (Weight.Checked)
                {
                    if (Unit1.Checked)
                    {
                        converted = Math.Round(wei.PoundToKilo(converted), 2);
                    }
                    else
                    {
                        converted = Math.Round(wei.KiloToPound(converted), 2);
                    }
                    textBox2.Text = converted.ToString();
                }
            }
            else
            {
                MessageBox.Show("Please enter numbers only.");
            }
        }
    }
}
