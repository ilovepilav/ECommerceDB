using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entities.Entities.Concrete
{
    public class Employee:BaseEntities
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime dateTime { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string HomePage { get; set; }
        public string Extension { get; set; }
        public string Photo { get; set; }
        public string Notes { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee ReportsTo { get; set; }
        public int OrderId { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
