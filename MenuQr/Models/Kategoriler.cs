using System.ComponentModel.DataAnnotations;

namespace MenuQr.Models
{
    public class Kategoriler
    {
        [Key]
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }

        public ICollection<Urunler> Urunler { get; set; }

    }
}
