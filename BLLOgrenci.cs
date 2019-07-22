﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLOgrenci
    {
        public static int OgrenciEkleBLL(EntityOgrenci p)
        {
            if (p.AD != null && p.SOYAD != null && p.NUMARA != null &&
                p.SIFRE != null && p.FOTOGRAF != null);
            {
                return DALOgrenci.OgrenciEkle(p);
            }
            return -1;
        }

        public static List<EntityOgrenci> BllListele()
        {
            return DALOgrenci.ÖğrenciListesi();
        }

        public static bool OgrenciSilBll(int p)
        {
            if (p >= 0) 
            {
                return DALOgrenci.OgrenciSil(p);
            }
            return false;
        }

        public static List<EntityOgrenci> BllDetay(int p)
        {
            return DALOgrenci.ÖğrenciDetay(p);
        }
        public static bool OgrenciGuncelleBLL(EntityOgrenci p)
        {
            if (p.AD != null && p.AD != "" && p.SOYAD != null && p.NUMARA != null &&
                p.SIFRE != null && p.FOTOGRAF != null && p.ID > 0); 
            {
                return DALOgrenci.OgrenciGüncelle(p);
            }
            return false;
        }
        



    }
}
