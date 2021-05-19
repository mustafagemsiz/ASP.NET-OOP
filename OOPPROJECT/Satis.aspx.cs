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
    public partial class Satis : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           List<EntitySatis> StsList = DALSatis.SatisListele();
            Repeater1.DataSource = StsList;
            Repeater1.DataBind();
        }
    }
}