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
        public int DurationYears { get; set; }

        public MortgageInfo(double cost, double principle, double interestRate, int durationYears)
        {
            Cost = cost;
            Principle = principle;
            InterestRate = interestRate;
            DurationYears = durationYears;
        }
    }
}