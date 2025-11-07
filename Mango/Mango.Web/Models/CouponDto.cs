using System.ComponentModel.DataAnnotations;

namespace Mango.Web.Models
{
    public class CouponDto
    {
        public int CouponId { get; set; }
        [Required(ErrorMessage = "Coupon code is required")]
        public string CouponCode { get; set; }
        [Required(ErrorMessage = "Discount amount is Required")]
        public double DiscountAmount { get; set; }
        public int MinAmount { get; set; }
    }
}
