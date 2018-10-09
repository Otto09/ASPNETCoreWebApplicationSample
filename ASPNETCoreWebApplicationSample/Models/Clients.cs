using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreWebApplicationSample.Models
{
    public class Clients
    {
        public int ID { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        public string Name { get; set; }
        [Required]
        [StringLength(70, MinimumLength = 3)]
        public string Product { get; set; }
        public int Quantity { get; set; }
        [Required]
        public DateTime SellDate { get; set; }
        [Required]
        [Range(0, 1000)]
        public decimal Price { get; set; }
        public int ProductID { get; set; }
    }
}
