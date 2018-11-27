using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab7.Models
{
    public class MortgageInfo
    {
        public double Cost { get; set; }
        public double Principle { get; set; }
        public double InterestRate { get; set; }
        public double DurationYears { get; set; }
        public double MonthlyPayment { get; set; }
    }
}