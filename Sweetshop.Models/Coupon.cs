using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweetshop.Models
{
      public class Coupon
    {
        public int Id { get; set; }
        public string  Title { get; set; }
        public string Type { get; set; }
        public double Discount { get; set; }
        public double MinimumAmount { get; set; }
        public byte [] couponPicture { get; set; }
        public  bool IsActive { get; set; }
            
    }
    public enum CouponType
    {
        percent =0,
        currncy = 1,
    }
}
