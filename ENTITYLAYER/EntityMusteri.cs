using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITYLAYER
{
    public class EntityMusteri
    {
        private int _MusteriId;
        private string _MusteriAd;
        private string _MusteriSoyad;

        public int MusteriId { get => _MusteriId; set => _MusteriId = value; }
        public string MusteriAd { get => _MusteriAd; set => _MusteriAd = value; }
        public string MusteriSoyad { get => _MusteriSoyad; set => _MusteriSoyad = value; }
    }
}
