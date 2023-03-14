using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb1
{
    public partial class AdminDeneyimler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.DENEYIMLERIMTableAdapter dt = new DataSet1TableAdapters.DENEYIMLERIMTableAdapter();
            Repeater1.DataSource = dt.DeneyimlerListesi();
            Repeater1.DataBind();
        }
    }
}