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
    public class DALPersonel
    {
        public static List<EntityPersonel> PersonelListele()
        {
            List<EntityPersonel> degerler = new List<EntityPersonel>();
            SqlCommand komut = new SqlCommand("DEPARTMANLISTESI",Baglanti.bgl);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityPersonel ent = new EntityPersonel();
                ent.PersonelId = int.Parse(dr["PERSONELID"].ToString());
                ent.PersonelAd = dr["PERSONELAD"].ToString();
                ent.PersonelSoyad = dr["PERSONELSOYAD"].ToString();
                ent.PersonelFotograf = dr["PERSONELFOTOGRAF"].ToString();
                ent.Departman = dr["DEPARTMANAD"].ToString();
                ent.PersonelMaas = decimal.Parse(dr["PERSONELMAAS"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static int PersonelEkle(EntityPersonel p)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO TBLPERSONEL (PERSONELAD,PERSONELSOYAD,PERSONELDEPARTMAN,PERSONELMAAS) VALUES (@p1,@p2,@p3,@p4)", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", p.PersonelAd);
            komut.Parameters.AddWithValue("@p2", p.PersonelSoyad);
            komut.Parameters.AddWithValue("@p3", p.PersonelDepartman);
            komut.Parameters.AddWithValue("@p4", p.PersonelMaas);
            return komut.ExecuteNonQuery();
        }
    }
}
