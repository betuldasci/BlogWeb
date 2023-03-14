using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb1
{
    public partial class AdminDeneyimGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);
            txtID.Enabled = false;
            txtID.Text = id.ToString();
            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.DENEYIMLERIMTableAdapter dt = new DataSet1TableAdapters.DENEYIMLERIMTableAdapter();
                txtBaslik.Text = dt.DeneyimGetir(Convert.ToInt16(id))[0].BAŞLIK;
                txtAltbaslik.Text = dt.DeneyimGetir(Convert.ToInt16(id))[0].ALTBAŞLIK;
                txtAciklama.Text = dt.DeneyimGetir(Convert.ToInt16(id))[0].AÇIKLAMA;
                txtTarih.Text = dt.DeneyimGetir(Convert.ToInt16(id))[0].TARİH;
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.DENEYIMLERIMTableAdapter dt = new DataSet1TableAdapters.DENEYIMLERIMTableAdapter();
            dt.DeneyimGuncelle(txtBaslik.Text, txtAltbaslik.Text, txtAciklama.Text, txtTarih.Text, Convert.ToInt16(txtID.Text));
            Response.Redirect("AdminDeneyimler.aspx");
        }
    }
}