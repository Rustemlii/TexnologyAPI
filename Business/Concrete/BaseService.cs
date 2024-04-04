using AutoMapper;
using Business.Abstract;
using DataAccess.MyContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BaseService<Send,T,Bring>:IBaseService<Send,T,Bring> where T : class
    {
        protected readonly IMapper _mapper;
        protected readonly Context _context;
        protected readonly DbSet<T> _dbSet;

        public BaseService(IMapper mapper, Context context)
        {
            _mapper = mapper;
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public void Delete(int id)
        {
            var entity = _dbSet.Find(id);
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }

        public List<Bring> GetAll()
        {
            var entity = _dbSet.ToList();
            var bringDto=_mapper.Map<List<Bring>>(entity);
            return bringDto;
        }

        public Bring GetById(int id)
        {
            var entity=_dbSet.Find(id);
            var bringDto=_mapper.Map<Bring>(entity);
            return bringDto;
        }

        public Bring Insert(Send dto)
        {
            var entity=_mapper.Map<T>(dto);
            _dbSet.Add(entity);
            _context.SaveChanges();
            var bringDto = _mapper.Map<Bring>(entity);
            return bringDto;
        }

        public void Update(Send dto)
        {
            var entity = _mapper.Map<T>(dto);
            _dbSet.Update(entity);
            _context.SaveChanges();
        }
    }
}
