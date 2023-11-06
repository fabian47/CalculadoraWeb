using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculadora
{
    public partial class calculadora_default : System.Web.UI.Page
    {
        private double? primerNumero = null;
        private double? segundoNumero = 0;
        private double? resultado = 0;
        string number_operator = "";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cinco_Click(object sender, EventArgs e)
        {
            TDisplay.Text += "5";
        }

        protected void siete_Click(object sender, EventArgs e)
        {

            TDisplay.Text += "7";

        }

        protected void cuatro_Click(object sender, EventArgs e)
        {
            TDisplay.Text += "4";
        }

        protected void uno_Click(object sender, EventArgs e)
        {
            TDisplay.Text += "1";
        }

        protected void ocho_Click(object sender, EventArgs e)
        {
            TDisplay.Text += "8";
        }

        protected void dos_Click(object sender, EventArgs e)
        {
            TDisplay.Text += "2";
        }

        protected void cero_Click(object sender, EventArgs e)
        {
            TDisplay.Text += "0";
        }

        protected void nueve_Click(object sender, EventArgs e)
        {
            TDisplay.Text += "9";
        }

        protected void seis_Click(object sender, EventArgs e)
        {
            TDisplay.Text += "6";
        }

        protected void tres_Click(object sender, EventArgs e)
        {
            TDisplay.Text += "3";
        }

        protected void delete_Click(object sender, EventArgs e)
        {
            TDisplay.Text = TDisplay.Text.Substring(0, TDisplay.Text.Length - 1);
        }


        protected void clear_Click(object sender, EventArgs e)
        {
            TDisplay.Text = "";
        }

        protected void mas_Click(object sender, EventArgs e)
        {
            TDisplay.Text += "+";
        }

        protected void coma_Click(object sender, EventArgs e)
        {
            TDisplay.Text += ",";
        }

        protected void masmenos_Click(object sender, EventArgs e)
        {
            {
                if (TDisplay.Text.Length > 0 && TDisplay.Text[0] == '-')
                {
                    TDisplay.Text = TDisplay.Text.Substring(1);
                }
                else if (TDisplay.Text.Length > 0 && TDisplay.Text[0] != '-')
                {
                    TDisplay.Text = "-" + TDisplay.Text;
                }
            }
        }

        protected void nsigno_Click(object sender, EventArgs e)
        {
            TDisplay.Text += "n!";
        }

        protected void xdos_Click(object sender, EventArgs e)
        {
            TDisplay.Text += "x²";
        }

        protected void RAIZ_Click(object sender, EventArgs e)
        {
            TDisplay.Text += "²√x";
        }

        protected void igual_Click(object sender, EventArgs e)
        {
            // Get the text from the display
            string text = TDisplay.Text;

            // Check for addition
            if (text.Contains("+"))
            {
                string[] parts = text.Split('+');
                if (parts.Length == 2)
                {
                    double num1, num2;
                    if (double.TryParse(parts[0], out num1) && double.TryParse(parts[1], out num2))
                    {
                        TDisplay.Text = (num1 + num2).ToString();
                    }
                    else
                    {
                        TDisplay.Text = "Error: Invalid input";
                    }
                }
                else
                {
                    TDisplay.Text = "Error: Invalid input";
                }
            }

            // Check for subtraction
            else if (text.Contains("-"))
            {
                string[] parts = text.Split('-');
                if (parts.Length == 2)
                {
                    double num1, num2;
                    if (double.TryParse(parts[0], out num1) && double.TryParse(parts[1], out num2))
                    {
                        TDisplay.Text = (num1 - num2).ToString();
                    }
                    else
                    {
                        TDisplay.Text = "Error: Invalid input";
                    }
                }
                else
                {
                    TDisplay.Text = "Error: Invalid input";
                }
            }

            // Check for multiplication
            else if (text.Contains("*"))
            {
                string[] parts = text.Split('*');
                if (parts.Length == 2)
                {
                    double num1, num2;
                    if (double.TryParse(parts[0], out num1) && double.TryParse(parts[1], out num2))
                    {
                        TDisplay.Text = (num1 * num2).ToString();
                    }
                    else
                    {
                        TDisplay.Text = "Error: Invalid input";
                    }
                }
                else
                {
                    TDisplay.Text = "Error: Invalid input";
                }
            }

            // Check for division
            else if (text.Contains("/"))
            {
                string[] parts = text.Split('/');
                if (parts.Length == 2)
                {
                    double num1, num2;
                    if (double.TryParse(parts[0], out num1) && double.TryParse(parts[1], out num2))
                    {
                        if (num2 != 0)
                        {
                            TDisplay.Text = (num1 / num2).ToString();
                        }
                        else
                        {
                            TDisplay.Text = "Error: Division by zero";
                        }
                    }
                    else
                    {
                        TDisplay.Text = "Error: Invalid input";
                    }
                }
                else
                {
                    TDisplay.Text = "Error: Invalid input";
                }
            }
            else if (text.Contains("long"))
            {
                // Extract the number after "long" (e.g., "long5" => "5")
                string numberString = text.Replace("long", "");
                double number;

                if (double.TryParse(numberString, out number))
                {
                    if (number > 0)
                    {
                        double result = Math.Log(number);
                        TDisplay.Text = result.ToString();
                    }
                    else
                    {
                        TDisplay.Text = "Error: Invalid input";
                    }
                }
                else
                {
                    TDisplay.Text = "Error: Invalid input";
                }
            }
            else if (text.Contains("²√x"))
            {
                // Extract the number after "²√x" (e.g., "²√x16" => "16")
                string numberString = text.Replace("²√x", "");
                double number;

                if (double.TryParse(numberString, out number))
                {
                    if (number >= 0)
                    {
                        double result = Math.Sqrt(number);
                        TDisplay.Text = result.ToString();
                    }
                    else
                    {
                        TDisplay.Text = "Error: Invalid input";
                    }
                }
                else
                {
                    TDisplay.Text = "Error: Invalid input";
                }
            }
            else if (text.Contains("n!"))
            {
                // Extract the number before "n!" (e.g., "5!" => "5")
                string numberString = text.Replace("n!", "");
                int number;

                if (int.TryParse(numberString, out number))
                {
                    if (number >= 0)
                    {
                        int result = 1;
                        for (int i = 2; i <= number; i++)
                        {
                            result *= i;
                        }
                        TDisplay.Text = result.ToString();
                    }
                    else
                    {
                        TDisplay.Text = "Error: Invalid input";
                    }
                }
                else
                {
                    TDisplay.Text = "Error: Invalid input";
                }
            }
            else if (text.Contains("x^y"))
            {
                // Split the text into two parts based on "x^y"
                string[] parts = text.Split(new string[] { "x^y" }, StringSplitOptions.None);

                if (parts.Length == 2)
                {
                    double baseNumber, exponent;
                    if (double.TryParse(parts[0], out baseNumber) && double.TryParse(parts[1], out exponent))
                    {
                        double result = Math.Pow(baseNumber, exponent);
                        TDisplay.Text = result.ToString();
                    }
                    else
                    {
                        TDisplay.Text = "Error: Invalid input";
                    }
                }
                else
                {
                    TDisplay.Text = "Error: Invalid input";
                }
            }
            else if (text.Contains("x²"))
            {
                // Extract the number before "x²" (e.g., "4²" => "4")
                string numberString = text.Replace("x²", "");
                double number;

                if (double.TryParse(numberString, out number))
                {
                    double result = number * number;
                    TDisplay.Text = result.ToString();
                }
                else
                {
                    TDisplay.Text = "Error: Invalid input";
                }
            }
            else if (text.Contains("10^x"))
            {
                // Extract the number after "10^x" (e.g., "10^x3" => "3")
                string numberString = text.Replace("10^x", "");
                double number;

                if (double.TryParse(numberString, out number))
                {
                    double result = Math.Pow(10, number);
                    TDisplay.Text = result.ToString();
                }
                else
                {
                    TDisplay.Text = "Error: Invalid input";
                }
            }


        }

        protected void resta_Click(object sender, EventArgs e)
        {
            TDisplay.Text += "-";
        }

        protected void multiplicacion_Click(object sender, EventArgs e)
        {
            TDisplay.Text += "*";
        }

        protected void division_Click(object sender, EventArgs e)
        {
            TDisplay.Text += "/";
        }

        protected void pordiez_Click(object sender, EventArgs e)
        {
            TDisplay.Text += "*10";
        }

        protected void xelevado_Click(object sender, EventArgs e)
        {
            TDisplay.Text += "x^y";
        }

        protected void long_Click(object sender, EventArgs e)
        {
            TDisplay.Text += "long";
        }
    }
}