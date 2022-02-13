using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace İlkProjemm
{
    public partial class OgrGuncelle : System.Web.UI.Page
    {
        public int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                try
                {
                     id = Convert.ToInt32(Request.QueryString["OGRID"]);
                    DataSet1TableAdapters.TBL_OGRENCITableAdapter dt = new DataSet1TableAdapters.TBL_OGRENCITableAdapter();

                    TxtOgrID.Text = id.ToString();
                    TxtOgrAD.Text = dt.OgrSec(id)[0].OGRAD;
                    TxtOgrSoyad.Text = dt.OgrSec(id)[0].OGRSOYAD;
                    TxtOgrMail.Text = dt.OgrSec(id)[0].OGRMAİL;
                    TxtOgrTelefon.Text = dt.OgrSec(id)[0].OGRTELEFON;
                    TxtOgrSifre.Text = dt.OgrSec(id)[0].OGRSIFRE;
                    TxtOgrFoto.Text = dt.OgrSec(id)[0].OGRFOTOGRAF;

                }
                catch (Exception)
                {

                    TxtOgrFoto.Text = " LİNK GİRİN ";
                }
            }

          

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_OGRENCITableAdapter dt = new DataSet1TableAdapters.TBL_OGRENCITableAdapter();
            dt.OgrGuncelle(TxtOgrAD.Text,TxtOgrSoyad.Text,TxtOgrTelefon.Text,TxtOgrMail.Text,TxtOgrSifre.Text,TxtOgrFoto.Text, Convert.ToInt32( TxtOgrID.Text));
            Response.Redirect("Default.aspx");
        }
    }
}