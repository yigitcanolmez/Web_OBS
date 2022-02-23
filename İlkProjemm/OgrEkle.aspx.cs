using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace İlkProjemm
{
    public partial class OgrEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_OGRENCITableAdapter dt = new DataSet1TableAdapters.TBL_OGRENCITableAdapter();
            dt.OgrEkle(TxtOgrAD.Text,TxtOgrSoyad.Text,txtNumara.Text,TxtOgrTelefon.Text,TxtOgrMail.Text,TxtOgrSifre.Text,TxtOgrFoto.Text);
            Response.Redirect("Default.aspx");    
        }
    }
}