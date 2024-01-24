using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTB2
{
    public class OgrenciBLL
    {
        public Ogrenci ara(int ogrenciNo)
        {
            Ogrenci ogrenci = new Ogrenci();
            NTB2DAL sqlHelper = new NTB2DAL();
            SqlParameter[] prm = new SqlParameter[] { new SqlParameter("@Numara", ogrenciNo) };

            SqlDataReader reader = sqlHelper.ExecuteReader("select * from tblOgrenciler where Numara = @Numara ", prm);

            if (reader.Read())
            { 
                ogrenci.OgrenciId = Convert.ToInt32(reader[0].ToString());
                ogrenci.Adi = reader[1].ToString();
                ogrenci.Soyadi = reader[2].ToString();
                ogrenci.Numara = Convert.ToInt32(reader[3].ToString());

            }

            reader.Close();

            return ogrenci;
        }
        public bool kaydet(Ogrenci ogrenci)
        {
            NTB2DAL sqlHelper = new NTB2DAL();
            SqlParameter[] prmInsert = new SqlParameter[] {
                    new SqlParameter("@Adi", ogrenci.Adi),
                    new SqlParameter("@Soyadi", ogrenci.Soyadi),
                    new SqlParameter("@Numarasi", ogrenci.Numara)
                };

            return sqlHelper.ExecuteNonQuery("insert into tblOgrenciler values(@Adi,@Soyadi,@Numarasi)", prmInsert) > 0;
        }

        public bool guncelle(Ogrenci ogrenci)
        {
            NTB2DAL sqlHelper = new NTB2DAL();

            SqlParameter[] prmUpdate = new SqlParameter[] {
                    new SqlParameter("@Adi", ogrenci.Adi),
                    new SqlParameter("@Soyadi", ogrenci.Soyadi),
                    new SqlParameter("@Numarasi", ogrenci.Numara),
                     new SqlParameter("@OgrenciId", ogrenci.OgrenciId)
                };
            return sqlHelper.ExecuteNonQuery("update tblOgrenciler set Ad=@Adi, Soyad = @Soyadi, Numara =@Numarasi where id=@OgrenciId ", prmUpdate) > 0;
        }

        public bool sil(int ogrenciId)
        {
            NTB2DAL sqlHelper = new NTB2DAL();
            SqlParameter[] prm = new SqlParameter[] { new SqlParameter("@OgrenciId", ogrenciId) };
            return sqlHelper.ExecuteNonQuery("delete from tblOgrenciler where id =@OgrenciId", prm) > 0;
        }

        public bool ogrenciNumarasiVarmi(Ogrenci ogrenci)
        {
            DataTable dt = new DataTable();
            SqlDataReader reader;
            NTB2DAL sqlHelper = new NTB2DAL();
            if (ogrenci.OgrenciId != null)
            {
                SqlParameter[] prm = new SqlParameter[] { new SqlParameter("@OgrenciId", ogrenci.OgrenciId), new SqlParameter("@Numara", ogrenci.Numara) };
                reader = sqlHelper.ExecuteReader("select * from tblOgrenciler where Numara = @Numara and id<>@OgrenciId ", prm);
                if (reader.Read())
                {
                    dt.Load(reader);
                    return dt.Rows.Count > 0;
                }
            }
            else
            {
                SqlParameter[] prm = new SqlParameter[] { new SqlParameter("@Numara", ogrenci.Numara) };
                reader = sqlHelper.ExecuteReader("select * from tblOgrenciler where Numara = @Numara ", prm);
                if (reader.Read())
                {
                    dt.Load(reader);
                    return dt.Rows.Count > 0;
                }
            }
            reader.Close();
            return false;
        }
    }
}
