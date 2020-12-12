using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
   public class BLLPersonel
    {
        public static List<EntityPersonel> BLLPERSONELLISTESI()
        {
            return DALPersonel.PersonelListesi();
        }

        public static int BLLPersonelEkle(EntityPersonel e)
        {
            if (e.Personelad != "" && e.Personelsoyad != "" && e.Personelmaas!=0 && e.Personeldepartman!=0)
            {
                return DALPersonel.PersonelEkle(e);
            }
            else
            {
                return -1;
            }
        }
    }

}

