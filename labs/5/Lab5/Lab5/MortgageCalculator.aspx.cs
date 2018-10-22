using System;

namespace Lab5
{
    public partial class MortgageCalculator : System.Web.UI.Page
    {


        public static double[] GeneratePercents(double min = 0.25, double max = 10.0, double step = 0.25)
        {

            int size = (int)((max - min) / step) + 1;

            double[] ret = new double[size];

            for (int i = 0; i < size; i++)
            {
                ret[i] = ((i * step) + min);
            }

            return ret;
        }

        protected void PostBackYears(object sender, EventArgs e)
        {
            if (RadioButtonListYears.SelectedItem != null &&
                RadioButtonListYears.SelectedItem.Value is "other")
            {
                TextBoxYearsOther.Enabled = true;
            }
            else
            {
                TextBoxYearsOther.Enabled = false;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            // If our interest rates are unpopulated
            if (DropDownListInterestRate.Items.Count is 0)
            {
                double[] percents = GeneratePercents();

                foreach (double d in percents)
                {
                    DropDownListInterestRate.Items.Add(d.ToString());
                }
            }

            if (IsPostBack)
            {
                BulletedListProblems.Items.Clear();

                double years = 0;
                double principal = 0;
                double interestrate = 0;

                // Try to get the years.
                if (RadioButtonListYears.SelectedItem != null)
                {
                    // They've selected an 'other' year.
                    if (RadioButtonListYears.SelectedItem.Value is "other")
                    {
                        try
                        {
                            years = Double.Parse(TextBoxYearsOther.Text);
                        }
                        catch (FormatException)
                        {
                            BulletedListProblems.Items.Add("Years is an invalid number.");
                        }
                    }
                    else // They've selected a year from our radio buttons.
                    {
                        try
                        {
                            years = Double.Parse(RadioButtonListYears.SelectedItem.Value);
                        }
                        catch (FormatException)
                        {
                            BulletedListProblems.Items.Add("Years is an invalid number.");
                        }
                    }
                }
                else // They have not selected a radio button.
                {
                    BulletedListProblems.Items.Add("No year selected.");
                }

                // Try to get the principal.
                try
                {
                    principal = Double.Parse(TextBoxPrinciple.Text);
                }
                catch (FormatException)
                {
                    BulletedListProblems.Items.Add("Principle is an invalid number.");
                }

                // Try to get the interest rate.
                try
                {
                    interestrate = Double.Parse(DropDownListInterestRate.SelectedValue);
                }
                catch (FormatException)
                {
                    BulletedListProblems.Items.Add("Interest rate is an invalid number.");
                }

                // If there are no problems
                if (BulletedListProblems.Items.Count is 0)
                {
                    double res = MortgageLib.MonthlyPayment(principal, interestrate, years);

                    // Seconds since UNIX epoch.
                    int secs = (int)((DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds);

                    MortgageLoggerSQL.TryCreateTables();

                    // Log a single mortgage.
                    MortgageLoggerSQL.Log(new MortgageLogEntry(secs, principal, interestrate, years));

                    string str = res.ToString("n2");

                    str = "$" + str;

                    TextBoxResult.Text = str;
                }
                else
                {
                    TextBoxResult.Text = null;
                }

            }
            else // Not postback.
            {

            }
        }

    }
}