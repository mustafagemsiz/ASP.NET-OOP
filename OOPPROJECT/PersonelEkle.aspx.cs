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
    public partial class PersonelEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack==false)
            {

            
            SqlCommand komut = new SqlCommand("SELECT*FROM TBLDEPARTMAN", Baglanti.bgl);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DropDownList1.DataValueField = "DEPARTMANID";
            DropDownList1.DataTextField = "DEPARTMANAD";
            DropDownList1.DataSource = dt;
            DropDownList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.PersonelAd = TextBox1.Text;
            ent.PersonelSoyad = TextBox2.Text;
            ent.PersonelMaas = decimal.Parse(TextBox3.Text.ToString());
            ent.PersonelDepartman = byte.Parse(DropDownList1.SelectedValue);
            BLLPersonel.BLLPersonelEkle(ent);
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
        }
    }
}