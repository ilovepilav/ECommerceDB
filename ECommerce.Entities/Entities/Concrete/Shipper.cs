using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entities.Entities.Concrete
{
    public class Shipper : BaseEntities
    {
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public int OrderId { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
