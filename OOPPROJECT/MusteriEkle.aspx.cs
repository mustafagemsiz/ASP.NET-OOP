using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ENTITYLAYER;
using DataAccesLayer;
using BusinessLogicLateyer;
namespace OOPPROJECT
{
    public partial class MusteriEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityMusteri ent = new EntityMusteri();
            ent.MusteriAd = TextBox1.Text;
            ent.MusteriSoyad = TextBox2.Text;
            BLLMusteri.BLLMusteriEkle(ent);
            TextBox1.Text = "";
            TextBox2.Text = "";
        }
    }
}