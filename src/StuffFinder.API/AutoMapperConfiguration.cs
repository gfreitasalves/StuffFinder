using AutoMapper;
using StuffFinder.API.ViewModels;
using StuffFinder.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StuffFinder.API
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration GetConfiguration(){

            var autoMapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Stuff, StuffCreateViewModel>().ReverseMap();
                cfg.CreateMap<Stuff, StuffEditViewModel>().ReverseMap();
                cfg.CreateMap<StuffContainer, StuffContainerCreateViewModel>().ReverseMap();
                cfg.CreateMap<StuffContainer, StuffContainerEditViewModel>().ReverseMap();

            });

            return autoMapperConfig;
        }
    }
}
