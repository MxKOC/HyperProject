using AutoMapper;
using HyperProject.DTOs;
using HyperProject.Entity;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Car, CarDTO>(); 
        CreateMap<Vehicle, VehicleDTO>(); 
    }
}   