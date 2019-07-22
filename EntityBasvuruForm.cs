using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityBasvuruForm
    {
        private int basvuruid;
        public int BASVURUID
        {
            get { return basvuruid; }
            set { basvuruid = value; }
        }  

        private int basdersid;
        public int BASDERSID
        {
            get { return basdersid; }
            set { basdersid = value; }
        }
   
        private int basogrid;
        public int BASOGRID
        {
            get { return basogrid; }
            set { basogrid = value; }
        }
    }
}
