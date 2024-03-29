﻿using AutoMapper;
using TaskMate.DTOs.Slider;
using TaskMate.Entities;

namespace TaskMate.MapperProfile;

public class SliderProfile : Profile
{
    public SliderProfile()
    {
        CreateMap<Slider, SliderCreateDTO>().ReverseMap();
    }
}