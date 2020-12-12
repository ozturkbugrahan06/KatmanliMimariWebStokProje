using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLMusteri
    {
        public static List<EntityMusteri> BLLMusteriListesi()
        {
            return DALMusteri.MusteriListesi();
        }

        public static int BLLMusteriEkle(EntityMusteri e)
        {
            if (e.Musteriad!=""&& e.Musterisoyad!=""&& e.Musteriad.Length<=10)
            {
                return DALMusteri.MusteriEkle(e);
            }
            else
            {
                return -1;
            }
        }

        public static bool BLLMusteriSil(int par)
        {
            if (par!=null)
            {
                return DALMusteri.MusteriSil(par);
            }
            return false;
        }

        public static List<EntityMusteri> BLLMusteriGetir(int p)
        {
            return DALMusteri.MusteriGetir(p);
        }

        public static bool BLLMusteriGuncelle(EntityMusteri p)
        {
            if (p.Musteriad!="" && p.Musterisoyad!="")
            {
                return DALMusteri.MusterıGuncelle(p);
            }
            return false;
        }
    }
}
