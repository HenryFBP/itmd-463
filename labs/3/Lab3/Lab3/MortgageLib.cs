using System;

namespace Lab3
{
    public static class MortgageLib
    {
        public static double MonthlyPayment(double principal, double rate, double years)
        {
            double top = (principal * rate) / 1200.0;

            double bot = 1 - Math.Pow(1.0 + (rate / 1200.0), -12.0 * years);

            double res = top / bot;

            Console.WriteLine("With a principle of ${0}, duration of {1} years and a interest rate of {2}% the monthly loan payment amount is {3:$0.00}", principal, years, rate, res);

            return res;
        }
    }
}