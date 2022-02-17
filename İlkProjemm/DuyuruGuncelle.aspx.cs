using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace İlkProjemm
{
    public partial class DuyuruGuncelle : System.Web.UI.Page
    {
        public int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack == false)
            {
                id = Convert.ToInt32(Request.QueryString["DUYURUID"].ToString());
                DataSet1TableAdapters.TBL_DUYURUTableAdapter dt = new DataSet1TableAdapters.TBL_DUYURUTableAdapter();

                TxtDuyuruID.Text = id.ToString();
                TxtDuyuruBaslik.Text = dt.DUYURUGUNCELLE(id)[0].DUYURUBASLIK;
                TxtDuyuruIcerik.Value = dt.DUYURUGUNCELLE(id)[0].DUYURUICERIK;
                

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_DUYURUTableAdapter dt = new DataSet1TableAdapters.TBL_DUYURUTableAdapter();
            dt.duyuruguncellmeislme(TxtDuyuruBaslik.Text,TxtDuyuruIcerik.Value,Convert.ToInt32( TxtDuyuruID.Text));
            Response.Redirect("DuyuruListesi.aspx");
        }
    }
}