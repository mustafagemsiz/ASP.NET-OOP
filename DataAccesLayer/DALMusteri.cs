using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITYLAYER;
using System.Data.SqlClient;
using System.Data;
namespace DataAccesLayer
{
    public class DALMusteri
    {
        public static List<EntityMusteri> MusteriListele() 
        { 
        List<EntityMusteri> degerler = new List<EntityMusteri>();
        SqlCommand komut = new SqlCommand("SELECT * FROM TBLMUSTERI",Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityMusteri ent = new EntityMusteri();
                ent.MusteriId = int.Parse(dr["MUSTERIID"].ToString());
                ent.MusteriAd = dr["MUSTERIAD"].ToString();
                ent.MusteriSoyad = dr["MUSTERISOYAD"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static int MusteriEkle(EntityMusteri p)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO TBLMUSTERI (MUSTERIAD,MUSTERISOYAD) VALUES (@p1,@p2)", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", p.MusteriAd);
            komut.Parameters.AddWithValue("@p2", p.MusteriSoyad);
            return komut.ExecuteNonQuery();

        }

        public static bool MusteriSil(int p)
        {
            SqlCommand komut = new SqlCommand("DELETE FROM TBLMUSTERI WHERE MUSTERIID=@p1", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", p);
            return komut.ExecuteNonQuery() > 0;
        }

        public static List<EntityMusteri> MusteriGetir(int id)
        {
            List<EntityMusteri> degerler = new List<EntityMusteri>();
            SqlCommand komut = new SqlCommand("SELECT * FROM TBLMUSTERI WHERE MUSTERIID=@p1", Baglanti.bgl);
            komut.Parameters.AddWithValue("@p1", id);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityMusteri ent = new EntityMusteri();
                ent.MusteriId = int.Parse(dr["MUSTERIID"].ToString());
                ent.MusteriAd = dr["MUSTERIAD"].ToString();
                ent.MusteriSoyad = dr["MUSTERISOYAD"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool MusteriGuncelle(EntityMusteri p)
        {
            SqlCommand komut = new SqlCommand("UPDATE TBLMUSTERI SET MUSTERIAD=@p1,MUSTERISOYAD=@p2 WHERE MUSTERIID=@p3", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", p.MusteriAd);
            komut.Parameters.AddWithValue("@p2", p.MusteriSoyad);
            komut.Parameters.AddWithValue("@p3", p.MusteriId);
            return komut.ExecuteNonQuery() > 0;
        }
    }
}
