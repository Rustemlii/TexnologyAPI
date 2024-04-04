using AutoMapper;
using Business.Abstract;
using DataAccess.Entity;
using DataAccess.MyContext;
using DTO.EntityDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryService : BaseService<CategoryDTO, Category, CategoryDTO>, ICategory
    {
        public CategoryService(IMapper mapper, Context context) : base(mapper, context)
        {
        }
    }
}
