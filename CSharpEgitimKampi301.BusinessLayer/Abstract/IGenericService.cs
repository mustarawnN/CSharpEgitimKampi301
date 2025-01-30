using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class

    {
        void Tinsert(T entity);
        void Tupdate(T entity);

        void Tdelete(T entity);
        List<T> TGetAll();
        T TGetById(int id);

    }
}
