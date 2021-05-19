using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITYLAYER
{
    public class EntityUrun
    {
        private int _UrunId;
        private string _UrunAd;
        private decimal _UrunFiyat;
        private int _UrunAdet;

        public int UrunId { get => _UrunId; set => _UrunId = value; }
        public string UrunAd { get => _UrunAd; set => _UrunAd = value; }
        public decimal UrunFiyat { get => _UrunFiyat; set => _UrunFiyat = value; }
        public int UrunAdet { get => _UrunAdet; set => _UrunAdet = value; }
    }
}
