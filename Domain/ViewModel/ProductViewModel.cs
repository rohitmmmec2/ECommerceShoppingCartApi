using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModel
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string? CompanyName { get; set; }
        public string? ProductName { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal CurrentPrice { get; set; }
        public decimal DiscountPercentage { get; set; }
        public string? Image { get; set; }
        public bool InStock { get; set; }
        public bool FastDelivery { get; set; }
        public string? Ratings { get; set; }
    }
}
