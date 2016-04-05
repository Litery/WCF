using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCFServiceContract;

namespace WindowsFormsApplication_GUI
{
    public partial class Form1 : Form
    {
        private string[] methods1
        {
            set { }
            get { return new string[] {"Fibonacci", "Wielkie litery", "Ile wystepuje litera z parametru2?"}; }
        }

        private string[] methods2
        {
            set { }
            get { return new string[] { "Dodawanie", "Odejmowanie", "Mnożenie", "Dzielenie", "Konkatenacja", "Mieszanie" }; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (serviceComboBox.SelectedItem.Equals("Usluga 1"))
            {
                DataService2 service = new DataService2();
                switch (MethodComboBox.Text)
                {
                    case "Fibonacci":
                    {
                        int result = service.Fibonacci(Int32.Parse(ParamTextBox1.Text));
                        Result.Text = result.ToString();
                        break;
                    }
                    case "Wielkie litery":
                    {
                        string result = service.ToUpperCase(ParamTextBox1.Text);
                        Result.Text = result;
                        break;
                    }
                    case "Ile wystepuje litera z parametru2?":
                    {
                        int result = service.GetNumberOfSelectedLetter(ParamTextBox1.Text,Char.Parse(ParamTextBox2.Text));
                        Result.Text = result.ToString();
                        break;
                    }
                }
            }
            else if (serviceComboBox.SelectedItem.Equals("Usluga 2"))
            {
                DataService service = new DataService();
                switch (MethodComboBox.Text)
                {
                    case "Dodawanie":
                        {
                            double result = service.Add(Double.Parse(ParamTextBox1.Text), Double.Parse(ParamTextBox2.Text));
                            Result.Text = result.ToString();
                            break;
                        }
                    case "Odejmowanie":
                        {
                            double result = service.Subtract(Double.Parse(ParamTextBox1.Text), Double.Parse(ParamTextBox2.Text));
                            Result.Text = result.ToString();
                            break;
                        }
                    case "Mnożenie":
                        {
                            double result = service.Multiply(Double.Parse(ParamTextBox1.Text), Double.Parse(ParamTextBox2.Text));
                            Result.Text = result.ToString();
                            break;
                        }
                    case "Dzielenie":
                        {
                            double result = service.Divide(Double.Parse(ParamTextBox1.Text), Double.Parse(ParamTextBox2.Text));
                            Result.Text = result.ToString();
                            break;
                        }
                    case "Konkatenacja":
                        {
                            string result = service.Concat(ParamTextBox1.Text, ParamTextBox2.Text);
                            Result.Text = result.ToString();
                            break;
                        }
                    case "Mieszanie":
                        {
                            string result = service.Shuffle(ParamTextBox1.Text, ParamTextBox2.Text);
                            Result.Text = result.ToString();
                            break;
                        }
                }
            }
        }

        private void serviceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MethodComboBox.Items.Clear();
            if (serviceComboBox.SelectedItem.Equals("Usluga 1"))
                MethodComboBox.Items.AddRange(methods1);
            else if (serviceComboBox.SelectedItem.Equals("Usluga 2"))
                MethodComboBox.Items.AddRange(methods2);
        }
    }
}
