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
            get { return new string[] { "metoda2", "metoda2", "metoda2" }; }
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
        }

        private void serviceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MethodComboBox.Items.Clear();
            if (serviceComboBox.SelectedItem.Equals("Usluga 1"))
                MethodComboBox.Items.AddRange(methods1);
            else
                MethodComboBox.Items.AddRange(methods2);
        }
    }
}
