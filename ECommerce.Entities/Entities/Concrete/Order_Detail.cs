using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entities.Entities.Concrete
{
    public class Order_Detail : BaseEntities
    {
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public double Discount { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
    }
}
