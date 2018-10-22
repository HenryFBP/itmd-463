using System;
using System.Web;

namespace Lab5
{
    public partial class MortgageHistory : System.Web.UI.Page
    {
        protected void PopulateData()
        {
            GridViewHistory.DataSource = MortgageLoggerSQL.GetDataTable();

            GridViewHistory.DataBind();

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            PopulateData();
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            MortgageLoggerSQL.DeleteAllRows();
        }
    }
}