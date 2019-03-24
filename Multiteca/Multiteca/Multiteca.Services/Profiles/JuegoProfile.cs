using AutoMapper;
using Multiteca.Models;
using NHibernate.Entities;

//namespace Multiteca.Services.Profile
//{    public class MappingProfile : Profile
//    {
//        public MappingProfile()
//        {
//            CreateMap<Company, CompanyFormViewModel>()
//               .ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id))
//               .ForMember(vm => vm.Name, map => map.MapFrom(m => m.Name))
//               .ForMember(vm => vm.Owner, map => map.MapFrom(m => m.Owner))
//               .ForMember(vm => vm.Email, map => map.MapFrom(m => m.Email))
//               .ForMember(vm => vm.Password, map => map.MapFrom(m => m.Password))
//               .ForMember(vm => vm.Address, map => map.MapFrom(m => m.Address));
//            CreateMap<CompanyFormViewModel, Company>()
//               .ForMember(m => m.Id, map => map.MapFrom(vm => vm.Id))
//               .ForMember(m => m.Name, map => map.MapFrom(vm => vm.Name))
//               .ForMember(m => m.Owner, map => map.MapFrom(vm => vm.Owner))
//               .ForMember(m => m.Email, map => map.MapFrom(vm => vm.Email))
//               .ForMember(m => m.Password, map => map.MapFrom(vm => vm.Password))
//               .ForMember(m => m.Address, map => map.MapFrom(vm => vm.Address));

//        }
//    }
//}