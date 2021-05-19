using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DataAccesLayer;
using ENTITYLAYER;
namespace BusinessLogicLateyer
{
    public class BLLDepartman
    {
        public static List<EntityDepartman> BLLDepartmanListele()
        {
            return DALDepartman.DepartmanListele();
        }

        public static int BLLDepartmanEkle(EntityDepartman p)
        {
            if (p.DepartmanAd != "")
            {
                return DALDepartman.DepartmanEkle(p);
            }
            return -1;
        }
    }
}
