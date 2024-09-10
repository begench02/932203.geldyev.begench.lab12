using System;

namespace W932203_Geldyev_lab12.Models
{
    public class Actions
    {
        public string value1 { get; set; }
        public string value2 { get; set; }
        public string operation { get; set; }

        public string getResult()
        {
            int a = Int32.Parse(value1);
            int b = Int32.Parse(value2);
            switch ((int)Convert.ToChar(operation))
            {
                case 42: return (value1) + " * " + (value2) + " = " + (a * b);
                case 43: return (value1) + " + " + (value2) + " = " + (a + b);
                case 45: return (value1) + " - " + (value2) + " = " + (a - b);
                case 47:
                    try
                    {
                        return (value1) + " / " + (value2) + " = " + (a / b);
                    }
                    catch (DivideByZeroException)
                    {
                        return "Division by zero!";
                    }

            }
            return "b";
        }
        public string getResultModel()
        {
            int a = Int32.Parse(value1);
            int b = Int32.Parse(value2);
            int c;
            switch ((int)Convert.ToChar(operation))
            {
                case 42:
                    c = a * b;
                    return c.ToString();
                case 43:
                    c = a + b;
                    return c.ToString();
                case 45:
                    c = a - b;
                    return c.ToString();
                case 47:
                    try
                    {
                        c = a / b;
                        return c.ToString();
                    }
                    catch (DivideByZeroException)
                    {
                        return "Division by zero!";
                    }
            }
            return "b";
        }
    }
}
