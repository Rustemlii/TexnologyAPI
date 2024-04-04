using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBaseService<Send,T,Bring>
    {
        List<Bring> GetAll();
        Bring GetById(int id);
        Bring Insert(Send dto);
        void Update(Send dto);
        void Delete(int id);
    }
}
