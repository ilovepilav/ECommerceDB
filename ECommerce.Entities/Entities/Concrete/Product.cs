using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entities.Entities.Concrete
{
    public class Product : BaseEntities
    {
        public string ProductName { get; set; }
        public int QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public short UnitsInOrder { get; set; }
        public short ReorderLevel { get; set; }
        public bool DisContinued { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }
        public ICollection<Order_Detail> Order_Details { get; set; }
    }
}
