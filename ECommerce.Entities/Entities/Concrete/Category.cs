using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entities.Entities.Concrete
{
    public class Category : BaseEntities
    {
        [Required]
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
