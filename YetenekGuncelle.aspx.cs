using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb1
{
    public partial class YetenekGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);
            txtID.Text = id.ToString();
            txtID.Enabled = false;

            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.YETENEKLERTableAdapter dt = new DataSet1TableAdapters.YETENEKLERTableAdapter();
                txtYetenek.Text = dt.YetenekGetir(Convert.ToInt16(id))[0].YETENEK;
            }
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.YETENEKLERTableAdapter dt = new DataSet1TableAdapters.YETENEKLERTableAdapter();
            dt.YetenekGuncelle(txtYetenek.Text, Convert.ToInt16(txtID.Text));
            Response.Redirect("YetenekListesi.aspx");
        }
    }
}