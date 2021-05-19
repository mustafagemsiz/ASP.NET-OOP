using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITYLAYER;
using System.Data;
using System.Data.SqlClient;
namespace DataAccesLayer
{
    public class DALUrun
    {
        public static List<EntityUrun> UrunListele()
        {
            List<EntityUrun> degerler = new List<EntityUrun>();
            SqlCommand komut = new SqlCommand("SELECT * FROM TBLURUN", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityUrun ent = new EntityUrun();
                ent.UrunId = int.Parse(dr["URUNID"].ToString());
                ent.UrunAd = dr["URUNAD"].ToString();
                ent.UrunFiyat = decimal.Parse(dr["URUNFIYAT"].ToString());
                ent.UrunAdet = int.Parse(dr["URUNADET"].ToString());
                degerler.Add(ent);      
            }
            dr.Close();
            return degerler;
        }

        public static int UrunEkle(EntityUrun p)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO TBLURUN (URUNAD,URUNFIYAT,URUNADET) VALUES (@p1,@p2,@p3)", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", p.UrunAd);
            komut.Parameters.AddWithValue("@p2", p.UrunAdet);
            komut.Parameters.AddWithValue("@p3", p.UrunFiyat);
            return komut.ExecuteNonQuery();
        }
    }
}
