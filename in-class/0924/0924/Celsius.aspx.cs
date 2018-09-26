using System;

namespace _0924
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String s = TextBoxCelsius.Text;

            float c = float.Parse(s);

            float f = TemperatureSolver.ctof(c);

            TextBoxFahrenheit.Text = f.ToString();
        }
    }
}