using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DALPersonel
    {
        public static List<EntityPersonel>PersonelListesi()
        {
            List<EntityPersonel> degerler = new List<EntityPersonel>();
            SqlCommand komut = new SqlCommand("DEPARTMANLIST", Baglanti.bgl);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityPersonel ent = new EntityPersonel();
                ent.Personelid = int.Parse(dr["PERID"].ToString());
                ent.Personelad = dr["PERAD"].ToString();
                ent.Personelsoyad =dr["PERSOYAD"].ToString();
                ent.Personelmaas =decimal.Parse(dr["PERMAAS"].ToString());
                // ent.Personeldepartman = int.Parse(dr["PERDEPARTMAN"].ToString());
                ent.Personeldep = int.Parse(dr["PERDEPARTMAN"].ToString());
                ent.Personelfotograf = dr["PERFOTOGRAF"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static int PersonelEkle(EntityPersonel e)
        {
            SqlCommand komut4 = new SqlCommand("insert into TBL_PERSONEL (PERAD,PERSOYAD,PERDEPARTMAN,PERMAAS) values (@P1,@P2,@P3,@P4)", Baglanti.bgl);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@P1", e.Personelad);
            komut4.Parameters.AddWithValue("@P2", e.Personeldepartman);
            komut4.Parameters.AddWithValue("@P3", e.Personeldepartman);
            komut4.Parameters.AddWithValue("@P4", e.Personelmaas);

            return komut4.ExecuteNonQuery();
        }
    }
}
