using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false) // 
            {


                DataSet1TableAdapters.HAKKIMDATableAdapter dt = new DataSet1TableAdapters.HAKKIMDATableAdapter();
                TextBox1.Text = dt.HakkımdaListele()[0].AD; // burada 0 değeri, ilk çektiği değer. hafızaya aldıgın ilk şeye göre ad ı getir demek istedik.
                TextBox2.Text = dt.HakkımdaListele()[0].SOYAD;
                TextBox3.Text = dt.HakkımdaListele()[0].ADRES;
                TextBox4.Text = dt.HakkımdaListele()[0].TELEFON;
                TextBox5.Text = dt.HakkımdaListele()[0].KISANOT;
                TextBox6.Text = dt.HakkımdaListele()[0].MAİL;
                TextBox7.Text = dt.HakkımdaListele()[0].FOTOGRAF;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.HAKKIMDATableAdapter dt1 = new DataSet1TableAdapters.HAKKIMDATableAdapter();
            dt1.HakkımdaGuncelle(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text);
            Response.Redirect("WebForm1.aspx");
        }
    }
}