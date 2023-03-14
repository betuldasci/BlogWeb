using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb1
{
    public partial class HobiGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);
            txtID.Text = id.ToString();
            txtID.Enabled = false;


            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.HOBİLERİMTableAdapter dt = new DataSet1TableAdapters.HOBİLERİMTableAdapter();
                txtHobi.Text = dt.HobileriGetir(Convert.ToInt16(id))[0].HOBİ;
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.HOBİLERİMTableAdapter dt = new DataSet1TableAdapters.HOBİLERİMTableAdapter();
            dt.HobiGuncelle(txtHobi.Text, Convert.ToInt16(txtID.Text));
            Response.Redirect("HobiListesi.aspx");
        }
    }
}