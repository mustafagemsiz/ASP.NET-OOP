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
    public partial class UrunEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            EntityUrun ent = new EntityUrun();
            ent.UrunAd = TextBox1.Text;
            ent.UrunAdet = int.Parse(TextBox2.Text.ToString());
            ent.UrunFiyat = decimal.Parse(TextBox3.Text.ToString());
            BLLUrun.BLLUrunEkle(ent);
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
        }
    }
}