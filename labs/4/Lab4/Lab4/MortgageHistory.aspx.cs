using System;
using System.Web;

namespace Lab4
{
    public partial class MortgageHistory : System.Web.UI.Page
    {
        protected void populate_data()
        {
            String filepath = HttpContext.Current.Server.MapPath(MortgageLogger.LOGPATH);

            GridViewHistory.DataSource = CSVHelper.GetDataTabletFromCSVFile(filepath);

            GridViewHistory.DataBind();

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            populate_data();
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            String filepath = HttpContext.Current.Server.MapPath(MortgageLogger.LOGPATH);

            MortgageLogger.GenerateMortgageLogfile(filepath);

            populate_data();
        }
    }
}