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
    public class DALMusteri
    {
        public static List<EntityMusteri>MusteriListesi()
        {
            List<EntityMusteri> degerler = new List<EntityMusteri>();
            SqlCommand komut = new SqlCommand("Select * From TBL_MUSTERI", Baglanti.bgl);
            if (komut.Connection.State!=ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                EntityMusteri ent = new EntityMusteri();
                ent.Musteriid = int.Parse(dr["MUSTERIID"].ToString());
                ent.Musteriad = dr["MUSTERIAD"].ToString();
                ent.Musterisoyad = dr["MUSTERISOYAD"].ToString();
                degerler.Add(ent);

            }
            dr.Close();
            return degerler;
        }
        public static int MusteriEkle(EntityMusteri e)
        {
            SqlCommand komut2 = new SqlCommand("insert into TBL_MUSTERI (MUSTERIAD,MUSTERISOYAD) values (@P1,@P2)", Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@P1", e.Musteriad);
            komut2.Parameters.AddWithValue("@P2", e.Musterisoyad);
            return komut2.ExecuteNonQuery();
        }

        public static bool MusteriSil(int p)
        {
            SqlCommand komut3 = new SqlCommand("Delete From TBL_MUSTERI WHERE MUSTERIID=@P1", Baglanti.bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@P1", p);
            return komut3.ExecuteNonQuery() > 0;
        }
        public static List<EntityMusteri> MusteriGetir(int id)
        {
            List<EntityMusteri> degerler = new List<EntityMusteri>();
            SqlCommand komut = new SqlCommand("Select * From TBL_MUSTERI WHERE MUSTERIID=@P1", Baglanti.bgl);
            komut.Parameters.AddWithValue("@P1", id);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityMusteri ent = new EntityMusteri();
                ent.Musteriad = dr["MUSTERIAD"].ToString();
                ent.Musterisoyad = dr["MUSTERISOYAD"].ToString();
                degerler.Add(ent);

            }
            dr.Close();
            return degerler;
        
        }
        public static bool MusterıGuncelle(EntityMusteri p)
        {
            SqlCommand komut = new SqlCommand("UPDATE TBL_MUSTERI SET MUSTERIAD=@P1,MUSTERISOYAD=@P2 WHERE MUSTERIID=@P3", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@P1", p.Musteriad);
            komut.Parameters.AddWithValue("@P2", p.Musterisoyad);
            komut.Parameters.AddWithValue("@P3", p.Musteriid);
            return komut.ExecuteNonQuery() > 0;

        }



    }



}


