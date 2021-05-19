using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITYLAYER
{
    public class EntityDepartman
    {
        private byte _DepartmanId;
        private string _DepartmanAd;

        public byte DepartmanId { get => _DepartmanId; set => _DepartmanId = value; }
        public string DepartmanAd { get => _DepartmanAd; set => _DepartmanAd = value; }
    }
}
