using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITYLAYER
{
    public class EntityPersonel
    {
        private int _PersonelId;
        private string _PersonelAd;
        private string _PersonelSoyad;
        private string _PersonelFotograf;
        private byte _PersonelDepartman;
        private decimal _PersonelMaas;
        private string _Departman;

        public int PersonelId { get => _PersonelId; set => _PersonelId = value; }
        public string PersonelAd { get => _PersonelAd; set => _PersonelAd = value; }
        public string PersonelSoyad { get => _PersonelSoyad; set => _PersonelSoyad = value; }
        public string PersonelFotograf { get => _PersonelFotograf; set => _PersonelFotograf = value; }
        public byte PersonelDepartman { get => _PersonelDepartman; set => _PersonelDepartman = value; }
        public decimal PersonelMaas { get => _PersonelMaas; set => _PersonelMaas = value; }
        public string Departman { get => _Departman; set => _Departman = value; }
    }
}
