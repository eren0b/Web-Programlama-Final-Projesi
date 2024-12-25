using System.ComponentModel.DataAnnotations;

namespace MenuQr.Models
{
    public class Urunler
    {
        [Key]
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public int KategoriID { get; set; }
        public int Fiyat { get; set; }
        public bool UrunStok { get; set; }
        public string UrunResmi { get; set; }

        public Kategoriler Kategori { get; set; }

    }
}
