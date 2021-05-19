using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccesLayer;
using BusinessLogicLateyer;
using ENTITYLAYER;
namespace OOPPROJECT
{
    public partial class Musteri : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityMusteri> MusList = BLLMusteri.BLLMusteriListele();
            Repeater1.DataSource = MusList;
            Repeater1.DataBind();
        }
    }
}