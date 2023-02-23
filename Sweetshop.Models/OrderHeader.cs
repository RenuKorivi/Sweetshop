using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweetshop.Models
{
    public class OrderHeader
    {
        public int ID { get; set; }
        public string ApplicationUserID { get; set; }
        public ApplicationId ApplicationId { get; set; }
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        public DateTime TimeoPick { get; set; }
        public DateTime DateofPick { get; set; }
        public double SubTotal { get; set; }
        public double OrderTotal { get; set; }
        public string  CouponCode { get; set; }
        public string CouponCodeDis { get; set; }
        public string TransId { get; set; }
        
        public string OrderStatus { get; set; }
        public string PaymentStatus { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }



    }
}
