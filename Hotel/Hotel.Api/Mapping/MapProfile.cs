using AutoMapper;
using Hotel.Model.Dtos.PersonelDt;
using Hotel.Model.Models.PersonelMd;

namespace Hotel.Api.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<PersonelType, PersonelTypeDto>().ReverseMap();
        }
    }
}
