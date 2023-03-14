using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb1
{
    public partial class SertifikaSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);
            DataSet1TableAdapters.SERTİFİKALARTableAdapter dt = new DataSet1TableAdapters.SERTİFİKALARTableAdapter();
            dt.SertifikaSil(Convert.ToInt16(id));
            Response.Redirect("SertifikaListesi.aspx");
        }
    }
}