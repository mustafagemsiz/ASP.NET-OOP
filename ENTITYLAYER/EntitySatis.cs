using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITYLAYER
{
    public class EntitySatis
    {
        private int _SatisId;
        private int _Urun;
        private int _Personel;
        private decimal _Tutar;
        private int _Musteri;
        private string _MusteriAd;
        private string _UrunAd;
        private string _PersonelAd;
 

        public int SatisId { get => _SatisId; set => _SatisId = value; }
        public int Urun { get => _Urun; set => _Urun = value; }
        public int Personel { get => _Personel; set => _Personel = value; }
        public decimal Tutar { get => _Tutar; set => _Tutar = value; }
        public int Musteri { get => _Musteri; set => _Musteri = value; }
        public string MusteriAd { get => _MusteriAd; set => _MusteriAd = value; } 
        public string UrunAd { get => _UrunAd; set => _UrunAd = value; }
        public string PersonelAd { get => _PersonelAd; set => _PersonelAd = value; }

    }
}
