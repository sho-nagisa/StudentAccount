using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace StudentAccount.Models.Home
{
    public class CommodityForm
    {
        public List<Commoditys>? Tasks { get; set; }

        public int CommodityId { get; set; }
        public string? Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime PurchaseDate { get; set; }
        public int? Number { get; set; }
        public int? Price { get; set; }
    }

    public class Commoditys
    {
        public int CommodityId { get; set; }
        public string? Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime PurchaseDate { get; set; }
        public int? Number { get; set; }
        public int? Price { get; set; }
    }
}
