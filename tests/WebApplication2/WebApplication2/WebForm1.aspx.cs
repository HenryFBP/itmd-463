using System;
using System.IO;
using System.Web.UI;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                TextBoxOutput.Text = "You entered: " + TextBox1.Text;
            }
            else
            {
                using (StreamWriter sw = System.IO.File.AppendText(Server.MapPath("/App_Data/access.log")))
                {
                    sw.Write($"WebForm1 accessed at {System.DateTime.UtcNow}.\n");

                    sw.Flush();
                }


            }
        }
    }
}