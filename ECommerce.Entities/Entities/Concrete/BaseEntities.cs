using ECommerce.Entities.Entities.Abstraction;
using ECommerce.Entities.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entities.Entities.Concrete
{
    public class BaseEntities:IBaseEntites
    {
        public int ID { get; set; }
        public Status Status { get; set; }
    }
}
