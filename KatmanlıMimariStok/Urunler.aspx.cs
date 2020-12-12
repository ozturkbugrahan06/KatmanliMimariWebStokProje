using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using BusinessLogicLayer;
using DataAccessLayer;

namespace KatmanlıMimariStok
{
    public partial class Urunler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityUrun> UrunList = BLLUrun.BLLUrunListesi();
            Repeater1.DataSource = UrunList;
            Repeater1.DataBind();
        }
    }
}