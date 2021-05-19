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
    public partial class MusteriSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["MUSTERIID"]);
            EntityMusteri ent = new EntityMusteri();
            ent.MusteriId = x;
            BLLMusteri.BLLMusteriSil(ent.MusteriId);
            Response.Redirect("Musteri.aspx");

        }
    }
}