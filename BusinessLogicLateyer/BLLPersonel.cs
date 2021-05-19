using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer;
using ENTITYLAYER;
namespace BusinessLogicLateyer
{
    public class BLLPersonel
    {
        public static List<EntityPersonel> BLLPersonelListele()
        {
            return DALPersonel.PersonelListele();
        }

        public static int BLLPersonelEkle(EntityPersonel p)
        {
            if (p.PersonelAd != "" && p.PersonelSoyad != "" && p.PersonelAd.Length >= 3 && p.PersonelSoyad.Length >= 3 && p.PersonelDepartman>0 && p.PersonelDepartman<10&&p.PersonelMaas>0&&p.PersonelMaas<10000)
            {
                return DALPersonel.PersonelEkle(p);
            }
            else
            {
                return -1;
            }

        }
    }
}
