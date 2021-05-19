using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using ENTITYLAYER;
using DataAccesLayer;
using BusinessLogicLateyer;
namespace OOPPROJECT
{
    public partial class SatisEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                SqlCommand komut = new SqlCommand("SELECT*FROM TBLURUN", Baglanti.bgl);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DropDownListUrun.DataValueField = "URUNID";
                DropDownListUrun.DataTextField = "URUNAD";
                DropDownListUrun.DataSource = dt;
                DropDownListUrun.DataBind();

                SqlCommand komut2 = new SqlCommand("SELECT MUSTERIID,(MUSTERIAD+' '+MUSTERISOYAD) AS 'MUSTERIADSOYAD' FROM TBLMUSTERI", Baglanti.bgl);
                SqlDataAdapter da2 = new SqlDataAdapter(komut2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                DropDownListMusteri.DataValueField = "MUSTERIID";
                DropDownListMusteri.DataTextField = "MUSTERIADSOYAD";
                DropDownListMusteri.DataSource = dt2;
                DropDownListMusteri.DataBind();

                SqlCommand komut3 = new SqlCommand("SELECT PERSONELID,(PERSONELAD+' '+PERSONELSOYAD) AS 'PERSONELADSOYAD' FROM TBLPERSONEL", Baglanti.bgl);
            
                SqlDataAdapter da3 = new SqlDataAdapter(komut3);
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);
                DropDownListPersonel.DataValueField = "PERSONELID";
                DropDownListPersonel.DataTextField = "PERSONELADSOYAD";
                DropDownListPersonel.DataSource = dt3;
                DropDownListPersonel.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntitySatis ent = new EntitySatis();
            ent.Tutar = decimal.Parse(TextBox3.Text.ToString());
            ent.Urun = byte.Parse(DropDownListUrun.SelectedValue);
            ent.Personel = byte.Parse(DropDownListPersonel.SelectedValue);
            ent.Musteri = byte.Parse(DropDownListMusteri.SelectedValue);
            DALSatis.SatisEkle(ent);
            TextBox3.Text = "";
        }
    }
}