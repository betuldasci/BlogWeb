using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb1
{
    public partial class YetenekListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.YETENEKLERTableAdapter dt = new DataSet1TableAdapters.YETENEKLERTableAdapter();
            Repeater1.DataSource = dt.YetenekListesi();
            Repeater1.DataBind();
        }
    }
}