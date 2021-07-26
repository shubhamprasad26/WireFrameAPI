using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WireFrame.Model
{
    public class Discount
    {
        public int Id { get; set; }
        public string CouponCode { get; set; }
        public int Percentage { get; set; }
    }
}
