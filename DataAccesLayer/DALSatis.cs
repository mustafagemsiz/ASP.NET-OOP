using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ENTITYLAYER;
namespace DataAccesLayer
{
    public class DALSatis
    {
        public static List<EntitySatis> SatisListele()
        {
            List<EntitySatis> degerler = new List<EntitySatis>();
            SqlCommand komut = new SqlCommand("SATISLAR", Baglanti.bgl);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntitySatis ent = new EntitySatis();
                ent.SatisId = int.Parse(dr["SATISID"].ToString());
                ent.UrunAd = dr["URUNAD"].ToString();
                ent.PersonelAd = dr["PERSONEL"].ToString();
                ent.MusteriAd = dr["MUSTERI"].ToString();
                ent.Tutar = decimal.Parse(dr["TUTAR"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static int SatisEkle(EntitySatis p)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO TBLSATIS (URUN,PERSONEL,TUTAR,MUSTERI) VALUES (@p1,@p2,@p3,@p4)", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", p.Urun);
            komut.Parameters.AddWithValue("@p2", p.Personel);
            komut.Parameters.AddWithValue("@p3", p.Tutar);
            komut.Parameters.AddWithValue("@p4", p.Musteri);
            return komut.ExecuteNonQuery();
        }
    }
}
