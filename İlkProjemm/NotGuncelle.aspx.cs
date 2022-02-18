using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace İlkProjemm
{
    public partial class NotGuncelle : System.Web.UI.Page
    {
        public int nid;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                nid = Convert.ToInt32(Request.QueryString["NOTID"].ToString());

                DataSet1TableAdapters.OgrNotlarTableAdapter dt = new DataSet1TableAdapters.OgrNotlarTableAdapter();

                TxtOgrID.Text = dt.NotGetir2(nid)[0].OGRENCIID.ToString();
                TxtOgrAdSoyad.Text = dt.NotGetir2(nid)[0].OGRENCIADSOYAD.ToString();
                TxtDersAd.Text = dt.NotGetir2(nid)[0].Ders.ToString();
                TxtS1.Text = dt.NotGetir2(nid)[0].SINAV1.ToString();
                TxtS2.Text = dt.NotGetir2(nid)[0].SINAV2.ToString();
                TxtS3.Text = dt.NotGetir2(nid)[0].SINAV3.ToString();
                TxtOrtalama.Text = dt.NotGetir2(nid)[0].ORTALAMA.ToString();
                TxtDurum.Text = dt.NotGetir2(nid)[0].DURUM.ToString();
            }

        }

        protected void BtnHesapla_Click(object sender, EventArgs e)
        {
            double s1, s2, s3;
            double ortalama;
            s1 = Convert.ToInt32(TxtS1.Text);
            s2 = Convert.ToInt32(TxtS2.Text);
            s3 = Convert.ToInt32(TxtS3.Text);

            ortalama = (s1 + s2 + s3) / 3;

            TxtOrtalama.Text = ortalama.ToString("0.00");
            if (ortalama >= 50)
            {
                TxtDurum.Text = "True";
            }
            else
            {
                TxtDurum.Text = "False";
            }
        }

        protected void BtnGuncelle_Click(object sender, EventArgs e)
        {
            nid = Convert.ToInt32(Request.QueryString["NOTID"].ToString());

            DataSet1TableAdapters.OgrNotlarTableAdapter dt = new DataSet1TableAdapters.OgrNotlarTableAdapter();
            dt.NotGuncelleme(byte.Parse(TxtS1.Text), byte.Parse(TxtS2.Text), byte.Parse(TxtS3.Text), decimal.Parse(TxtOrtalama.Text), bool.Parse(TxtDurum.Text),nid);
            Response.Redirect("NotListesi.aspx");

        }
    }
}