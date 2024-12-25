using System.Data.Entity;

namespace MenuQr.Models
{
    public class UrunlerContext:DbContext
    {
        public DbSet<Urunler> Urunler { get; set; }
        public DbSet<Kategoriler> Kategoriler { get; set; }
    }
}
