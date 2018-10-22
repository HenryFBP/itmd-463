namespace Lab5
{
    public class MortgageLogEntry
    {
        private long time;
        private double principle;
        private double rate;
        private double years;

        public double Principle { get => principle; set => principle = value; }
        public long Time { get => time; set => time = value; }
        public double Rate { get => rate; set => rate = value; }
        public double Years { get => years; set => years = value; }

        public MortgageLogEntry(long time, double principle, double rate, double years)
        {
            this.Time = time;
            this.Principle = principle;
            this.Rate = rate;
            this.Years = years;
        }
    }
}