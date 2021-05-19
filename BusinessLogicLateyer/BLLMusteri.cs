using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITYLAYER;
using DataAccesLayer;
using BusinessLogicLateyer;
namespace BusinessLogicLateyer
{
    public class BLLMusteri
    {
        public static List<EntityMusteri> BLLMusteriListele()
        {
            return DALMusteri.MusteriListele();
        }

        public static int BLLMusteriEkle(EntityMusteri p)
        {
            if(p.MusteriAd!="" && p.MusteriSoyad != "" && p.MusteriAd.Length>3 && p.MusteriSoyad.Length>3)
            {
                return DALMusteri.MusteriEkle(p);
            }
            else
            {
                return -1;
            }
            
        }

        public static bool BLLMusteriSil(int p)
        {
            if (p != null)
            {
                return DALMusteri.MusteriSil(p);
            }
            return false;
        }

        public static List<EntityMusteri> BLLMusteriGetir(int p)
        {
            return DALMusteri.MusteriGetir(p);
        }

        public static bool BLLMusteriGuncelle(EntityMusteri p)
        {
            if(p.MusteriAd!="" && p.MusteriSoyad != "")
            {
                return DALMusteri.MusteriGuncelle(p);
            }
            return false;
        }

    }
}
