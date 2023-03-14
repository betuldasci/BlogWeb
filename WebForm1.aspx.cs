using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.HAKKIMDATableAdapter dt = new DataSet1TableAdapters.HAKKIMDATableAdapter();
            Repeater1.DataSource = dt.HakkımdaListele();
            Repeater1.DataBind();
            DataSet1TableAdapters.DENEYIMLERIMTableAdapter dt2 = new DataSet1TableAdapters.DENEYIMLERIMTableAdapter();
            Repeater2.DataSource = dt2.DeneyimlerListesi();
            Repeater2.DataBind();
            DataSet1TableAdapters.EGITIMTableAdapter dt3 = new DataSet1TableAdapters.EGITIMTableAdapter();
            Repeater3.DataSource = dt3.EgitimListesi();
            Repeater3.DataBind();
            DataSet1TableAdapters.YETENEKLERTableAdapter dt4 = new DataSet1TableAdapters.YETENEKLERTableAdapter();
            Repeater4.DataSource = dt4.YetenekListesi();
            Repeater4.DataBind();
            DataSet1TableAdapters.HOBİLERİMTableAdapter dt5 = new DataSet1TableAdapters.HOBİLERİMTableAdapter();
            Repeater5.DataSource = dt5.HobiListesi();
            Repeater5.DataBind();
            DataSet1TableAdapters.SERTİFİKALARTableAdapter dt6 = new DataSet1TableAdapters.SERTİFİKALARTableAdapter();
            Repeater6.DataSource = dt6.SertifikaListesi();
            Repeater6.DataBind();


            DataSet1TableAdapters.HAKKIMDATableAdapter dt7 = new DataSet1TableAdapters.HAKKIMDATableAdapter();
            Repeater7.DataSource = dt7.HakkımdaListele();
            Repeater7.DataBind();
        }
    }
}