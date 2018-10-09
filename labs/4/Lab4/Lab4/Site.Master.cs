using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab4
{
    public partial class SiteMaster : MasterPage
    {

        // Hi prof. I'm abusing the UTF-8 support pretty hard.

        // Did you notice the zero-width spaces? There are two.
        〇﹏〇​ᖴᖇᑌIT​〤﹏〤​ ʄʀʊɨȶ = new 〇﹏〇​ᖴᖇᑌIT​〤﹏〤​(HttpContext.Current.Server.MapPath(〇﹏〇​ᖴᖇᑌIT​〤﹏〤​.DATA_PATH));

        protected void Page_Load(object sender, EventArgs e)
        {
        }
        
        // Give them the time.
        protected void TimerTime_Tick(object sender, EventArgs e)
        {
            LabelTime.Text = DateTime.Now.ToString("hh:mm:ss");
            Console.WriteLine("Tick!");
        }

        // Give them random fruit!
        protected void TimerFruit_Tick(object sender, EventArgs e)
        {
            LabelFruit.Text = ʄʀʊɨȶ.ЯΛПDӨMFЯЦIƬ();
        }

    }
}