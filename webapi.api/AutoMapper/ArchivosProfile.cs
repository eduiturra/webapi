using AutoMapper;
using webapi.api.VIewModels;
using webapi.core.Models;

namespace webapi.api.AutoMapper
{
    public class ArchivosProfile : Profile
    {
        public ArchivosProfile()
        {
            CreateMap<Archivos, MostrarArchivosVM>();
        }
    }
}