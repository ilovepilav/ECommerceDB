using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entities.Entities.Concrete
{
    public class Supplier : BaseEntities
    {
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string ContactName { get; set; }
        [Required]
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string HomePage { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
