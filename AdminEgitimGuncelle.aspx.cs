using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb1
{
    public partial class AdminEgitimGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);
            txtID.Text = id.ToString();
            txtID.Enabled = false;
            if (Page.IsPostBack==false)
            {
                DataSet1TableAdapters.EGITIMTableAdapter dt = new DataSet1TableAdapters.EGITIMTableAdapter();
                txtBaslik.Text = dt.EgitimGetir(Convert.ToInt16(id))[0].BAŞLIK;
                txtAltbaslik.Text = dt.EgitimGetir(Convert.ToInt16(id))[0].ALTBAŞ;
                txtGnot.Text = dt.EgitimGetir(Convert.ToInt16(id))[0].GNOT;
                txtTarih.Text = dt.EgitimGetir(Convert.ToInt16(id))[0].TARİH;
                txtAciklama.Text = dt.EgitimGetir(Convert.ToInt16(id))[0].AÇIKLAMA;
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.EGITIMTableAdapter dt = new DataSet1TableAdapters.EGITIMTableAdapter();
            dt.EgitimGuncelle(txtBaslik.Text, txtAltbaslik.Text, txtGnot.Text, txtTarih.Text, txtAciklama.Text, Convert.ToInt16(txtID.Text));
            Response.Redirect("AdminEgitim.aspx");
        }
    }
}