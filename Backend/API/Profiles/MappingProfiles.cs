using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Domain.Entities;

namespace API.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Address,AddressDto>().ReverseMap();
            CreateMap<City,CityDto>().ReverseMap();
            CreateMap<Client,ClientDto>().ReverseMap();
            CreateMap<Country,CountryDto>().ReverseMap();
            CreateMap<Gamaprodruct,GamaprodructDto>().ReverseMap();
            CreateMap<Order,OrderDto>().ReverseMap();
            CreateMap<Product,ProductDto>().ReverseMap();
            CreateMap<State,StateDto>().ReverseMap();
        }
    }
}