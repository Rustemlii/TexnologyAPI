using AutoMapper;
using DataAccess.Entity;
using DTO.EntityDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Business.Map
{
    public class MyMapper : Profile
    {
        public MyMapper()
        {
            CreateMap<CategoryDTO, Category>();
            CreateMap<Category, CategoryDTO>();
            CreateMap<MarkaDTO, TexnoMarka>();
            CreateMap<TexnoMarka, MarkaDTO>();
            CreateMap<ModelDTO, TexnoModel>();
            CreateMap<TexnoModel, ModelDTO>();

        }
    }
}
