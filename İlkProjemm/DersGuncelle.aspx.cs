using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace İlkProjemm
{
    public partial class DersGuncelle : System.Web.UI.Page
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                id = Convert.ToInt32(Request.QueryString["DERSID"].ToString());

                DataSet1TableAdapters.TBL_DERSLERTableAdapter dt = new DataSet1TableAdapters.TBL_DERSLERTableAdapter();

                dt.dersgetir(id);
                TxtDersID.Text = dt.dersgetir(id)[0].DERSID.ToString();
                TxtDers.Text = dt.dersgetir(id)[0].DERSAD.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            id = Convert.ToInt32(Request.QueryString["DERSID"].ToString());

            DataSet1TableAdapters.TBL_DERSLERTableAdapter dt = new DataSet1TableAdapters.TBL_DERSLERTableAdapter();
            dt.DersGuncelle(TxtDers.Text,id);

            Response.Redirect("DersListesi.aspx");
            

        }
    }
}