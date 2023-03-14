using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb1
{
    public partial class SertifikaListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.SERTİFİKALARTableAdapter dt = new DataSet1TableAdapters.SERTİFİKALARTableAdapter();
            Repeater1.DataSource = dt.SertifikaListesi();
            Repeater1.DataBind();

        }
    }
}