using System;
using System.Collections.Generic;
using System.Web.UI.HtmlControls;

namespace Lab1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            foreach (var item in BinaryFunctions.dict)
            {
                ops.Items.Add(item.Key);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {


            if (Page.IsPostBack)
            {
                double? a = null;
                double? b = null;

                List<String> problems = new List<string>();

                try
                {
                    a = double.Parse(op1.Text);
                }
                catch (System.FormatException)
                {
                    problems.Add($"Op1, '{op1.Text}' is not a number!\n");
                }

                try
                {
                    b = double.Parse(op2.Text);
                }
                catch (System.FormatException)
                {
                    problems.Add($"Op2, '{op2.Text}' is not a number!\n");
                }

                if (problems.Count == 0)
                {
                    string op = ops.SelectedItem.Text;

                    double res = BinaryFunctions.dict[op].Calculate(new double[] { (double)a, (double)b });

                    result.Text = res.ToString();
                }
                else
                {
                    foreach (String s in problems)
                    {
                        var li = new HtmlGenericControl("li");
                        var p = new HtmlGenericControl("p");

                        p.InnerText = s; //add our problem to the paragraph.
                        li.Controls.Add(p); //add our paragraph to the list item
                        problemsul.Controls.Add(li); //add our list item to the ul.
                    }
                }


            }

        }
    }
}