using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormOdev
{
    class UrunDal
    {
        public List<object> GetAll()
        {

            using (AA_OdevEntities context = new AA_OdevEntities())
            {

                var result = from u in context.tblUruns
                             join k in context.tblKategoris on u.KategoriId equals k.Id
                             
                             select new
                             {
                                 Id = u.Id,
                                 UrunAdi = u.UrunAdi,
                                 Fiyat = u.Fiyat,
                                 Stok = u.Stok,
                                 Katagori = k.KatagoriAdi
                     
                             };

                return result.ToList<object>();
            }
        }
        
        public List<object> KategoriGetAll()
        {

            using (AA_OdevEntities context = new AA_OdevEntities())
            {

                var result = from k in context.tblKategoris

                             select new
                             {
                                 Id = k.Id,
                                 KatagoriAdi= k.KatagoriAdi,
                             };

                return result.ToList<object>();
            }
        }
        public List<object> SatisGetAll()
        {

            using (AA_OdevEntities context = new AA_OdevEntities())
            {
                var result = from s in context.tblSatis
                             join u in context.tblUruns on s.UrunId equals u.Id

                             select new
                             {
                                 Id = s.Id,
                                 Detay= s.Detay,
                                 StisTarihi=s.StisTarihi,
                                 Discount=s.Discount,
                                 Urun = u.UrunAdi,

                             };

                return result.ToList<object>();
            }
        }
        public int GetKategoriIdByAd(string kategoriAdi)
        {
            using (AA_OdevEntities context = new AA_OdevEntities())
            {
                var kategori = context.tblKategoris.FirstOrDefault(k => k.KatagoriAdi == kategoriAdi);
                if (kategori != null)
                {
                    return kategori.Id;
                }
                else
                {
                    // Kategori bulunamadı.
                    return -1;
                }
            }
        }
        public void UrunAdd(tblUrun urun)
        {
            using (AA_OdevEntities context = new AA_OdevEntities())
            {
                
                
                    var entity = context.Entry(urun);
                    entity.State = EntityState.Added;
                    context.SaveChanges();
                
               
            }
        }
        public void UrunUpdate(tblUrun urun)
        {
            using (AA_OdevEntities context = new AA_OdevEntities())
            {
                var entity = context.Entry(urun);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void UrunDelete(tblUrun urun)
        {
            using(AA_OdevEntities context = new AA_OdevEntities())
            {
                var entity = context.Entry(urun);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        

        public int GetUrunIdByAd(string urunAdi)
        {
            using (AA_OdevEntities context = new AA_OdevEntities())
            {
                var urun = context.tblUruns.FirstOrDefault(u => u.UrunAdi == urunAdi);
                if (urun != null)
                {
                    return urun.Id;
                }
                else
                {
                    // Ürün bulunamadı.
                    return -1;
                }
            }
        }
        public void SatisAdd(tblSati satis)
        {
            using (AA_OdevEntities context = new AA_OdevEntities())
            {
                var entity = context.Entry(satis);
               
                entity.State = EntityState.Added;
                
                context.SaveChanges();
            }
        }
        public void SatisUpdate(tblSati satis)
        {
            using (AA_OdevEntities context = new AA_OdevEntities())
            {
                var entity = context.Entry(satis);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void SatisDelete(tblSati satis)
        {
            using (AA_OdevEntities context = new AA_OdevEntities())
            {

                var entity = context.Entry(satis);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
