using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb1
{
    public partial class AdminDeneyimSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);

            DataSet1TableAdapters.DENEYIMLERIMTableAdapter dt = new DataSet1TableAdapters.DENEYIMLERIMTableAdapter();
            dt.DeneyimSil(Convert.ToInt16(id));
            Response.Redirect("AdminDeneyimler.aspx");
        }
    }
}