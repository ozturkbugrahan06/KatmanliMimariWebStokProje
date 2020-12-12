using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLUrun
    {
        public static List<EntityUrun> BLLUrunListesi()
        {
            return DALUrun.UrunListesi();
        }


        public static int BLLUrunEkle(EntityUrun e)
        {
            if (e.Urunad != "" && e.Urunfiyat != 0 && e.Urunadet != 0 && e.Urunfiyat >= 1)
            {
                return DALUrun.UrunEkle(e);
            }
            else
            {
                return -1;
            }
        }
    }
}


