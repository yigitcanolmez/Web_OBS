using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace İlkProjemm
{
    public partial class İstatistikler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_OGRENCI1TableAdapter dt = new DataSet1TableAdapters.TBL_OGRENCI1TableAdapter();
            TxtOgrenciSayisi.Text = "Toplam Öğrenci Sayısı : " + dt.OgrSayısı();

            DataSet1TableAdapters.TBL_OGRETMENTableAdapter dt0 = new DataSet1TableAdapters.TBL_OGRETMENTableAdapter();
            TxtOgrtSayisi.Text = "Toplam Öğretmen Sayısı : " + dt0.OgrtmenSay();

            DataSet1TableAdapters.TBL_DERSLERTableAdapter dt1 = new DataSet1TableAdapters.TBL_DERSLERTableAdapter();
            TxtDersSayisi.Text = "Toplam Ders Sayısı : " + dt1.DersSay();

            TextBox2.Text = "Veri Tabanı Dersinin En Başarılı Öğrencisi : " + dt.Veritabani();
            TextBox1.Text = "Sistemdeki Duyuru Sayısı : " + dt.DuyuruSAY();
            TextBox3.Text = "Temel Programlama Dersinin En Başarılı Öğrencisi : " + dt.TemelProg();
            TextBox4.Text = "Algoritma Dersinin En Başarılı Öğrencisi : " + dt.Algoritma();
            TextBox5.Text = "Grafik Tasarım Dersinin En Başarılı Öğrencisi : " + dt.GrafikTas();
            TextBox6.Text = "İleri Programlama Dersinin En Başarılı Öğrencisi : " + dt.İleriProg();
            TextBox7.Text = "Programlama Öğretimi Yaklaşımları Dersinin En Başarılı Öğrencisi : " + dt.ProgOgrt();
            TextBox8.Text = "Ayrık Matematik Dersinin En Başarılı Öğrencisi : " + dt.AyrıkMat();
            TextBox9.Text = "Robotik Kodlama Dersinin En Başarılı Öğrencisi : " + dt.RobKod();
            TextBox10.Text = "Elektronik Devre Elemanları En Başarılı Öğrencisi : " + dt.Ede();
            TextBox11.Text = "Temel Programlama Ders Ortalaması : " + dt.tp();
            TextBox12.Text = "Veri Tabanı Ders Ortalaması : " + dt.VT();
            TextBox13.Text = "Algoritma Ders Ortalaması : " + dt.alg();
            TextBox14.Text = "Grafik TasarımDers Ortalaması : " + dt.GT();
            TextBox15.Text = "İleri Programlama Ders Ortalaması : " + dt.İP();
            TextBox16.Text = "Programlama Öğretimi Yaklaşımları Ders Ortalaması : " + dt.PÖY();
            TextBox17.Text = "Elektronik Devre Elemanları Ders Ortalaması : " + dt.ELEK();
            TextBox18.Text = "Robotik Kodlama Ders Ortalaması : " + dt.roboo();

        }
    }
}