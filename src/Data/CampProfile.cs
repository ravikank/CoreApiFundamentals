using AutoMapper;
using CoreCodeCamp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCodeCamp.Data
{
    public class CampProfile : Profile
    {
        public CampProfile()
        {
            CreateMap<Camp, CampModel>()
                .ForMember(c => c.VenueName, o => o.MapFrom(l => l.Location.VenueName))
                .ForMember(c => c.Address1, o => o.MapFrom(l => l.Location.Address1))
                .ForMember(c => c.Address2, o => o.MapFrom(l => l.Location.Address2))
                .ForMember(c => c.Address3, o => o.MapFrom(l => l.Location.Address3))
                .ForMember(c => c.CityTown, o => o.MapFrom(l => l.Location.CityTown))
                .ForMember(c => c.StateProvince, o => o.MapFrom(l => l.Location.StateProvince))
                .ForMember(c => c.PostalCode, o => o.MapFrom(l => l.Location.PostalCode))
                .ForMember(c => c.Country, o => o.MapFrom(l => l.Location.Country));
        }
    }
}
