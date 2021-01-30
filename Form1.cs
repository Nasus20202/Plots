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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData == Keys.Enter || keyData == Keys.D)
            {
                draw();
                return true;
            }
            if (keyData == (Keys.C | Keys.Shift))
            {
                clear();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            draw();
        }

        private void draw()
        {
            zeroDivide = false;
            genericError = false;
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
                        MessageBox.Show("Jeden z nawiasów jest niedomknięty");
                        return;
                    }
                }
            }
            if (brackets.Count != 0)
            {
                MessageBox.Show("Jeden z nawiasów jest niedomknięty");
                return;
            }
            List<double> dataXtemp = new List<double>();
            List<double> dataYtemp = new List<double>();
            int c = 0;
            for (double i = from; i <= to; i += step)
            {
                double x = i;
                double y = calculate(equation, x);
                dataXtemp.Add(x);
                dataYtemp.Add(y);
                c++;
            }
            double[] dataX = new double[c];
            double[] dataY = new double[c];
            for(int i = 0; i < c; i++)
            {
                dataX[i] = dataXtemp[i];
                dataY[i] = dataYtemp[i];
            }
            if (!genericError && !zeroDivide)
            {
                formsPlot1.plt.PlotScatter(dataX, dataY);
                formsPlot1.Render();
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            formsPlot1.plt.Clear();
            formsPlot1.Render();
        }

        static bool zeroDivide = false;
        static bool genericError = false;
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

            for (int k = 0; k < parts.Count; k++)
            {
                for (int i = 0; i < parts.Count; i++)
                {

                    string part = parts[i];
                    if (part.Contains("sin"))
                    {
                        try
                        {
                            string a;
                            try
                            {
                                a = parts[i + 1];
                            }
                            catch
                            {
                                a = "0";
                            }
                            string result = Convert.ToString(Math.Sin(Math.PI * Convert.ToDouble(a) / 180.0));
                            parts[i] = result;
                            parts.RemoveAt(i + 1);
                        }
                        catch
                        {
                            return 0;
                        }
                    }
                    if (part.Contains("cos"))
                    {
                        try
                        {
                            string a;
                            try
                            {
                                a = parts[i + 1];
                            }
                            catch
                            {
                                a = "0";
                            }
                            string result = Convert.ToString(Math.Cos(Math.PI * Convert.ToDouble(a) / 180.0));
                            parts[i] = result;
                            parts.RemoveAt(i + 1);
                        }
                        catch
                        {
                            return 0;
                        }
                    }
                    if (part.Contains("ctg"))
                    {
                        try
                        {
                            string a;
                            try
                            {
                                a = parts[i + 1];
                            }
                            catch
                            {
                                a = "0";
                            }
                            double ad = Convert.ToDouble(a);
                            double tg = Math.Tan(Math.PI * ad / 180.0);
                            string result;
                            if (tg != 0) {
                                result = Convert.ToString(1.0 / tg);
                            }
                            else
                            {
                                result = "0";
                            }
                            parts[i] = result;
                            parts.RemoveAt(i + 1);
                        }
                        catch
                        {
                            return 0;
                        }
                    }
                    else if (part.Contains("tg"))
                    {
                        try
                        {
                            string a;
                            try
                            {
                                a = parts[i + 1];
                            }
                            catch
                            {
                                a = "0";
                            }
                            double ad = Math.Round(Convert.ToDouble(a), 1);
                                string result = Convert.ToString(Math.Tan(Math.PI * ad / 180.0));
                                parts[i] = result;
                                parts.RemoveAt(i + 1);
                        }
                        catch
                        {
                            return 0;
                        }
                    }
                    

                }
            }

            // Power, root

            for (int k = 0; k < parts.Count; k++)
            {
                for (int i = 0; i < parts.Count; i++)
                {

                    string part = parts[i];
                    if (part.Contains("^"))
                    {
                        try
                        {
                            string a, b;
                            try
                            {
                                a = parts[i - 1];
                            }
                            catch
                            {
                                a = "0";
                            }
                            try
                            {
                                b = parts[i + 1];
                            }
                            catch
                            {
                                b = "0";
                            }
                            string result = Convert.ToString(Math.Pow(Convert.ToDouble(a), Convert.ToDouble(b)));
                            parts[i] = result;
                            parts.RemoveAt(i - 1);
                            parts.RemoveAt(i);
                        }
                        catch
                        {
                            return 0;
                        }
                    }
                    if (part.Contains("sqrt") || part.Contains("pierw2"))
                    {
                        try
                        {
                            string a;
                            try
                            {
                                a = parts[i + 1];
                            }
                            catch
                            {
                                a = "0";
                            }
                            string result = Convert.ToString(Math.Pow(Convert.ToDouble(a), 0.5));
                            parts[i] = result;
                            parts.RemoveAt(i + 1);
                        }
                        catch
                        {
                            return 0;
                        }
                    }
                    if (part.Contains("root") || part.Contains("pierw"))
                    {
                        try
                        {
                            string a, b;
                            try
                            {
                                a = parts[i+1];
                            }
                            catch
                            {
                                a = "1";
                            }
                            try
                            {
                                b = parts[i + 2];
                            }
                            catch
                            {
                                b = "0";
                            }
                            if (Convert.ToDouble(b) > 0)
                            {
                                string result = Convert.ToString(Math.Pow(Convert.ToDouble(b), 1 / Convert.ToDouble(a))); ;
                                parts[i] = result;
                                parts.RemoveAt(i + 1);
                                parts.RemoveAt(i + 1);
                            }
                        }
                        catch
                        {
                            return 0;
                        }
                    }
                }
            }

            // Multiply, divide


            for (int k = 0; k < parts.Count; k++)
            {
                for (int i = 0; i < parts.Count; i++)
                {

                    string part = parts[i];
                    if (part.Contains("*"))
                    {
                        try
                        {
                            string a, b;
                            try
                            {
                                a = parts[i - 1];
                            }
                            catch
                            {
                                a = "0";
                            }
                            try
                            {
                                b = parts[i + 1];
                            }
                            catch
                            {
                                b = "0";
                            }
                            string result = Convert.ToString(Convert.ToDouble(a) * Convert.ToDouble(b));
                            parts[i] = result;
                            parts.RemoveAt(i - 1);
                            parts.RemoveAt(i);
                        }
                        catch
                        {
                            return 0;
                        }
                    }
                    if (part.Contains("/"))
                    {
                        try
                        {
                            string a, b;
                            try
                            {
                                a = parts[i - 1];
                            }
                            catch
                            {
                                a = "0";
                            }
                            try
                            {
                                b = parts[i + 1];
                            }
                            catch
                            {
                                b = "1";
                            }
                            if (Convert.ToDouble(b) != 0)
                            {
                                string result = Convert.ToString(Convert.ToDouble(a) / Convert.ToDouble(b));
                                parts[i] = result;
                                parts.RemoveAt(i - 1);
                                parts.RemoveAt(i);
                            }
                            else
                            {
                                if (!zeroDivide)
                                {
                                    MessageBox.Show("Dzielenie przez zero", "Błąd matematyczny", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    zeroDivide = true;
                                }
                            }
                        }
                        catch
                        {
                            return 0;
                        }
                    }
                }
            }

            // Add, subtract

            for (int k = 0; k < parts.Count; k++)
            {
                for (int i = 0; i < parts.Count; i++)
                {

                    string part = parts[i];
                    if (part.Contains("+"))
                    {
                        try
                        {
                            string a, b;
                            try
                            {
                                a = parts[i - 1];
                            }
                            catch
                            {
                                a = "0";
                            }
                            try
                            {
                                b = parts[i + 1];
                            }
                            catch
                            {
                                b = "0";
                            }
                            string result = Convert.ToString(Convert.ToDouble(a) + Convert.ToDouble(b));
                            parts[i] = result;
                            parts.RemoveAt(i - 1);
                            parts.RemoveAt(i);
                        }
                        catch
                        {
                            return 0;
                        }
                    }
                    if (part.Contains("- "))
                    {
                        try
                        {
                            string a, b;
                            bool isA = true, isB = true;
                            if (i >= 1)
                            {
                                a = parts[i - 1];
                            }
                            else
                            {
                                a = "0";
                                isA = false;
                            }
                            if (i < parts.Count - 1)
                            {
                                b = parts[i + 1];
                            }
                            else
                            {
                                b = "0";
                                isB = false;
                            }
                            string result = Convert.ToString(Convert.ToDouble(a) - Convert.ToDouble(b));
                            //MessageBox.Show(result);
                            parts[i] = result;
                            if (isA && isB)
                            {
                                parts.RemoveAt(i - 1);
                                parts.RemoveAt(i);
                            }
                            else if (isA && !isB)
                            {
                                parts.RemoveAt(i - 1);
                            }
                            else if (!isA && isB)
                            {
                                parts.RemoveAt(i + 1);
                            }
                        }
                        catch
                        {
                            return 0;
                        }

                    }
                }
            }

            foreach(var part in parts)
            {
                //MessageBox.Show(part);
            }

            try
            {
                y = Convert.ToDouble(parts[0]);
            }
            catch
            {
                if (!genericError)
                {
                    MessageBox.Show("Błędne dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    genericError = true;
                }

                y = 0;
            }
            return y;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Nasus20202/Plots");
        }

        private void zapiszObrazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formsPlot1.plt.SaveFig("wykres.png");
        }

        private void zapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Pliki PNG (*.png)|*.png|Wszystkie pliki (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = "wykres.png";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                formsPlot1.plt.SaveFig(path);
            }
        }

        private void pomocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rówanie wpisz w pole do tego przeznaczone.\n" +
                "Wartość Od to wartość x początkowa.\n" +
                "Wartość Do to wartość x końcowa.\n" +
                "Wartość Krok to odległość pomiędzy punktami.\n\n" +
                "Operatory matematyczne typu + i * proszę odzielać spacjami od liczb.\n" +
                "Ułamki zapisujemy z użyciem przecinka, np. 0,4.\n\n" +
                "Funckcjonalność:\n" +
                "Dodawanie (+) - x + 2\n" +
                "Odejmowanie (-) - 5 - x\n" +
                "Mnożenie (*) - 3 * x\n" +
                "Dzielenie (/) - x / 0,5\n" +
                "Potęgowanie (^) - 2 ^ 3\n" +
                "Pierwiastek 2 stopnia (sqrt, pierw2) np. sqrt 4\n" +
                "Pierwiastek dowolnego stopnia (root, pierw) np. root 2 9 = 3\n" +
                "Nawiasy () - np. 5 - (2 + 3) = 0\n" +
                "Funckje trygonometryczne:\n" +
                "Sinus (sin) np. sin x\n" +
                "Cosinus (cos) np. cos 60\n" +
                "Tangens (tg) np. tg x\n" +
                "Cotangens (ctg) np. ctg 45\n\n\n" +
                "Przykład:" +
                "Równanie: x ^ 2 - 5 * x + 12\n" +
                "Od: -10\n" +
                "Do: 10\n" +
                "Krok: 0,1", "Pomoc",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Question);
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://swharden.com/scottplot/");
            System.Diagnostics.Process.Start("https://github.com/Nasus20202/Plots");
            MessageBox.Show("Autor: Krzysztof Nasuta\n\nProgram napisany w C# z użwyciem Windows Forms .NET oraz bibloteki ScottPlot.", "Info",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
