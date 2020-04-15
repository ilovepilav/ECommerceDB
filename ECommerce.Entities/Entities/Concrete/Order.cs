using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entities.Entities.Concrete
{
    public class Order:BaseEntities
    {
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShipppedDate { get; set; }
        public decimal Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }
        public virtual Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public virtual Employee Employee { get; set; }
        public int EmployeeId { get; set; }
        public virtual Shipper ShipVia { get; set; }
        public int ShipperId { get; set; }
        public virtual ICollection<Order_Detail> Order_Details { get; set; }
    }
}
