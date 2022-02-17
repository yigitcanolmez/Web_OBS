using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace İlkProjemm
{
    public partial class DuyuruEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.TBL_OGRETMENTableAdapter dt = new DataSet1TableAdapters.TBL_OGRETMENTableAdapter();

                TxtDuyuruOgrt.DataSource = dt.OgrtList();
                TxtDuyuruOgrt.DataTextField = "OGRTAD";
                TxtDuyuruOgrt.DataValueField = "OGRTID";

                TxtDuyuruOgrt.DataBind();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_DUYURUTableAdapter dt = new DataSet1TableAdapters.TBL_DUYURUTableAdapter();
            dt.DuyuruEkle(TxtDuyuruBaslik.Text,TxtDuyuruIcerik.Value.ToString(),Convert.ToInt32(TxtDuyuruOgrt.SelectedValue));
            Response.Redirect("DuyuruListesi.aspx");
        }
    }
}