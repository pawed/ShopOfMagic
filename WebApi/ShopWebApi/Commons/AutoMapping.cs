using AutoMapper;
using ShopWebApi.DTO;
using ShopWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopWebApi.Commons
{
    public class AutoMapping: Profile
    {
        public AutoMapping()
        {
            CreateMap<NewUserRequest, User>()
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
                .ForMember(dest => dest.Phone, opt => opt.MapFrom(src => src.Phone))
                .ForMember(dest => dest.EMail, opt => opt.MapFrom(src => src.EMail))
                .ForAllOtherMembers(x=>x.Ignore()); 
            
            CreateMap<NewAddressRequest, Adress>()
                .ForMember(dest => dest.StreetName, opt => opt.MapFrom(src => src.StreetName))
                .ForMember(dest => dest.StreetNumber, opt => opt.MapFrom(src => src.StreetNumber))
                .ForMember(dest => dest.ApartmentNumber, opt => opt.MapFrom(src => src.ApartmentNumber))
                .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.City))
                .ForMember(dest => dest.CountryCode, opt => opt.MapFrom(src => src.CountryCode))
                .ForAllOtherMembers(x=>x.Ignore());

        }
    }
}
