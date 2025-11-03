namespace Mango.Services.Coupon.Models.Dto
{
    public class CouponDto
    {
        public int CouponId { get; set; }
        public int CouponCode { get; set; }
        public double DiscountAmount { get; set; }
        public int MinAmount { get; set; }
    }
}
