using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sbecker1730ex2f1
{
    public class Ex2fCalculations
    {
        public static string Calc01(string input)
        {
            // #1: if
            decimal subtotal = 0.0m;
            decimal discountPercent = 0.0m;
            subtotal = Decimal.Parse(input);
            if (subtotal >= 100)
                discountPercent = 0.2m;
            return discountPercent.ToString("n2");
        }

        public static string Calc02(string input)
        {
            // #2: if {block}
            decimal subtotal = 0.0m;
            decimal discountPercent = 0.0m;
            subtotal = Decimal.Parse(input);
            string status = "Standard rate: ";
            if (subtotal >= 100m)
            {
                discountPercent = 0.2m;
                status = "Bulk rate: " + discountPercent.ToString("n2");
            }
            return status;
        }

        public static string Calc03(string input)
        {

            // #3: if else
            decimal subtotal = 0.0m;
            decimal discountPercent = 0.0m;
            subtotal = Decimal.Parse(input);
            discountPercent = 0m;
            if (subtotal >= 100m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc04(string input)
        {
            decimal subtotal = 0.0m;
            decimal discountPercent = 0.0m;
            subtotal = Decimal.Parse(input);
            discountPercent = 0m;
            if (subtotal >= 100m && subtotal < 200)
                discountPercent = 0.2m;
            else if (subtotal >= 200m && subtotal < 300)
                discountPercent = 0.3m;
            else if (subtotal >= 300m)
                discountPercent = 0.4m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc05(string input)
        {
            decimal subtotal = 0.0m;
            decimal discountPercent = 0.0m;
            subtotal = Decimal.Parse(input);
            discountPercent = 0m;
            if (subtotal >= 300m)
                discountPercent = 0.4m;
            else if (subtotal >= 200m)
                discountPercent = 0.3m;
            else if (subtotal >= 100m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc06(string inputA, string inputB)
        {
            decimal subtotal = 0.0m;
            decimal discountPercent = 0.0m;
            subtotal = Decimal.Parse(inputA);
            string customerType = inputB;
            discountPercent = 0m;
            if (customerType == "R")
            {
                if (subtotal >= 100m)
                    discountPercent = 0.2m;
                else
                    discountPercent = 0.1m;
            }
            else          // customerType isn't "R"
                discountPercent = 0.4m;
            return discountPercent.ToString("n2");
        }

        public static string Calc07(string input)
        {
            // #7 Validate input: non-empty string
            decimal ethereum = 0m;
            if (input != "")
            {
                decimal dollars = Decimal.Parse(input);
                ethereum = 200m * dollars;
                return ethereum.ToString("n2");

                }
            return "Invalid input";
        }

        public static string Calc08(string inputA, string inputB)
        {
            // #8 Validate input, calculate quantity * price, shipping
            decimal total = 0;
            if (inputA != "" && inputB != "") ;
            return "Invalid input";
        }

        public static string Calc09(string inputA, string inputB)
        {
            // #9 Validate input, calculate difference * rate
            
        }

        public static string Calc10(string inputA, string inputB)
        {
            // #10 Validate input, divide large num by small
            //     Both numbers must be > 0
            double result = 0.0;
            if (inputA != "" && inputB != "") ;
            return "Invalid input";

        }
    }
}
