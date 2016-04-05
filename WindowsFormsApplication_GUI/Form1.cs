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
        private string[] primaryFunctions
        {
            set { }
            get { return new string[] { "Add", "Subtract", "Multiply", "Divide", "Concat", "Shuffle" }; }
        }

        private string[] secondaryFunctions
        {
            set { }
            get { return new string[] { "Fibonacci", "To uppercase", "To lowercase", "Count letter" }; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            if (ServiceComboBox.SelectedItem.Equals("Primary"))
            {
                DataService service = new DataService();
                switch (MethodComboBox.Text)
                {
                    case "Add":
                        {
                            double result = service.Add(Double.Parse(FirstArgumentTextBox.Text), Double.Parse(SecondArgumentTextBox.Text));
                            ResultTextBox.Text = result.ToString();
                            break;
                        }
                    case "Subtract":
                        {
                            double result = service.Subtract(Double.Parse(FirstArgumentTextBox.Text), Double.Parse(SecondArgumentTextBox.Text));
                            ResultTextBox.Text = result.ToString();
                            break;
                        }
                    case "Multiply":
                        {
                            double result = service.Multiply(Double.Parse(FirstArgumentTextBox.Text), Double.Parse(SecondArgumentTextBox.Text));
                            ResultTextBox.Text = result.ToString();
                            break;
                        }
                    case "Divide":
                        {
                            double result = service.Divide(Double.Parse(FirstArgumentTextBox.Text), Double.Parse(SecondArgumentTextBox.Text));
                            ResultTextBox.Text = result.ToString();
                            break;
                        }
                    case "Concat":
                        {
                            string result = service.Concat(FirstArgumentTextBox.Text, SecondArgumentTextBox.Text);
                            ResultTextBox.Text = result.ToString();
                            break;
                        }
                    case "Shuffle":
                        {
                            string result = service.Shuffle(FirstArgumentTextBox.Text, SecondArgumentTextBox.Text);
                            ResultTextBox.Text = result.ToString();
                            break;
                        }
                }
            }
            else if (ServiceComboBox.SelectedItem.Equals("Secondary"))
            {
                DataService2 service = new DataService2();
                switch (MethodComboBox.Text)
                {

                    case "To uppercase":
                        {
                            string result = service.ToUpperCase(FirstArgumentTextBox.Text);
                            ResultTextBox.Text = result;
                            break;
                        }
                    case "To lowercase":
                        {
                            string result = service.ToLowerCase(FirstArgumentTextBox.Text);
                            ResultTextBox.Text = result;
                            break;
                        }
                    case "Count letter":
                        {
                            int result = service.LetterCount(FirstArgumentTextBox.Text, Char.Parse(SecondArgumentTextBox.Text));
                            ResultTextBox.Text = result.ToString();
                            break;
                        }
                    case "Fibonacci":
                        {
                            int result = service.Fibonacci(Int32.Parse(FirstArgumentTextBox.Text));
                            ResultTextBox.Text = result.ToString();
                            break;
                        }
                    case "Factorial":
                        {
                            int result = service.Factorial(Int32.Parse(FirstArgumentTextBox.Text));
                            ResultTextBox.Text = result.ToString();
                            break;
                        }
                }
            }
        }

        private void ServiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MethodComboBox.Items.Clear();
            if (ServiceComboBox.SelectedItem.Equals("Primary"))
                MethodComboBox.Items.AddRange(primaryFunctions);
            else if (ServiceComboBox.SelectedItem.Equals("Secondary"))
                MethodComboBox.Items.AddRange(secondaryFunctions);
        }

        private void FunctionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ServiceComboBox.SelectedItem.Equals("Primary"))
            {
                DataService service = new DataService();
                switch (MethodComboBox.Text)
                {
                    case "Add":
                        {
                            FirstArgumentTextBox.ReadOnly = false;
                            SecondArgumentTextBox.ReadOnly = false;
                            break;
                        }
                    case "Subtract":
                        {
                            FirstArgumentTextBox.ReadOnly = false;
                            SecondArgumentTextBox.ReadOnly = false;
                            break;
                        }
                    case "Multiply":
                        {
                            FirstArgumentTextBox.ReadOnly = false;
                            SecondArgumentTextBox.ReadOnly = false;
                            break;
                        }
                    case "Divide":
                        {
                            FirstArgumentTextBox.ReadOnly = false;
                            SecondArgumentTextBox.ReadOnly = false;
                            break;
                        }
                    case "Concat":
                        {
                            FirstArgumentTextBox.ReadOnly = false;
                            SecondArgumentTextBox.ReadOnly = false;
                            break;
                        }
                    case "Shuffle":
                        {
                            FirstArgumentTextBox.ReadOnly = false;
                            SecondArgumentTextBox.ReadOnly = false;
                            break;
                        }
                }
            }
            else if (ServiceComboBox.SelectedItem.Equals("Secondary"))
            {
                DataService2 service = new DataService2();
                switch (MethodComboBox.Text)
                {

                    case "To uppercase":
                        {
                            FirstArgumentTextBox.ReadOnly = false;
                            SecondArgumentTextBox.ReadOnly = true;
                            break;
                        }
                    case "To lowercase":
                        {
                            FirstArgumentTextBox.ReadOnly = false;
                            SecondArgumentTextBox.ReadOnly = true;
                            break;
                        }
                    case "Count letter":
                        {
                            FirstArgumentTextBox.ReadOnly = false;
                            SecondArgumentTextBox.ReadOnly = false;
                            break;
                        }
                    case "Fibonacci":
                        {
                            FirstArgumentTextBox.ReadOnly = false;
                            SecondArgumentTextBox.ReadOnly = true;
                            break;
                        }
                    case "Factorial":
                        {
                            FirstArgumentTextBox.ReadOnly = false;
                            SecondArgumentTextBox.ReadOnly = true;
                            break;
                        }
                }
            }
        }
    }
}
