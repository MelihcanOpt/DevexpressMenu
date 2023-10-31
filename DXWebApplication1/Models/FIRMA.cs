using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DXWebApplication1.Models
{
    public class FIRMA
    {
        public int FIRMA_ID { get; set; }
        public string FIRMA_AD { get; set; }
        public string FIYAT_KOD { get; set; }
        public string TICARI_UNVAN { get; set; }
        public DateTime KAYIT_TARIH { get; set; }
    }

    public class FIRMADbContext : DbContext
    {
        public DbSet<FIRMA> fIRMAs { get; set; }
    }
}