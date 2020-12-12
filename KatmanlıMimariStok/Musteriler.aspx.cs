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
    public partial class Musteriler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityMusteri> MusteriList = BLLMusteri.BLLMusteriListesi();
            Repeater1.DataSource = MusteriList;
            Repeater1.DataBind();
        }
    }
}