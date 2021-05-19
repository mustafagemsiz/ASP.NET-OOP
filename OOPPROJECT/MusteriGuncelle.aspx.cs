using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLateyer;
using DataAccesLayer;
using ENTITYLAYER;
namespace OOPPROJECT
{
    public partial class MusteriGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["MUSTERIID"]);
            TextBox3.Text = x.ToString();
            EntityMusteri ent = new EntityMusteri();
            if(Page.IsPostBack==false)
            { 
            List<EntityMusteri> MusteriList = BLLMusteri.BLLMusteriGetir(x);
            TextBox1.Text = MusteriList[0].MusteriAd.ToString();
            TextBox2.Text = MusteriList[0].MusteriSoyad.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityMusteri ent = new EntityMusteri();
            ent.MusteriAd = TextBox1.Text;
            ent.MusteriSoyad = TextBox2.Text;
            ent.MusteriId = Convert.ToInt32(TextBox3.Text);
            BLLMusteri.BLLMusteriGuncelle(ent);
            Response.Redirect("Musteri.aspx");
        }
    }
}