using AutoMapper;
using Hotelier.EntityLayer;
using Hotelier.UI.DTOs.AboutDTO;
using Hotelier.UI.DTOs.BookingDTO;
using Hotelier.UI.DTOs.RegisterDTO;
using Hotelier.UI.DTOs.ServiceDTO;
using Hotelier.UI.DTOs.SubscribeDTO;

namespace Hotelier.UI.Mapping
{
    public class AutoMapperConfigUI : Profile
    {
        public AutoMapperConfigUI()
        {
            CreateMap<ResultServiceDTO, Service>().ReverseMap();
            CreateMap<CreateServiceDTO, Service>().ReverseMap();
            CreateMap<UpdateServiceDTO, Service>().ReverseMap();

            CreateMap<CreateNewUserDTO,AppUser>().ReverseMap();

            CreateMap<ResultAboutDTOs,About>().ReverseMap();
            CreateMap<UpdateAboutDTOs,About>().ReverseMap();


            CreateMap<CreateSubscribeDTOs, Subscribe>().ReverseMap();

            CreateMap<CreateBookingDTOs, Booking>().ReverseMap();
            CreateMap<ApprovedBookingDTOs, Booking>().ReverseMap();

        }
    }
}
