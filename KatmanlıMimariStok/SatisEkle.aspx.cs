using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;
using System.Data;
using System.Data.SqlClient;

namespace KatmanlıMimariStok
{
    public partial class SatisEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                SqlCommand komut = new SqlCommand("Select * From TBL_URUN", Baglanti.bgl);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DropDownList1.DataValueField = "URUNID";
                DropDownList1.DataValueField = "URUNAD";
                DropDownList1.DataSource = dt;
                DropDownList1.DataBind();

                SqlCommand komut2 = new SqlCommand("Select PERID,(PERAD+' '+PERSOYAD) AS 'PERADSOYAD' From TBL_PERSONEL", Baglanti.bgl);
                SqlDataAdapter da2 = new SqlDataAdapter(komut2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                DropDownList2.DataValueField = "PERID";
                DropDownList2.DataValueField = "PERADSOYAD";
                DropDownList2.DataSource = dt2;
                DropDownList2.DataBind();

                SqlCommand komut3 = new SqlCommand("Select MUSTERIID,(MUSTERIAD+' '+MUSTERISOYAD) AS 'MUSTERIADSOYAD' From TBL_MUSTERI", Baglanti.bgl);
                SqlDataAdapter da3 = new SqlDataAdapter(komut3);
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);
                DropDownList3.DataValueField = "MUSTERIID";
                DropDownList3.DataValueField = "MUSTERIADSOYAD";
                DropDownList3.DataSource = dt3;
                DropDownList3.DataBind();
            }
        }
    }
}