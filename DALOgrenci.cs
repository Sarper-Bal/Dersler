using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace DataAccessLayer
{
    public class DALOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci parametre)

        {
            SqlCommand komut1 = new SqlCommand("insert into TblOgrencııı(OgrAd,OgrSoyad,OgrNumara,OgrFoto,OgrSıfre) values(@p1,@p2,@p3,@p4,@p5)", Baglanti.bg1);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@p1", parametre.AD);
            komut1.Parameters.AddWithValue("@p2", parametre.SOYAD);
            komut1.Parameters.AddWithValue("@p3", parametre.NUMARA);
            komut1.Parameters.AddWithValue("@p4", parametre.FOTOGRAF);
            komut1.Parameters.AddWithValue("@p5", parametre.SIFRE);
            return komut1.ExecuteNonQuery();
        }

        public static List<EntityOgrenci> ÖğrenciListesi()
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut2 = new SqlCommand("Select * From TBLOGRENCIII", Baglanti.bg1);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            SqlDataReader dr = komut2.ExecuteReader();
            while(dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.ID = Convert.ToInt32(dr["OGRID"].ToString());
                ent.AD = dr["OGRAD"].ToString();
                ent.SOYAD = dr["OGRSOYAD"].ToString();
                ent.NUMARA = dr["OGRNUMARA"].ToString();
                ent.FOTOGRAF = dr["OGRFOTO"].ToString();
                ent.SIFRE = dr["OGRSIFRE"].ToString();
                ent.BAKIYE = Convert.ToDouble(dr["OGRBAKIYE"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool OgrenciSil(int parametre)
        {
            SqlCommand komut4 = new SqlCommand("Delete From TBLBASVURUFORM where OGRENCIID = @P1"
               , Baglanti.bg1);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@P1", parametre);
            komut4.ExecuteNonQuery();      

            SqlCommand komut3 = new SqlCommand("Delete From TBLOGRENCIII where OGRID = @P1"
                ,Baglanti.bg1);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@P1", parametre);
            return komut3.ExecuteNonQuery() > 0;          

        }
        
        public static List<EntityOgrenci> ÖğrenciDetay(int id)
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut4 = new SqlCommand("Select * From TBLOGRENCIII where OGRID=@P1", Baglanti.bg1);
            komut4.Parameters.AddWithValue("@p1", id);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            SqlDataReader dr = komut4.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();                
                ent.AD = dr["OGRAD"].ToString();
                ent.SOYAD = dr["OGRSOYAD"].ToString();
                ent.NUMARA = dr["OGRNUMARA"].ToString();
                ent.FOTOGRAF = dr["OGRFOTO"].ToString();
                ent.SIFRE = dr["OGRSIFRE"].ToString();
                ent.BAKIYE = Convert.ToDouble(dr["OGRBAKIYE"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool OgrenciGüncelle(EntityOgrenci deger)
        {
            SqlCommand komut5 = new SqlCommand("Update TBLOGRENCIII Set OGRAD=@P1,OGRSOYAD=@P2,OGRNUMARA=@P3,OGRFOTO=@P4,OGRSIFRE=@P5 where OGRID=@P6", Baglanti.bg1);
            if (komut5.Connection.State != ConnectionState.Open)
            {
                komut5.Connection.Open();
            }
            komut5.Parameters.AddWithValue("@P1", deger.AD);
            komut5.Parameters.AddWithValue("@P2", deger.SOYAD);
            komut5.Parameters.AddWithValue("@P3", deger.NUMARA);
            komut5.Parameters.AddWithValue("@P4", deger.FOTOGRAF);
            komut5.Parameters.AddWithValue("@P5", deger.SIFRE);
            komut5.Parameters.AddWithValue("@P6", deger.ID);
            return komut5.ExecuteNonQuery() > 0;
        }
                
    }
}
