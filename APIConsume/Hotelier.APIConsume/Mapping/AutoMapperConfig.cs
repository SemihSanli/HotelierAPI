using AutoMapper;
using Hotelier.DTOLayer.Dtos.RoomDto;
using Hotelier.EntityLayer;

namespace Hotelier.APIConsume.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<CreateRoomDto, Room>().ReverseMap();
            CreateMap<UpdateRoomDto, Room>().ReverseMap();
            CreateMap<ResultRoomDto, Room>().ReverseMap();
        }
    }
}
