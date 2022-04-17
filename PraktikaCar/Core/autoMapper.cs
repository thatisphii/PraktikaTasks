using AutoMapper;
using PraktikaCar.DTOs;
using PraktikaCar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraktikaCar.Core
{
    public class autoMapper:Profile
    {
        public autoMapper()
        {
            CreateMap<CarToAddDTO, Car>().ReverseMap();
            CreateMap<CarToUpdateDTO, Car>().ReverseMap();
            CreateMap<CarToListDTO, Car>().ReverseMap();

        }
    }
}
