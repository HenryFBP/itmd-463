using System;
using System.Web;

namespace Lab3
{
    public partial class MortgageHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String filepath = HttpContext.Current.Server.MapPath(MortgageLogger.LOGPATH);

            GridViewHistory.DataSource = CSVHelper.GetDataTabletFromCSVFile(filepath);

            GridViewHistory.DataBind();
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            String filepath = HttpContext.Current.Server.MapPath(MortgageLogger.LOGPATH);

            MortgageLogger.GenerateMortgageLogfile(filepath);

            // Refresh the page.
            Page.Response.Redirect(Page.Request.Url.ToString(), true);
        }
    }
}