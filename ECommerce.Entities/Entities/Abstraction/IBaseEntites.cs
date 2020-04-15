using ECommerce.Entities.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entities.Entities.Abstraction
{
    public interface IBaseEntites
    {
        int ID { get; set; }
        Status Status { get; set; }
    }
}
