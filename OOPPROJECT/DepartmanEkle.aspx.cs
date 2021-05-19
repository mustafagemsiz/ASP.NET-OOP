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
    public partial class DepartmanEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityDepartman ent = new EntityDepartman();
            ent.DepartmanAd = TextBox1.Text;
            BLLDepartman.BLLDepartmanEkle(ent);
            TextBox1.Text = "";
        }
    }
}