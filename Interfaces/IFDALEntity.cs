using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces {
    public interface IFDALEntity<T> {
        List<T> GetAll();
        T GetById(string id);
        void Create(T entity);
        void Edit(T entity);
        void Delete(T entity);
    }
}
