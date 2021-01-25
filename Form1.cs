using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plots
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }   

        private void formsPlot1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            string equation = equationText.Text;
            double from = 0, to = 0, step = 0;
            try
            {
                from = Convert.ToDouble(fromText.Text);
                to = Convert.ToDouble(toText.Text);
                step = Convert.ToDouble(stepText.Text);
                if (to <= from)
                {
                    MessageBox.Show("Wartość Do powinna być większa od wartości Od");
                    return;
                }
                else if (step >= to - from)
                {
                    MessageBox.Show("Wartość Krok powinna być mniejsza od różnicy Od i Do");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Podaj prawidłowe wartości Od, Do i Krok");
                return;
            }
            Stack<bool> brackets = new Stack<bool>();
            foreach(char ch in equation)
            {
                if(ch == '(')
                {
                    brackets.Push(true);
                }
                if(ch == ')')
                {
                    if (brackets.Count>=1)
                    {
                        if (brackets.Peek() == true)
                        {
                            brackets.Pop();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Jeden z nawiasów jest niedokmnięty");
                        return;
                    }
                }
            }
            if (brackets.Count != 0)
            {
                MessageBox.Show("Jeden z nawiasów jest niedokmnięty");
                return;
            }
            for(double i = from; i <=to; i+=step)
            {
                double x = i;
                double y = calculate(equation, x);

            }

            double[] dataX = new double[] { 1, 2 };
            double[] dataY = new double[] { 3, 4 };

            formsPlot1.plt.PlotScatter(dataX, dataY);
            formsPlot1.Render();
        }

        private double calculate(string equation, double x)
        {
            double y = 0; int bracketsOpened = 0;
            List<string> parts = new List<string>();
            string temp = String.Empty;
            int c = 0;
            foreach (char ch in equation)
            {
                c++;
                if (ch == '(')
                {
                    bracketsOpened++;
                    temp += ch;
                }
                else if (ch == ')')
                {
                    bracketsOpened--;
                    temp += ch;
                    if (temp != " " && temp != "" && bracketsOpened == 0)
                    {
                        
                        parts.Add(temp);
                        temp = String.Empty;
                    }
                    
                   
                }
                else
                {
                    if (ch == ' ' && bracketsOpened == 0)
                    {
                        temp += ch;
                        if (temp != " " && temp != "")
                        {
                            
                            parts.Add(temp);
                        }
                        temp = String.Empty;
                    }
                    else if (c == equation.Length)
                    {
                        temp += ch;
                        if (temp != " " && temp != "")
                        {
                            parts.Add(temp);
                        }

                    }
                    else
                    {
                        temp += ch;
                    }
                }
            }

            for (int i = 0; i < parts.Count; i++)
            {
                string part = parts[i];
                MessageBox.Show(part);
            }

            // Brackets
            for (int i = 0; i < parts.Count; i++)
            {
                string part = parts[i];
                if (part.Contains('(') && part.Contains(')'))
                {
                    String newPart = String.Empty;
                    string newEquation = String.Empty;
                    for (int j = 1; j < part.Length - 1; j++)
                    {
                        newEquation += part[j];
                        
                    }
                    newPart = calculate(newEquation, x).ToString();
                    MessageBox.Show(newEquation);
                    parts[i] = newPart;
                }
            }
            // x

            for (int i = 0; i < parts.Count; i++)
            {
                string part = parts[i];
                if (part.Contains("x"))
                {
                    string newPart = String.Empty;
                    foreach(char ch in part)
                    {
                        if (ch != 'x') {
                            newPart += ch;
                        }
                        else
                        {
                            newPart = x.ToString();
                        }
                    }
                    parts[i] = newPart;
                }
            }

            // Trigonometry



            // Power, root

            // Multiply, divide

            // Add, subtract

            for (int i = 0; i < parts.Count; i++)
            {
                string part = parts[i];
                MessageBox.Show(part);
            }
            return y;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
