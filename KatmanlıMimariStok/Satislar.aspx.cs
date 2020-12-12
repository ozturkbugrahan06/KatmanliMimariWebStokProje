using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

namespace KatmanlıMimariStok
{
    public partial class Satislar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntitySatis> SatisList = BLLSatis.BLLSatisListesi();
            Repeater1.DataSource = SatisList;
            Repeater1.DataBind();
        }
    }
}