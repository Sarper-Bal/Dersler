using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLDers
    {
        public static List<EntityDers> BllListele()
        {
            return DALDers.DersListesi();
        }
        public static int TalepEkleBll(EntityBasvuruForm p)
        {
            if(p.BASDERSID != null && p.BASDERSID != null)
            {
                return DALDers.TalepEkle(p);
            }
            return -1;
        }
    }
}
