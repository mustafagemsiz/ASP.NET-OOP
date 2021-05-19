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
    public class BLLSatis
    {
        public static List<EntitySatis> BLLSatisListele()
        {
            return DALSatis.SatisListele();
        }

        public static int BLLSatisEkle(EntitySatis p)
        {
            if (p.Tutar>0 && p.Personel!=0 && p.Musteri!=0 && p.Urun!=0)
            {
                return DALSatis.SatisEkle(p);
            }
            else
            {
                return -1;
            }

        }

    }
}
