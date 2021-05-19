using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITYLAYER;
using DataAccesLayer;

namespace BusinessLogicLateyer
{
    public class BLLUrun
    {
        public static List<EntityUrun> BLLPersonelListele()
        {
            return DALUrun.UrunListele();
        }

        public static int BLLUrunEkle(EntityUrun p)
        {
            if(p.UrunAd!="" && p.UrunAd.Length>3 && p.UrunAdet!=0 && p.UrunFiyat != 0)
            {
                return DALUrun.UrunEkle(p);
            }
            else
            {
                return -1;
            }
        }
    }
}
