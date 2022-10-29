using AutoMapper;
using CaramoissantApi.Models;

namespace CaramoissantApi.Helpers;
public class AutoMapperProfiles : Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<Caramoissant, CaramoissantViewModel>();
        CreateMap<CaramoissantPostModel, Caramoissant>();
    }
}

