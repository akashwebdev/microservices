using AutoMapper;
using Mango.Services.Coupon.Models;
using Mango.Services.Coupon.Models.Dto;

namespace Mango.Services.Coupon
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps() 
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Coupons, CouponDto>();
                cfg.CreateMap<CouponDto, Coupons>();
            });

            return config;
        }
    }
}
