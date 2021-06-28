using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        bool operationPerf = false;
        string operation = "";
        double answer = 0;
        readonly string file = "C:\\Users\\Liam\\source\\repos\\WindowsFormsApp1\\file.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void NumEvent(object sender, EventArgs e)
        {
            if (textbox.Text == "0" || operationPerf)
                textbox.Clear();

            Button butt = (Button)sender;
            textbox.Text += butt.Text;
            operationPerf = false;

            //Copies the first digit every time a double digit or more value is entered, needs fixing!
            label.Text = label.Text + " " + textbox.Text;
        }

        private void OperandEvent(object sender, EventArgs e)
        {
            operationPerf = true;
            Button butt = (Button)sender;
            string newOperand = butt.Text;

            label.Text = label.Text + " " + newOperand;

            switch (operation)
            {
                case "+": textbox.Text = (answer + Double.Parse(textbox.Text)).ToString(); 
                    break;
                case "-": textbox.Text = (answer - Double.Parse(textbox.Text)).ToString(); 
                    break;
                case "*": textbox.Text = (answer * Double.Parse(textbox.Text)).ToString(); 
                    break;
                case "/": textbox.Text = (answer / Double.Parse(textbox.Text)).ToString(); 
                    break;
                case "^": textbox.Text = (Math.Pow(answer, Double.Parse(textbox.Text))).ToString();
                    break;
                case "√": textbox.Text = (Math.Sqrt(Double.Parse(textbox.Text))).ToString();
                    break;
                default:
                    break;
            }
            answer = Double.Parse(textbox.Text);
            operation = newOperand;
        }

        private void bC_Click(object sender, EventArgs e)
        {
            textbox.Text = "0";
            label.Text = "";
            answer = 0;
            operation = "";
        }

        private void bEq_Click(object sender, EventArgs e)
        {
            operationPerf = true;

            switch (operation)
            {
                case "+": textbox.Text = (answer + Double.Parse(textbox.Text)).ToString(); 
                    break;
                case "-": textbox.Text = (answer - Double.Parse(textbox.Text)).ToString(); 
                    break;
                case "*": textbox.Text = (answer * Double.Parse(textbox.Text)).ToString(); 
                    break;
                case "/": textbox.Text = (answer / Double.Parse(textbox.Text)).ToString(); 
                    break;
                case "^": textbox.Text = (Math.Pow(answer, Double.Parse(textbox.Text))).ToString();
                    break;
                case "√": textbox.Text = (Math.Sqrt(Double.Parse(textbox.Text))).ToString();
                    break;
                default:
                    break;
            }
            label.Text = label.Text + " = " + textbox.Text;

            File.AppendAllText(file, Convert.ToString(label.Text) + Environment.NewLine);

            label.Text = "";
            answer = Double.Parse(textbox.Text);
            textbox.Text = answer.ToString();
            answer = 0;
            operation = "";
        }
        
        private void bMEM_Click(object sender, EventArgs e)
        {
            textboxmem.Text = String.Join("" + Environment.NewLine, File.ReadAllLines(file));
        }

        private void bMC_Click(object sender, EventArgs e)
        {
            File.WriteAllText(file, "");
            textboxmem.Text = "";
        }
    }
}
