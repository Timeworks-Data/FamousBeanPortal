using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamousBeanPortal.Models
{
    public class Order
    {
        public string Id { get; set; }
        public DateTime OrderedTime { get; set; }
        public string UserId { get; set; }
        public string Products { get; set; }
        public string Location { get; set; }
        public decimal OrderAmount { get; set; }
        public string OrderStatus { get; set; }
        public string DeviceInfo { get; set; }
        public string Notes{ get; set; }
    }
}
