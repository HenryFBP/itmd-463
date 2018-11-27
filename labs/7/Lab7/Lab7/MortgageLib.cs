using Lab7.Models;
using System;

namespace Lab7
{
    public static class MortgageLib
    {
        public static double MonthlyPayment(double principal, double rate, double years)
        {
            double top = (principal * rate) / 1200.0;

            double bot = 1 - Math.Pow(1.0 + (rate / 1200.0), -12.0 * years);

            double res = top / bot;

            // Console.Write(principal);
            // Console.Write(rate);
            // Console.Write(years);
            // Console.WriteLine(res);

            return res;
        }

        public static double MonthlyPayment(MortgageInfo m)
        {
            return MonthlyPayment(m.Principle, m.InterestRate, m.DurationYears);
        }
    }
}