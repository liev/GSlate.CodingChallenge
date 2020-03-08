using AutoMapper;
using GSlate.CodingChallenge.Common.Models.Entity;
using GSlate.CodingChallenge.Common.Models.ViewModels;
using System;
using System.Collections.Generic;

namespace Gslate.Common.Mappers
{
    
    public class UserToUserViewModel
    {
        public static List<UserViewModel> ConvertToListUserViewModel(List<User> users)
        {
            try
            {
                Mapper.Reset();
                Mapper.Initialize(cfg => {
                    cfg.CreateMap<List<User>, users>()
                    });
                    //{
                    //    cfg.CreateMap<ExchangeViewModel, Exchange>()
                    //    //.ForMember(dest => dest.CodCurrency, opt => opt.MapFrom(src => src.codCurrency))
                    //    .ForMember(dest => dest.OriginCurrency, opt => opt.MapFrom(src => src.originCurrency))
                    //    .ForMember(dest => dest.DestinationCurrency, opt => opt.MapFrom(src => src.destinationCurrency))
                    //    .ForMember(dest => dest.PurchaseValue, opt => opt.MapFrom(src => src.purchaseValue))
                    //    .ForMember(dest => dest.SaleValue, opt => opt.MapFrom(src => src.saleValue));
                    //});

                    return Mapper.Map<List<UserViewModel>>(users);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
