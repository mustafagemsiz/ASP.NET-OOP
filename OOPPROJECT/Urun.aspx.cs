using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ENTITYLAYER;
using DataAccesLayer;
namespace OOPPROJECT
{
    public partial class Urun : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityUrun> UrnList = DALUrun.UrunListele();
            Repeater1.DataSource = UrnList;
            Repeater1.DataBind();

        }
    }
}